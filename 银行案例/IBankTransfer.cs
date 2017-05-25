using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行案例
{
    interface IBankTransfer:IBankAccount
    {
        /// <summary>
        /// 转账
        /// </summary>
        /// <returns></returns>
        bool TransferAccount(IBankAccount bankAccount,decimal amount);
    }
}
