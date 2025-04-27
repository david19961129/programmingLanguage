namespace ACh07_P07_Record_Value_Behavior_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pl = new Person("Andy", 30);
            var p2 = new Person("Andy", 30);

            Console.WriteLine($"pl.Equals(p2): (pl.Equals(p2))");
            Console.WriteLine($"pl = p2 : (pl = p2)");


            var el = new Employee("Eric", 30);
            var e2 = new Employee("Eric", 30);

            Console.WriteLine($"el.Equals(e2) : (el.Equals(e2))");
            Console.WriteLine($"el = e2 : (el = e2)");
            Console.ReadLine();
        }
    }
    public record Person(string name, int age);
    public class Employee
    {
        public string name;
        public int age;
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
