using ACh07_P10_Enum_EX;
using System;
using System.Threading.Tasks;
namespace ACh07_P10_Enum_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            State state = State.Running;
            Console.WriteLine($"state = {state}, state.value = {(int)state}");
            State2 state2 = State2.Stopped;
            Console.WriteLine($"state2 ={state2}, state2.value = {(int)state2}");

            foreach (var name in Enum.GetNames(typeof(Colors)))
                Console.Write($"name = (name) (t");
            Console.WriteLine();
            foreach (var value in Enum.GetValues(typeof(Colors)))
                Console.Write($"value = (int)value) (t");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    enum State { Running, Waiting, Stopped }
    enum State2 { Running = 0, Waiting = 3, Stopped = Waiting + 2 }
    enum Colors { Red, Green, Blue }
}