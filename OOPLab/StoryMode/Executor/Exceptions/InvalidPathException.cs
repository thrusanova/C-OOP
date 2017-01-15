using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Exceptions
{
    public class InvalidPathException:Exception
    {
        public const string InvalidPath = "The sourse does not exist.";

        public InvalidPathException() : base(InvalidPath)
        {

        }
        public InvalidPathException(string message)
            : base(message)
        {

        }
    }
}
