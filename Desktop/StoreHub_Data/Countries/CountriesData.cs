using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Countries
{
    public class CountriesData
    {

        public async static Task<List<string>> LoadCountriesNames()
        {
            using var context = Settings.CreateContext();

            var countries = await context.Countries.AsNoTracking().Select(c => c.CountryName).ToListAsync();

            return countries;


        }




    }
}
