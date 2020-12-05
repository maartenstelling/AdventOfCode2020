using System.Collections.Generic;
using AdventOfCode2020.Services;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2020.Tests.Day3
{
    public class Day4ServiceTests
    {
        [Fact]
        public void CalculatePuzzle1_GivenInput_GivenOutput()
        {
            // Arrange
            var day3Service = new Day3Service();
            var input = new List<string>
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };

            // Act
            var result = day3Service.CalculatePuzzle1(input);

            // Assert
            result.Should().Be(7);
        }

        [Fact]
        public void CalculatePuzzle2_GivenInput_GivenOutput()
        {
            // Arrange
            var day3Service = new Day3Service();
            var input = new List<string>
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };

            // Act
            var result = day3Service.CalculatePuzzle2(input);

            // Assert
            result.Should().Be(336);
        }
    }
}
