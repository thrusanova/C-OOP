using System;

namespace TemperatureConverter
{
    public class Program
    {
       public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] input = line.Split(' ');
                int number = int.Parse(input[0]);
                string temp = input[1];
                if (temp == "Celsius")
                {
                    double farenheit = ConverToFarenhait(number);
                    Console.WriteLine($"{farenheit:F2} Fahrenheit");
                }
                else
                {
                    double celsius = ConvertToCelsius(number);
                    Console.WriteLine($"{celsius:F2} Celsius");
                }
                line = Console.ReadLine();
            }
        }

        private static double ConvertToCelsius(int number)
        {
           
            return (number - 32) * (double)5 / 9;
        }

        private static double ConverToFarenhait(int number)
        {
            return number * (double)9 / 5 + 32;
        }
    }
}
