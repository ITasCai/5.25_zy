using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_zy
{
    /// <summary>
    /// 企鹅类
    /// </summary>
    class Penguin : Bird
    {
        /// <summary>
        /// 引用父类中的构造方法
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Color">颜色</param>
        public Penguin(string Name, string Color) : base(Name, Color)
        {
        }

        /// <summary>
        /// 重写吃饭的功能（企鹅）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("我是企鹅，我喜欢吃鱼！！");
        }

        /// <summary>
        /// 重写睡觉的功能（企鹅）
        /// </summary>
        public override void Sleep()
        {
            Console.WriteLine("我是企鹅，我会睡觉！！被冻醒了！哇哇哇......");
        }
    }
}
