using System.Collections.Generic;

namespace Zballos.ProjectDemo.UnitCourse.Persons
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person person = null;

            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor) person = new Supervisor(first, last);
                else person = new Employee(first, last);
            }

            return person;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>
            {
                new Person("Joao", "Lucas"),
                new Person("Jose", "Maria"),
                new Person("Maria", "Santos")
            };

            return people;
        }

        public Supervisor GetSupervisor()
        {
            Supervisor supervisor = (Supervisor)CreatePerson("Jones", "Brito", true);

            supervisor.AddEmployee(new Employee("Joao", "Lucas"));
            supervisor.AddEmployee(new Employee("Marta", "Lima"));

            return supervisor;
        }
    }
}
