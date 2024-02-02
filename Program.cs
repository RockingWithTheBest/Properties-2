using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_2
{
    internal class BankAccount
    {
        private string owner;
        private decimal[] contributions;
        private int nextContributions;

        public BankAccount( string owner, decimal balance)
        {
            this.owner = owner;
            contributions = new decimal[100];
            contributions[0] = balance;
            nextContributions= 1;
        }

        public decimal Balance
        {
            get { decimal result = 0;
            foreach(decimal ctr  in contributions)
                
                    result += ctr;
                    return result;
                
            }
        }
        public void Deposit(Decimal amount)
        {
            contributions[nextContributions] = amount;
            nextContributions++;
        }
        public void Withdraw(Decimal amount)
        {
            contributions[nextContributions] = -amount;
            nextContributions++;
        }
        public override string ToString()
        {
            return owner + "'s account holds " +
            +Balance + " kroner";
        }
        
    }
    class Boy
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Peter", 1000);
            Console.WriteLine(ba);
            ba.Deposit(100);
            Console.WriteLine("Balance: {0}", ba.Balance);

            ba.Withdraw(300);
            Console.WriteLine("Balance: {0}", ba.Balance);
            ba.Deposit(100);
            Console.WriteLine("Balance: {0}", ba.Balance);
        }
    }
}
