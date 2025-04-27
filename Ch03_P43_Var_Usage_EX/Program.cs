using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P43_Var_Usage_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"x={x}");//{變數}

            var y = 20;            //當執行指定時，var y Type就會被決定;
            Console.WriteLine($"y={y},and y is tyoe: {y.GetType()}");
            y = (int)34.56;   //Explicit Type Casting, 大解析度(double)的變數,塞入小解析度(int)的容器時;      
            Console.WriteLine($"y={y},and y is tyoe: {y.GetType()}");

            var z = 123.456;      //double:
            Console.WriteLine($"z={z},and y is tyoe: {z.GetType()}");
            z = 123;          //Implicit Type Casting, Auto Casting;
            Console.WriteLine($"z={z},and y is tyoe: {z.GetType()}");

            Console.ReadLine();
        }
    }
}
