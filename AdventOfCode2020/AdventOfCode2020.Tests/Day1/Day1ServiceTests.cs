using System.Collections.Generic;
using AdventOfCode2020.Services;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2020.Tests.Day1
{
    public class Day1ServiceTests
    {
        [Fact]
        public void CalculatePuzzle1_GivenInput_GivenOutput()
        {
            // Arrange
            var day1Service = new Day1Service();
            var input = new List<string>
            {
                "1721",
                "979",
                "366",
                "299",
                "675",
                "1456"
            };

            // Act
            var result = day1Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(514579);
        }
        [Fact]
        public void CalculatePuzzle2_GivenInput_GivenOutput()
        {
            // Arrange
            var day1Service = new Day1Service();
            var input = new List<string>
            {
                "1721",
                "979",
                "366",
                "299",
                "675",
                "1456"
            };

            // Act
            var result = day1Service.CalculatePuzzle2(input);

            // Assert
            result.Should().Be(241861950);
        }
    }
}
