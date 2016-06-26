using System;
using System.Collections.Generic;
using System.Text;

namespace FibonachiNumbers
{
    public class Fibonacci
    {
        public List<long> fibs;

        public Fibonacci()
        {
        }
        public Fibonacci(List<long> fibs)
        {
            this.fibs = new List<long>();
        }
        public List<long> FibNumbers(int start,int end)
        {
            var list = new List<long>();
            list.Add(0);
            list.Add(1);
            long first = 0;
            long second = 1;
            
            for (int i = 2; i <= end; i++)
            {
                long next = first + second;
                list.Add(next);
                first = second;
                second = next;
            }
            var sb = new List<long>();
            for (int  i = start; i <= end-1; i++)  
            {
                sb.Add(list[i]);
            }
            return sb;
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            var fib = new Fibonacci();
            var res = fib.FibNumbers(start, end);
            Console.WriteLine(string.Join(", ",res));
            }
        }

    }

