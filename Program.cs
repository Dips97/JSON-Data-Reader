using System;
using System.Collections.Generic;

namespace JSONReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\LENOVO\source\repos\JSONReader\Pop by Largest.json";
            DataReader reader = new DataReader(path);
            List<Country> countries = reader.ReadAllCountries();

            //Country Liliput = countries.Add();    Ask: how to add in get set prop type
            foreach(Country country in countries)
            {
                Console.WriteLine($"{country.Population2017}     :  {country.CountryName} ");
            }

            Console.WriteLine($"\n{countries.Count} Countries");
            Console.ReadLine();
            
        }
    }
}
