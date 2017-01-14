using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCallories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string line = Console.ReadLine();
                var piza = new Pizza();
                while(line!="END")
                    {

                    string[] input =line.Split(' ');
                    string word = input[0];
                    switch (word)
                    {
                        case "Pizza":
                            string name = input[1];
                            int number = int.Parse(input[2]);
                            piza = new Pizza(name, number);
                            break;
                        case "Dough":
                            string dough = input[1].ToLower();
                            string bakingType = input[2].ToLower();
                            double weight = double.Parse(input[3]);
                            var newDought = new Dough(dough, bakingType, weight);
                           
                            var r = newDought.CalcCalories(newDought);
                            Console.WriteLine(r);
                            piza.Dough = newDought;
                            piza.addDough(newDought);

                            break;
                        case "Topping":
                            string toppingType = input[1];
                            double tweight = double.Parse(input[2]);
                            var newTopping = new Topping(toppingType,tweight);
                            var top=newTopping.CalcCalories(newTopping);
                             piza.addTopping(newTopping);
                            Console.WriteLine(top);
                            break;
                    }
                    line = Console.ReadLine();
                }
              var res=  piza.totalCalories();
                Console.WriteLine($"{piza.Name} - {res:F2} Callories");
               
            }
            catch(Exception ex)
            {
                  Console.WriteLine(ex.Message);
            }
        }
    }
}
