using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_P114_GenericList_Add_Insert_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3};
            showElements();

            numbers.Add(5); showElements();
            numbers.AddRange(new int[] {7,11}); showElements();

            numbers.Insert(6,11); showElements();
            numbers.Insert(7, 15); showElements();
            numbers.Insert(8, 25); showElements();
            numbers.Add(85); showElements();

            numbers.InsertRange(1,new int[] { 8,88,888 }); showElements();


            Console.ReadLine();

            void showElements()  //Inner Method, helper method;
            {
                foreach (var element in numbers)
                {
                    Console.Write(element+"\t");
                }
                Console.WriteLine($"numbers.Count={numbers.Count}. numbers.Capacity ={ numbers.Capacity}");
            }
        }
    }
}
