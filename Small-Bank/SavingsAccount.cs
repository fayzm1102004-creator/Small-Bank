using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Bank
{
    internal class SavingsAccount : BankAccount
    {

        public SavingsAccount(string clientname, double balance) : base(clientname, balance)
        {
       

        }


        public override double CalculateInterest()
        {

            return Balance + Balance * 0.05;
        }
        public override string ToString()
        {
            return$"AccountNo[{Id}]||ClientName:[{ClientName}] || Amount:[{CalculateInterest()}]";
        }

    }
}
