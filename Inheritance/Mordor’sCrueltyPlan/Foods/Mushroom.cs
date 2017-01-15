using MordorsCrueltyPlan.Foods;

namespace MordorsCrueltyPlan
{
    public class Mushroom : Food
    {
        private const int POINTS = -10;
        public Mushroom():base(POINTS)
        {
        }
    }
}