using System;
namespace Ass3
{
	public class Admission
	{
        static void Main(string[] args)
        {
            Console.Write("Enter marks for Math: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Chemistry: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            int sum = math + phy + chem;

			if(math>=65 && phy>=55 && chem>=50 && sum >= 180)
			{
				Console.WriteLine("Eligible");
			}else if (math + phy >= 140)
			{
				Console.WriteLine("Eligigle");
			}
			else
			{
				Console.WriteLine("Not Eligible");
			}
		}
	}
}

