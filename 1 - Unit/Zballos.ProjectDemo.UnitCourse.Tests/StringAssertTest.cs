using System.Text.RegularExpressions;
using Xunit;

namespace Zballos.ProjectDemo.UnitCourse.Tests
{
    public class StringAssertTest
    {
        [Fact]
        public void ContainsTest()
        {
            string str1 = "Edson Luiz";
            string str2 = "Luiz";

            Assert.Contains(str2, str1);
        }

        [Fact]
        public void StartWithTest()
        {
            string str1 = "Meu segundo teste";
            string str2 = "Meu segundo";

            Assert.StartsWith(str2, str1);
        }

        [Fact]
        public void IsAllLowerCaseTest()
        {
            Regex regex = new Regex(@"^([^A-Z])+$");

            string str1 = "meu segundo teste";

            Assert.Matches(regex, str1);
        }

        [Fact]
        public void IsNotAllLowerCaseTest()
        {
            Regex regex = new Regex(@"^([^A-Z])+$");

            string str1 = "Meu segundo teste";

            Assert.DoesNotMatch(regex, str1);
        }
    }
}
