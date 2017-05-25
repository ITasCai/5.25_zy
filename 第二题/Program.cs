using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 2.从学生、老师、校长类抽象出人的类，学生和老师都有收作业的方法，但是校长不会收作业。

            Person p1 = new Student("学生",17,"男");
            Console.WriteLine(p1);
            p1.Eat();
            p1.Sleep();
            Job j1 = new Student();
            j1.GetJob();
            Console.WriteLine("------------------------");
            Console.ReadKey();

            Person p2 = new Teacher("老师", 35, "女");
            Console.WriteLine(p2);
            p2.Eat();
            p2.Sleep();
            Job j2 = new Student();
            j2.GetJob();
            Console.WriteLine("------------------------");
            Console.ReadKey();

            Person p3 = new Principal("校长", 35, "男");
            Console.WriteLine(p3);
            p3.Eat();
            p3.Sleep();

            Console.ReadKey();

            #endregion
        }
    }
}
