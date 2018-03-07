using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_Number_0_9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            int nmb = int.Parse(Console.ReadLine());
            String str = "";
            switch (nmb)
            {
                case 0:
                    str = "zero";
                    break;
                case 1:
                    str = "one";
                    break;
                case 2:
                    str = "two";
                    break;
                case 3:
                    str = "three";
                    break;
                case 4:
                    str = "four";
                    break;
                case 5:
                    str = "five";
                    break;
                case 6:
                    str = "six";
                    break;
                case 7:
                    str = "seven";
                    break;
                case 8:
                    str = "eight";
                    break;
                case 9:
                    str = "nine";
                    break;
                default:
                    str = "number too big";
                    break;
            }
            Console.WriteLine(str);
        }
    }
}
