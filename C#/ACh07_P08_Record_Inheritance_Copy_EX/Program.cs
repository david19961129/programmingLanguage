using System.Xml.Linq;

namespace ACh07_P08_Record_Inheritance_Copy_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Andy", "Math");
            var s2 = s1 with { };
            var s3 = s1 with { name = "Bill", major = "Bio" };

            Console.WriteLine($"sl.name=(s1.name), s1.major=(s1.major)");
            Console.WriteLine($"s2.name=(s2.name), s2.major=(s2.major)");
            Console.WriteLine($"s3.name=[s3.name), s3.major=(s3.major)");

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s3.ToString());
            Console.ReadLine();
        }
    }
    public record Person(string name);
    public record Student(string name, string major) : Person(name);
}
