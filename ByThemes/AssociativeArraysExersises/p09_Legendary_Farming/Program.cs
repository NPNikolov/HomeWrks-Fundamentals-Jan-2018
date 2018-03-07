using System;
using System.Collections.Generic;
using System.Linq;


namespace p09_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapQuantities = new SortedDictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            int cntrLines = 0;
            string legendaryMaterial = "";
            do
            {
                legendaryMaterial = ProcessCmnd(mapQuantities);
                cntrLines++;
            } while ("".Equals(legendaryMaterial));
            PrintFarm(legendaryMaterial, mapQuantities);
        }

        private static void PrintFarm(string legendaryMaterial, SortedDictionary<string, int> mapQuantities)
        {
            string obtainedMaterial = "";

            if (legendaryMaterial.Equals("shards"))
            {
                obtainedMaterial = "Shadowmourne";
            }else if (legendaryMaterial.Equals("fragments"))
            {
                obtainedMaterial = "Valanyr";
            }
            else if (legendaryMaterial.Equals("motes"))
            {
                obtainedMaterial = "Dragonwrath";
            }
            Console.WriteLine($"{obtainedMaterial} obtained!");
            //var sortedDict = from entry in mapQuantities orderby entry.Value descending select entry;
            var finalResources = mapQuantities.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in finalResources)
            {
                if (item.Key.Equals("shards")|| item.Key.Equals("fragments") || item.Key.Equals("motes"))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            foreach (var item in mapQuantities)
            {
                if (item.Key.Equals("shards") || item.Key.Equals("fragments") || item.Key.Equals("motes"))
                {
                    
                }else Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static string ProcessCmnd(SortedDictionary<string, int> mapQuantities)
        {
            var strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            Dictionary<string, int> mapnewMaterials = GetMapFromArray(strArr);
                
            string legendaryMaterial = InsertNewMaterials(mapQuantities, mapnewMaterials);
                
            return legendaryMaterial;
        }

        private static string InsertNewMaterials(SortedDictionary<string, int> mapQuantities, 
            Dictionary<string, int> mapnewMaterials)
        {
            string obtainedMaterial = "";
            foreach (var item in mapnewMaterials)
            {
                bool found = false;
                int newQtty = item.Value;
                found = mapQuantities.TryGetValue(item.Key, out int crrntQtty);
                if (found)
                {
                    newQtty += crrntQtty;
                }
                else mapQuantities.Add(item.Key, 0);
                mapQuantities[item.Key] = newQtty;
                
                    if (newQtty>=250&&("shards".Equals(item.Key)|| "fragments".Equals(item.Key) || "motes".Equals(item.Key)))
                    {
                        obtainedMaterial = item.Key;
                    mapQuantities[item.Key] = newQtty - 250;
                    return obtainedMaterial;
                    }
                    
            }
            return obtainedMaterial;
        }

        private static Dictionary<string, int> GetMapFromArray(string[] strArr)
        {
            Dictionary<string, int> materialsMap = new Dictionary<string, int>();

            int sizeArr = strArr.Count();

            for (int i = 0; i < sizeArr/2; i++)
            {
                if (i>24)
                {
                    break;
                }
                string material = strArr[2*i+1].ToLower();
                int qtty = int.Parse(strArr[2*i]);
                bool found = materialsMap.TryGetValue(material, out int crrntQtty);
                if (found)
                {
                    qtty += crrntQtty;
                }
                else materialsMap.Add(material, 0);
                materialsMap[material] = qtty;
            }
            return materialsMap;
        }
    }
}
