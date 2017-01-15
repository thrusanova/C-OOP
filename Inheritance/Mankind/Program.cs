using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string fName = studentInfo[0];
            string lName = studentInfo[1];
            string falultyNum = studentInfo[2];
            string[] workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string wfName = workerInfo[0];
            string wlName = workerInfo[1];
            decimal salary = decimal.Parse(workerInfo[2]);
            double hours = double.Parse(workerInfo[3]);
            try
            {
                var student = new Student(fName, lName, falultyNum);
                var worker = new Worker(wfName, wlName, salary, hours);
                Console.WriteLine(student);
                Console.WriteLine(worker);

            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
