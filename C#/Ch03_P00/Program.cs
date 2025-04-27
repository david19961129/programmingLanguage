using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short x = 10;
            short y = 20;
            int z = x+y;

            Console.WriteLine($"x is {x},y is {y},z and {z}");

            Console.WriteLine("請輸入x值");
            x = Convert.ToInt16( Console.ReadLine() );
            Console.WriteLine("請輸入y值");
            y = Convert.ToInt16(Console.ReadLine());
            z = x + y;
            Console.WriteLine($"x is {x},y is {y},z and {z}");
            
            Console.ReadLine();
        }
    }
}
