using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Project
{
    class Client
    {

        //fields
        protected string name;
        protected string checkingActNum;
        protected string savingsActNum;


        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string CheckingActNum
        {
            get { return this.checkingActNum; }
            set { this.checkingActNum = value; }
        }

        public string SavingsActNum
        {
            get { return this.savingsActNum; }
            set { this.savingsActNum = value; }
        }

        //constructors

        

        public Client()
        {
            this.name = "David Gomez";
            this.checkingActNum = "Checking Acct# 567890";
            this.savingsActNum = "Savings Acct# 836849";
        }

        //Method  to call client info
        public virtual string GetInfo()
        {
            return name + " " + checkingActNum + " " + savingsActNum;
        }



    }
}
