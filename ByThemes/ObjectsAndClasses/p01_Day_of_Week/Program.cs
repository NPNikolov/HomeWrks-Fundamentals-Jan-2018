using System;
using System.Globalization;

namespace p01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStrng = Console.ReadLine();
            DateTime dateObj = DateTime.ParseExact(dateStrng, "d-M-yyyy", CultureInfo.InvariantCulture);
            string dayOfWeek = dateObj.DayOfWeek.ToString();
            Console.WriteLine(dayOfWeek);
        }
    }
}
