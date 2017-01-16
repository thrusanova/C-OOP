using System;

namespace BasicMaths
{

    public class MathUtil
    {
        public static void CalculateSum(double a,double b)
        {
            double sum = a + b;
            Console.WriteLine($"{sum:F2}");
        }
        public static void CalculateSubstact(double a, double b)
        {
            double sum = a - b;
            Console.WriteLine($"{sum:F2}");
           
        }
        public static void CalculateMultiply(double a, double b)
        {
            double sum = a * b;
            Console.WriteLine($"{sum:F2}");
        }
        public static void CalculateSuDevider(double a, double b)
        {
            double sum = a / b;
            Console.WriteLine($"{sum:F2}");
        }
        public static void CalculatePersentage(double a, double b)
        {
            double sum = (b / 100) * a;
            Console.WriteLine($"{sum:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var expr = new MathUtil();
            while (line != "End")
            {
                string[] input = line.Split(' ');
                string command = input[0];
                double a = double.Parse(input[1]);
                double b = double.Parse(input[2]);
                switch (command)
                {
                    case "Sum":MathUtil.CalculateSum(a, b);break;
                    case "Subtract": MathUtil.CalculateSubstact(a, b); break;
                    case "Divide": MathUtil.CalculateSuDevider(a, b); break;
                    case "Percentage": MathUtil.CalculatePersentage(a, b); break;
                    case "Multiply": MathUtil.CalculateMultiply(a, b); break;

                }
                line = Console.ReadLine();
            }
        }
    }
}
