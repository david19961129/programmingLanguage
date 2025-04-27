using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_P107_Hierchical_Generic_Class_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseConcrete bc =new BaseConcrete(12,34);
            bc.showInternalStates();

            BaseGeneric<double> bg = new BaseGeneric<double>(12.34,34.56);
            bg.showInternalStates();

            Gen1<string> gen1 = new Gen1<string>("Hello Gen1", 56, 78);
            gen1.showInternalStates();

            Gen2<string> gen2 = new Gen2<string>("Hello Gen2", 56.78, 78.90);
            gen2.showInternalStates();

            Gen3<string> gen3 = new Gen3<string>("Hello Gen3", "David", "Eric");
            gen3.showInternalStates();

            Gen3<Char> gen4 = new Gen3<Char>('x','y','T');
            gen4.showInternalStates();

            Console.Read();
        }
    }
    class BaseConcrete
    {
        public int x,y;
        public BaseConcrete(int x,int y)
        {
         this.x = x;
         this.y = y;
        }
        public virtual void showInternalStates()
        {
        Console.WriteLine($"In BaseConcrete:point.x={x},point.y={y}");
        }

    }
    class BaseGeneric<T>
    {
        public T x, y;
        public BaseGeneric(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void showInternalStates()
        {
            Console.WriteLine($"In BaseConcrete: point.x={x},point.y={y}");
        }

    }
    class Gen1<T>:BaseConcrete
    {
        T z;
        public Gen1(T z,int x,int y):base(x,y)
        {
            this.z = z;
        }
        public override void showInternalStates()
        {
            Console.WriteLine($"In Gen1<t>:BaseConcrete:point.x={x},point.y={y},point.z={z}");
        }

     }
    class Gen2<T> : BaseGeneric<double>
    {
        T z;
        public Gen2(T z, double x, double y) : base(x, y)
        {
            this.z = z;
        }
        public override void showInternalStates()
        {
            Console.WriteLine($"In Gen2<t>:BaseGeneric<double>:point.x={x},point.y={y},point.z={z}");
        }

    }

    class Gen3<T> : BaseGeneric<T> 
    {
        T z;
        public Gen3(T z, T x, T y) : base(x, y)
        {
            this.z = z;
        }
        public override void showInternalStates()
        {
            Console.WriteLine($"In Gen3<t>:BaseGeneric<T>:point.x={x},point.y={y},point.z={z}");
        }

    }

}
