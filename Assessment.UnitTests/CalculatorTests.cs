using System;
using BDDfy;
using Xunit;
using TestStack.BDDfy.Xunit;
using Assessment.Contract;
using Assessment.Library;
using Shouldly;

namespace Assessment.UnitTests
{
    public class CalculatorTests
    {
        private readonly ICalculator calculator;
        public CalculatorTests()
        {
            calculator = new Calculator();
        }


        [Theory]
        [InlineData(3, 4, 7)]
        public void Add(double a, double b, double res)
        {
            calculator.Add(a, b).ShouldBe(res);
        }
    }
}
