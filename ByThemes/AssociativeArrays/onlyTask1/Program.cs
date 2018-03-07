using System;
using System.Collections.Generic;
using System.Linq;

namespace onlyTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new SortedDictionary<DateTime, string>();
            events[new DateTime(1998, 4, 9)] = "Google's Birth date";
        }
    }
}
