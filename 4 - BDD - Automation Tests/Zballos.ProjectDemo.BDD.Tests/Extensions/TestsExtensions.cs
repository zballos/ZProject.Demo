using System;
using System.Linq;

namespace Zballos.ProjectDemo.BDD.Tests.Extensions
{
    public static class TestsExtensions
    {
        public static int OnlyNumbers(this string value) 
        {
            return Convert.ToInt16(new string(value.Where(char.IsDigit).ToArray()));
        }
    }
}
