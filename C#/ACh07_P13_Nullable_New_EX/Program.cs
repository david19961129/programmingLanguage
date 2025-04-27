namespace ACh07_P13_Nullable_New_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = null;
            string t = null;
            int? i = null;
            int? j = null;
            //1=12;
            j = i ?? 0;
            Console.WriteLine($"i = (i),j=(j)"); // i = mull,j = 0;

            String ss = "Sam";
            j = ss?.Length; //3
            Console.WriteLine($"i =(j)");//i=null,j=3;

            j = ss?.Length; //3
            Console.WriteLine($"i = (i),j=(j)");//i=null,j=null;

            j ??= 3; //j = j ? 3;
            Console.WriteLine($"i = (i),j=(j)"); //i=null,j=3;
            Console.Read();
            
        }
    }
}