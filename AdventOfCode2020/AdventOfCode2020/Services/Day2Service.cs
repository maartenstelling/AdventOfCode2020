using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Models;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public interface IDay2Service
    {
        int Puzzle1();

        int Puzzle2();
    }

    public class Day2Service : IDay2Service
    {
        public int Puzzle1()
        {
            var input = InputReader.Get("day2");

            return CalculatePuzzle1(input);
        }

        public int CalculatePuzzle1(IEnumerable<string> input)
        {
            var policies = input.Select(GetPasswordPolicy);
            var validPasswords = 0;

            foreach (var policy in policies)
            {
                var charCount = policy.Password.Count(c => c.ToString() == policy.Character);
                if (charCount >= policy.MinimalAmount && charCount <= policy.MaximumAmount)
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }

        private static PasswordPolicy GetPasswordPolicy(string input)
        {
            return new PasswordPolicy
            {
                MinimalAmount = int.Parse(input.Split('-').First()),
                MaximumAmount = int.Parse(input.Split('-')[1].Split(' ').First()),
                Character = input.Split(' ')[1].Split(':').First(),
                Password = input.Split(' ').Last()
            };
        }
        public int Puzzle2()
        {
            var input = InputReader.Get("day2");

            return CalculatePuzzle2(input);
        }

        public int CalculatePuzzle2(IEnumerable<string> input)
        {
            var policies = input.Select(GetPasswordPolicy);
            var validPasswords = 0;

            foreach (var policy in policies)
            {
                var firstChar = policy.Password.ElementAt(policy.MinimalAmount - 1).ToString();
                var secondChar = policy.Password.ElementAt(policy.MaximumAmount - 1).ToString();

                if (firstChar != policy.Character && secondChar != policy.Character ||
                    firstChar == policy.Character && secondChar == policy.Character)
                    continue;

                validPasswords++;
            }

            return validPasswords;
        }
    }
}
