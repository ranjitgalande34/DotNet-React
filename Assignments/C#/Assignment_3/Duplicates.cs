using System;
using System.Collections.Generic;
namespace Ass3;

class Duplicates
{
    static void Main(string[] args)
    {
        int[] array = { 1, 1,2,2,3,3,4,4}; 
        List<int> duplicateElements = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j] && !duplicateElements.Contains(array[i]))
                {
                    duplicateElements.Add(array[i]);
                    break; 
                }
            }
        }

        Console.WriteLine("Total number of duplicate elements: " + duplicateElements.Count);
    }
    }


        