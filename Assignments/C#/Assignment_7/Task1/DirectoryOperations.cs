using System;
using System.IO;

namespace Task1
{
    public static class DirectoryOperations
    {
        public static void CreateDemoDirectories()
        {
            Directory.CreateDirectory("Demo");
            Directory.CreateDirectory("Demo/Demo1");
            Directory.CreateDirectory("Demo/Demo2");
        }

        public static void DisplayContents()
        {
            Console.WriteLine("Contents of Demo directory:");
            foreach (var dir in Directory.GetDirectories("Demo"))
            {
                Console.WriteLine($"Directory: {dir}");
            }
            foreach (var file in Directory.GetFiles("Demo"))
            {
                Console.WriteLine($"File: {file}");
            }
        }

        public static void GetCreationTime()
        {
            Console.WriteLine("Creation times:");
            foreach (var dir in Directory.GetDirectories("Demo"))
            {
                Console.WriteLine($"Directory: {dir}, Created at: {Directory.GetCreationTime(dir)}");
            }
            foreach (var file in Directory.GetFiles("Demo"))
            {
                Console.WriteLine($"File: {file}, Created at: {File.GetCreationTime(file)}");
            }
        }

        public static void DeleteAllDirectories()
        {
            Directory.Delete("Demo", true);
        }
    }
}
