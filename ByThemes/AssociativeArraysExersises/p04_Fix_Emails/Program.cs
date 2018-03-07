using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLs = new Dictionary<int, string>();
            var indxs = new Dictionary<string, int>();
            string cmnd = "";
            int cntr = 0;
            do
            {
                cntr++;
                cmnd = ProcessCmnd(emailLs, indxs, cntr);
            } while (!("stop".Equals(cmnd)));
        }

        static string ProcessCmnd(Dictionary<int, string> emailLs, Dictionary<string, int> indxs, int cntr)
        {
            string input = Console.ReadLine();
            string cmnd = input.ToLower();

            switch (cmnd)
            {

                case "stop":
                    foreach (var item in indxs)
                    {

                        Console.WriteLine($"{item.Key} -> {emailLs[item.Value]}");
                    }
                    break;
                default:
                    if (cntr % 2 == 1)
                    {
                        bool found_indx = indxs.TryGetValue(input, out int indx);
                        indxs[input] = cntr;
                        if (found_indx) emailLs.Remove(indx);
                        emailLs[cntr] = input;

                    }
                    else
                    {
                        bool endemail = input.EndsWith("uk", StringComparison.InvariantCultureIgnoreCase)|| input.EndsWith("us", StringComparison.InvariantCultureIgnoreCase);

                        if (endemail)
                        {
                            string key = emailLs[cntr - 1];
                            indxs.Remove(key);
                            emailLs.Remove(cntr - 1);
                        }
                        else emailLs[cntr - 1] = input;
                    }
                        
                    break;
            }
            return cmnd;
        }
    }
}
