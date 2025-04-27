using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACh07_P03_Struct_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(); //Default CTOR;
            p.x = 10;
            p.y = 20;
            Console.WriteLine($"p.x = (p.x), p.y = (p.y)");

            Point p2 = new Point(100, 200); //Standandard CTOR;
            Console.WriteLine($"p2.x = (D2.x), D2. = (D2.y);");
            Console.ReadLine();
        }
    }
    struct Point
    {
        public int x, y;
        public Point(int x, int y) //Standard CTOR;
        {
            this.x = x;
            this.y = y;
        }
    }
}