using Accounts.Interfaces;
using Accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new Account();
            account.Deposit(200);
            account.GetMoney(50);
            account.GetBalance();

            //********************************
            Console.WriteLine("--------------------------------");
            IAccount juniorAccount = new JuniorAccount();
            juniorAccount.Deposit(500);
            juniorAccount.GetMoney(10);
            juniorAccount.GetBalance();


            IAccount juniorAccount1 = new JuniorAccount();
            juniorAccount1.Deposit(500);
            juniorAccount1.GetMoney(10);
            juniorAccount1.GetBalance();

            //IAccount[] accounts = new IAccount[] { account, juniorAccount };


            List<IAccount> accounts = new List<IAccount>();
            accounts.Add(account);
            accounts.Add(juniorAccount);
            accounts.Add(juniorAccount1);

            int count = 0;
            foreach (var item in accounts)
            {
                
                if (item is Account ja)
                {
                    count++;
                }
                
            }
            Console.WriteLine($"there are {count} Account accounts in the list");

        }
    }
}
