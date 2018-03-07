using System;

namespace p11_5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string res = "init";

            for (int i = a; i <= b - 4; i++)
            {
                for (int j = i+1; j <= b -3; j++)
                {
                    for (int k = j+1; k <= b-2; k++)
                    {
                        for (int l = k+1; l <= b-1; l++)
                        {
                            for (int m = l+1; m <= b; m++)
                            {
                                res = i + " "+j + " " + k + " " + l + " " + m;
                                Console.WriteLine(res);

                            }

                        }
                    }
                }
            }

            if (res.Equals("init"))
            {
                Console.WriteLine("No");
            }
        }
    }
}
