using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P48_String_Concate_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = a + " world!!!";
            Console.WriteLine($"string a ={a}");
            Console.WriteLine($"string b ={b}");

            a += " World";      // a= a+"World"; // Compound Operator 複合運算子;
            Console.WriteLine($"string a ={a}");
            Console.WriteLine($"string b ={b}");

            int i = 1;
            string c = i + " is " + 1;
            string d = i .ToString() +" is "+1.ToString();
            Console.WriteLine($"c:{c}, and d: {d}");

            string s1 = "Hello";
            string s2 = "World";
            string s = $"{s1} {s2}";
            string t = s1 + " " + s2;
            Console.WriteLine($"s:{s},and t:{t}");


            // For number; +=, -=, *=, /=, %= (mod)

            Console.ReadLine();

        }
    }
}
