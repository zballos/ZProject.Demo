using Xunit;
using Zballos.ProjectDemo.UnitOne.Models;

namespace Zballos.ProjectDemo.UnitOne.Tests.Models
{
    public class CircleTests
    {
        [Fact]
        public void Circle_Area_ReturnArea()
        {
            // Arrange
            double area = 78.54;
            var circle = new Circle(radius: 5);

            // Act
            var result = circle.Area();

            // Assert
            Assert.Equal(area, result);
        }

        [Theory]
        [InlineData(1, 3.142)]
        [InlineData(2, 12.566)]
        [InlineData(3, 28.274)]
        [InlineData(4, 50.265)]
        public void Circle_Area_ReturnAreas(double radius, double area)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.Area();

            // Assert
            Assert.Equal(area, result);
        }

        [Fact]
        public void Circle_Circumference_ReturnCircumference()
        {
            // Arrange
            double circumference = 6.283;
            var circle = new Circle(radius: 1);

            // Act
            var result = circle.Circumference();

            // Assert
            Assert.Equal(circumference, result);
        }

        [Theory]
        [InlineData(1, 6.283)]
        [InlineData(2, 12.566)]
        [InlineData(3, 18.85)]
        [InlineData(4, 25.133)]
        public void Circle_Circumference_ReturnCircumferences(double radius, double circumference)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.Circumference();

            // Assert
            Assert.Equal(circumference, result);
        }

        [Fact]
        public void Circle_Circumference_ReturnInvalidCircumference()
        {
            // Arrange
            double circumference = 6.283;
            var circle = new Circle(radius: 0);

            // Act
            var result = circle.Circumference();

            // Assert
            Assert.NotEqual(circumference, result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        [InlineData(3, 6)]
        [InlineData(4, 8)]
        public void Circle_Diameter_ReturnDiameters(double radius, double diameter)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.Diameter();

            // Assert
            Assert.Equal(diameter, result);
        }
    }
}
