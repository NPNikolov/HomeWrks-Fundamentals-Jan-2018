using System;

namespace p07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingrdnt = Console.ReadLine();
            int nmbrIngrdnt = 0;
            
            while (!(ingrdnt.Equals("Bake!")))
            {
                
                Console.WriteLine($"Adding ingredient {ingrdnt}.");
                nmbrIngrdnt += 1;
                ingrdnt = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {nmbrIngrdnt} ingredients.");
        }
    }
}
