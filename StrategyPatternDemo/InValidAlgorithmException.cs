using System;

namespace StrategyPatternDemo
{
    public class InValidAlgorithmException : Exception
    {
        public InValidAlgorithmException()
        {
        }

        public InValidAlgorithmException(string message) : base(message)
        {
        }

        public InValidAlgorithmException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}