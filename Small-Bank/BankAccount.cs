using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Bank
{
    abstract public class BankAccount: IReportable
    {
        private static int _Counter=1000;
        private int _Id;
     String _ClientName;
        private double _Balance;

        public BankAccount(String clientname,double balance)
        {
            _Counter++;
           _Id =_Counter;
            _ClientName = clientname;
            Balance = balance;
        }public int Id { get => _Id; set => _Id = value; }
        public string ClientName { get => _ClientName; set => _ClientName = value; }
        public double Balance {
            get{ return _Balance; } 
            private set {
                if (value < 0)
                {
              throw new ArgumentOutOfRangeException("the Balance must be postive");
                }
     _Balance = value;
            } 
        }


        abstract public double CalculateInterest();


        public void  GetFinancialDetails() {

            Console.WriteLine("") ;
        }

        
    }
}
