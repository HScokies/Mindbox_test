using System.ComponentModel;

namespace Calc.Tests
{
    public class TriangleTests
    {

        [Theory]
        [InlineData(5, 4, 3)]
        [InlineData(3, 5, 4)]
        [InlineData(4, 3, 5)]
        public void CheckIfTriangleIsRight_ReturnsTrue(double Hypotenuse, double Opposite, double Base)
        {
            // Arrange
            Triangle triangle = new(Hypotenuse, Opposite, Base);

            // Act - Assert
            Assert.True(triangle.isRight);
        }

        [Fact]
        public void CheckIfTriangleIsRight_ReturnsFalse()
        {
            // Arrange
            Triangle triangle = new(5, 5, 7);

            // Act - Assert
            Assert.False(triangle.isRight);
        }

        [Theory]
        [InlineData(5, 4, 3)]
        [InlineData(3, 5, 4)]
        [InlineData(4, 3, 5)]
        public void GetRightTriangleArea(double Hypotenuse, double Opposite, double Base)
        {
            // Arrange
            Triangle triangle = new(Hypotenuse, Opposite, Base);
            var Expected = 6;

            // Act
            var Actual = Calc.GetArea(triangle);

            // Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void GetTrianglePerimeter()
        {
            // Arrange
            Triangle triangle = new(1, 1, 1);
            var Expected = 3;

            // Act
            var Actual = triangle.GetPerimeter();

            // Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void GetIrregularTriangleArea()
        {
            // Arrange
            Triangle triangle = new(5, 5, 7);
            var Expected = 12.4975;
            var precision = 4;

            // Act
            var res = Calc.GetArea(triangle);
            var Actual = Math.Round(res, precision);

            // Assert
            Assert.Equal(Expected, Actual);
        }
    }

    public class CircleTests
    {
        [Fact]
        public void GetCircleArea()
        {
            // Arrange
            Circle circle = new(1.234);
            var Expected = 4.78;
            var precision = 2;

            // Act
            var res = circle.GetArea();
            var Actual = Math.Round(res, precision);

            // Assert
            Assert.Equal(Expected, Actual);
        }
    }
}