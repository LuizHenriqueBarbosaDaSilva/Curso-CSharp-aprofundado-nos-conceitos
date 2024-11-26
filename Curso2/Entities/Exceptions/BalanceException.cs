using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Exceptions
{
    class BalanceException : ApplicationException
    {
        public BalanceException(string message) : base(message){ }
    }
}
