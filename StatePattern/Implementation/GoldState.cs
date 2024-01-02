using StatePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementation
{
    public class GoldState : BankAccountState
    {
        public GoldState(decimal banalce, BankAccount bankaccount) 
        {
            Balance = banalce;
            BankAccount = bankaccount;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, Depositing  {amount} 10 % bonus {amount / 10}");
            Balance += amount + (amount/10);
            
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing  {amount} from {Balance}");
            Balance -= amount;
            if(Balance < 1000  && Balance >= 0)
            {
                //Change State to Regular
                BankAccount.BankAccountState = new RegularState(Balance,BankAccount);
            }
            else if(Balance < 0)
            { // Change State  to Overdrawen State
                BankAccount.BankAccountState = new OverDrawnState(Balance,BankAccount);
            }
           
        }
    }
}
