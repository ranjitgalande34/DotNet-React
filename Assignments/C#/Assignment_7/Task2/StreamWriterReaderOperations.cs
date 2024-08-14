using System;
using System.IO;

namespace Task2
{
    public static class StreamWriterReaderOperations
    {
        public static void AddContentsToFile()
        {
            Console.Write("Enter file name: ");
            var fileName = Console.ReadLine();
            try
            {
                using (var writer = new StreamWriter(fileName))
                {
                    Console.Write("Enter content: ");
                    var content = Console.ReadLine();
                    writer.Write(content);
                    Console.WriteLine("Content added successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void AppendContentsToFile()
        {
            Console.Write("Enter file name: ");
            var fileName = Console.ReadLine();
            try
            {
                using (var writer = new StreamWriter(fileName, append: true))
                {
                    Console.Write("Enter content to append: ");
                    var content = Console.ReadLine();
                    writer.Write(content);
                    Console.WriteLine("Content appended successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void DisplayContentsOneByOne()
        {
            Console.Write("Enter file name: ");
            var fileName = Console.ReadLine();
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void DisplayAllContents()
        {
            Console.Write("Enter file name: ");
            var fileName = Console.ReadLine();
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
