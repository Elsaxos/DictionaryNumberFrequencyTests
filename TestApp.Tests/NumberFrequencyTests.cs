using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class NumberFrequencyTests
    {
        [Test]
        public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
        {
            // Arrange
            int number = 0;

            // Act
            Dictionary<int, int> result = NumberFrequency.CountDigits(number);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
        {
            // Arrange
            int number = 7;

            // Act
            Dictionary<int, int> result = NumberFrequency.CountDigits(number);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.ContainsKey(7));
            Assert.AreEqual(1, result[7]);
        }

        [Test]
        public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
        {
            // Arrange
            int number = 35353532;

            // Act
            Dictionary<int, int> result = NumberFrequency.CountDigits(number);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.ContainsKey(3));
            Assert.IsTrue(result.ContainsKey(5));
            Assert.IsTrue(result.ContainsKey(2));
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(3, result[5]);
            Assert.AreEqual(1, result[2]);
        }

        [Test]
        public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
        {
            // Arrange
            int number = -2323233;

            // Act
            Dictionary<int, int> result = NumberFrequency.CountDigits(number);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.ContainsKey(2));
            Assert.IsTrue(result.ContainsKey(3));
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
        }
    }
}
