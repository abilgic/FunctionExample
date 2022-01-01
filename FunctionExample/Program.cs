using System;

namespace FunctionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var func = new Func<int, int, int>(CalculateValue);
            Console.WriteLine(func(2, 5));
        }
        public static int CalculateValue(int a, int b)
        {
            return a * b;
        }
    }
}
