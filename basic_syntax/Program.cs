using System;

namespace basic_syntax
{
    class Rectangle {
        double length;
        double width;

        public void Acceptdetails() {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea() {
            return length * width;
        }
        
        public void Display() {
            Console.WriteLine("Lenght: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle r = new Rectangle();

            r.Acceptdetails();
            r.Display();
            
        }
    }
}
