using NUnit.Framework;
using FactorialApp;  // Reference to main namespace

namespace FactorialApp.Tests
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void CalculateFactorial_For5_Returns120()
        {
            // Arrange
            int input = 5;
            long expected = 120;

            // Act
            long actual = Program.CalculateFactorial(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateFactorial_For0_Returns1()
        {
            // Arrange
            int input = 0;
            long expected = 1;

            // Act
            long actual = Program.CalculateFactorial(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}