using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            string cmnd = "";
            do
            {
                cmnd = ProcessCmnd(phoneBook);
            } while (!("end".Equals(cmnd)));
        }

        static string ProcessCmnd(SortedDictionary<string, string> phoneBook)
        {
            var strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string cmnd = strArr[0].ToLower();
            switch (cmnd)
            {
                case "a":
                    phoneBook[strArr[1]] = strArr[2];
                    break;
                case "s":
                    bool found = phoneBook.TryGetValue(strArr[1], out string phone);
                    if (found)
                    {
                        Console.WriteLine($"{strArr[1]} -> {phone}");
                    }
                    else Console.WriteLine($"Contact {strArr[1]} does not exist.");
                    break;
                case "listall":
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
            }
            return cmnd;
        }
    }
}
