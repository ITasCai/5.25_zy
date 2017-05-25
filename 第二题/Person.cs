using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{

    /// <summary>
    /// 一个抽象的人类
    /// </summary>
    abstract  class Person
    {

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { set; get; }


        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { set; get; }

        public Person()
        {
        }

        /// <summary>
        /// 抽象的人类的一个有参数的构造方法，用于对数据的初始化
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Age">年龄</param>
        /// <param name="Sex">性别</param>
        public Person(string Name,int Age,string Sex) {
            this.Name = Name;
            this.Age = Age;
            this.Sex = Sex;
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
            return "姓名：" + Name + "\t年龄：" + Age+"\t性别"+Sex;
        }

    }
}
