using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_P151_LINQ_Query_vs_Fluent_Syntax_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Andy", "Bill", "Carol", "David", "Eric" };
            var lquery = from e in names
                         where e.Contains("a")
                         select e.ToUpper();
            dumpContents(lquery);

            var fquery = names.Where(e => e.Contains("a")).Select(e => e.ToUpper());
            dumpContents(fquery);
            Console.ReadLine();
            void dumpContents(IEnumerable<string> sequence)
            {
                foreach (var e in sequence)
                {
                    Console.Write($"{e,-8}");
                }
                Console.WriteLine();
            }
        }
    }
}
