using System;

namespace reverse_indexing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Indexing");

           int [] list =  { 8, 3, 2 };

            Console.WriteLine(list[1]);
            Console.WriteLine(list[^2]);
        }
    }
}
