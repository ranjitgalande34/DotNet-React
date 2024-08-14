using System;

namespace first
{
    public class Program2
    {
        private static void Main(string[] args)
        {
            
            double x = 10;
            double y = 5;

           
            double addition = x + y;
            double subtraction = x - y;
            double multiplication = x * y;
            double division = x / y; 

            
            Console.WriteLine($"Addition: {x} + {y} = {addition}");
            Console.WriteLine($"Subtraction: {x} - {y} = {subtraction}");
            Console.WriteLine($"Multiplication: {x} * {y} = {multiplication}");
            Console.WriteLine($"Division: {x} / {y} = {division}");
        }
    }
}



