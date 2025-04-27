using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P48_Compound_Operators_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            y += x;            //y = y+x
            Console.WriteLine($"x:{x}, y:{y}");

            x += 10;           // 
            y -= 20;//
            Console.WriteLine($"x:{x}, y:{y}");

            x *= 3;
            y /= 2;
            Console.WriteLine($"x:{x}, y:{y}");

            x %= 7;
            Console.WriteLine($"x:{x}, y:{y}");

            if (x++> 4)           //post- position//後置型
            {
                y = 10;
            }
            else 
            {
                y = 20;
            }
            Console.WriteLine($"x:{x}, y:{y}"); //x=4+1,y=20;

            x = 4;
            y = 5;
            if (++x > 4)           //pre- position前置型
            {
                y = 10;
            }
            else
            {
                y = 20;
            }
            Console.WriteLine($"x:{x}, y:{y}");  //x=4+1,y=10;

            x = 4;y = 5;
            y = (++x > 4) ? 10 : 20;             //三元運算子:  e1? e2 : e3
            Console.WriteLine($"x:{x}, y:{y}");  //x=4+1,y=10

            int? z = 10;                         //nullable int type;
            x = z ?? 0;                          //if z!=null,return z, other return 0;
            Console.WriteLine($"x:{x}, z:{z}");  // x=10, z=10;
            z = null;
            x=z?? 0;                             //if z!=null, return z, other return 0;

            Console.WriteLine($"x:{x}, z:{z}");  // x=0, z=null; 

            Console.ReadLine();
        }
    }
}
