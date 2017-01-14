using System;
using System.Collections.Generic;

namespace RawData
{
    class Program
    { 
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var carLst = new List<Car>();
        
            for (int i = 0; i < number; i++)
            {
                var list = new List<Tire>();
           
                string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //“<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” 
                //Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1
                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Carco cargo = new Carco(cargoWeight, cargoType);
               
                var firstTire = new Tire(int.Parse(input[6]), double.Parse(input[5]));
                var secondTire = new Tire(int.Parse(input[8]), double.Parse(input[7]));
                var thirdTire = new Tire(int.Parse(input[10]), double.Parse(input[9]));
                var fourthTire = new Tire(int.Parse(input[12]), double.Parse(input[11]));
                list.Add(firstTire);
                list.Add(secondTire);
                list.Add(thirdTire);
                list.Add(fourthTire);

                Car car = new Car(model, engine, cargo, list);
                
                carLst.Add(car);
            }
                string word = Console.ReadLine();
                var res = new List<Tire>();
            foreach (var car in carLst)
            {
                switch (word)
                {
                    case "fragile":
                        foreach (var tire in car.Tires)
                        {
                            if (tire.TypePressure < 1)
                            {
                                Console.WriteLine($"{car.Model}");
                                break;
                            }
                            
                        }
                        break;
                    case "flamable":
                        if( car.Engine.Power > 250 && car.Cargo.CsrgoType == "flamable")
                        {
                            Console.WriteLine($"{car.Model}");
                        }
                        break;
                }
             
            }
               

        }
        }
    }

