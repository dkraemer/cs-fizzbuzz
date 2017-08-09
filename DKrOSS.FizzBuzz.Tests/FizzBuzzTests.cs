using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace DKrOSS.FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void IsFizz_ShouldReturn_TrueForMultiplesOfThree()
        {
            // Arrange
            var generator = new FizzBuzz();
            var multiplesOfThree = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

            foreach(var number in multiplesOfThree)
            {
                // Act
                bool result = generator.IsFizz(number);

                // Assert
                Assert.True(result);
            }
        }

        [Fact]
        public void IsFizz_ShouldReturn_FalseForNotMultiplesOfThree()
        {
            // Arrange
            var generator = new FizzBuzz();
            var notMultiplesOfThree = new[] { 1, 2, 4, 5, 7, 8, 10, 11, 13, 14 };

            foreach (var number in notMultiplesOfThree)
            {
                // Act
                bool result = generator.IsFizz(number);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void IsBuzz_ShouldReturn_TrueForMultiplesOfFive()
        {
            // Arrange
            var generator = new FizzBuzz();
            var multiplesOfFive = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            foreach (var number in multiplesOfFive)
            {
                // Act
                bool result = generator.IsBuzz(number);

                // Assert
                Assert.True(result);
            }
        }

        [Fact]
        public void IsBuzz_ShouldReturn_FalseForNotMultiplesOfFive()
        {
            // Arrange
            var generator = new FizzBuzz();
            var notMultiplesOfFive = new[] { 6, 11, 16, 21, 26, 31, 36, 41, 46, 51 };

            foreach (var number in notMultiplesOfFive)
            {
                // Act
                bool result = generator.IsBuzz(number);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWith100StringElements()
        {
            // Arrange
            var generator = new FizzBuzz();
            var expectedCount = 100;

            // Act
            IReadOnlyList<string> result = generator.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count);
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfFizzBuzzStringsForNumbers1To100()
        {
            // Arrange
            var generator = new FizzBuzz();
            var expectedCount = 6;

            // Act
            IReadOnlyList<string> result = generator.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count(x => x == "FizzBuzz"));
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfBuzzStringsForNumbers1To100()
        {
            // Arrange
            var generator = new FizzBuzz();
            var expectedCount = 14;

            // Act
            IReadOnlyList<string> result = generator.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count(x => x == "Buzz"));
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfFizzStringsForNumbers1To100()
        {
            // Arrange
            var generator = new FizzBuzz();
            var expectedCount = 27;

            // Act
            IReadOnlyList<string> result = generator.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count(x => x == "Fizz"));
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfNumberStringsForNumbers1To100()
        {
            // Arrange
            var generator = new FizzBuzz();
            var expectedCount = 53;
            var numberRegex = new Regex("^\\d{1,3}$");
            var matchedNumbersCount = 0;

            // Act
            IReadOnlyList<string> result = generator.GenerateList();

            // Assert
            foreach (var item in result)
            {
                if (numberRegex.IsMatch(item))
                {
                    matchedNumbersCount++;
                }
            }
            Assert.Equal(expectedCount, matchedNumbersCount);
        }
    }
}
