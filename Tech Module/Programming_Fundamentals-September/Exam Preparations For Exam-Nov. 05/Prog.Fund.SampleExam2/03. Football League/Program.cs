﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace CitiesByContinentAndCountry
{
    class Cities
    {
        static void Main()
        {
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }
                continentsData[continent][country].Add(city);

            }
            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;
                Console.WriteLine($"{continentName}: ");
                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine(" {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }
    }
}