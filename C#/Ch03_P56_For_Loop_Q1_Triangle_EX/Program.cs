using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P56_For_Loop_Q1_Triangle_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row=0, col=0;
            for(row=0; row<=4;row++)
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
