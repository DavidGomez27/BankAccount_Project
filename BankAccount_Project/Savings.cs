using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Project
{
    class Savings: Accounts
    {

        public double savingsStart;

        public double SavingsStart
        {
            get { return this.savingsStart; }
            set { this.savingsStart = value; }
        }


        public Savings()
        {
            this.savingsStart = 8000.00;
        }


        public override void Balance()
        {
            base.Balance(); Console.WriteLine("$" + (viewBalance + savingsStart));
        }










    }
}
