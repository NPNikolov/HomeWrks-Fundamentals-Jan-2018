using System;

namespace p03_Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMins = minutes + 30;
            if (newMins>59)
            {
                hour = hour + 1;
                newMins = newMins - 60;
            }
            if (hour>23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{newMins,0:D2}");
        }
    }
}
