using NUnit.Framework;
using FactorialApp;   // same namespace as Program.cs

namespace FactorialApp.Tests
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void Factorial_Of_5_Is_120()
        {
            long result = Program.CalculateFactorial(5);
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Factorial_Of_0_Is_1()
        {
            long result = Program.CalculateFactorial(0);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}