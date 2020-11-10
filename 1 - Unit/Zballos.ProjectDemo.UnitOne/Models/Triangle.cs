using System;

namespace Zballos.ProjectDemo.UnitOne.Models
{
    public class Triangle
    {
        public double Height { get; private set; }
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double height, double sideA, double sideB, double sideC)
        {
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            return (SideB * Height)/2;
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
