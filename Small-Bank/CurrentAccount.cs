using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Bank
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string clientname, double balance) : base(clientname, balance)
        {
        }
        public override double CalculateInterest() {
          return Balance-50;
        }

        public override string ToString()
        {
            return $"AccountNo[{Id}]||ClientName:[{ClientName}] || Amount:[{CalculateInterest()}]"
            ;
        }
    }
}
