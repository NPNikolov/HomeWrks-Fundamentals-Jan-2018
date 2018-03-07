using System;

namespace p05_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            if ("England".Equals(country)||"USA".Equals(country))
            {
                Console.WriteLine("English");
            }
            else if ("Spain".Equals(country) || "Argentina".Equals(country) || "Mexico".Equals(country))
            {
                Console.WriteLine("Spanish");
            }
            else Console.WriteLine("unknown");
            
            
        }
    }
}
