using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P57_Q2_Triangle_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while ( i <= 4)
            {
                int j = 0;  //1
                do          //(2)
                {   
                    if (j < (4 - i)) //3
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    j++;    //4
                } while (j <= 4) ;  //2
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
