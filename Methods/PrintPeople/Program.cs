using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintPeople
{

    public class Person
    {
        private string name;
        private int age;
        public string occupation;

        public Person(string name,int age,string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
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
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Occupation
        {
            get
            {
                return this.occupation;
            }
            set
            {
                this.occupation = value;
            }
        }

        public override string ToString()
        {
            return string.Format($"{this.name} - age: {this.age}, occupation: {this.occupation}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] input = line.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);
                string occup = input[2];
                var person = new Person(name, age, occup);
                list.Add(person);
                line = Console.ReadLine();
            }
            var result = list.OrderBy(x => x.Age);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            };
        }
    }
}
