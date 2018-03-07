using System;

namespace p05_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();

            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            char[] strArrHealth = new char[maxHealth+2];
            char[] strArrEnergy = new char[maxEnergy+2];

            strArrHealth[0] = '|';
            strArrHealth[maxHealth+1] = '|';
            strArrEnergy[0] = '|';
            strArrEnergy[maxEnergy + 1] = '|';

            for (int i = 1;i<= maxHealth; i++)
            {
                if (i > health)
                {
                    strArrHealth[i] = '.';
                }
                else strArrHealth[i] = '|';
            }
            string hlth = "";
            for (int i = 0; i <= maxHealth+1; i++)
            {
                hlth = hlth + strArrHealth[i];
            }

            for (int i = 1; i <= maxEnergy; i++)
            {
                if (i > energy)
                {
                    strArrEnergy[i] = '.';
                }
                else strArrEnergy[i] = '|';
            }
            
            string enrg = "";
            for (int i = 0; i <= maxEnergy + 1; i++)
            {
                enrg = enrg + strArrEnergy[i];
            }
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {hlth}");
            Console.WriteLine($"Energy: {enrg}");
        }
    }
}
