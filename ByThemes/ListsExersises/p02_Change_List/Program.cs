using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intsList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            ReadCmd(intsList);

        }

        static void ReadCmd(List<int> intsList)
        {
            string cmd = Console.ReadLine();

            while (EndCmd(cmd, intsList))
            {
                string[] arrStr = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int arrSize = arrStr.Length;
                if (arrStr[0].Equals("Delete"))
                {
                    int elm = int.Parse(arrStr[1]);
                    intsList.RemoveAll(elmnt => elmnt==elm);
                }
                if (arrStr[0].Equals("Insert"))
                {
                    int elm = int.Parse(arrStr[1]);
                    int pstn = int.Parse(arrStr[2]);
                    intsList.Insert(pstn, elm);
                }
                cmd = Console.ReadLine();
            }
        }

        static bool EndCmd(string cmd, List<int> intsList)
        {
            bool cntnue = false;
            if ("Even".Equals(cmd) || "Odd".Equals(cmd))
            {
                int check = 0;
                if ("Odd".Equals(cmd)) check = 1;
                for (int i = 0; i < intsList.Count; i++)
                {
                    if (check==intsList[i]%2)
                    {
                        Console.Write(intsList[i]);
                        Console.Write(" ");
                    }
                }
            }
            else cntnue = true;
            return cntnue;
        }
    }
}
