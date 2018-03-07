using System;
using System.Collections.Generic;
using System.Linq;

namespace p08_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapUsers = new SortedDictionary<string, Dictionary<string, int>>();
            int numLines = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numLines; i++)
            {
                if (i==numLines)
                {
                    PrintUsers(mapUsers);
                }else
                ProcessCmnd(mapUsers);
            }
        }

        private static void ProcessCmnd(SortedDictionary<string, Dictionary<string, int>> mapUsers)
        {
            var strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string cmnd = strArr[0].ToLower();
            
                Dictionary<string, int> mapnewIPmsg = GetMapFromArray(strArr);
                bool found = false;
                string user = strArr[1];
                found = mapUsers.TryGetValue(user, out var mapIP_msg);
                var toFillMap = new Dictionary<string, int>();

                toFillMap = InsertNewIP(found, mapIP_msg, mapnewIPmsg);
                mapUsers[user] = toFillMap;
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
                    int newVal = item.Value;
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

            string ip = strArr[0];

            ipsMap[ip] = int.Parse(strArr[2]);

            return ipsMap;
        }

        private static void PrintUsers(SortedDictionary<string, Dictionary<string, int>> mapUsers)
        {
            foreach (var item in mapUsers)
            {
                string ipsResult = "";
                long timing = 0;
                var sortedDict = from entry in item.Value orderby entry.Key ascending select entry;
                foreach (var item1 in sortedDict)
                {
                    if (!"".Equals(ipsResult))
                    {
                        ipsResult += ", ";
                    }
                    else ipsResult = "[";
                    ipsResult += item1.Key;
                    timing += item1.Value;
                }
                ipsResult += "]";

                Console.WriteLine($"{item.Key}: {timing} {ipsResult}");
                
            }
        }
    }
}
