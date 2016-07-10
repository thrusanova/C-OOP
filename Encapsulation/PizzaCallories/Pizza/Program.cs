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
                string [] pizza = Console.ReadLine().Split(' ');
                string name = pizza[1];
                int number = int.Parse(pizza[2]);
                var piza = new Pizza(name,number);
                string line = Console.ReadLine();
                while(line!="END")
                    {

                    string[] input =line.Split(' ');
                    string word = input[0];
                    switch (word)
                    {
                        case "Dough":
                            string dough = input[1].ToLower();
                            string bakingType = input[2].ToLower();
                            double weight = double.Parse(input[3]);
                            var newDought = new Dough(dough, bakingType, weight);
                            newDought.CalcCalories(newDought);
                            piza.Dough = newDought;
                            piza.addDough(newDought);
                                
                            break;
                        case "Topping":
                            string toppingType = input[1];
                            double tweight = double.Parse(input[2]);
                            var newTopping = new Topping(toppingType,tweight);
                            newTopping.CalcCalories(newTopping);
                            piza.addTopping(newTopping);
                            
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
