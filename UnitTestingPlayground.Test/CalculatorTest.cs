using System;
using Xunit;
using UnitTestingPlayground;
using System.Diagnostics;

namespace UnitTestingPlayground.Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(8,4,12)]
        [InlineData(3,2,5)]
        [InlineData(1.25,7.75,9)]
        public void Add_SimpleTest(double x, double y, double expected)
        {
            // Arrange
            
            // Act
            double actual = Calculator.Add(x, y);
            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_MaxDoubleTest()
        {
            // Arrange

            // Act
            double actual = Calculator.Add(double.MaxValue, double.MaxValue);
            // Assert

            Assert.True(double.IsInfinity(actual));
        }

        [Fact]
        public void Add_MinDoubleTest()
        {
            // Arrange

            // MinValue
            double actual = Calculator.Add(double.MinValue, double.MinValue);
            // Assert

            Assert.True(double.IsInfinity(actual));
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(3, 2, 1)]
        [InlineData(1.25, 7.75, -6.5)]
        public void Subtract_SimpleTest(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Subtract(x, y);
            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_MaxDoubleTest()
        {
            // Arrange
            double expected = 0;
            // Act
            double actual = Calculator.Subtract(double.MaxValue, double.MaxValue);
            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_MinDoubleTest()
        {
            // Arrange
            double expected = 0;
            // MinValue
            double actual = Calculator.Subtract(double.MinValue, double.MinValue);
            // Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 32)]
        [InlineData(3, 2, 6)]
        public void Multiply_SimpleTest(double x, double y, double expected)
        {
            // arrange
            // act
            double actual = Calculator.Multiply(x, y);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_MaxTest()
        {
            // arrange
            double x = double.MaxValue;
            double y = double.MaxValue;
            double expected = double.PositiveInfinity;
            // act

            double actual = Calculator.Multiply(x, y);
            // assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_MinTest()
        {
            // arrange
            double x = double.MinValue;
            double y = double.MinValue;
            double expected = double.PositiveInfinity;
            // act

            double actual = Calculator.Multiply(x, y);
            // assert

            Assert.Equal(expected, actual);
        }
    }
}
