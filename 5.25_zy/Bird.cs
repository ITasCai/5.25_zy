using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._25_zy
{
    /// <summary>
    /// 一个鸟的抽象类
    /// </summary>
    abstract  class Bird
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { set; get; }


        public Bird() {
        }

        /// <summary>
        /// 鸟类的一个有参数的构造方法，用于对数据的初始化
        /// </summary>
        /// <param name="Name">名字</param>
        /// <param name="Color">颜色</param>
        public Bird(string Name,string Color) {
            this.Name = Name;
            this.Color = Color;

        }

        /// <summary>
        /// 吃饭的方法
        /// </summary>
       public abstract void Eat();
        /// <summary>
        /// 睡觉的方法
        /// </summary>
        public abstract void Sleep();

        /// <summary>
        /// 重写tostring方法，用于对数据的输出
        /// </summary>
        /// <returns>返回数据内容</returns>
        public override string ToString()
        {
            return "姓名：" + Name + "\t颜色：" + Color;
        }
    }
}
