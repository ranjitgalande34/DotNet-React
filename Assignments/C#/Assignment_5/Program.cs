using System;
using System.Collections.Generic;
namespace Ass5;

class Program
 {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool continueAdding = true;

            while (continueAdding)
            {
                Console.WriteLine("Are you an Admin or a Customer?");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter employee type:");
                    Console.WriteLine("1. Contract");
                    Console.WriteLine("2. Payroll");
                    int empType = int.Parse(Console.ReadLine());

                    if (empType == 1)
                    {
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter reporting manager:");
                        string manager = Console.ReadLine();
                        Console.WriteLine("Enter contract date (yyyy-mm-dd):");
                        DateTime contractDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter duration (months):");
                        int duration = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter charges per month:");
                        decimal charges = decimal.Parse(Console.ReadLine());

                        employees.Add(new ContractEmployee(name, manager, contractDate, duration, charges));
                    }
                    else if (empType == 2)
                    {
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter reporting manager:");
                        string manager = Console.ReadLine();
                        Console.WriteLine("Enter joining date (yyyy-mm-dd):");
                        DateTime joiningDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter experience (years):");
                        int experience = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter basic salary:");
                        decimal basicSalary = decimal.Parse(Console.ReadLine());

                        employees.Add(new PayrollEmployee(name, manager, joiningDate, experience, basicSalary));
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter employee name to search:");
                    string searchName = Console.ReadLine();

                    foreach (var employee in employees)
                    {
                        if (employee.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            employee.DisplayDetails();
                            break;
                        }
                    }
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueResponse = Console.ReadLine();
                continueAdding = continueResponse.Equals("yes", StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine($"Total number of employees: {employees.Count}");
        }
    }

    