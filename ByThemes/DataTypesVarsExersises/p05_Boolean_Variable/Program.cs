using System;

namespace p05_Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolVal = Convert.ToBoolean(Console.ReadLine());
            string yes_no;
            if (boolVal)
            {
                yes_no ="Yes";
            }
            else
            {
                yes_no = "No";
            }
            Console.WriteLine(yes_no);
        }
    }
}
