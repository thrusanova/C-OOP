using SampleExam;
using SExam.Homes;
using SExam.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SExam
{
    public class Families
    {
        static void Main(string[] args)
        {
            City city = new City();
            string pattern = @"[\d.]+";
            Regex regex = new Regex(pattern);
            //Matcher matcher;
            string line = Console.ReadLine();
            int counter = 0;
            HomeFactory factory = new HomeFactory();
            
            while (line != "Democracy")
            {
                counter++;
                if (line == "EVN")
                {
                    Console.WriteLine($"Total consumption: {city.getConsumption()}");
                    if (counter % 3 == 0)
                    {
                        city.receiveSalary();
                    }
                  
                    line = Console.ReadLine();
                    continue;
                }
                else if (line == "EVN bill")
                {
                    if (counter % 3 == 0)
                    {
                        city.receiveSalary();
                    }
                    city.payBills();
                    line = Console.ReadLine();
                    continue;
                }
                string homeType = line.Substring(0, line.IndexOf("("));
                string homeArgsLine = "";
                if (line.IndexOf(" Child") == -1)
                {
                    homeArgsLine = line;
                }
                else
                {

                    homeArgsLine = line.Substring(0, line.IndexOf(" Child"));
                }

                MatchCollection match = regex.Matches(homeArgsLine);
                List<String> homeArguments = new List<string>();
                foreach (Match m in match)
                {

                    homeArguments.Add(m.Groups[0].Value);
                }

                List<Child> currentChildrenList = new List<Child>();
                if (line.Contains("Child"))
                {
                    string[] separatingChars = { " Child" };

                    string childArgsLine = line.Substring(line.IndexOf(" Child"), line.Length- line.IndexOf(" Child"));
                    string[] childrenInfo = childArgsLine.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < childrenInfo.Length; i++)
                    {

                        List<decimal> childArgs = new List<decimal>();
                        if (childrenInfo[i].Length > 0)
                        {
                            match = regex.Matches(childrenInfo[i]);
                        
                       foreach(Match m in match)
                            {

                                childArgs.Add(decimal.Parse(m.Groups[0].Value));
                            }
                            Child child = new Child(childArgs[0]);
                            for (int j = 1; j < childArgs.Count; j++)
                            {

                                Toy toy = new Toy(childArgs[j]);
                                child.addToys(toy);
                            }
                            currentChildrenList.Add(child);
                        }
                    }
                }

                Home home = factory.createHome(homeType, homeArguments, currentChildrenList);
               
                home.calcSalaries();
                home.totalBills();
                city.addHome(home);
                if (counter % 3 == 0)
                {

                    city.receiveSalary();
                }
                line = Console.ReadLine();

            }
         
            Console.WriteLine($"Total population: {city.getPopulation()}");
        }
    }

}