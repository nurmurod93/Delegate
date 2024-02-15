using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public Money(decimal amount) 
        {
            Amount = amount;
            Currency = "UZS";
        }
        public delegate void MoneyDelegate(Money money);
    }
}
