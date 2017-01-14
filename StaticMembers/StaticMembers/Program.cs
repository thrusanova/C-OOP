using System;

namespace StaticMembers
{
    public class Student
    {
        public string name;
        public static int counter=0;

        public Student(string name)
        {
            this.name = name;
            counter++;
        }
    }
  public  class Program
    {
     public static void Main()
        {
            string name = Console.ReadLine();
            while (name!="End")
            {
                var student = new Student(name);
                name = Console.ReadLine();
            }
            Console.WriteLine(Student.counter);
        }
    }
}
