using System.Collections.Generic;
using System.Linq;
using Xunit;
using Zballos.ProjectDemo.UnitCourse.Persons;

namespace ZProject.ProjectDemo.UnitCourse.Tests
{
    public class PersonManagerTest
    {
        [Fact]
        public void IsInstanceOfTypeTest_Supervisor()
        {
            PersonManager manager = new PersonManager();
            Person person;

            person = manager.CreatePerson("João", "José", true);

            Assert.IsType<Supervisor>(person);
        }

        [Fact]
        public void IsInstanceOfTypeTest_Employee()
        {
            PersonManager manager = new PersonManager();
            Person person;

            person = manager.CreatePerson("João", "Maria", false);

            Assert.IsType<Employee>(person);
        }

        [Fact]
        public void IsPersonEqualsTest()
        {
            Person person1 = new Person("João", "José");
            Employee person2 = new Employee("João", "José");
            bool isEqual;

            isEqual = person1.Equals(person2);

            Assert.True(isEqual);
        }

        [Fact]
        public void IsPersonNotEqualsTest()
        {
            Person person1 = new Person("João", "José");
            Employee person2 = new Employee("maria", "josé");
            bool isEqual;

            isEqual = person1.Equals(person2);

            Assert.False(isEqual);
        }

        [Fact]
        public void SupervisorHasEmployees()
        {
            PersonManager manager = new PersonManager();
            Supervisor supervisor;
            bool hasEmployees;

            supervisor = manager.GetSupervisor();
            hasEmployees = supervisor.Employees.Any();

            Assert.True(hasEmployees);
        }
    }
}
