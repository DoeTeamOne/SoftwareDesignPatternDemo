using StatePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementation
{
    public class OverDrawnState: BankAccountState
    {
        public OverDrawnState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"IN {GetType()}, Depositing {amount}");
            Balance += amount;
            if (Balance >= 0)
            {
                // change State to Regular
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"IN: {GetType()}, Cannot Withdraw Balance  {Balance}");
           
        }
    }
}
