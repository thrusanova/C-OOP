using Mordor_sCrueltyPlan.Moods;
using MordorsCrueltyPlan;
using MordorsCrueltyPlan.Foods;
using System;
using System.Collections.Generic;

namespace Mordor_sCrueltyPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<Food>();
            var points = 0;
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(FoodFactory.ProduceFood(input[i]));
            }
            foreach (var item in list)
            {
                points += item.GetHappiness();
            }
            Console.WriteLine(points);
            Console.WriteLine(MoodFactory.calcMood(points));
        }
    }
}
