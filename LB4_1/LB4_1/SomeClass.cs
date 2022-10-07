using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class SomeClass
    {
        public void SomeMethod(int id, double count, string name)
        {
            Debug.WriteLine(id);
            Debug.WriteLine(name);
            Debug.WriteLine(count);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{id.GetType()} {id}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name.GetType()} {name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{count.GetType()} {count}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
