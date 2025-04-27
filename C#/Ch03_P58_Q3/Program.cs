using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P58_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {


                for (int j = 0; j <= 4; j++)
                {
                    if(j<=(4-i))
                        Console.Write("*");
                
                else
                
                    Console.Write(" ");
                }
                Console.WriteLine();

               
            }
            Console.ReadLine();
        }
    }
}
