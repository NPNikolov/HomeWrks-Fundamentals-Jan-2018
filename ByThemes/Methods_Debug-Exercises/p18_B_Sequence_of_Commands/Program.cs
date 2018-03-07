using System;
using System.Linq;

namespace p18_B_Sequence_of_Commands
{
    public class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            ulong[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(ulong.Parse).ToArray();


            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string line = command.Trim();
                int[] args = new int[2];
                string[] stringParams = line.Split(ArgumentsDelimiter);
                command = stringParams[0].ToLower();
                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);
                }

                PerformAction(array, command, args);

                PrintArray(array);
                Console.Write('\n');

                command = Console.ReadLine().ToLower().Trim();
            }
        }

        static void PerformAction(ulong[] array, string action, int[] args)
        {

            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= (ulong)value;
                    break;
                case "add":
                    array[pos - 1] += (ulong)value;
                    break;
                case "subtract":
                    array[pos - 1] -= (ulong)value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(ulong[] array)
        {
            ulong tmpElmnt = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = tmpElmnt;
        }

        private static void ArrayShiftLeft(ulong[] array)
        {
            ulong tmpElmnt = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = tmpElmnt;
        }

        private static void PrintArray(ulong[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(array[i]);
            }
        }
    }
}
