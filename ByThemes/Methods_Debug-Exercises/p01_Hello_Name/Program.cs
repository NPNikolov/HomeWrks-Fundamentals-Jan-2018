using System;

namespace p01_Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
