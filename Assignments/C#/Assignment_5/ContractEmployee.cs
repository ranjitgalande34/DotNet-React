using System;
using Ass5;
using System.Xml.Linq;

namespace Ass5
{
    public class ContractEmployee : Employee
    {
        public DateTime ContractDate { get; set; }
        public int Duration { get; set; } 
        public decimal Charges { get; set; } 

        public ContractEmployee(string name, string reportingManager, DateTime contractDate, int duration, decimal charges)
        {
            Name = name;
            ReportingManager = reportingManager;
            ContractDate = contractDate;
            Duration = duration;
            Charges = charges;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Reporting Manager: {ReportingManager}");
            Console.WriteLine($"Contract Date: {ContractDate.ToShortDateString()}");
            Console.WriteLine($"Duration: {Duration} months");
            Console.WriteLine($"Charges: {Charges:C} per month");
        }
    }
}
