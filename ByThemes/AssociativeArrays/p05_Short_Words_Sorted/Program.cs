using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var wrdsLs = Console.ReadLine().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToList();
            var rsltLs = wrdsLs.Where(x => x.Length < 5).Distinct().OrderBy(x => x);
            Console.WriteLine(string.Join(", ", rsltLs));
        }
    }
}
