using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordor_sCrueltyPlan.Moods
{
   public class MoodFactory
    {
        public static Mood calcMood(int points)
        {
            if (points<-5)
            {
                return new Angry();
            }
            else if(points<=0)
            {
                return new Sad();
            }
            else if (points <= 15)
            {
                return new Happy();
            }
            else
            {
                return new Javascript();
            }
        }
    }
}
