using System;

namespace BasicCalculator
{
    public static class ErrorHandling
    {
        public static void HandleInvalidOperation(string operation)
        {
            var exceptionMesage = $"{operation} is an invalid operation, please try again.";

            Console.WriteLine(exceptionMesage);

            throw new ArgumentException(exceptionMesage);
        }
    }
}
