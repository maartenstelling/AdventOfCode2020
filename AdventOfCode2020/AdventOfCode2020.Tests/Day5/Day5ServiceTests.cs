using System.Collections.Generic;
using AdventOfCode2020.Services;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2020.Tests.Day5
{
    public class Day6ServiceTests
    {
        [Fact]
        public void CalculatePuzzle1_GivenInput1_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();
            var input = new List<string>
            {
                "FBFBBFFRLR"
            };

            // Act
            var result = day5Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(357);
        }
        [Fact]
        public void CalculatePuzzle1_GivenInput2_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();
            var input = new List<string>
            {
                "BFFFBBFRRR"
            };

            // Act
            var result = day5Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(567);
        }

        [Fact]
        public void CalculatePuzzle1_GivenInput3_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();
            var input = new List<string>
            {
                "FFFBBBFRRR"
            };

            // Act
            var result = day5Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(119);
        }

        [Fact]
        public void CalculatePuzzle1_GivenInput4_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();
            var input = new List<string>
            {
                "BBFFBBFRLL"
            };

            // Act
            var result = day5Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(820);
        }

        [Fact]
        public void CalculatePuzzle1_GivenInput5_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();
            var input = new List<string>
            {
                "FBFBBFFRLR",
                "BFFFBBFRRR",
                "FFFBBBFRRR",
                "BBFFBBFRLL"
            };

            // Act
            var result = day5Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(820);
        }
    }
}
