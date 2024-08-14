using System;

namespace MyNamespace
{
    public class MatrixSum
    {
        static void Main()
        {
          
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 20 }
            };

            int sum = 0;

      
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine($"The Sum Of Matrix is {sum}");
        }
    }
}
