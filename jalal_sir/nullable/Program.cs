using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable Data type");

            // Define nullable type
            Nullable < int > n = null;

            Console.WriteLine(n.GetValueOrDefault());  

            // Define nullable type
            int? n1 = null;

            Console.WriteLine(n1.GetValueOrDefault());  

            int? n2 = 47;

            Console.WriteLine(n2.GetValueOrDefault()); 

        }
    }
}
