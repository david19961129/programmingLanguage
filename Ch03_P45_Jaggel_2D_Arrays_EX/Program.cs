using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P45_Jaggel_2D_Arrays_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] a = new string[2][]; //1
            a[0]= new string[2];
            a[1]= new string[3];
            a[0][0] = "00"; a[0][1] = "01";
            a[1][0] = "10"; a[1][1] = "11";
            Console.WriteLine($"a[0][0]:{a[0][0]}\ta[0][1]:{a[0][1]}");
            Console.WriteLine($"a[1][0]:{a[1][0]}\ta[1][1]:{a[1][1]}");

            Console.WriteLine("-----------------------------------");
            string[][] b = new string[][] { new[] { "ab", "cd" }, new[] {"ef","gh","ij" } }; //2m
            Console.WriteLine($"b[0][0]:{b[0][0]}\tb[0][1]:{b[0][1]}");
            Console.WriteLine($"b[1][0]:{b[1][0]}\tb[1][1]:{b[1][1]}");
            Console.ReadLine();
        }
    }
}
