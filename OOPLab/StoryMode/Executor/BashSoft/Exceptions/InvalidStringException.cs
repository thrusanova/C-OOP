using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Exceptions
{
  public  class InvalidStringException:Exception
    {
        public const string NullOrEmptyValue = "The value of the variable CANNOT be null or empty!";

        public InvalidStringException()
        {

        }

        public InvalidStringException(string message):
            base(NullOrEmptyValue)
        {

        }
       
    }
}
