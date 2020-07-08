using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JSONReader
{
    class DataReader
    {
        string _file;
        public DataReader(string file)
        {
            _file = file;
        }

        public List<Country> ReadAllCountries()
        {
            var countries = new List<Country>();
           

            
            

            using (var sr = new StreamReader(_file))
            {
                var fileContent = sr.ReadToEnd();
                countries = JsonConvert.DeserializeObject<List<Country>>(fileContent);
            }

                //var files = File.ReadAllLines(_file);
                //foreach (var file in files)
                //{
                //    if (file.Contains("\"Country Name\""))
                //    {
                //        country = new Country();
                //        removeQuotes = file.Replace("\"", null);
                //        removeLabel = removeQuotes.Replace("Country Name:", null);
                //        JsonItem = removeLabel.Replace(",", null).Trim();
                //        country.Name = JsonItem;
                //    }
                //    if (file.Contains("\"Country Code\""))
                //    {
                //        removeQuotes = file.Replace("\"", null);
                //        removeLabel = removeQuotes.Replace("Country Code:", null);
                //        JsonItem = removeLabel.Replace(",", null).Trim();
                //        country.Code = JsonItem;
                //    }
                //    if (file.Contains("\"Continent\""))
                //    {
                //        removeQuotes = file.Replace("\"", null);
                //        removeLabel = removeQuotes.Replace("Continent:", null);
                //        JsonItem = removeLabel.Replace(",", null).Trim();
                //        country.Continent = JsonItem;
                //    }
                //    if (file.Contains("\"Population 2017\""))
                //    {
                //        removeQuotes = file.Replace("\"", null);
                //        removeLabel = removeQuotes.Replace("Population 2017:", null);
                //        JsonItem = removeLabel.Replace(",", null).Trim();
                //        int.TryParse(JsonItem, out int population);
                //        country.Population = population;
                //        countries.Add(country);
                //    }
                //}
                return countries;
        }
    }
}
