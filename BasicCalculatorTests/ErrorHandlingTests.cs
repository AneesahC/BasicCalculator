using BasicCalculator;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace BasicCalculatorTests
{
    public class ErrorHandlingTests
    {
        [Test]
        public void InvalidOperationShouldThrowArgumentException()
        {
            //arrange
            const string invalidOperation = "A";
            const string expectedExceptionMessage = "A is an invalid operation, please try again.";

            var expectedException = new ArgumentException($"{invalidOperation} is an invalid operation, please try again.");

            //act
            Action InvalidOperation = () => ErrorHandling.HandleInvalidOperation(invalidOperation);

            //assert
            InvalidOperation.Should().Throw<ArgumentException>().WithMessage(expectedExceptionMessage); ;
        }
    }
}
