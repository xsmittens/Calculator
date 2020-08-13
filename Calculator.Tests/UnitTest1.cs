using NUnit.Framework;
using Shouldly;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Test]
        public void OutputYesMethodResultShouldBeYes()
        {
            const string expected = "Yes";

            var actual = OutputYes();

            actual.ShouldBe(expected);
        }

        private string OutputYes()
        {
            return "Yes";
        }
    }
}
