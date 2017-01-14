using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = Console.ReadLine().Split(';');

                var dict = new Dictionary<string, Product>();
                var pers = new Dictionary<string, Person>();

                foreach (var item in lines)
                {
                    string[] input = item.Split('=');
                    string name = input[0];
                    decimal money = decimal.Parse(input[1]);
                    var person = new Person(name, money);
                    pers.Add(name, person);
                }

                string[] prod = Console.ReadLine().Split(new[] { ';', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in prod)
                {
                    string[] input = item.Split('=');
                    string name = input[0];
                    decimal money = decimal.Parse(input[1]);
                    var product = new Product(name, money);
                    dict.Add(name, product);
                }
                string inp = Console.ReadLine();
                while (inp != "END")
                {
                    string[] str = inp.Split(' ');
                    string name = str[0];
                    string p = str[1];
                    pers[name].addProduct(dict[p]);
                    inp = Console.ReadLine();
                }
                foreach (var item in pers)
                {
                  
                    Console.Write($"{item.Key} - ");
                  
                    var pr = item.Value.Products;
                    if (pr.Count == 0)
                    {
                        Console.WriteLine("Nothing bought");
                    }
                    else
                    {
                        var sb = new StringBuilder();
                        foreach (var p in pr.ToArray())
                        {

                            sb.Append(p.Name);
                            sb.Append(", ");

                        }
                        Console.WriteLine(sb.ToString().Substring(0, sb.Length - 2));
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
