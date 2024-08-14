using System;
using System.IO;

namespace Task2
{
    public static class FileStreamOperations
    {
        public static void CreateNewFile()
        {
            Console.Write("Enter file name: ");
            var fileName = Console.ReadLine();
            using (var fileStream = File.Create(fileName))
            {
                Console.WriteLine($"File {fileName} created successfully.");
            }
        }
    }
}
