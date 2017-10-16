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
            Console.WriteLine("1. Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdrawal Funds");
            Console.WriteLine("5. Exit");

            int selection = 1;

            selection = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (selection == 1)
            {
                Client client1 = new Client();
                Console.WriteLine(client1.GetInfo());
            }

            else if (selection == 2)
            {
                Console.WriteLine("a. Checking Account");
                Console.WriteLine("b. Savings Account");
            }
            

                

            


        }
    }
}
