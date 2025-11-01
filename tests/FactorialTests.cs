// tests/FactorialTests.cs
using NUnit.Framework;
using FactorialApp;

namespace FactorialApp.Tests
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void Factorial_Of_5_Should_Return_120()
        {
            long result = Program.CalculateFactorial(5);
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Factorial_Of_0_Should_Return_1()
        {
            long result = Program.CalculateFactorial(0);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}