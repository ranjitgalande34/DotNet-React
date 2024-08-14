using System;
namespace first
{
	public class Program5
	{
		
            public static void Main(string[] args)
            {
                Console.WriteLine("Even numbers up to 20 using do-while loop:");

                int number = 2; 
                do
                {
                    Console.WriteLine(number);
                    number += 2; 
                } while (number <= 20);

                Console.WriteLine("Even numbers up to 20 using for loop:");

                for (int num = 2; num <= 20; num += 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }



