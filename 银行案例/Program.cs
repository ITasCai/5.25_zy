using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行案例
{
    class Program
    {
        static void Main(string[] args)
        {

            IBankAccount ba = new SaverAccoun("狗蛋");

            ba.Play(100);//存款
            ba.PayOut(300);//取款
            Console.WriteLine(ba.ToString());

            Console.WriteLine("----------------------");
            Console.ReadKey();

            IBankAccount ga = new GoldAccount("李四");
            ga.Play(10000);
            ga.PayOut(500);
            Console.WriteLine(ga.ToString());

            Console.ReadKey();

            #region 银行转账

            //IBankTransfer bt = new GoldAccount("李四");

            

            #endregion

        }
    }
}
