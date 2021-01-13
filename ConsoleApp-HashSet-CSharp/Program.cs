using System;
using System.Collections.Generic;

namespace ConsoleApp_HashSet_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();

            names.Add("Denis");
            names.Add("Federico");
            names.Add("Bladi");
            names.Add("Fanny");

            names.Remove("Denis"); // test eliminar este item

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
