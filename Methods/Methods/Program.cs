using System;
using System.Reflection;

namespace Methods
{
    public class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Greeteng()
        {
            Console.WriteLine($"{this.name} says \"Hello\"!" );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Length != 1 || methods.Length != 5)
            {
                throw new Exception();
            }

            string name = Console.ReadLine();
            var person = new Person(name);
            person.Greeteng();
        }
    }
}
