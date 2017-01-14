using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
 public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string first,string last)
        {
            this.FirstNamme = first;
            this.LastNamme = last;
        }

        public virtual string FirstNamme
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter!Argument: firstName");
                }
                this.firstName = value;
            }
        }

        public virtual string LastNamme
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols!Argument: lastName");
                }
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter!Argument: lastName");
                }
                this.lastName = value;
            }
        }

      
    }
}
