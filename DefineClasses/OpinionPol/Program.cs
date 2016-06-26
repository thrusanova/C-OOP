using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPol
{

    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age) : this()
        {
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                list.Add(person);
            }
            var result = list.Where(p => p.age > 30).OrderBy(p => p.name).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.name} - {item.age}");
            }
        }
    }
}
