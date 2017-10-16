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


        public Checking()
        {
            this.checkingStart = 5000.00;
        }
            
            

        public override void Balance()
        {
            base.Balance(); Console.WriteLine("$" + (viewBalance + checkingStart));
        }



    }
}
