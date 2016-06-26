using System;

namespace PrimeChecker
{
    public class Number
    {
        public int number;
        public bool isPrime;

        public Number(int num)
        {
            this.number = num;
           
        }
        public Number(int num,bool isPrime)
        {
            this.number = num;
            this.isPrime = isPrime;
        }

        public void CheckIsPrime(int numer,bool isPr)
        {
             isPr = isPrimeNum(numer);
          var res= findNextPrime(number);

        }
      public  Number findNextPrime(int number)
        {
         var  prime = isPrimeNum(number);
            int tempNumber = number;
            bool isNextPrime = false;
            while (!isNextPrime)
            {
                tempNumber++;
                isNextPrime = this.isPrimeNum(tempNumber);
            }
            return new Number(tempNumber);
        }
        public bool isPrimeNum(int number)
        {
            if (number == 0) return true;
            if (number == 1) return true;
            if (number == 2) return true;

            if (number % 2 == 0 && number!=2) return false; //Even number     
           
            for (int i = 1; i < number; i += 2)
            {
                if (number % i == 0 ) return false;
            }

            return true;

        }
    }
    class Program
    {
        public static bool isPrimeNum(int number)
        {
            if (number == 0) return true;
            if (number == 1) return true;
            if (number == 2) return true;

            if (number % 2 == 0 && number != 2) return false; //Even number     

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
           
            var number = new Number(num);
            bool isP = isPrimeNum(num);

            number.CheckIsPrime(num,isP);

            
var res = number.findNextPrime(num).number;
            Console.WriteLine(res+ ", "+ (isP==true ? "true":"false")); 
        }
    }
   
}
