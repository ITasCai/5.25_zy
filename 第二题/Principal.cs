using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    /// <summary>
    /// 校长类
    /// </summary>
    class Principal : Person
    {

        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年龄</param>
        /// <param name="Sex">性别</param>
        public Principal(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {
        }


        public Principal() {
        }


        /// <summary>
        /// 重写父类中的吃饭的方法（校长）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("今天吃了红烧肉！！！");
        }


        /// <summary>
        /// 重写父类中的睡觉的方法（校长）
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("今天没事干，10点就睡了！！！");
        }
    }
}
