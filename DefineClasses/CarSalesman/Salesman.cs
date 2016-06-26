using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{

    class Salesman
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var engList = new List<Engine>();
            for (int i = 0; i < N; i++)
            {
                string [] engine=Console.ReadLine().Split(new[] { ' ', '\t', '\n' } ,StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engine[0];
                int enginePower = int.Parse(engine[1]);
                string engineDisplacement = "n/a";
                string engineEfficiency = "n/a";


                if (engine.Length ==3 && Char.IsDigit(engine[2][0]))
                {
                     engineDisplacement = engine[2];
                }
               else if (engine.Length == 3 && Char.IsLetter(engine[2][0]))
                {
                     engineEfficiency = engine[2];
                }
                else if (engine.Length == 4)
                {
                     engineDisplacement = engine[2];
                     engineEfficiency = engine[3];
                }
                var newEngine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
                engList.Add(newEngine);
            }
            int M = int.Parse(Console.ReadLine());
            var carList = new List<Car>();
            for (int i = 0; i < M; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engine = input[1];
                string weight = "n/a";
                string color = "n/a";

                if (input.Length == 3 && Char.IsDigit(input[2][0]))
                {
                    weight = input[2];
                }
                else if (input.Length == 3 && Char.IsLetter(input[2][0]))
                {
                    color = input[2];
                }
                else if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }
                foreach (var eng in engList)
                {
                    if (eng.Model == engine)
                    {
                        var newCar = new Car(model, eng, weight, color);
                        carList.Add(newCar);
                        break;
                    }
                }
               
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
        }
    }
}
