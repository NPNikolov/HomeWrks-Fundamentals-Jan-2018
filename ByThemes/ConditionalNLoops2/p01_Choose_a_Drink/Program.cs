using System;

namespace p01_Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink;
            if (profession.Equals("Athlete"))
            {
                drink = "Water";
            }
            else if (profession.Equals("Businessman") || profession.Equals("Businesswoman"))
            {
                drink = "Coffee";
            }
            else if (profession.Equals("SoftUni Student"))
            {
                drink = "Beer";
            }
            else drink = "Tea";
            Console.WriteLine(drink);
        }
    }
}
