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
            ATMMessages.CreateAccountMessage();
            string name=ATMPrompts.GetName();
            int accountNo = ATMValidators.GenreateAccountNumber(AccountsList);
            if (accountNo ==-1)
            {
                ATMMessages.AccountGenerationFailed();
                return;
            }
            int pin = ATMPrompts.GetPinNo();
            Account acc = new Account(accountNo, pin, name);
            AccountsList.Add(acc.accountNo, acc);
        }

        public void Deposit()
        {
            int accountNo = ATMPrompts.GetAccountNo();

            if (AccountsList.ContainsKey(accountNo))
            {
                int pinNo = ATMPrompts.GetPinNo();
                if (!ATMValidators.ValidateUser(AccountsList, accountNo, pinNo))
                {
                    return;
                }

                ATMTransactions.Deposit(AccountsList, accountNo);
            }
            else
            {
                ATMMessages.InvalidAccountNo();
            }
        }

        public void Withdraw()
        {
            int accountNo = ATMPrompts.GetAccountNo();

            if (AccountsList.ContainsKey(accountNo))
            {
                int pinNo = ATMPrompts.GetPinNo();
                if (!ATMValidators.ValidateUser(AccountsList, accountNo, pinNo))
                {
                    return;
                }
                ATMTransactions.Withdraw(AccountsList, accountNo);
            }
            else
            {
                ATMMessages.InvalidAccountNo();
            }
        }

        public void GetTransactions()
        {
            int accountNo = ATMPrompts.GetAccountNo();

            if (AccountsList.ContainsKey(accountNo))
            {
                int pinNo = ATMPrompts.GetPinNo();
                if (!ATMValidators.ValidateUser(AccountsList, accountNo, pinNo))
                {
                    return;
                }
                Console.WriteLine("Transaction History:");
                foreach (var transaction in AccountsList[accountNo].transactions)
                {
                    Console.WriteLine(transaction);
                }
            }
            else
            {
                ATMMessages.InvalidAccountNo();
            }
        }
    }
}
