using System.Collections.Generic;
using Xunit;
using Zballos.ProjectDemo.UnitCourse.Persons;

namespace ZProject.ProjectDemo.UnitCourse.Tests
{
    public class CollectionAssertTest
    {
        [Fact]
        public void AreCollectionEqualOverrideTest()
        {
            PersonManager manager = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual;

            peopleExpected.Add(new Person("Joao", "Lucas"));
            peopleExpected.Add(new Person("Jose", "Maria"));
            peopleExpected.Add(new Person("Maria", "Santos"));

            peopleActual = manager.GetPeople();

            Assert.Equal(peopleExpected, peopleActual);
        }

        [Fact]
        public void AreCollectionContainsOnePersonByFirstNameTest()
        {
            PersonManager manager = new PersonManager();
            Person personExpected = new Person("Jose", "Maria");
            List<Person> peopleActual;

            peopleActual = manager.GetPeople();

            Assert.Contains(personExpected, peopleActual);
        }
    }
}
