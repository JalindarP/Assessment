using System;
using Xunit;
using Shouldly;
using Assessment.Contract;
using Assessment.Library;

namespace UnitTests
{
    public class CalculatorTests:IClassFixture<DatabaseFixture>
    {
        private ICalculator calculator;

        DatabaseFixture fixture;

        public CalculatorTests(DatabaseFixture fixture)
        {
            this.fixture = fixture;
            this.calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void add(double a, double b, double result)
        {
            // Act
            double response = this.calculator.Add(a, b);

            // Assert
            response.ShouldBe(result);
        }

        [Fact]
        public void add2()
        {
            // Arrange
            double a = 10;
            double b = 20;

            // Act
            double response = this.calculator.Add(a, b);

            // Assert
            response.ShouldBe(30);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 2, 4)]
        public void sub(double a, double b, double result)
        {
            // Act
            double response = this.calculator.Sub(a, b);

            // Assert
            response.ShouldBe(result);
        }

        [Fact]
        [Trait("Category", "Integration")]
        public void divide()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => this.calculator.divide(a, b));
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void divide2()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act and Assert

            Should.Throw<DivideByZeroException>(() => this.calculator.divide(a, b));
        }
    }

    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            //Db = new SqlConnection("MyConnectionString");

            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }

        //public SqlConnection Db { get; private set; }
    }

}