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
                StandardMessages.WelcomeMessage();
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
                        StandardMessages.InvalidSelection();
                       
                        break;
                }
            }
        }
    }
}
