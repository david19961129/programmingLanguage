using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P51_StringBuilder_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine($"sb origin:{sb}");

            sb.Append(" world");
            Console.WriteLine($"sb Append():{sb}");

            sb.Remove(0, 5);
            Console.WriteLine($"sb Remove():{sb}");

            sb.Insert(0, "Bye");
            Console.WriteLine($"sb Insert():{sb}");

            string s=sb.ToString();
            Console.WriteLine($"sb ToString():{sb}, and s:{s}");

            sb.Insert(0, "Bye"); s.Insert(0, "Bye ");
            Console.WriteLine($"sb Insert():{sb}, and s:{s}");

            Console.ReadLine();
        }
    }
}
