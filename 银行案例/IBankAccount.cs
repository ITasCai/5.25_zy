using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行案例
{
    interface IBankAccount
    {
          /// <summary>
          /// 存款
          /// </summary>
          /// <param name="amount">金额</param>
        void Play(decimal amount);
        /// <summary>
        /// 取款
        /// </summary>
        /// <returns>返回取款成功</returns>
        bool PayOut(decimal amount);

        /// <summary>
        /// 余额
        /// </summary>
        decimal Balance {
            get;
        }

        string OpendAccount();
    }
}
