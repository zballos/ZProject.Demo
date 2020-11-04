﻿using UnitOne.Models;
using Xunit;

namespace UnitOne.Tests.Models
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_Area_ReturnArea()
        {
            // Arrange
            var triangle = new Triangle(5, 2, 2, 2);

            // Act
            var result = triangle.Area();

            // Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(2, 1, 1, 1, 1)]
        [InlineData(2, 2, 2, 2, 2)]
        [InlineData(3, 2, 3, 2, 4.5)]
        [InlineData(4, 2, 4, 2, 8)]
        public void Triangle_Area_ReturnAreas(double height, double sideA, double sideB, double sideC, double area)
        {
            // Arrange
            var triangle = new Triangle(height, sideA, sideB, sideC);

            // Act
            var result = triangle.Area();

            // Assert
            Assert.Equal(area, result);
        }
    }
}