using System;

namespace p01_Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmCntries = int.Parse(Console.ReadLine());
            int nmYears = nmCntries * 100;
            double nmbrDaysInYear = 365.2422;
            double nmbrDays = nmbrDaysInYear * nmYears;
            nmbrDays = Math.Round(nmbrDays);
            int nmbrSecondsInEmphemerisDay = 86400;
            double minutes = (nmbrDays * nmbrSecondsInEmphemerisDay) / 60.0;
            double hours = minutes / 60.0;
            Console.WriteLine($"{nmCntries} centuries = {nmYears} years = {nmbrDays,0:F0} days = {hours,0:F0} hours = {minutes,0:F0} minutes");

        }
    }
}
