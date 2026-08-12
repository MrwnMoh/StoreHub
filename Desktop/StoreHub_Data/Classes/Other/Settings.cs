using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Classes.Other
{
    public class Settings
    {

        public static AppDbContext CreateContext()
        {


            var options = new DbContextOptionsBuilder<AppDbContext>()
          .UseSqlServer("Server=localhost;Database=StoreHub;Trusted_Connection=True;TrustServerCertificate=True;")
          .Options;

            var context = new AppDbContext(options);


            return context;
        }





    }
}
