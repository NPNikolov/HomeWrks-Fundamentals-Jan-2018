using System;

namespace p15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string peshosStrike = "Roundhouse kick";
            string goshosStrike = "Thunderous fist";
            int peshosHealth = 100;
            int goshosHealth = 100;
            string peshosName = "Pesho";
            string goshosName = "Gosho";
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int cntr = 0;

            while ((peshosHealth>0)&&(goshosHealth>0))
            {
                cntr += 1;
                if (1 == cntr % 2)
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth<=0)
                    {
                        break;
                    }
                    Console.WriteLine($"{peshosName} used {peshosStrike} and reduced {goshosName} to {goshosHealth} health.");
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"{goshosName} used {goshosStrike} and reduced {peshosName} to {peshosHealth} health.");
                }
                if (0 ==cntr%3)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
            }
            string winner = "";
            if (peshosHealth > 0)
            {
                winner = peshosName;
            } else winner = goshosName;
            Console.WriteLine($"{winner} won in {cntr}th round.");
        }
    }
}
