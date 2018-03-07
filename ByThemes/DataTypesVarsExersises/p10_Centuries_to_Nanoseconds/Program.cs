using System;

namespace p10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmCntries = int.Parse(Console.ReadLine());
            int nmYears = nmCntries * 100;
            double nmbrDaysInYear = 365.2422;
            double nmbrDays = nmbrDaysInYear * nmYears;
            nmbrDays = Math.Floor(nmbrDays);
            int nmbrSecondsInEmphemerisDay = 86400;
            double minutes = (nmbrDays * nmbrSecondsInEmphemerisDay) / 60.0;
            double hours = minutes / 60.0;
            ulong seconds = (ulong)(nmbrDays * nmbrSecondsInEmphemerisDay);
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000.0m;

            Console.WriteLine($"{nmCntries} centuries = {nmYears} years = {nmbrDays,0:F0} days = {hours,0:F0} hours = {minutes,0:F0} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds,0:F0} nanoseconds");

        }
    }
}
