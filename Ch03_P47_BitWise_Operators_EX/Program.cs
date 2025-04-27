using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P47_BitWise_Operators_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 5;
            byte y = 4;
            Console.WriteLine($"x in binary:{Convert.ToString(x,2).PadLeft(8,'0')},{x}");
            Console.WriteLine($"y in binary:{Convert.ToString(y, 2).PadLeft(8, '0')},{y}");


            byte z;                
            z = (byte)(x & y);        //byte op byte => int; AND Bitwise;//且運算;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"z = x & y :{Convert.ToString(z, 2).PadLeft(8, '0')},{z}");

            
            z = (byte)(x | y);        //byte op byte => int; OR Bitwise;//或運算;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"z = x | y :{Convert.ToString(z, 2).PadLeft(8, '0')},{z}");

            z = (byte)(x ^ y);        //byte op byte => int; XOR Bitwise;//互斥運算;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"z = x ^ y :{Convert.ToString(z, 2).PadLeft(8, '0')},{z}");

            z = (byte)( ~ x );        //byte op byte => int; Invert Bitwise;//反向運算; 1->0, 0->1;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"z = ~ x  :{Convert.ToString(z, 2).PadLeft(8, '0')},{z}");

            z = (byte)(x >> 2);        //byte op byte => int; shift Right 2 bits;//右旋2bits運算;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"z = x >> 2  :{Convert.ToString(z, 2).PadLeft(8, '0')},{z}");

            z = (byte)(x << 2);        //byte op byte => int; shift Right 2 bits;//左旋2bits運算;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"z = x << 2  :{Convert.ToString(z, 2).PadLeft(8, '0')},{z}");

            Console.ReadLine() ;
        }
    }
}
