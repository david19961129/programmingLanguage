using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_p45_String_Object_Dynamic_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ABC";
            Console.WriteLine($"s Length:{s.Length}");

            int x = 100;
            object obj = x;
            int y ;
            y=(int)obj;
            Console.WriteLine($"x:{x},and y:{y}");

            dynamic dy;
            dy = 100;
            Console.WriteLine($"dy:{dy}");

            Console.ReadLine();
        }
    }
}
