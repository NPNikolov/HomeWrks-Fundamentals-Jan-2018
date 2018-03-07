using System;

namespace p05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = PrintTemperature(fahrenheit);
            Console.WriteLine($"{celsius,0:f2}");
        }

        static double PrintTemperature(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9;
        }
    }
}
