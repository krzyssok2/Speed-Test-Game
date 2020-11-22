using NUnit.Framework;
using System.Collections.Generic;
using TestSpeedGame.Utilities;
using Xunit;

namespace UnitTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Fact]
        public void CalculateNumberOfCharsTest()
        {
            //Arrange
            GameCalculator gameCalculator = new GameCalculator();
            int expectedValue = 10;
            string[] words =
            {
                "My",
                "Name",
                "Is",
                "Jeff"
            };

            //Act
            int actualValue = gameCalculator.CalculateNumberOfChars(words);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Fact]
        public void CalculateNumberOfWrongWordsTest()
        {
            //Arrange
            GameCalculator gameCalculator = new GameCalculator();
            int expectedValue = 1;
            string[] words =
            {
                "My",
                "Name",
                "Is",
                "Jeff"
            };
            List<string> words2 = new List<string>
            {
                "My",
                "Name",
                "Is",
                "Kristopher"
            };

            //Act
            int actualValue = gameCalculator.CalculateWrongsWords(words, words2);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Fact]
        public void CalculateNumberOfCorrectWordsTest()
        {
            //Arrange
            GameCalculator gameCalculator = new GameCalculator();
            int expectedValue = 3;
            string[] words =
            {
                "My",
                "Name",
                "Is",
                "Jeff"
            };
            List<string> words2 = new List<string>
            {
                "My",
                "Name",
                "was",
                "Jeff"
            };

            //Act
            int actualValue = gameCalculator.CalculateWrongsWords(words, words2);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}