using System;

namespace p04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double enrgy = volume / 100.0 * energy;
            double sgr = volume / 100.0 * sugar;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{enrgy}kcal, {sgr}g sugars");

        }
    }
}
