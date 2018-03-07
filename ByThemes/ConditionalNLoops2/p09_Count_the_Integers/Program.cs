using System;

namespace p09_Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool check = false;
            do
            {
                string test = Console.ReadLine();
                int niakoe = 0;
                check = int.TryParse(test, out niakoe);
                if (check)
                {
                    counter += 1;
                }
            } while (check);
            Console.WriteLine(counter);
        }
        
    }
}
