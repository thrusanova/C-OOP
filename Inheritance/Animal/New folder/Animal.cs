using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public class Animal:IGetSound
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
           set
            {
                if (string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }
        public virtual string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || (value.ToLower()!="female" && value.ToLower()!="male"))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
            }

        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public virtual string produceSound()
        {
            return "Not implemented!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} {this.Name} {this.Age} {this.Gender} ");
            sb.Append($"{this.produceSound()}");



            return sb.ToString();
        }
    }
}
