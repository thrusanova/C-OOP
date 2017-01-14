using System;

namespace LastDigit
{
    public class Number
    {
        public int num;

        public Number(int n)
        {
            this.num = n;
        }

        public string FindLastDigit(int number)
        {
          
              int digit =  number % 10;
            string str = "";
            switch (digit)
            {
                case 0: str = "zero"; break;
                case 1: str = "one"; break;
                case 2: str = "two"; break;
                case 3: str = "three"; break;
                case 4: str=  "four"; break;
                case 5: str = "five"; break;
                case 6: str = "six"; break;
                case 7: str = "seven"; break;
                case 8: str = "eight"; break;
                case 9: str = "nine"; break;
            }

            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var num = new Number(number);
            var res=num.FindLastDigit(number);
            Console.WriteLine(res);

        }
    }
}
