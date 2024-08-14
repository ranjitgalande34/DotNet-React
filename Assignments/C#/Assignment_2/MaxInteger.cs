using System;
namespace MyNamespace { 

class MaxInteger
{
    static void Main(string[] args)
    {
            int[] numb = new int[] { 6,3,111,23,67,55,33 };
            int max = 0;

            for(int i = 0; i < numb.Length; i++)
            {
                if (numb[i] > max)
                {
                    max = numb[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"The Greatest Number is {max}");
    }
}
}