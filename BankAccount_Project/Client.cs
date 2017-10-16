﻿using System;
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
        protected string userName;
        protected int pinNumber;


        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public int PinNumber
        {
            get { return this.pinNumber; }
            set { this.pinNumber = value; }
        }

        //constructors

        

        public Client()
        {
            this.name = "David Gomez";
            this.userName = "DGomez27";
            this.pinNumber = 723443;
        }

        public virtual string GetInfo()
        {
            return name + " " + userName + " " + pinNumber;
        }



    }
}
