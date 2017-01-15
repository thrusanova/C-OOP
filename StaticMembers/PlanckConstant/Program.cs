using System;

namespace PlanckConstant
{
    public class Calculation
    {
        private static  double  PLANK = 6.62606896e-34;
        private static  double PI = 3.14159;

        public static double GetResult()
        {
            return PLANK / (2 * PI);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.GetResult());
        }
    }
}
