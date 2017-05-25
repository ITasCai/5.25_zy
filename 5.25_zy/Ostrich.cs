using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_zy
{
    /// <summary>
    /// 鸵鸟类
    /// </summary>
    class Ostrich : Bird
    {
        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Color">颜色</param>
        public Ostrich(string Name, string Color) : base(Name, Color)
        {
        }


        /// <summary>
        /// 重写吃饭的功能（鸵鸟）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("我是鸵鸟，我喜欢吃仙人掌！！");
        }

        /// <summary>
        /// 重写睡觉的功能（鸵鸟）
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("我是鸵鸟，我会睡觉！！这天真热。。。。。");
        }
    }
}
