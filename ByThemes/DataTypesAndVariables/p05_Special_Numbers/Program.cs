using System;

namespace p05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int nm_dgts = i + 1;
                string to_str = ""+nm_dgts;
                int str_length = to_str.Length;
                int sum = 0;
                char character = ' ';
                for (int j = 0; j < str_length; j++)
                {
                    character = to_str[j];
                    string int_str = "" + character;
                    int val = 0;
                    bool try_p = int.TryParse(int_str, out val);
                    if (try_p)
                    {
                        sum += val;
                    }
                   
                }
                if (sum == 7 || sum == 11 || sum == 5)
                {
                    to_str = "True";
                }else
                    to_str = "False";
                Console.WriteLine($"{nm_dgts} -> {to_str}");
            }

        }
    }
}
