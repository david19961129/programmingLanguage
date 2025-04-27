using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P46_Implicit_ConvertType_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bt = 123;
            int x = bt + 1;
            Console.WriteLine($"x={x}");

            short sh = 18;
            x = sh;
            Console.WriteLine($"x={x}");

            char ch = '游';
            x = ch;
            Console.WriteLine($"x={x:X},{x}");

            ch = 'a';
            x= ch;
            Console.WriteLine($"x={x:X},{x}");

            Console.ReadLine();
        }
    }
}
