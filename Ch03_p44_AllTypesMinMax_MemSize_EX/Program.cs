using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_p44_AllTypesMinMax_MemSize_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"short min:{short.MinValue}, short max:{short.MaxValue}, short MemSize:{sizeof(short)}bytes ");
            Console.WriteLine($"int min:{int.MinValue}, short max:{int.MaxValue}, int MemSize:{sizeof(int)}bytes ");
            Console.WriteLine($"long min:{long.MinValue}, long max:{long.MaxValue}, long MemSize:{sizeof(long)}bytes ");

            Console.WriteLine($"float min:{float.MinValue}, float max:{float.MaxValue}, float MemSize:{sizeof(float)}bytes ");
            Console.WriteLine($"double min:{double.MinValue}, double max:{double.MaxValue}, int double:{sizeof(double)}bytes ");
            Console.WriteLine($"decimal min:{decimal.MinValue}, decimal max:{decimal.MaxValue}, decimal MemSize:{sizeof(decimal)}bytes ");

            float fx = -1.012345678901234567890123456789f;
            Console.WriteLine($"float precison:{fx}");
            double dx = -1.012345678901234567890123456789;
            Console.WriteLine($"double precison:{dx}");
            decimal ddx = -1.012345678901234567890123456789m;
            Console.WriteLine($"decimal precison:{ddx}");

            Console.ReadLine();
        }
    }
}
