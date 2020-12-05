using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public interface IDay5Service
    {
        long Puzzle1();

        long Puzzle2();
    }

    public class Day5Service : IDay5Service
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day5").ToList();

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IList<string> input)
        {
            var boardingPassIds = new List<long>();

            foreach (var boardingPass in input)
            {
                var rowCharacters = boardingPass.Substring(0, 7).Select(c => c.ToString()).ToList();
                var lowInput = 0;
                var highInput = 127;

                for (var i = 0; i < rowCharacters.Count; i++)
                {
                    var rowCharacter = rowCharacters[i];
                    var calc = (highInput - lowInput + 1) / 2;

                    if (rowCharacter == "F")
                    {
                        highInput = calc;
                    }
                    else
                    {
                        lowInput += calc;
                    }
                }
            }

            return boardingPassIds.Max();
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day5").ToList();

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IList<string> input)
        {
            return 0;
        }
    }
}
