using System;
namespace MyNamespace
{

    class RowSum
    {
        static void Main(string[] args)
        {
            int[,] matrix =
           {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 20 }
            };


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;


                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }


                Console.WriteLine($"The Sum of Column {i} is {sum}");
            }
        }
    }

}
