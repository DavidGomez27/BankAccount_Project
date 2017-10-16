using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Project
{
    class Checking: Accounts
    {

        public double checkingStart;

        public double CheckingStart
        {
            get { return this.checkingStart; }
            set { this.checkingStart = value; }
        }

        //My set starting balance
        public Checking()
        {
            this.checkingStart = 5000.00;
        }
            
            
        //So that in the output itll add the set balance i made(5000) and add it to ammount deposited or withdrawn.
        public override void Balance()
        {
            base.Balance(); Console.WriteLine("New Checking Balance is $" + (viewBalance + checkingStart));
        }



    }
}
