using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double d = 1234.5678;
                int x= (int)d;
                Console.WriteLine($"d is {d},x is {x}");
              
                long ll = 123456789012;
                Console.WriteLine($"long.Max={long.MaxValue},and ll ={ll}");
                x = (int)ll;
                Console.WriteLine($"ll is {ll}, x is {x}");

                Console.ReadLine();
            }
    }
}
