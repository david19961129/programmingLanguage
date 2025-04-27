using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P55_For_For_Loops_9x9_Table_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int outer = 1; outer <= 9; outer++)
            {

                for (int inner = 2; inner <= 5; inner++)
                {
                    Console.Write($"{inner}x{outer}={inner * outer}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------");

            for (int outer = 1; outer <= 9; outer++)
            {

                for (int inner = 6; inner <= 9; inner++)
                {
                    Console.Write($"{inner}x{outer}={inner * outer}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");
            for (int outer = 1; outer <= 9; outer++)
            {

                int inner = 2;
                while(inner<=5)
                {
                    Console.Write($"{inner}x{outer}={inner * outer}\t");
                    inner++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------");

            for (int outer = 1; outer <= 9; outer++)
            {

                int inner = 6;
                do 
                {
                    Console.Write($"{inner}x{outer}={inner * outer}\t");
                inner++;
                } while (inner <= 9) ;
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
