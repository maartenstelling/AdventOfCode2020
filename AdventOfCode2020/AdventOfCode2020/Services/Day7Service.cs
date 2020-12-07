using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Interfaces;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public class Day7Service : IDayService
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day7").ToList();

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IList<string> input)
        {
            return 0;
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day7").ToList();

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IList<string> input)
        {
            return 0;
        }
    }
}
