using AdventOfCode2020.Services;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2020.Tests.Day5
{
    public class Day5ServiceTests
    {
        [Fact]
        public void CalculatePuzzle1_GivenInput_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();

            // Act
            var result = day5Service.CalculatePuzzle1(null);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void CalculatePuzzle2_GivenInput_GivenOutput()
        {
            // Arrange
            var day5Service = new Day5Service();

            // Act
            var result = day5Service.CalculatePuzzle2(null);

            // Assert
            result.Should().Be(0);
        }
    }
}
