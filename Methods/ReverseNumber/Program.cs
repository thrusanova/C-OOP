using System;
using System.Text;

namespace ReverseNumber
{

    public class DecimalNumber
    {
        public decimal number;

        public DecimalNumber(decimal num)
        {
            this.number = num;
        }
        public string ReversedNum(decimal number)
        {
            string str = number.ToString();
            var sb = new StringBuilder(str);
            var res = new StringBuilder();
            for (int i = sb.Length-1; i >=0 ; i--)
            {
                res.Append(sb[i]);
            }
            return res.ToString(); ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            var number = new DecimalNumber(num);
           var result = number.ReversedNum(num);
            Console.WriteLine(result);
        }
    }
}
