using System;

namespace p05_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lngth = word.Length;
            string lastSymb = word.Substring(lngth - 1);
            lastSymb = lastSymb.ToLower();
            if (word.EndsWith("y"))
            {
                lastSymb = word.Remove(lngth - 1);
                

                lastSymb = lastSymb + "ies";
            }
            else
            {
                switch (lastSymb)
                {
                    case "o": case "s": case "x": case "z": lastSymb = word + "es";
                        break;
                    case "h": string tmp = word.Substring(lngth - 2);
                        if (tmp.ToLower().Equals("ch")|| tmp.ToLower().Equals("sh"))
                        {
                            lastSymb = word + "es";
                            
                        }else lastSymb = word + "s";
                        break;
                    default: lastSymb = word + "s";
                        break;
                }
            }
            Console.WriteLine(lastSymb);
        }
    }
}
