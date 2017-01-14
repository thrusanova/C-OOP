using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pizza
{
    public class Piza
    {
        private int group;
        private string name;

        public Piza(string name,int group)
        {
            this.name = name;
            this.group = group;
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Group
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var dict = new SortedDictionary<int, List<string>>();
            string pattern = @"(\d+)(\w+)";
            Regex regex = new Regex(pattern);
            foreach (var item in input)
            {
                MatchCollection matches = regex.Matches(item);
                foreach (Match m in matches)
                {
                    int gr = int.Parse(m.Groups[1].Value);
                    var name = m.Groups[2].Value;
                    var pizza = new Piza(name, gr);
                    if (!dict.ContainsKey(gr))
                    {
                        dict.Add(gr, new List<string>());
                        dict[gr].Add(name);
                    }
                    else
                    {
                        dict[gr].Add(name);
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.Write($"{item.Key} - ");
                Console.WriteLine(String.Join(", ",item.Value));
                
            }
           
        }
    }
}
