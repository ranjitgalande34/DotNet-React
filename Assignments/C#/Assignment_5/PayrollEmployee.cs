using System;
using Ass5;
using System.Xml.Linq;

namespace Ass5

{
    public class PayrollEmployee : Employee
    {
        public DateTime JoiningDate { get; set; }
        public int Experience { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal DA { get; private set; } 
        public decimal HRA { get; private set; } 
        public decimal PF { get; private set; } 
        public decimal NetSalary { get; private set; }

        public PayrollEmployee(string name, string reportingManager, DateTime joiningDate, int experience, decimal basicSalary)
        {
            Name = name;
            ReportingManager = reportingManager;
            JoiningDate = joiningDate;
            Experience = experience;
            BasicSalary = basicSalary;
            CalculateSalary();
        }

        private void CalculateSalary()
        {
            if (Experience > 10)
            {
                DA = 0.10m * BasicSalary;
                HRA = 0.085m * BasicSalary;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = 0.07m * BasicSalary;
                HRA = 0.065m * BasicSalary;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = 0.041m * BasicSalary;
                HRA = 0.038m * BasicSalary;
                PF = 1800;
            }
            else
            {
                DA = 0.019m * BasicSalary;
                HRA = 0.020m * BasicSalary;
                PF = 1200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Reporting Manager: {ReportingManager}");
            Console.WriteLine($"Joining Date: {JoiningDate.ToShortDateString()}");
            Console.WriteLine($"Experience: {Experience} years");
            Console.WriteLine($"Basic Salary: {BasicSalary:C}");
            Console.WriteLine($"DA: {DA:C}");
            Console.WriteLine($"HRA: {HRA:C}");
            Console.WriteLine($"PF: {PF:C}");
            Console.WriteLine($"Net Salary: {NetSalary:C}");
        }
    }
}
