using NUnit.Framework;
using Shouldly;

namespace Calculator.Tests
{
    public class CalculatorOperations
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            const int expected = 10;
            const int firstNumber = 1;
            const int secondNumber = 9;

            var actual = Calculation.Addition(firstNumber, secondNumber);

            actual.ShouldBe(expected);
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            const int expected = 5;
            const int firstNumber = 6;
            const int secondNumber = 1;

            var actual = Calculation.Subtraction(firstNumber, secondNumber);

            actual.ShouldBe(expected);

        }

        [Test]
        public void ShouldMultipyTwoNumbers()
        {
            const int expected = 20;
            const int firstNumber = 10;
            const int secondNumber = 2;

            var actual = Calculation.Multiplication(firstNumber, secondNumber);

            actual.ShouldBe(expected);
        }
        [Test]
        public void ShouldDivideTwoNumbers()
        {
            const int expected = 50;
            const int firstNumber = 100;
            const int secondNumber = 2;

            var actual = Calculation.Division(firstNumber, secondNumber);

            actual.ShouldBe(expected);
        }
    }
}
