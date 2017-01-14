using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            try
            {

                 while (animal != "Beast!")
                {
                    string line = Console.ReadLine();

                    string[] input = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    string name = "";
                    int age = 0;
                    string gender = "";
                    Animal newAnimal = null;
                    if (input.Length == 3)
                    {
                        name = input[0];
                        age = int.Parse(input[1]);
                        gender = input[2];
                    }
                    else if (input.Length == 2)
                    {
                        name = input[0];
                        age = int.Parse(input[1]);
                        if (name=="kitten" || name=="Kitten")
                        {
                            gender = "Female";
                        }
                        else
                        {
                            gender = "Male";
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                    switch (animal.ToLower())
                    {
                        case "animal":
                             newAnimal = new Animal(name, age, gender); break;
                        case "cat":
                             newAnimal = new Cat(name, age, gender); break;
                        case "dog":
                            newAnimal = new Dog(name, age, gender); break;
                        case "frog":
                            newAnimal = new Frog(name, age, gender); break;
                        case "kitten":
                            newAnimal = new Kitten(name, age, gender); break;
                        case "tomcat":
                            newAnimal = new Tomcat(name, age, gender); break;
                    }

                  
                    animal = Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
    }
}
