using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoExcecao.Entities.Exceptions
{
    class WithdrawLimitException : ApplicationException
    {

        public WithdrawLimitException(string message) : base(message) 
        { 
            
        }
    }
}
