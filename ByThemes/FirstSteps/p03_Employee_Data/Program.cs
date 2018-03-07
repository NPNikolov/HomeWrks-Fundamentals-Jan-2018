using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            String age = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            double slry = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine($"Employee ID: {id:D8}");
            Console.WriteLine("Salary: {0:F2}", slry);
        }
    }
}
