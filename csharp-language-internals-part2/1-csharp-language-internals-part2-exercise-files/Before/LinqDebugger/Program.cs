using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            var xs = new[] { 2, 4, 7, 6, 5, 1, 2, 3 };

            var ys = from x in xs
                     where x % 2 == 0
                     orderby 2 * x / 3 descending
                     select x + 1;

            foreach (var y in ys)
                Console.WriteLine(y);
        }
    }
}
