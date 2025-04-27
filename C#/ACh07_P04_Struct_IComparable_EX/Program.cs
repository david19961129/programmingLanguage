using System;
namespace ACh07_P04_Struct_IComparable_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pl = new Point(10, 12); //22
            Point p2 = new Point(9, 13); ///22
            Point p3 = new Point(29, 13); //42
            Console.WriteLine($"pl.CompareTo(p2): (pl.CompareTo(p2)"); //0
            Console.WriteLine($"pl.CompareTo(p3): (pl.CompareTo(p3)"); //-1
            Console.ReadLine();
        }
    }
    struct Point : IComparable
    {
        public int x, y;
        public Point(int x, int y) //Standard CTOR;
        {
            this.x = x;
            this.y = y;
        }
        public int CompareTo(object obj)
        {
            int res = 0;
            Point tmp = (Point)obj;
            int self = x + y;
            int para = tmp.x + tmp.y;

            if (self > para) { res = 1; }
            else if (self == para) { res = 0; }
            else { res = -1; }
            return res;
        }
    }
}