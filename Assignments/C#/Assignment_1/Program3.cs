using System;

namespace first
{
    public class Program3
    {
       

        public static void Main(string[] args)
        {
           
            Console.Write("Enter the first number (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (y): ");
            int y = int.Parse(Console.ReadLine());

          
            int addition = x + y;
            int subtraction = x - y;
            int multiplication = x * y;
            double division = (double)x / y; 

           
            Console.WriteLine($"Addition of x and y: {addition}");
            Console.WriteLine($"Subtraction of y from x: {subtraction}");
            Console.WriteLine($"Multiplication of x and y: {multiplication}");
            Console.WriteLine($"Division of x by y: {division}");
        }
    }
}
