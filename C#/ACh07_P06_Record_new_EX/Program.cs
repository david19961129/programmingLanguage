namespace ACh07_P06_Record_new_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person_Gen() { Name = "Andy", Age = 20 };
            var p2 = new Person_PP("Bill", 30);
            var p3 = new Person_PP_Gen("Carol", 40) {Country = "USA" };
            Console.WriteLine($"p1.Name={p1.Name}, p1.Age={p1.Age}");
            Console.WriteLine($"p2.Name={p2.Name}, p2.Age={p2.Age}");
            Console.WriteLine($"p3.Name={p3.Name}, p3.Age={p3.Age}, p3.Country={p3.Country}");
            Console.ReadLine();
        }
    }
    public record Person_Gen
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }
    public record Person_PP(string Name, int Age);
    public record Person_PP_Gen(string Name, int Age)
    {
        public string Country { get; init; }
    }
}