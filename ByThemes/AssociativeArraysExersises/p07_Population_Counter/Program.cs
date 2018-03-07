using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapCountries = new Dictionary<string, Dictionary<string, int>>();
            string cmnd = "";

            do
            {
                cmnd = ProcessCmnd(mapCountries);
            } while (!("report".Equals(cmnd)));
        }

        private static string ProcessCmnd(Dictionary<string, 
            Dictionary<string, int>> mapCountries)
        {
            var strArr = Console.ReadLine().Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string cmnd = strArr[0].ToLower();
            if ("report".Equals(cmnd))
            {
                PrintMap(mapCountries);
            }
            else
            {
                Dictionary<string, int> mapnewCity = GetMapFromArray(strArr);
                bool found = false;
                string country = strArr[1];
                found = mapCountries.TryGetValue(country, out var mapCities);
                var toFillMap = new Dictionary<string, int>();

                toFillMap = InsertNewCity(found, mapCities, mapnewCity);
                mapCountries[country] = toFillMap;
            }

            return cmnd;
        }

        private static Dictionary<string, int> InsertNewCity(bool found, 
            Dictionary<string, int> mapCities, Dictionary<string, int> mapnewCity)
        {
            if (found)
            {
                foreach (var item in mapnewCity)
                {
                    mapCities[item.Key] = item.Value;
                }
                return mapCities;
            }
            else return mapnewCity;
        }

        private static Dictionary<string, int> GetMapFromArray(string[] strArr)
        {
            var cityMap = new Dictionary<string,int>();

            string city = strArr[0];

            cityMap[city] = int.Parse(strArr[2]);

            return cityMap;
        }

        private static void PrintMap(Dictionary<string, Dictionary<string, int>> mapCountries)
        {

            var cntriesPopltn = new Dictionary<string, long>();
            foreach (var item in mapCountries)
            {
                long populationTotal = 0;
                
                foreach (var item1 in item.Value)
                {
                    populationTotal += item1.Value;
                }
                cntriesPopltn[item.Key] = populationTotal;
            }
            var sortedDict = from entry in cntriesPopltn orderby entry.Value descending select entry;
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                var citiesDct = mapCountries[item.Key];
                var sortedDictCty = from entry in citiesDct orderby entry.Value descending select entry;
                foreach (var item1 in sortedDictCty)
                {
                    Console.WriteLine($"=>{item1.Key}: {item1.Value}");
                }
            }
        }
        
    }
}
