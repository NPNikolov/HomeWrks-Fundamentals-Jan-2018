using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            String type = Console.ReadLine();
            double a, b;
            a = 1;
            b = 1;
            switch (type)
            {
                case "square":
                    {
                        a = double.Parse(Console.ReadLine());
                        b = a * a;
                    }
                    break;
                case "rectangle":
                    {
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        b = b * a;
                    }
                    break;
                case "circle":
                    {
                        a = double.Parse(Console.ReadLine());
                        b = Math.PI * a * a;
                    }
                    break;
                case "triangle":
                    {
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        b = b * a / 2.0;
                    }
                    break;
            }
            b = Math.Round(b, 3);
            Console.WriteLine(b);
        }
    }
}
