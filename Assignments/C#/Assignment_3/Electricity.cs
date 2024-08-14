using System;
namespace Ass3
{
	public class Electricity
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter IDNO");
            int idno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Unit Consumed");
            int unit = Convert.ToInt32(Console.ReadLine());
            double bill = 0;
            double amountCharge = 0;

            if (unit <= 199)
            {
                bill = unit * 1.20;
                amountCharge = 1.20;            }
            else if(unit>=200 && unit < 400)
            {
                bill = unit * 1.50;
                amountCharge = 1.50;
            }
            else if (unit>=400 && unit < 600)
            {
                bill = unit * 1.80;
                amountCharge = 1.80;
            }
            else
            {
                bill = unit * 2;
                amountCharge = 2.00;
            }


            if (bill > 400)
            {
                double charge = (bill / 100) * 15;
                double perUnit = bill;
                bill = bill + charge;
                Console.WriteLine($"Amount Charge is {amountCharge} ");
                Console.WriteLine($"per Unit bill is {perUnit}");
                Console.WriteLine($"charge is {charge}");
                Console.WriteLine($"Final bill is {bill}");
            }else
            {
                Console.WriteLine($"amountCharge is {amountCharge}");
                Console.WriteLine($"Final Bill is {bill}");
            }
        }
	}
}

