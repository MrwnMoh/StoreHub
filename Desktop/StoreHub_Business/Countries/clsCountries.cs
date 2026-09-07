using StoreHub_Data.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Countries
{
    public class clsCountries
    {

        public async static Task<List<string>> LoadCountries()
        {
            var countries = await CountriesData.LoadCountriesNames();
            return countries;
        }


    }
}
