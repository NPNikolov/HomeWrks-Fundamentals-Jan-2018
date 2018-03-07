using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var mine = new Dictionary<int, double>();
            var indxs = new Dictionary<string, int>();
            string cmnd = "";
            int cntr = 0;
            do
            {
                cntr++;
                cmnd = ProcessCmnd(mine,indxs, cntr);
            } while (!("stop".Equals(cmnd)));
        }

        static string ProcessCmnd(Dictionary<int, double> mine, Dictionary<string, int> indxs, int cntr)
        {
            string input = Console.ReadLine();
            string cmnd = input.ToLower();
            
            switch (cmnd)
            {
                
                case "stop":
                    foreach (var item in indxs)
                    {
                        
                        Console.WriteLine($"{item.Key} -> {mine[item.Value]}");
                    }
                    break;
                default:
                    if (cntr%2==1)
                    {
                        bool found_indx = indxs.TryGetValue(input, out int indx);
                        indxs[input] = cntr;
                        if (found_indx)
                        {
                            double qtty = mine[indx];
                            mine.Remove(indx);
                            mine[cntr] = qtty;
                        }
                        else mine[cntr] = 0;
                        
                    }
                    else
                        mine[cntr - 1] += double.Parse(input);
                    break;
            }
            return cmnd;
        }
    }
}
