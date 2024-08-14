using System;

namespace MyNamespace
{
    class ColSum
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 20 }
            };

            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;

               
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }

               
                Console.WriteLine($"The Sum of Column {j} is {sum}");
            }
        }
    }
}
