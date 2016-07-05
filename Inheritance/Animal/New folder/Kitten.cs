using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public class Kitten:Cat
    {
      
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = gender;
        }
        public override string Gender => base.Gender = "Female";
        public override string produceSound()
        {
            return "Miau";
        }
    }
}
