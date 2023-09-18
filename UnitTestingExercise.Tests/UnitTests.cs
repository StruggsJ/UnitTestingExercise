using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory] //Add test data <-------
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 1,0, 1)]
        [InlineData(-1, -2, -3, -6)]
        [InlineData(-4, 2, 0, -2)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            
            Calculator instance = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = instance.Add(num1, num2, num3);

            //Assert
                
            Assert.Equal(expected, actual);
        }

        [Theory] //Add test data <-------
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(2, 1, 1)]
        [InlineData(-4, -3, -1)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();

            //Act
            var actual = instance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]//Add test data <-------
        [InlineData(1,1,1)]
        [InlineData(5,-1,-5)]
        [InlineData(-1,-3,3)]
        [InlineData(12,0,0)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator instance = new Calculator();

            //Act
            var actual = instance.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]//Add test data <-------
        [InlineData(1,1,1)]
        [InlineData(5,-1,-5)]
        [InlineData(-12, -6,2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();

            //Act
            var actual = instance.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
