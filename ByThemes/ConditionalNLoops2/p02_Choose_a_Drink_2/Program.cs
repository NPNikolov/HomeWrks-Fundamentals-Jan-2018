using System;

namespace p02_Choose_a_Drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double amnt = 0.0;
            string drink;
            if (profession.Equals("Athlete"))
            {
                drink = "Water";
                amnt = quantity * 0.7;
            }
            else if (profession.Equals("Businessman") || profession.Equals("Businesswoman"))
            {
                drink = "Coffee";
                amnt = quantity * 1.0;
            }
            else if (profession.Equals("SoftUni Student"))
            {
                drink = "Beer";
                amnt = quantity * 1.7;
            }
            else
            {
                drink = "Tea";
                amnt = quantity * 1.2;
            }
            Console.WriteLine($"The {profession} has to pay {amnt,0:f2}.");
        }
    }
}
