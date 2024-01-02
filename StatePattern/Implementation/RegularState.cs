using StatePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementation
{
    public class RegularState : BankAccountState
    {
        public RegularState( decimal balance, BankAccount bankAccount) 
        { 
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"IN {GetType()}, Depositing {amount}");
            Balance += amount;
            if (Balance > 1000)
            {
                // Change state to Gold 
                BankAccount.BankAccountState = new GoldState(Balance, BankAccount);
            }
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"IN: {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;
            if (Balance < 0)
            {
                BankAccount.BankAccountState =  new  OverDrawnState(Balance,BankAccount);
            }
        }
    }
}
