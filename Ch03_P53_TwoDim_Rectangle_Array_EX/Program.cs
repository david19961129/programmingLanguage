using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P53_TwoDim_Rectangle_Array_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] x = new string[2, 2];  //1
            x[0, 0] = "ABC"; x[0, 1] = "def";
            x[1, 0] = "123"; x[1, 1] = "456";
            Console.WriteLine($"x[0,0]:{x[0,0]},x[0,1]:{x[0, 1]}");
            Console.WriteLine($"x[1,0]:{x[1, 0]},x[1,1]:{x[1, 1]}");

            string[,] y = new string[2, 2] { { "GHI", "jkl" },{ "789", "234" } };  //2
            Console.WriteLine($"y[0,0]:{y[0, 0]},y[0,1]:{y[0, 1]}");
            Console.WriteLine($"y[1,0]:{y[1, 0]},y[1,1]:{y[1, 1]}");

            string[,] z ={ { "MNO", "pqr" },{ "567", "890" } };  //3
            Console.WriteLine($"z[0,0]:{z[0, 0]},z[0,1]:{z[0, 1]}");
            Console.WriteLine($"z[1,0]:{z[1, 0]},z[1,1]:{z[1, 1]}");

            Console.ReadLine();
        }
    }
}
