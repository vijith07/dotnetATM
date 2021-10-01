using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class AccountMessages
    {
        public static void CreateMessage(int accountNo,string name,double balance)
        {
            Console
               .WriteLine("Account Successfully Created with Account No: " +
               accountNo +
               " Name: " +
               name +
               " Balance: " +
               balance);
        }
    }
}
