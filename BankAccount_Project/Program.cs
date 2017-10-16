using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Checking checking1 = new Checking();
            Savings savings1 = new Savings();
            int newTransaction = 1;
            int selection = 1;
            do
            {




                Console.WriteLine("1. Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdrawal Funds");
                Console.WriteLine("5. Exit");

                

                selection = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (selection == 1)
                {
                    Client client1 = new Client();
                    Console.WriteLine(client1.GetInfo());
                }

                else if (selection == 2)
                {
                    Console.WriteLine("a. Checking Account Balance");
                    Console.WriteLine("b. Savings Account Balance");
                    char option = char.Parse(Console.ReadLine());
                    if (option == 'a')
                    {

                        checking1.Balance();
                        Console.WriteLine();
                    }
                    else if (option == 'b')
                    {
                        Savings saving1 = new Savings();
                        saving1.Balance();
                        Console.WriteLine();
                    }
                }
                else if (selection == 3)
                {
                    Console.WriteLine("a. To Checking Account");
                    Console.WriteLine("b. To Savings Account");
                    char option = char.Parse(Console.ReadLine());
                    if (option == 'a')
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        double depositAmt = double.Parse(Console.ReadLine());
                        checking1.Deposit(depositAmt);
                        checking1.Balance();
                        Console.WriteLine();
                    }
                    else if (option == 'b')
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        double depositAmt = double.Parse(Console.ReadLine());
                        savings1.Deposit(depositAmt);
                        savings1.Balance();
                        Console.WriteLine();
                    }
                }
                else if (selection == 4)
                {
                    Console.WriteLine("a. From Checking Account");
                    Console.WriteLine("b. From Savings Account");
                    char option = char.Parse(Console.ReadLine());
                    if (option == 'a')
                    {
                        Console.WriteLine("How much would you like to withdrawal?");
                        double withdrawalAmt = double.Parse(Console.ReadLine());
                        checking1.Withdrawal(withdrawalAmt);
                        checking1.Balance();
                        Console.WriteLine();
                    }
                    else if (option == 'b')
                    {
                        Console.WriteLine("How much would you like to withdrawal?");
                        double withdrawalAmt = double.Parse(Console.ReadLine());
                        savings1.Withdrawal(withdrawalAmt);
                        savings1.Balance();
                        Console.WriteLine();
                    }
                }
                else if (selection == 5)
                {
                    Console.WriteLine("Thank you for your services.");
                }
            }
            while (selection < 5);
            


        }
    }
}
