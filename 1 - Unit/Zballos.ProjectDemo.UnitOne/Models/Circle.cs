using System;

namespace Zballos.ProjectDemo.UnitOne.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), digits: 3);
        }

        public double Circumference()
        {
            return Math.Round(2 * Math.PI * Radius, digits: 3);
        }

        public double Diameter()
        {
            return Math.Round(2 * Radius, digits: 3);
        }
    }
}
