using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_zy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.麻雀、鸵鸟、企鹅、鹦鹉。麻雀和鹦鹉可以飞，但是企鹅和鸵鸟不能。   怎么使用接口实现。（继承一个类同时实现接口）

            Bird b1 = new Parrot("鹦鹉","绿色");
            Console.WriteLine(b1);
            b1.Eat();
            b1.Sleep();
            Flight f1 = new Parrot();
            f1.GetFlight();
            Console.WriteLine("------------------------------");
            Console.ReadKey();

            Bird b2 = new Sparrow("麻雀", "灰色");
            Console.WriteLine(b2);
            b1.Eat();
            b1.Sleep();
            Flight f2 = new Sparrow();
            f2.GetFlight();
            Console.WriteLine("------------------------------");
            Console.ReadKey();


            Bird b3 = new Penguin("企鹅", "黑白色");
            Console.WriteLine(b3);
            b3.Eat();
            b3.Sleep();
            Console.WriteLine("------------------------------");
            Console.ReadKey();


            Bird b4 = new Ostrich("鸵鸟", "褐色");
            Console.WriteLine(b4);
            b4.Eat();
            b4.Sleep();
            Console.ReadKey();

            #endregion
        }
    }
}
