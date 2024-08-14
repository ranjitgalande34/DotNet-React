using System;
using Task1;
using Task2;

namespace FileDirectoryOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Task 1 - Directory Operations");
                Console.WriteLine("2. Task 2 - FileStream & StreamWriter/Reader Operations");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1Operations();
                        break;
                    case "2":
                        Task2Operations();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void Task1Operations()
        {
            // Task 1 operations
            DirectoryOperations.CreateDemoDirectories();
            FileOperations.CreateFiles();
            FileOperations.WriteToFiles();
            FileOperations.CopyFileToDemo2();
            DirectoryOperations.DisplayContents();
            DirectoryOperations.GetCreationTime();

            // Uncomment the following lines to delete files and directories
            // FileOperations.DeleteAllFiles();
            // DirectoryOperations.DeleteAllDirectories();
        }

        static void Task2Operations()
        {
            // Task 2 operations with menu
            bool task2Running = true;
            while (task2Running)
            {
                Console.Clear();
                Console.WriteLine("Task 2 Menu:");
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Add contents to the file");
                Console.WriteLine("3. Append contents to the file");
                Console.WriteLine("4. Display contents one by one");
                Console.WriteLine("5. Display all contents together");
                Console.WriteLine("6. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FileStreamOperations.CreateNewFile();
                        break;
                    case "2":
                        StreamWriterReaderOperations.AddContentsToFile();
                        break;
                    case "3":
                        StreamWriterReaderOperations.AppendContentsToFile();
                        break;
                    case "4":
                        StreamWriterReaderOperations.DisplayContentsOneByOne();
                        break;
                    case "5":
                        StreamWriterReaderOperations.DisplayAllContents();
                        break;
                    case "6":
                        task2Running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }

                if (task2Running)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
