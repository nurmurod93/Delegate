using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PulBoshqaruvchi
    {
        private Pul totalBalance;
        public PulBoshqaruvchi(decimal boshlangichBalanse, string currency)
        {
            totalBalance = new Pul(boshlangichBalanse, currency);
        }
        public void Deposit(Pul amount)
        {
            totalBalance.Amount += amount.Amount;
            Console.WriteLine($"Deposited: {amount}");
            DisplayBalance();
        }

        public void Withdraw(Pul amount)
        {
            if(totalBalance.Amount >= amount.Amount)
            {
                totalBalance.Amount -= amount.Amount;
                Console.WriteLine($"Withdraw: {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
            DisplayBalance();
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: {totalBalance}");
        }

     
    }
}
