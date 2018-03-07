using System;

namespace p06_Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string chars = "";
            for (char i = 'a'; i <= 'z'; i++)
            {
                chars += i;
            }
            
            string src_str = "";
            
            for (int i = 0; i <= n-1; i++)
            {
                src_str += chars[i];
            }

            int indx = Math.Min(n - 1, 2);

            string hlp_str = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        hlp_str = "" + src_str[i] + src_str[j] + src_str[k];
                        Console.WriteLine(hlp_str);
                    }
                }
            }

            
            


        }
    }
}
