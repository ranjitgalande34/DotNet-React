using System;
namespace first
{
	public class Program6
        {
            public static void Main(string[] args)
            {
               
                Console.WriteLine("Odd numbers up to 20 using do-while loop:");

                int number = 1; 
                do
                {
                    Console.WriteLine(number);
                    number += 2; 
                } while (number <= 20);

               
                Console.WriteLine("Odd numbers up to 20 using for loop:");

                for (int num = 1; num <= 20; num += 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }


