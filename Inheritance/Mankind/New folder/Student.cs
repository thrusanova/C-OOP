using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
   public class Student:Human
    {
        private string facultyNumber;

        public Student(string firstName,string lastName,string facultyNumber) : base(firstName, lastName)
        {
           
                this.FacultyNumber = facultyNumber;
        
        }

        public override string FirstNamme
        {
            get
            {
                return base.FirstNamme;
            }

            set
            {
                if (value.Length<4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                base.FirstNamme = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
      set
            {
                if (value.Length<5 || value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetterOrDigit(value[i]))
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstNamme}");
            sb.AppendLine($"Last Name: {this.LastNamme}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");
            return sb.ToString();
        }
    }
}
