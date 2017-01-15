
using MordorsCrueltyPlan.Foods;

namespace MordorsCrueltyPlan
{
   public class FoodFactory
    {
        public static Food ProduceFood(string foodName)
        {
            switch (foodName.ToLower())
            {
                case "cram":return new Cram();
                case "melon":return new Melon();
                case "apple":return new Apple();
                case "honeycake":return new HoneyCake();
                case "lembas":return new Lembas();
                case "mushrooms":return new Mushroom();
                default:return new Junk();
            }
        }
    }
}
