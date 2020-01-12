using System;
using System.Collections.Generic;
using System.Linq;

namespace lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expression Bodied");

            Console.WriteLine(DoubleTheValue(4));
            Console.WriteLine(doubleTheValue(4));


            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression
            // to calculate square of 
            // each value in the list
            var square = numbers.Select(x => x * x);

            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression
            // to calculate square of 
            // divisible by 3
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

        }

        static int DoubleTheValue(int someValue)
        {
            return someValue * 2;
        }

        static int doubleTheValue(int someValue) => someValue * 2;
    }
}
