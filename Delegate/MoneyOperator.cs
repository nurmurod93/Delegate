using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
     public class MoneyOperator
    {
        /// <param name = "money"></param>
        public void Uzs2Usd(Money money)
        {
            money.Currency = "UZS";
            money.Amount /= 12360;
        }
        /// <param name = "money"></param>
        public void Usd2Uzs(Money money)
        {
            money.Currency = "UZS";
            money.Amount *= 12360;
        }
        public void Send(Money money, string bank, Money.MoneyDelegate moneyDelegate)
        {
            if (moneyDelegate.Target != null)
            {
                moneyDelegate.Invoke(money); // => moneyDelegate(money);
            }
            Console.WriteLine(money.Amount.ToString("0.00") + " " + money.Currency + "a sum of money" + "has been successfully transferred to" + bank);
        }
    }
}
