using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueStudentNames
{

    public class Student
    {
        public string name;


        public Student(string name)
        {
            this.name = name;
            StudentGroup.groupStudents.Add(this.name);
           
        }
    }

    public class StudentGroup
    {
        public static HashSet<String> groupStudents = new HashSet<string>(); 
    }

        public class Program
        {
            static void Main(string[] args)
            {
                string name = Console.ReadLine();
                while (name != "End")
                {
                    var student = new Student(name);
                name = Console.ReadLine();
                }
                Console.WriteLine(StudentGroup.groupStudents.Count());
            }
        }

    }
    