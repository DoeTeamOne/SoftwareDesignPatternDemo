using StatePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementation
{
    /// <summary>
    /// Context CLass
    /// </summary>
    public class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }
        public decimal Balance { get { return BankAccountState.Balance; } }
        public BankAccount() 
        {
            BankAccountState = new RegularState(200,this);
        }
        public void Deposit(decimal amount)
        {
            BankAccountState.Deposit(amount);
        }
        public void WithDraw(decimal amount)
        {
            BankAccountState.WithDraw(amount);
        }
    }
}
