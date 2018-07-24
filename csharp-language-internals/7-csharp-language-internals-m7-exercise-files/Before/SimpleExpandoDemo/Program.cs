using System;
using System.Collections.Generic;

namespace SimpleExpandoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic person = new Expando();

            // The following does not run correctly. Implement DynamicObject
            // on the Expando class to make it run fine.

            person.Name = "Bart";

            string name = person.Name;

            Console.WriteLine(name);
        }
    }

    class Expando
    {
    }
}
