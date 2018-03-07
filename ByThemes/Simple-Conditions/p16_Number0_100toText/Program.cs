using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16_Number0_100toText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numadd = 1000;
            String res = "";
            if (num == 0)
            {
                res = "zero";
            }
            else if (num == 100)
            {
                res = "one hundred";
            }
            else if (num < 0 || num > 100)
            {
                res = "invalid number";
            }
            else if (num <= 10)
            {
                switch (num)
                {
                    case 1:
                        res = "one";
                        break;
                    case 2:
                        res = "two";
                        break;
                    case 3:
                        res = "three";
                        break;
                    case 4:
                        res = "four";
                        break;
                    case 5:
                        res = "five";
                        break;
                    case 6:
                        res = "six";
                        break;
                    case 7:
                        res = "seven";
                        break;
                    case 8:
                        res = "eight";
                        break;
                    case 9:
                        res = "nine";
                        break;
                    case 10:
                        res = "ten";
                        break;
                }
            }
            else if (num <= 20)
            {
                switch (num)
                {
                    case 11:
                        res = "eleven";
                        break;
                    case 12:
                        res = "twelve";
                        break;
                    case 13:
                        res = "thirteen";
                        break;
                    case 14:
                        res = "fourteen";
                        break;
                    case 15:
                        res = "fifteen";
                        break;
                    case 16:
                        res = "sixteen";
                        break;
                    case 17:
                        res = "seventeen";
                        break;
                    case 18:
                        res = "eighteen";
                        break;
                    case 19:
                        res = "nineteen";
                        break;
                    case 20:
                        res = "twenty";
                        break;
                }
            }
            else if (num < 30)
            {
                res = "twenty";
                numadd = num % 10;
            }
            else if (num < 40)
            {
                res = "thirty";
                numadd = num % 10;
            }
            else if (num < 50)
            {
                res = "forty";
                numadd = num % 10;
            }
            else if (num < 60)
            {
                res = "fifty";
                numadd = num % 10;
            }
            else if (num < 70)
            {
                res = "sixty";
                numadd = num % 10;
            }
            else if (num < 80)
            {
                res = "seventy";
                numadd = num % 10;
            }
            else if (num < 90)
            {
                res = "eighty";
                numadd = num % 10;
            }
            else if (num < 100)
            {
                res = "ninety";
                numadd = num % 10;
            }
            if (numadd > 0 & numadd < 10)
            {
                switch (numadd)
                {
                    case 1:
                        res = res + " one";
                        break;
                    case 2:
                        res = res + " two";
                        break;
                    case 3:
                        res = res + " three";
                        break;
                    case 4:
                        res = res + " four";
                        break;
                    case 5:
                        res = res + " five";
                        break;
                    case 6:
                        res = res + " six";
                        break;
                    case 7:
                        res = res + " seven";
                        break;
                    case 8:
                        res = res + " eight";
                        break;
                    case 9:
                        res = res + " nine";
                        break;

                }
            }
            Console.WriteLine(res);
        }
    }
}
