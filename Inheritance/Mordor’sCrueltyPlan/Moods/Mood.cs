using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordor_sCrueltyPlan.Moods
{
   public abstract class Mood
    {
        private string mood;

        public Mood(string mood)
        {
            this.mood = mood;
        }
        public override string ToString()
        {
            return this.mood;
        }
    }
}
