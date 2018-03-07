using System;

namespace p13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char testSymbol = Console.ReadLine()[0];
            if ('0'<=testSymbol&&testSymbol<='9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (testSymbol)
                {
                    case 'A':
                        case 'a':
                        case'O':
                        case 'o':
                        case 'U':
                        case 'u':
                        case 'E':
                        case 'e':
                        case 'I':
                        case 'i':Console.WriteLine("vowel");
                        break;
                    default:Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
