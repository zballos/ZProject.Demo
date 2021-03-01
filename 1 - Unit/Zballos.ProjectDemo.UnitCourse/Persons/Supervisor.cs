using System.Collections.Generic;

namespace Zballos.ProjectDemo.UnitCourse.Persons
{
    public class Supervisor : Person
    {
        public Supervisor(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public List<Employee> Employees { get; private set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
