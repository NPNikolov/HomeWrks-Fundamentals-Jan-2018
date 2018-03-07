using System;

namespace p10_Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr = int.Parse(Console.ReadLine());
            string line = "";
            for (int i = 1; i <= nmbr; i++)
            {
                line = int_line(i);
                Console.WriteLine(line);
            }
        }
        public static string int_line(int nm)
        {
            string res = "";
            for (int i = 0; i < nm; i++)
            {
                res = res + nm;
                if (i<nm)
                {
                    res = res + " ";
                }
            }
            return res;
        }
    }
}
