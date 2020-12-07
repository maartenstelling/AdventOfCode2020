using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Interfaces;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public class Day5Service : IDayService
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day5").ToList();

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IList<string> input)
        {
            var boardingPassIds = new List<int>();

            foreach (var boardingPass in input)
            {
                var rowCharacters = boardingPass.Substring(0, 7).Select(c => c.ToString()).ToList();
                var columnCharacters = boardingPass.Substring(7, 3).Select(c => c.ToString()).ToList();

                var row = Calculate(rowCharacters, "F", 127);
                var column = Calculate(columnCharacters, "L", 7);

                boardingPassIds.Add((row * 8) + column);
            }

            return boardingPassIds.Max();
        }

        private static int Calculate(IReadOnlyList<string> characters, string lowCharacter, int highInput)
        {
            var lowInput = 0;

            for (var i = 0; i < characters.Count; i++)
            {
                var rowCharacter = characters[i];
                var calc = (highInput - lowInput + 1) / 2;

                if (calc == 1)
                {
                    return rowCharacter == lowCharacter ? lowInput : highInput;
                }

                if (rowCharacter == lowCharacter)
                {
                    highInput -= calc;
                }
                else
                {
                    lowInput += calc;
                }
            }

            return 0;
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day5").ToList();

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IList<string> input)
        {
            var boardingPassIds = new List<int>();

            foreach (var boardingPass in input)
            {
                var rowCharacters = boardingPass.Substring(0, 7).Select(c => c.ToString()).ToList();
                var columnCharacters = boardingPass.Substring(7, 3).Select(c => c.ToString()).ToList();

                var row = Calculate(rowCharacters, "F", 127);
                var column = Calculate(columnCharacters, "L", 7);

                boardingPassIds.Add((row * 8) + column);
            }

            var min = boardingPassIds.Min();
            var max = boardingPassIds.Max();

            return Enumerable.Range(min, max - min + 1).Except(boardingPassIds).First();
        }
    }
}
