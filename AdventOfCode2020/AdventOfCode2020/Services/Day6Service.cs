using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Interfaces;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public class Day6Service : IDayService
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day6").ToList();

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IList<string> input)
        {
            var groups = new List<string>();
            var groupAnswers = string.Empty;

            foreach (var line in input)
            {
                if (string.IsNullOrEmpty(line))
                {
                    groups.Add(groupAnswers);
                    groupAnswers = string.Empty;
                    continue;
                }

                groupAnswers += line;
            }

            groups.Add(groupAnswers);

            return groups.Sum(group => group.Distinct().Count());
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day6").ToList();

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IList<string> input)
        {
            var groups = new List<List<string>>();
            var persons = new List<string>();

            foreach (var line in input)
            {
                if (string.IsNullOrEmpty(line))
                {
                    groups.Add(persons);
                    persons = new List<string>();
                    continue;
                }

                persons.Add(line);
            }

            groups.Add(persons);

            var result = 0;

            foreach (var group in groups)
            {
                var chars = group.SelectMany(g => g.ToList()).Select(c => c.ToString()).GroupBy(c => c);

                foreach (var c in chars)
                {
                    if (c.Count() == group.Count)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
