using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Bank
{
public  class Loan: IReportable
    {
        private String Name;
        private double Bloan;

        public Loan(string name, double bloan)
        {
            Name1 = name;
            Bloan1 = bloan;
        }

        public string Name1 { get => Name; set => Name = value; }
        public double Bloan1 { get => Bloan; set => Bloan = value; }

        public  void GetFinancialDetails() {

            Console.WriteLine("") ;
        }
        public override string ToString()
        {
            
            return $" ClientName: {Name} | Amount: {Bloan} | Status: Pending";
        }
    }
}
