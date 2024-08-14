using System;
using DTO;
using BLL;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new BatchService();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Display All Batches");
                Console.WriteLine("2. Add New Batch");
                Console.WriteLine("3. Delete Batch");
                Console.WriteLine("4. Update Batch");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayAllBatches(service);
                        break;

                    case "2":
                        AddBatch(service);
                        break;

                    case "3":
                        DeleteBatch(service);
                        break;

                    case "4":
                        UpdateBatch(service);
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private static void DisplayAllBatches(BatchService service)
        {
            var batches = service.GetAll();
            Console.WriteLine("All Batches:");
            foreach (var batch in batches)
            {
                Console.WriteLine($"{batch.Id} - {batch.Name}- {batch.Capacity} - {batch.Trainer}");
            }
        }

        private static void AddBatch(BatchService service)
        {
            var newBatch = new Batch();

            Console.Write("Enter batch name: ");
            newBatch.Name = Console.ReadLine();

            Console.Write("Enter start date (yyyy-MM-dd): ");
            newBatch.DateOfStart = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter end date (yyyy-MM-dd): ");
            newBatch.DateOfEnd = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter capacity: ");
            newBatch.Capacity = int.Parse(Console.ReadLine());

            Console.Write("Enter trainer's name: ");
            newBatch.Trainer = Console.ReadLine();

            service.Add(newBatch);
            Console.WriteLine("Batch added successfully.");
        }

        private static void DeleteBatch(BatchService service)
        {
            Console.Write("Enter batch ID to delete: ");
            var id = int.Parse(Console.ReadLine());

            service.Delete(id);
            Console.WriteLine("Batch deleted successfully.");
        }

        private static void UpdateBatch(BatchService service)
        {
            Console.Write("Enter batch ID to update: ");
            var id = int.Parse(Console.ReadLine());

            var batch = service.GetById(id);
            if (batch != null)
            {
                Console.Write("Enter new name: ");
                batch.Name = Console.ReadLine();

                Console.Write("Enter new start date (yyyy-MM-dd): ");
                batch.DateOfStart = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter new end date (yyyy-MM-dd): ");
                batch.DateOfEnd = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter new capacity: ");
                batch.Capacity = int.Parse(Console.ReadLine());

                Console.Write("Enter new trainer's name: ");
                batch.Trainer = Console.ReadLine();

                service.Update(batch);
                Console.WriteLine("Batch updated successfully.");
            }
            else
            {
                Console.WriteLine("Batch not found.");
            }
        }
    }
}
