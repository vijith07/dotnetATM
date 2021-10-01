using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATMTransactions
    {
        public static void Deposit(Dictionary<int, Account> AccountsList, int accountNo)
        {
            double amount = ATMPrompts.DepositPrompt();
            AccountsList[accountNo].balance += amount;
            double balance = AccountsList[accountNo].balance;
            string transaction = ATMTransactions.GenerateCreditString(amount, balance);
            AccountsList[accountNo].transactions.Add(transaction);
            ShowBalance(balance);
        }
        public static void Withdraw(Dictionary<int, Account> AccountsList, int accountNo)
        {
            double amount = ATMPrompts.WithdrawPrompt();
            
            if (amount > AccountsList[accountNo].balance)
            {
                ATMMessages.InsufficientBalance();
                return;
            }
            AccountsList[accountNo].balance -= amount;
            double balance = AccountsList[accountNo].balance;
            string transaction = ATMTransactions.GenerateDebitString(amount, balance);
            AccountsList[accountNo].transactions.Add(transaction);
            ShowBalance(balance);
        }
        public static string GenerateDebitString(double amount ,double balance)
        {
            string transaction = "Debit -";
            transaction += amount.ToString();
            transaction += "  Balance:";
            transaction += balance.ToString();
            return transaction;
        }
        public static string GenerateCreditString(double amount, double balance)
        {
            string transaction = "Credit +";
            transaction += amount.ToString();
            transaction += "  Balance:";
            transaction += balance.ToString();
            return transaction;
        }
        public static void ShowBalance(double balance)
        {
            Console.WriteLine("Tranaction Successful Avaliable Balance: " + balance.ToString() + " /-");
        }
    }

}
