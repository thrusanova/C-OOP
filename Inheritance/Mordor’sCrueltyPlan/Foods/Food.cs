namespace MordorsCrueltyPlan.Foods
{
   public  class Food
    {
        private int points;
        public Food(int points)
        {
            this.points = points;
        }
        public int GetHappiness()
        {
            return this.points;
        }
    }
}
