using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Interfaces;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public class Day1Service : IDayService
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day1");

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IEnumerable<string> input)
        {
            var numbers = input.Select(int.Parse).ToList();

            foreach (var x in numbers)
            {
                foreach (var y in numbers)
                {
                    if (x + y == 2020)
                    {
                        return x * y;
                    }
                }
            }

            throw new ArgumentException("Cannot find answer");
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day1");

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IEnumerable<string> input)
        {
            var numbers = input.Select(int.Parse).ToList();

            foreach (var x in numbers)
            {
                foreach (var y in numbers)
                {
                    foreach (var z in numbers)
                    {
                        if (x + y + z == 2020)
                        {
                            return x * y * z;
                        }
                    }
                }
            }

            throw new ArgumentException("Cannot find answer");
        }
    }
}
