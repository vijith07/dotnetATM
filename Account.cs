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
            Console
                .WriteLine("Account Created with Acc No:" +
                accountNo +
                " Name: " +
                name +
                " Balance: " +
                this.balance);
        }

        public int GetPin()
        {
            return this.pin;
        }

        public int GetAccountNo()
        {
            return this.accountNo;
        }

        public double GetBalanne()
        {
            return this.balance;
        }
    }
}
