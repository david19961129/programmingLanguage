using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_p44_TypeRange_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short s0, s1;
            s0 = -32768;
            s1 =  32767;
            Console.WriteLine($"s0 is {s0},s1 is {s1}");

            s0 = short.MinValue;
            s1 = short.MaxValue;
            Console.WriteLine($"short main is {s0},short max is {s1}");

            int res0,res1;

            res0 = (short)(s0 - 1);
            res1 = (short)(s1 + 1);
            Console.WriteLine($"res0 is {res0},resl is {res1}");

            res0 = s0-1;
            res1 = s1-1;
            Console.WriteLine($"res0 is {res0},resl is {res1}");

            
            Console.ReadLine();
        }
    }
}
