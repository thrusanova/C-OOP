using System;

namespace BeerCounter
{
    public class BeerCounter
    {
        public static int beerInStock;
        public static int beerDrankCount;

        public void AddBeer(int beers)
        {
            beerInStock += beers;
        }

        public void RemoveBeer(int beers)
        {
            beerDrankCount += beers;
            beerInStock -= beers;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] input = line.Split(' ');
                int beerIn = int.Parse(input[0]);
                int beerOut = int.Parse(input[1]);
                var beeCounter = new BeerCounter();
                beeCounter.AddBeer(beerIn);
                beeCounter.RemoveBeer(beerOut);
                line = Console.ReadLine();
            }
            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beerDrankCount}");
        }
    }
}