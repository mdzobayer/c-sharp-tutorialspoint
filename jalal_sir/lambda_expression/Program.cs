using System;

namespace lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expression Bodied");

            Console.WriteLine(DoubleTheValue(4));
            Console.WriteLine(doubleTheValue(4));
        }

        static int DoubleTheValue(int someValue) {
            return someValue * 2;
        }

        static int doubleTheValue(int someValue) => someValue * 2;
    }
}
