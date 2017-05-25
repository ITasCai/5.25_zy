using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_zy
{
    /// <summary>
    /// 麻雀类
    /// </summary>
    class Sparrow : Bird,Flight
    {
        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Color">颜色</param>
        public Sparrow(string Name, string Color) : base(Name, Color)
        {
        }

        public Sparrow() {
        }

        /// <summary>
        /// 重写吃饭的功能（麻雀）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("我是麻雀，我喜欢吃虫子");
        }

  

        /// <summary>
        /// 重写飞翔的功能（麻雀）
        /// </summary>
        /// 
        public void GetFlight()
        {
            Console.WriteLine("我是麻雀，我会飞！哈哈哈哈。。。。");
        }


        /// <summary>
        /// 重写睡觉的功能（麻雀）
        /// </summary>
        /// 


        public override void Sleep()
        {
          
            Console.WriteLine("我是麻雀，我会睡觉！睡着了。。。。。");
        }
    }
}
