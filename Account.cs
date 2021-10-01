using System;
using System.Collections;
using System.Collections.Generic;

namespace ATM
{
    class Account
    {
        public string name;

        public double balance;

        public int accountNo;

        public int pin;

        public ArrayList transactions;

        public Account(int accountNo, int pin, string name)
        {
            this.accountNo = accountNo;
            this.pin = pin;
            this.name = name;
            this.balance = 100;
            this.transactions = new ArrayList();
            AccountMessages.CreateMessage(accountNo,name,this.balance);
        }

        public int GetPin()
        {
            return pin;
        }

        public int GetAccountNo()
        {
            return accountNo;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
