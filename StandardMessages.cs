using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to River Bank");
            Console.WriteLine("Menu");
            Console.WriteLine("1.Create Account");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Show Transaction History");
            Console.Write("Please enter your selections: ");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }
        public static void InvalidSelection()
        {
            Console.WriteLine("Invalid selection!");
            StandardMessages.EndApplication();
        }
    }
}
