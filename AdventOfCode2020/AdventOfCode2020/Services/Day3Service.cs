using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public interface IDay3Service
    {
        long Puzzle1();

        long Puzzle2();
    }

    public class Day3Service : IDay3Service
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day3").ToList();

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IList<string> input)
        {
            return CalculateTrees(input, 3, 1);
        }

        private static long CalculateTrees(ICollection<string> input, int stepsX, int stepsY)
        {
            var columnCount = input.First().Length;
            var rowCount = input.Count;
            var indexX = 0;
            var indexY = 0;
            var treeCount = 0;

            while (true)
            {
                if (indexY >= rowCount) break;
                if (indexX >= columnCount) indexX -= columnCount;

                var pos = input.ElementAt(indexY)[indexX];

                if (pos.ToString().Equals("#", StringComparison.OrdinalIgnoreCase)) treeCount++;

                indexX += stepsX;
                indexY += stepsY;
            }

            return treeCount;
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day3").ToList();

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IList<string> input)
        {
            var slope1 = CalculateTrees(input, 1, 1);
            var slope2 = CalculateTrees(input, 3, 1);
            var slope3 = CalculateTrees(input, 5, 1);
            var slope4 = CalculateTrees(input, 7, 1);
            var slope5 = CalculateTrees(input, 1, 2);

            return slope1 * slope2 * slope3 * slope4 * slope5;
        }
    }
}
