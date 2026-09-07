using Shop_Desktop_Business.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business.Countries
{
    public class clsCountries
    {

        public static async Task<List<string>> LoadCountriesNames()
        {
            var countries = await clsDefultes.Client.GetFromJsonAsync<List<string>>("Countries/Countries");
            return countries;
        }




    }
}
