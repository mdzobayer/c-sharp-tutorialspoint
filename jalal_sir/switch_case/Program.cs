using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch case example");

            int i = -8;

            switch (i)
            {
                case 1:
                case 2:
                    Console.WriteLine("One or Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
