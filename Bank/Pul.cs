using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public delegate void MoneyOperationDelegate(Pul amount);
    public class Pul
    {
        public decimal Amount
        {
            get; set;
        }
        public string Currency
        {
            get; set;
        } 
        public Pul(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public override string ToString()
        {
            return $" {Amount} {Currency}";
        }
    }

}
