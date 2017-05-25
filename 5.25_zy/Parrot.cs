using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_zy
{
    /// <summary>
    /// 鹦鹉类
    /// </summary>
    class Parrot : Bird,Flight
    {

        public Parrot() {
        }


        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Color">颜色</param>
        public Parrot(string Name, string Color) : base(Name, Color)
        {
        }

        


        /// <summary>
        /// 重写吃饭的功能（鹦鹉）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("我是鹦鹉，我喜欢吃鸟粮！！！");
        }

     

        /// <summary>
        /// 重写飞翔的功能（鹦鹉）
        /// </summary>
        public void GetFlight()
        {
            Console.WriteLine("我是鹦鹉，我会飞！！！嘎嘎嘎！！！");
        }

        /// <summary>
        /// 重写睡觉的功能（鹦鹉）
        /// </summary>
        /// 
        public override void Sleep()
        {
         
            Console.WriteLine("我是鹦鹉，我会睡觉，我日，失眠了！！！");
        }
    }
}
