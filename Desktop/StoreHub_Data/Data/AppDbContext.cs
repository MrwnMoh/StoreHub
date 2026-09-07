using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Data
{
    public partial class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Person>(entity =>
                {
                    entity.ToTable(tb => tb.UseSqlOutputClause(false));

                    entity.HasKey(e => e.PersonId).HasName("PK_Person");

                    entity.HasIndex(e => e.CountryId, "IX_People_CountryId");
                    entity.HasIndex(e => e.Email, "UQ_People_Email").IsUnique();
                    entity.HasIndex(e => e.Phone, "UQ_People_Phone").IsUnique();

                    entity.HasOne(e => e.Country)
                    .WithMany(e => e.People)
                    .HasForeignKey(e => e.CountryId)
                    .HasConstraintName("FK_Countries_People");

                    entity.Property(e => e.IsAdmin).HasDefaultValue(0) ;
                    entity.Property(e => e.IsSeller).HasDefaultValue(0);
                    entity.Property(e => e.IsActive).HasDefaultValue(1);
                    entity.Property(e => e.RegisterAt).HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.FirstName).HasMaxLength(50);
                    entity.Property(e => e.LastName).HasMaxLength(50);
                    entity.Property(e => e.Address).HasMaxLength(500);
                    entity.Property(e => e.Email).HasMaxLength(250);
                    entity.Property(e => e.PasswordHash).HasMaxLength(100);
                    entity.Property(e => e.Phone).HasMaxLength(25);

                }
            );

           

            modelBuilder.Entity<RefreshToken>(entity =>
            {

                entity.HasKey(e => e.PersonId).HasName("PK_RefreshTokens");


                entity.Property(e => e.RefreshTokenHash).HasMaxLength(200);


                entity.HasOne(e => e.Person).WithOne(e => e.RefreshToken).HasForeignKey<RefreshToken>(e => e.PersonId).HasConstraintName("FK_RefreshTokens_People");

            }
            );

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId).HasName("PK_Country");

                entity.HasIndex(e => e.CountryName, "UQ_Countries_CountryName").IsUnique();

                entity.Property(e => e.CountryName).HasMaxLength(50);


            });


            modelBuilder.Entity<Category>(entity =>
            {

                entity.HasKey(e => e.CategoryId).HasName("PK_Categories");

                entity.HasIndex(e => e.Name, "UQ_Categories_Name").IsUnique();

                entity.Property(e => e.Name).HasMaxLength(25);


            });

            modelBuilder.Entity<Store>(entity =>
            {

                entity.HasKey(e => e.StoreId).HasName("PK_Store");
                entity.HasIndex(e => e.StoreName, "UQ_Stores_StoreName").IsUnique();
                entity.HasIndex(e => e.PersonId, "IX_Stores_PersonId");

                    
                entity.HasOne(e=> e.Person).WithMany(e=> e.Stores).HasForeignKey(e=> e.PersonId).HasConstraintName("FK_Stores_People");

                entity.Property(e => e.StoreName).HasMaxLength(100);
                entity.Property(e => e.StoreDescription).HasMaxLength(500);

            }
            );

            modelBuilder.Entity<Order>(entity =>
            {

                entity.HasKey(e => e.OrderId).HasName("PK_Orders");
                entity.HasIndex(e => e.PersonId, "IX_Orders_PersonId");
                entity.HasIndex(e => e.OrderStatusId, "IX_Orders_OrderStatusId");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("(getdate())");

                entity.ToTable(t => t.HasCheckConstraint("CK_Orders_TotalAmount","[TotalAmount] >= 0"));

                entity.HasOne(e => e.OrderStatus).WithMany(e => e.Orders).HasForeignKey(e => e.OrderStatusId).HasConstraintName("FK_Orders_OrderStatuses");

                entity.HasOne(e => e.Person).WithMany(e => e.Orders).HasForeignKey(e => e.PersonId).HasConstraintName("FK_Orders_People");
                
                entity.Property(e => e.ShippingAddress).HasMaxLength(500);

                entity.Property(e => e.TotalAmount)
                      .HasColumnType("decimal(18,2)");

            }
            );

            modelBuilder.Entity<OrderStatus>(entity => 
            {

                entity.HasKey(e => e.OrderStatusId).HasName("PK_OrderStatuses");
                entity.HasIndex(e => e.Name, "UQ_OrderStatuses_Name").IsUnique();

                entity.Property(e => e.Name).HasMaxLength(30);

            }
            );

            modelBuilder.Entity<ProductImage>(entity => { 
            
                entity.HasKey(e => e.ProductImageId).HasName("PK_ProductImages");


                entity.HasIndex(e => e.ProductId, "IX_ProductImages_ProductId");

                entity.HasOne(e => e.Product).WithMany(e => e.ProductImages).HasForeignKey(e => e.ProductId ).HasConstraintName("FK_ProductImage_Products");


            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                      .HasName("PK_OrderItems");

                entity.HasIndex(e => e.OrderId, "IX_OrderItems_OrderId");
                entity.HasIndex(e => e.ProductId, "IX_OrderItems_ProductId");

                entity.Property(e => e.Quantity)
                      .HasDefaultValue(1);

                entity.ToTable(t =>
                    t.HasCheckConstraint(
                        "CK_OrderItems_UnitPrice",
                        "[UnitPrice] >= 0"));

                entity.ToTable(t =>
                    t.HasCheckConstraint(
                        "CK_OrderItems_Quantity",
                        "[Quantity] > 0"));

                entity.Property(e => e.UnitPrice)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                entity.HasOne(e => e.Order)
                      .WithMany(e => e.Items)
                      .HasForeignKey(e => e.OrderId)
                      .HasConstraintName("FK_OrderItems_Orders");

                entity.HasOne(e => e.Product)
                      .WithMany(e => e.OrderItems)
                      .HasForeignKey(e => e.ProductId)
                      .OnDelete(DeleteBehavior.NoAction)
                      .HasConstraintName("FK_OrderItems_Products");
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                      .HasName("PK_Products");

                entity.HasIndex(e => e.StoreId, "IX_Products_StoreId");

                entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");


                entity.Property(e => e.Name)
                      .HasMaxLength(150);



                entity.Property(e => e.Description)
                      .HasMaxLength(500);

                entity.Property(e => e.Price)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                entity.Property(e => e.StockQuantity)
                      .HasDefaultValue(0);

                entity.Property(e => e.IsDeleted)
                     .HasDefaultValue(0);


                entity.ToTable(t =>
                    t.HasCheckConstraint(
                        "CK_Products_Price",
                        "[Price] >= 0"));

                entity.ToTable(t =>
                    t.HasCheckConstraint(
                        "CK_Products_StockQuantity",
                        "[StockQuantity] >= 0"));


                entity.HasOne(e => e.Store)
                      .WithMany(e => e.Products)
                      .HasForeignKey(e => e.StoreId)
                      .HasConstraintName("FK_Products_Stores");

                entity.HasOne(e => e.Category)
                      .WithMany(e => e.Products)
                      .HasForeignKey(e => e.CategoryId)
                      .HasConstraintName("FK_Products_Categories");


                entity.HasMany(e => e.ProductImages)
                      .WithOne(e => e.Product)
                      .HasForeignKey(e => e.ProductId)
                      .HasConstraintName("FK_ProductImage_Products");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                      .HasName("PK_Carts");

                entity.HasIndex(e => e.PersonId, "UQ_Carts_PersonId")
                      .IsUnique();

                entity.HasOne(e => e.Person)
                      .WithOne(e => e.Cart)
                      .HasForeignKey<Cart>(e => e.PersonId)
                      .HasConstraintName("FK_Carts_People");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(e => e.CartItemId)
                      .HasName("PK_CartItems");

                entity.HasOne(e => e.Cart)
                      .WithMany(e => e.Items)
                      .HasForeignKey(e => e.CartId)
                      .HasConstraintName("FK_CartItems_Carts");

                entity.HasOne(e => e.Product)
                      .WithMany()
                      .HasForeignKey(e => e.ProductId)
                      .HasConstraintName("FK_CartItems_Products").OnDelete(DeleteBehavior.NoAction);

                entity.Property(e => e.Quantity)
                      .HasDefaultValue(1);

                entity.ToTable(t =>
                    t.HasCheckConstraint(
                        "CK_CartItems_Quantity",
                        "[Quantity] >= 0"));
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                      .HasName("PK_Reviews");

                entity.HasIndex(e => e.PersonId)
                      .HasName("IX_Reviews_PersonId");

                entity.HasIndex(e => e.ProductId)
                      .HasName("IX_Reviews_ProductId");

                entity.Property(e => e.ReviewText)
                      .HasMaxLength(100);

                entity.Property(e => e.Date)
                      .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Edited)
                     .HasDefaultValue(0);

                entity.ToTable(t => t.HasCheckConstraint(
                    "CK_Reviews",
                    "[Rate] >= 1 AND [Rate] <= 5"
                ));

                entity.HasOne(e => e.Person)
                      .WithMany(e => e.Reviews)
                      .HasForeignKey(e => e.PersonId)
                      .HasConstraintName("FK_Reviews_People");

                entity.HasOne(e => e.Product)
      .WithMany(e => e.Reviews)
      .HasForeignKey(e => e.ProductId)
      .OnDelete(DeleteBehavior.NoAction)
      .HasConstraintName("FK_Reviews_Products");
            });

            OnModelCreatingPartial(modelBuilder);


        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

       

    }
}
