using System;

namespace DateTimer
{
    public class DateModifier
    {
        public void totalDays(DateTime d1,DateTime d2)
        {
            TimeSpan difference = d2.Subtract(d1);
            Console.WriteLine(difference.TotalDays);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            DateTime d1= Convert.ToDateTime(firstDate);
            string secondDate = Console.ReadLine();
            DateTime d2 = Convert.ToDateTime(secondDate);

            var date = new DateModifier();
            date.totalDays(d1, d2);
        }
    }
}
