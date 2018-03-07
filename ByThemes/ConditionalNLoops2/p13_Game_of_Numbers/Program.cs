using System;

namespace p13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nm_1 = int.Parse(Console.ReadLine());
            int nm_2 = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int magic1 = 0;
            int magic2 = 0;

            int cntr = 0;

            for (int i = nm_1; i <= nm_2; i++)
            {
                for (int j = nm_1; j <= nm_2; j++)
                {
                    cntr += 1;
                    if (j+i==magic)
                    {
                        magic1 = i;
                        magic2 = j;
                    }
                }
            }

            if (magic1>0)
            {
                Console.WriteLine($"Number found! {magic1} + {magic2} = {magic}");
            }
            else
            {
                Console.WriteLine($"{cntr} combinations - neither equals {magic}");
            }

        }
    }
}
