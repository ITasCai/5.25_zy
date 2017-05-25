using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Student : Person, Job
    {


        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年龄</param>
        /// <param name="Sex">性别</param>
        public Student(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {
        }

        public Student() {
        }

        /// <summary>
        /// 重写吃饭的方法（学生）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("我今天吃了西红柿炒鸡蛋");
        }



        /// <summary>
        /// 实现接口中收作业的功能（学生）
        /// </summary>
        public void GetJob()
        {
            Console.WriteLine("又开始收作业了！！！");
        }

        /// <summary>
        /// 重写睡觉的方法（学生）
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("今天作业很多，我凌晨三点才睡觉！！！");
        }
    }
}
