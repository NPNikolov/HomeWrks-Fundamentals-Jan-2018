using System;

namespace p06_Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrTable = new int[3,3];
            //string[] arrDays = { "weekday", "weekend", "holiday" };
            arrTable[0,0] = 12; arrTable[0,1] = 18; arrTable[0,2] = 12;
            arrTable[1,0] = 15; arrTable[1,1] = 20; arrTable[1,2] = 15;
            arrTable[2,0] = 5; arrTable[2,1] = 12; arrTable[2,2] = 10;
            string typeOfDay = Console.ReadLine().ToLower();
            double age = double.Parse(Console.ReadLine());
            int index1 = -1;
            int index2 = -1;
            if ((age < 0 || age > 122))
            {
                Console.WriteLine("Error!");
                
            }
            else if (age <= 18)
            {
                index2 = 0;
            }
            else if (age <= 64)
            {
                index2 = 1;
            } else index2 = 2;
            if ("weekday".Equals(typeOfDay))
            {
                index1 = 0;
            }
            else if ("weekend".Equals(typeOfDay))
            {
                index1 = 1;
            } else index1 = 2;
            if (index2>-1)
            {
                Console.WriteLine("{0}$",arrTable[index1,index2]);
            }

        }
    }
}
