using System.Collections.Generic;
using AdventOfCode2020.Services;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2020.Tests.Day2
{
    public class Day3ServiceTests
    {
        [Fact]
        public void CalculatePuzzle1_GivenInput_GivenOutput()
        {
            // Arrange
            var day2Service = new Day2Service();
            var input = new List<string>
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };

            // Act
            var result = day2Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(2);
        }

        [Fact]
        public void CalculatePuzzle2_GivenInput_GivenOutput()
        {
            // Arrange
            var day2Service = new Day2Service();
            var input = new List<string>
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };

            // Act
            var result = day2Service.CalculatePuzzle2(input);

            // Assert
            result.Should().Be(1);
        }
    }
}
