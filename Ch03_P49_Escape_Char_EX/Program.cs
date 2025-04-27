using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P49_Escape_Char_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello " + "World";  //string concate +
            Console.WriteLine(myString);
            myString = "Hello\nWorld";             //  /n:new line:
            Console.WriteLine(myString);

            myString = "He's a handsome Guy!!!";
            Console.WriteLine(myString);

            myString = "Tom\'s a handsome Guy!!!";
            Console.WriteLine(myString);

            myString = "steve\"s a handsome Guy!!!";
            Console.WriteLine(myString);

            String s1 = "c:\\Windows\\System32\\cmd.exe";
            Console.WriteLine(s1);
            s1 = @"c:\Windows\System32\cmd.exe";
            Console.WriteLine(s1);


            Console.ReadLine();
        }
    }
}
