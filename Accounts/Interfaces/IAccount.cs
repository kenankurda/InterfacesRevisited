using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Interfaces
{
    public interface IAccount
    {
        bool GetMoney(decimal amount);
        void Deposit(decimal amount);
        decimal GetBalance();

    }
}
