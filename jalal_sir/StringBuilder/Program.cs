using System;
using System.Text;

namespace string_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder Example");

             StringBuilder sb = new StringBuilder("Hello ", 50);

            Console.WriteLine(sb);

            sb.Append("World!!");
            Console.WriteLine(sb);
            sb.AppendLine("Hello C#!");
            Console.WriteLine(sb);
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);
        }
    }
}
