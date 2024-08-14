using System;
namespace first
{
	public class Program7
	{
		
        
            public static void Main(string[] args)
            {
                
                Console.Write("Enter a number to create its multiplication table: ");
                int number = Convert.ToInt32(Console.ReadLine());

           
                Console.WriteLine($"Multiplication table for {number}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
        }
    }



