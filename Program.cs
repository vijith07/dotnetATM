using System;
using System.Collections;
using System.Collections.Generic;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Show Transaction History");
                Console.Write("Please enter your selections: ");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        atm.CreateAccount();
                        break;
                    case 2:
                        atm.Deposit();
                        break;
                    case 3:
                        atm.Withdraw();
                        break;
                    case 4:
                        atm.GetTransactions();
                        break;
                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                }
            }
        }
    }
}
