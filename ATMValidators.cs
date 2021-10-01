using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATMValidators
    {
        public static bool ValidateAccountNo(Dictionary<int, Account> AccountsList,int accountNo)
        {
            return AccountsList.ContainsKey(accountNo);
        }
        public static bool ValidateUser(Dictionary<int, Account> AccountsList, int accountNo,int pin)
        {
            if (pin != AccountsList[accountNo].pin)
            {
                ATMMessages.InvalidPin();
                return false;
            }
            return true;
        }
        public static int GenreateAccountNumber(Dictionary<int, Account> AccountsList)
        {
            int accountNo = ATMPrompts.GetAccountNo();
            while (AccountsList.ContainsKey(accountNo))
            {
                ATMMessages.AccountNumberExists();  
                accountNo = int.Parse(Console.ReadLine());
                if (accountNo == 007)
                {
                    return -1;
                }
            }
            return accountNo;
        }
        
    }
}
