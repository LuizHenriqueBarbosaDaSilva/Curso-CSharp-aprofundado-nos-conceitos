using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }


    }
}
