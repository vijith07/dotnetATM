using System;
using System.Collections;
using System.Collections.Generic;

namespace ATM
{
    class ATM
    {
        public static Dictionary<int, Account> AccountsList;

        static ATM()
        {
            AccountsList = new Dictionary<int, Account>();
        }

        public void CreateAccount()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new account number");
            int accountNo = int.Parse(Console.ReadLine());
            while (AccountsList.ContainsKey(accountNo))
            {
                Console.WriteLine("Already exists enter another number");
                Console.WriteLine("Enter new number or 007 to exit");
                accountNo = int.Parse(Console.ReadLine());
                if (accountNo == 007)
                {
                    Console.WriteLine("Couldn't Create Account");
                    return;
                }
            }
            Console.WriteLine("Enter your new pin");
            int pin = int.Parse(Console.ReadLine());

            Account acc = new Account(accountNo, pin, name);
            AccountsList.Add(acc.accountNo, acc);
        }

        public void Deposit()
        {
            Console.WriteLine("Enter the account number");
            int accountNo = int.Parse(Console.ReadLine());

            if (AccountsList.ContainsKey(accountNo))
            {
                Console.WriteLine("Enter your pin");
                int pinNo = int.Parse(Console.ReadLine());
                if (pinNo != AccountsList[accountNo].pin)
                {
                    Console.WriteLine("Invalid Pin");
                    return;
                }
                Console.WriteLine("Enter your amount you wish to deposit");
                double amount = Math.Abs(double.Parse(Console.ReadLine()));
                AccountsList[accountNo].balance += amount;
                double bal = AccountsList[accountNo].balance;
                string transaction = "🟢 +";
                transaction += amount.ToString();
                transaction += "  Balance:";
                transaction += bal.ToString();
                AccountsList[accountNo].transactions.Add(transaction);
            }
            else
            {
                Console.WriteLine("Invalid account number");
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the account number");
            int accountNo = int.Parse(Console.ReadLine());

            if (AccountsList.ContainsKey(accountNo))
            {
                Console.WriteLine("Enter your pin");
                int pinNo = int.Parse(Console.ReadLine());
                if (pinNo != AccountsList[accountNo].pin)
                {
                    Console.WriteLine("Invalid Pin");
                    return;
                }
                Console.WriteLine("Enter the amount you wish to withdraw");

                double amount = Math.Abs(double.Parse(Console.ReadLine()));
                if (amount > AccountsList[accountNo].balance)
                {
                    Console.WriteLine("Insufficient Balance;");
                    return;
                }
                AccountsList[accountNo].balance -= amount;
                double bal = AccountsList[accountNo].balance;
                string transaction = "🔴 -";
                transaction += amount.ToString();
                transaction += "  Balance:";
                transaction += bal.ToString();
                AccountsList[accountNo].transactions.Add(transaction);
            }
            else
            {
                Console.WriteLine("Invalid account number");
            }
        }

        public void GetTransactions()
        {
            Console.WriteLine("Enter the account number");
            int accountNo = int.Parse(Console.ReadLine());
            if (AccountsList.ContainsKey(accountNo))
            {
                Console.WriteLine("Enter your pin");
                int pinNo = int.Parse(Console.ReadLine());
                if (pinNo != AccountsList[accountNo].pin)
                {
                    Console.WriteLine("Invalid Pin");
                    return;
                }
                Console.WriteLine("Transaction History:");
                foreach (var transaction in AccountsList[accountNo].transactions
                )
                {
                    Console.WriteLine (transaction);
                }
            }
            else
            {
                Console.WriteLine("Invalid account number");
            }
        }
    }
}
