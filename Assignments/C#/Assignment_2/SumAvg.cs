using System;
namespace MyNamespace
{ 
    public class SumAvg
    {
        static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;


            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine($"Sum is {sum} ");
            float avg = (float)sum / num.Length;

            Console.WriteLine($"Average of array is {avg}");
        }
    }
}

