using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosSelados.Entities
{
    // não vai funcionar o extends se SavingsAccount possuir 'sealed'
    internal class SavingsAccountPlus : SavingsAccount
    {


        // Não vai funcionar pois SavingsAccount aplica 'sealed' no método Withdraw
        /*
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 3;
        }
        */
    }
}
