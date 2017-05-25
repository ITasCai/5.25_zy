using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    /// <summary>
    /// 老师类
    /// </summary>
    class Teacher : Person, Job
    {

        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年龄</param>
        /// <param name="Sex">性别</param>
        public Teacher(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {
        }

        public Teacher() {

        }


        /// <summary>
        /// 重写父类中吃饭的方法（老师）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("我今天吃了红薯！！！");
        }

        /// <summary>
        /// 实现接口中收作业的功能（老师）
        /// </summary>
        public void GetJob()
        {
            Console.WriteLine("又要把作业送到校长那里！！！");
        }

        /// <summary>
        /// 重写父类中睡的方法（老师）
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("今天要备课，十二点才睡觉！！！S");
        }
    }
}
