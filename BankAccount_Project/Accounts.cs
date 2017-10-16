using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Project
{
    class Accounts
    {

        protected int accountNumber;
        protected double viewBalance;
        protected string accountType;
        


        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public double ViewBalance
        {
            get { return this.viewBalance; }
            set { this.viewBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

      


        public virtual void Balance()
        {
            
        }

        public virtual double Withdrawal(double withdrawalAmt)
        {
            viewBalance -= withdrawalAmt;
            return viewBalance;
        }

        public virtual double Deposit(double depositAmt)
        {
            viewBalance += depositAmt;
            return viewBalance;
        }
    }
}
