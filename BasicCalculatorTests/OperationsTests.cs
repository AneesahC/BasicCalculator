using NUnit.Framework;
using FluentAssertions;
using BasicCalculator;

namespace BasicCalculatorTests
{
    public class OperationsTests
    {
        [Test]
        public void ShouldAddSecondNumberToFirstNumber()
        {
            //arrange
            const int expectedResult = 3;

            //act
            var result = Operations.Add(1, 2);

            //assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void ShouldSubtractSecondNumberFromFirstNumber()
        {
            //arrange
            const int expectedResult = 4;

            //act
            var result = Operations.Subtract(5, 1);

            //assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void ShouldDivideFirstNumberBySecondNumber()
        {
            //arrange
            const int expectedResult = 3;

            //act
            var result = Operations.Divide(6, 2);

            //assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void ShouldMultiplyFirstNumberBySecondNumber()
        {
            //arrange
            const int expectedResult = 10;

            //act
            var result = Operations.Multiply(5, 2);

            //assert
            result.Should().Be(expectedResult);
        }
    }
}