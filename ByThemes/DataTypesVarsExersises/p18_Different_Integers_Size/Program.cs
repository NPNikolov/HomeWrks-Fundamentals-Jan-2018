using System;

namespace p18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string testValue = Console.ReadLine();
            int stringLength = testValue.Length;
            
            if ('-' ==testValue[0])
            {
                if (stringLength>20)
                {
                    Console.WriteLine($"{testValue} can't fit in any type");
                }
                else if (stringLength == 20)
                {
                    ulong testLong = ulong.Parse(testValue.Substring(1));
                    ulong maxLong = ulong.Parse("9223372036854775808");
                    if (testLong > maxLong)
                    {
                        Console.WriteLine($"{testValue} can't fit in any type");
                    }
                    else {
                        Console.WriteLine($"{testValue} can fit in:");
                        Console.WriteLine("* long");
                    }
                }
                else
                {
                    long testLong = long.Parse(testValue.Substring(1));
                    Console.WriteLine($"{testValue} can fit in:");
                    if (128>=testLong)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (32768 >= testLong)
                    {
                        Console.WriteLine("* short");
                    }
                    if (2147483648 >= testLong)
                    {
                        Console.WriteLine("* int");
                    }
                    Console.WriteLine("* long");
                }
            }
            else
            {
                try
                {
                    ulong result = Convert.ToUInt64(testValue);
                    Console.WriteLine($"{testValue} can fit in:");
                    if (127>=result)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (255 >= result)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (32767 >= result)
                    {
                        Console.WriteLine("* short");
                    }
                    if (65535 >= result)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (2147483647 >= result)
                    {
                        Console.WriteLine("* int");
                    }
                    if (4294967295 >= result)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (9223372036854775807 >= result)
                    {
                        Console.WriteLine("* long");
                    }
                    Console.WriteLine("* ulong");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"{testValue} can't fit in any type");
                }
            }
        }
    }
}
