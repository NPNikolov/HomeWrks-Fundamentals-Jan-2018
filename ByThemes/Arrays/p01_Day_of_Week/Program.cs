using System;

namespace p01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayDaysOfWeek = {"Monday","Tuesday","Wednesday","Thursday","Friday",
                "Saturday","Sunday"};
            int indxDay = int.Parse(Console.ReadLine());
            if (indxDay > 0 && indxDay <= 7)
            {
                Console.WriteLine(arrayDaysOfWeek[indxDay - 1]);
            }
            else Console.WriteLine("Invalid Day!");

        }
    }
}
