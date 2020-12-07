using System.Collections.Generic;
using AdventOfCode2020.Services;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2020.Tests.Day6
{
    public class Day6ServiceTests
    {
        [Fact]
        public void CalculatePuzzle1_GivenInput_GivenOutput()
        {
            // Arrange
            var day6Service = new Day6Service();
            var input = new List<string>
            {
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            };

            // Act
            var result = day6Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(11);
        }

        [Fact]
        public void CalculatePuzzle2_GivenInput_GivenOutput()
        {
            // Arrange
            var day6Service = new Day6Service();
            var input = new List<string>
            {
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            };

            // Act
            var result = day6Service.CalculatePuzzle2(input);

            // Assert
            result.Should().Be(6);
        }
    }
}
