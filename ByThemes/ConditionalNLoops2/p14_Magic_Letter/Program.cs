using System;

namespace p14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char chr1 = str1[0];
            str1 = Console.ReadLine();
            char chr2 = str1[0];
            str1 = Console.ReadLine();
            char chr3 = str1[0];
            String str2 = "" + chr3;
            int cntrl = 0;

            for (char i = chr1; i <= chr2; i++)
            {
                for (char j = chr1; j <= chr2; j++)
                {
                    for (char k = chr1; k <= chr2; k++)
                    {
                        str1 = ""+ i + j + k;
                        if (cntrl > 0)
                        {
                            Console.Write(" ");
                            cntrl = 0;
                        }
                        if (!str1.Contains(str2))
                        {
                            
                            Console.Write(str1);
                            cntrl += 1;
                        }

                    }
                }
            }
            if (cntrl>0)
            {
                Console.WriteLine();
            }

        }
    }
}
