using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapUsers = new SortedDictionary<string, Dictionary<string, int>>();
            string cmnd = "";

            do
            {
                cmnd = ProcessCmnd(mapUsers);
            } while (!("end".Equals(cmnd)));
        }

        private static string ProcessCmnd(SortedDictionary<string, Dictionary<string, int>> mapUsers)
        {
            var strArr = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string cmnd = strArr[0].ToLower();
            if ("end".Equals(cmnd))
            {
                PrintMap(mapUsers);
            }
            else
            {
                Dictionary<string, int> mapnewIPmsg = GetMapFromArray(strArr);
                bool found = false;
                string user = strArr[strArr.Count() - 1];
                found = mapUsers.TryGetValue(user, out var mapIP_msg);
                var toFillMap = new Dictionary<string, int>();

                toFillMap = InsertNewIP(found, mapIP_msg, mapnewIPmsg);
                mapUsers[user] = toFillMap;
            }

            return cmnd;
        }

        private static Dictionary<string, int> InsertNewIP(bool found, 
            Dictionary<string, int> mapIP_msg, Dictionary<string, int> mapPImsgs)
        {
            
            if (found)
            {
                
                foreach (var item in mapPImsgs)
                {
                    bool foundinIps = false;
                    foundinIps = mapIP_msg.TryGetValue(item.Key, out int tmpVal);
                    int newVal = 1;
                    if (foundinIps)
                    {
                        newVal += tmpVal;
                    }
                    
                    mapIP_msg[item.Key] = newVal;
                }
                return mapIP_msg;
            }
            else return mapPImsgs;
        }

        private static Dictionary<string, int> GetMapFromArray(string[] strArr)
        {
            Dictionary<string, int> ipsMap = new Dictionary<string, int>(1);
            
                string ip = strArr[1];
                
                ipsMap[ip] = 1;
            
            return ipsMap;
        }

        private static void PrintMap(SortedDictionary<string, Dictionary<string, int>> mapUsers)
        {
            foreach (var item in mapUsers)
            {
                string ipsResult = "";

                foreach (var item1 in item.Value)
                {
                    if (! "".Equals(ipsResult))
                    {
                        ipsResult += ", ";
                    }
                    ipsResult += item1.Key + " => " + item1.Value;
                }
                ipsResult += ".";
              
                Console.WriteLine($"{item.Key}:");
                Console.WriteLine(ipsResult);
            }
        }
    }
}
