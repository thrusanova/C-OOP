using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalName, string animalType, double animalWeight,string region)
            : base(animalName,animalType, animalWeight, region)
        {
        }
    }
}
