using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATMMessages
    {
        public static void InvalidAccountNo()
        {
            Console.WriteLine("Invalid Account Number...!");
        }
        public static void InvalidPin()
        {
            Console.WriteLine("Invalid Pin..!");
        }
        public static void InsufficientBalance()
        {
            Console.WriteLine("Insufficient Balance..!");
        }
        public static void CreateAccountMessage()
        {
            Console.WriteLine("Welcome To River Bank");
            Console.WriteLine("TO CREATE ACCOUNT PLEASE ENTER THE DETAILS AS PROMPTED");
        }
        public static void AccountNumberExists()
        {
            Console.WriteLine("Already exists enter another number");
            Console.WriteLine("Enter new number or 007 to exit");
        }
        public static void AccountGenerationFailed()
        {
            Console.WriteLine("Couldn't Create Account");
        }
    }
}
