using System;

namespace ACh07_P14_String_Extension_Method_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "123.45678";
            Console.WriteLine($"s to double is: (Double.Parse(s))");
            Console.WriteLine($"s to double is:(s.ToDouble())"); //Extensio

            s = "Welcome to C# Programming";
            Console.WriteLine($"words count in s:{s.GetWordsCount()}");

            Console.ReadLine();
        }
    }
    static class MyExtensions
    {
        public static double ToDouble(this string s)
        {
            return Double.Parse(s);
        }

        public static double GetWordsCount(this string s)
        {
            return s.Split().Length;
        }
    }
}
