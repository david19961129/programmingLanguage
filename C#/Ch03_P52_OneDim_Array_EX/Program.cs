using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P52_OneDim_Array_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x;
            x = new int[3]; //1
            x[0] = 1;
            x[1] = 2;
            x[2] = 3;
            Console.WriteLine($"x[0]:{x[0]},\tx[1]:{x[1]},\tx[2]:{x[2]}");

            int[] y;
            y = new int[3] { 3, 4, 5 }; //2
            Console.WriteLine($"y[0]:{y[0]},\ty[1]:{y[1]},\ty[2]:{y[2]}");

            int[]z= { 6, 7, 8 }; //3
            Console.WriteLine($"z[0]:{z[0]},\tz[1]:{z[1]},\tz[2]:{z[2]}");


            Console.ReadLine();
        }
    }
}
