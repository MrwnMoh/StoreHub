using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using StoreHub_Api.Authorization;
using StoreHub_Business.Other;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        // TokenValidationParameters define how incoming JWTs will be validated.
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,


            ValidateAudience = true,


            ValidateLifetime = true,


            ValidateIssuerSigningKey = true,


            ValidIssuer = builder.Configuration["Jwt:Issuer"],


            ValidAudience = builder.Configuration["Jwt:Audience"],

            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ClockSkew = TimeSpan.Zero


        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("UserOwnerAdminPolicy", policy => policy.Requirements.Add(new UserOwnerAdminRequirement()));
});
builder.Services.AddSingleton<IAuthorizationHandler, UserOwnerAdminHandler>();



builder.Services.AddScoped<clsTokens>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("StoreHubCorsPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:7172", "http://localhost:5124")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",


        Type = SecuritySchemeType.Http,


        Scheme = "Bearer",


        BearerFormat = "JWT",


        In = ParameterLocation.Header,


        Description = "Enter: Bearer {your JWT token}"
    });


    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },


            new string[] {}
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("StoreHubCorsPolicy");


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
