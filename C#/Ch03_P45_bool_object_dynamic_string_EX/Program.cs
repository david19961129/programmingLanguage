using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P45_bool_object_dynamic_string_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ranny, sunny;
            sunny =true;
            ranny =false;

            short sh;

            Console.WriteLine("請輸入今天天氣: 1:晴天,0:雨天");
            sh = Convert.ToInt16(Console.ReadLine());
            if (sh != 0 ) sunny = true;
            else sunny = false;
            
            ranny = !sunny;
            if (sunny)
            {
                Console.WriteLine("今天不用帶雨傘");
                Console.WriteLine("今天建議帶洋傘");
            }

            if (ranny==true)
            {
                Console.WriteLine("今天請帶雨傘");
            }
            Console.ReadLine();
        }
    }
}
