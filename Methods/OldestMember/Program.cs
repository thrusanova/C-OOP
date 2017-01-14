using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldestMember
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Family
    {
        public List<Person> familyMembers;

        public Family(List<Person> members)
        {
            this.familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         

            int num = int.Parse(Console.ReadLine());
            var femily = new Family(new List<Person>());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
             
                femily.AddMember(person);
            }
            var res = femily.familyMembers.OrderByDescending(x => x.age).First();
            Console.WriteLine(res.name+ " " +res.age);
        }
    }
}
