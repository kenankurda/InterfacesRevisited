using Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Models
{
    public class JuniorAccount : IAccount, ISayHeelo
    {
        private decimal balance = 0;
        public void Deposit(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine($"You depositetd {amount}");
        }

        public decimal GetBalance()
        {
            Console.WriteLine($"Your balance is {balance}");
            return balance;
        }

        public bool GetMoney(decimal amount)
        {
            if (amount > 10)
            {
                Console.WriteLine("You are not aalowed to get more than 10 euro's");
                return false;
            }
            if (balance < amount)
            {

                Console.WriteLine($"your balance is smaller than {amount}");
                return false;
            }
            Console.WriteLine($"you asked {amount} ");
            balance = balance - amount;
            return true;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello I am too young");
        }
    }
}
