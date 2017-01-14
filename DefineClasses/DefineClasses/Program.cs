using System;
using System.Reflection;

namespace DefineClasses
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

        public Person(int age):this()
        {
           
            this.age=age;
        }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            var person = new Person("Gosho", 18);
            var peshoPerson = new Person("Pesho", 20);
            var stamatPerson = new Person("Stamat", 43);
        }
    }
}
