using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P50_String_Methods_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "String";
            Console.WriteLine($"a:{a}");

            string b = a.Replace("i", "o");
            Console.WriteLine($"a:{a},b:{b}");
            
            b=a.Insert(0, "My ");
            Console.WriteLine($"a.Insert:{a},b:{b}");

            b = a.Remove(0, 3);
            Console.WriteLine($"a.Remove:{a},b:{b}");

            b = a.Substring(0, 3);
            Console.WriteLine($"a.Substring:{a},b:{b}");

            b = a.ToUpper();
            Console.WriteLine($"a.ToUpper:{a},b:{b}");

            b = a.ToLower();
            Console.WriteLine($"a.ToLower:{a},b:{b}");

            int len =a.Length;
            Console.WriteLine($"a.Length:{a},len:{len}");

            Console.ReadLine();

        }
    }
}
