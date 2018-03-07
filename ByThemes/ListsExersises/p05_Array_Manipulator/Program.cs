using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            var intLst = array.ToList();
            string cmd = "";
            do
            {
                string[] arrCmd = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                cmd = ProcessCmd(arrCmd, intLst);

            } while (! "print".Equals(cmd));
        }

        static string ProcessCmd(string[] arrCmd, List<int> arrList)
        {
            string cmd = arrCmd[0].ToLower();

            switch (cmd)
            {
                case "add":arrList.Insert(int.Parse(arrCmd[1]), int.Parse(arrCmd[2]));
                    break;
                case "sumpairs":
                    int numPairs = arrList.Count/2;
                    for (int i = 0; i < numPairs; i++)
                    {
                        int tmp = arrList[i+1];

                        arrList.RemoveAt(i+1);
                        arrList[i] +=tmp;
                    }
                    break;
                case "shift":
                    int atPstns = int.Parse(arrCmd[1]);
                    for (int i = 1; i <= atPstns; i++)
                    {
                        int tmp = arrList[0];
                        arrList.RemoveAt(0);
                        arrList.Add(tmp);
                    }
                    break;
                case "remove":
                    int atPstn = int.Parse(arrCmd[1]);
                    arrList.RemoveAt(atPstn);
                    break;
                case "contains":
                    int indof = arrList.IndexOf(int.Parse(arrCmd[1]));
                    Console.WriteLine(indof);
                    break;
                case "addmany":

                    int[] arrRange = new int[arrCmd.Length - 2];
                    for (int i = 0; i < arrRange.Length; i++)
                    {
                        arrRange[i] = int.Parse(arrCmd[i + 2]);
                    }
                    arrList.InsertRange(int.Parse(arrCmd[1]), arrRange);
                    
                    break;
                case "print":PrintList(arrList);
                    break;

            default:cmd = "4";
            break;
            }
            return cmd;
        }

        static void PrintList(List<int> arrLs)
        {
            string str = string.Join(", ", arrLs);
            Console.WriteLine($"[{str}]");
        }
    }
}
