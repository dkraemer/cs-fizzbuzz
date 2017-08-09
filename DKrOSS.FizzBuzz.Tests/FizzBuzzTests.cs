// Copyright © 2017 Daniel Kraemer <dkraemer@dkross.org>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

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
            var multiplesOfThree = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

            foreach (var number in multiplesOfThree)
            {
                // Act
                var result = FizzBuzz.IsFizz(number);

                // Assert
                Assert.True(result);
            }
        }

        [Fact]
        public void IsFizz_ShouldReturn_FalseForNotMultiplesOfThree()
        {
            // Arrange
            var notMultiplesOfThree = new[] { 1, 2, 4, 5, 7, 8, 10, 11, 13, 14 };

            foreach (var number in notMultiplesOfThree)
            {
                // Act
                var result = FizzBuzz.IsFizz(number);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void IsBuzz_ShouldReturn_TrueForMultiplesOfFive()
        {
            // Arrange
            var multiplesOfFive = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            foreach (var number in multiplesOfFive)
            {
                // Act
                var result = FizzBuzz.IsBuzz(number);

                // Assert
                Assert.True(result);
            }
        }

        [Fact]
        public void IsBuzz_ShouldReturn_FalseForNotMultiplesOfFive()
        {
            // Arrange
            var notMultiplesOfFive = new[] { 6, 11, 16, 21, 26, 31, 36, 41, 46, 51 };

            foreach (var number in notMultiplesOfFive)
            {
                // Act
                var result = FizzBuzz.IsBuzz(number);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWith100StringElements()
        {
            // Arrange
            const int expectedCount = 100;

            // Act
            var result = FizzBuzz.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count);
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfFizzStringsForNumbers1To100()
        {
            // Arrange
            const int expectedCount = 27;

            // Act
            var result = FizzBuzz.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count(x => x == "Fizz"));
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfBuzzStringsForNumbers1To100()
        {
            // Arrange
            const int expectedCount = 14;

            // Act
            var result = FizzBuzz.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count(x => x == "Buzz"));
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfFizzBuzzStringsForNumbers1To100()
        {
            // Arrange
            const int expectedCount = 6;

            // Act
            var result = FizzBuzz.GenerateList();

            // Assert
            Assert.Equal(expectedCount, result.Count(x => x == "FizzBuzz"));
        }

        [Fact]
        public void GenerateList_ShouldReturn_ListWithCorrectNumberOfNumberStringsForNumbers1To100()
        {
            // Arrange
            const int expectedCount = 53;
            var numberRegex = new Regex("^\\d{1,3}$");

            // Act
            var result = FizzBuzz.GenerateList();

            // Assert
            var matchedNumbersCount = result.Count(item => numberRegex.IsMatch(item));
            Assert.Equal(expectedCount, matchedNumbersCount);
        }
    }
}
