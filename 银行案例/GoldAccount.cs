using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行案例
{
    class GoldAccount : IBankTransfer
    {
        private string AccountName { set; get; }

        public string AccountNo { get; set; }

        public GoldAccount(string accountName)
        {
            this.AccountName = accountName;
            this.AccountNo = OpendAccount();

            Console.WriteLine("账户名称:" + accountName + "\n卡号:" + AccountNo);
        }
        private decimal balance;


        public GoldAccount()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Balance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool PayOut(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(AccountName + "取款成功：" + amount);
                return true;
            }
            Console.WriteLine("取款失败");
            return false;
        }


        public bool PayTransfer(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("转账成功");
                return true;
            }
            Console.WriteLine("转账失败");
            return false;
        }

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount"></param>
        public void Play(decimal amount)
        {
            balance = balance + amount;
        }


        //public string GetBankAccoutNo() {

        //}


        /// <summary>
        /// 查看账户余额
        /// </summary>
        /// <returns>返回余额</returns>
        public override string ToString()
        {
            return string.Format("余额：{0:c2}", balance);
        }

        public string OpendAccount()
        {
            string strNO = DateTime.Now.ToString("yyMMddhhmmss");
            return strNO;
        }

        public bool TransferAccount(IBankAccount bankAccount, decimal amount)
        {
            if (PayOut(amount))//判断余额是否充足
            {
                bankAccount.Play(amount);//向转账对象账户存款
                return true;
            }
            return false;
        }
    }
}
