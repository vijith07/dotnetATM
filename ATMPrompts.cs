using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATMPrompts
    {
        public static int GetAccountNo()
        {
            Console.WriteLine("Enter the account number");
            int accountNo = int.Parse(Console.ReadLine());
            return accountNo;
        }
        public static int GetPinNo()
        {
            Console.WriteLine("Enter your new pin");
            int pin = int.Parse(Console.ReadLine());
            return pin;
        }
        public static string GetName()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            return name;
        }
        public static double DepositPrompt()
        {
            Console.WriteLine("Enter your amount you wish to deposit");
            double amount = Math.Abs(double.Parse(Console.ReadLine()));
            return amount;
        }
        public static double WithdrawPrompt()
        {
            Console.WriteLine("Enter your amount you wish to withdraw");
            double amount = Math.Abs(double.Parse(Console.ReadLine()));
            return amount;
        }
    }
}
