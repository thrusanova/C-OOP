using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ImmutableList
{

    public class ImmutableList
    {
        public List<int> list;

        public ImmutableList(List<int> list)
        {
            this.list = new List<int>();
        }

        public ImmutableList CreateCopy()
        {
            var newList = new List<int>();
            foreach (var item in list)
            {
                newList.Add(item);
            }
            return new ImmutableList(newList);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }
}
