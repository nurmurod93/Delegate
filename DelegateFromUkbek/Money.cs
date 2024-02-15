using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFromUkbek
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public Money(decimal amount)
        {
            Amount = amount;
            Currency = "UZB";
        }
        public delegate void MoneyDelegate(Money money);
    }
}
