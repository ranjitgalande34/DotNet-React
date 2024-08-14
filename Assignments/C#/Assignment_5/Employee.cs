using System;
namespace Ass5
{
    public abstract class Employee
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string ReportingManager { get; set; }

        public Employee()
        {
            Id = nextId++;
        }

        public abstract void DisplayDetails();
    }
}
