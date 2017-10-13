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
        protected float viewBalance;
        protected string accountType;
        protected float depositAmmount;
        protected float withdrawalAmmount;


        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public float ViewBalance
        {
            get { return this.viewBalance; }
            set { this.viewBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public float DepositAmmount
        {
            get { return this.depositAmmount; }
            set { this.depositAmmount = value; }
        }

        public float WithdrawalAmmount
        {
            get { return this.withdrawalAmmount; }
            set { this.withdrawalAmmount = value; }
        }
    }
}
