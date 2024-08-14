using System;
namespace first
{
	public class Program8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 100 to 5 with a gap of 3 (using for loop):");
            for (int number = 100; number >= 5; number -= 3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
