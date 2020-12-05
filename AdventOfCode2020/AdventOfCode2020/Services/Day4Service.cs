using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AdventOfCode2020.Utilities;

namespace AdventOfCode2020.Services
{
    public interface IDay4Service
    {
        long Puzzle1();

        long Puzzle2();
    }

    public class Day4Service : IDay4Service
    {
        public long Puzzle1()
        {
            var input = InputReader.Get("day4").ToList();

            return CalculatePuzzle1(input);
        }

        public long CalculatePuzzle1(IList<string> input)
        {
            var passports = new List<string>();
            var password = string.Empty;

            foreach (var line in input)
            {
                if (string.IsNullOrEmpty(line))
                {
                    passports.Add(password);
                    password = string.Empty;
                    continue;
                }

                password += string.IsNullOrEmpty(password) ? line : $" {line}";
            }

            passports.Add(password);

            var bla = passports.Select(GetPassport).ToList();

            return bla.Count(h => h.Byr is not null &&
                                  h.Ecl is not null &&
                                  h.Eyr is not null &&
                                  h.Hcl is not null &&
                                  h.Hgt is not null &&
                                  h.Iyr is not null &&
                                  h.Pid is not null);
        }

        private static Passport GetPassport(string line)
        {
            return new Passport
            {
                Byr = GetValue(line, "byr"),
                Cid = GetValue(line, "cid"),
                Ecl = GetValue(line, "ecl"),
                Eyr = GetValue(line, "eyr"),
                Hcl = GetValue(line, "hcl"),
                Hgt = GetValue(line, "hgt"),
                Iyr = GetValue(line, "iyr"),
                Pid = GetValue(line, "pid")
            };
        }

        private static string GetValue(string line, string key)
        {
            return line.Split(' ').FirstOrDefault(b => b.Split(':')[0].Equals(key, StringComparison.OrdinalIgnoreCase))?.Split(':')[1];
        }

        public class Passport
        {
            public string Byr { get; set; }

            public string Iyr { get; set; }

            public string Eyr { get; set; }

            public string Hgt { get; set; }

            public string Hcl { get; set; }

            public string Ecl { get; set; }

            public string Pid { get; set; }

            public string Cid { get; set; }
        }

        public long Puzzle2()
        {
            var input = InputReader.Get("day4").ToList();

            return CalculatePuzzle2(input);
        }

        public long CalculatePuzzle2(IList<string> input)
        {
            var passports = new List<string>();
            var password = string.Empty;

            foreach (var line in input)
            {
                if (string.IsNullOrEmpty(line))
                {
                    passports.Add(password);
                    password = string.Empty;
                    continue;
                }

                password += string.IsNullOrEmpty(password) ? line : $" {line}";
            }

            passports.Add(password);

            var bla = passports.Select(GetPassport).ToList();

            return bla.Count(IsValid);
        }

        private static bool IsValid(Passport passport)
        {
            if (passport.Byr is null || !int.TryParse(passport.Byr, out var byr)) return false;
            if (byr < 1920 || byr > 2002) return false;

            if (passport.Iyr is null || !int.TryParse(passport.Iyr, out var iyr)) return false;
            if (iyr < 2010 || iyr > 2020) return false;

            if (passport.Eyr is null || !int.TryParse(passport.Eyr, out var eyr)) return false;
            if (eyr < 2020 || eyr > 2030) return false;

            if (passport.Hgt is null) return false;
            if (passport.Hgt?.Contains("cm") == false && passport.Hgt?.Contains("in") == false) return false;
            if (passport.Hgt?.Contains("cm") == true)
            {
                var height = passport.Hgt.Substring(0, passport.Hgt.IndexOf("cm", StringComparison.OrdinalIgnoreCase));
                if (!int.TryParse(height, out var h)) return false;
                if (h < 150 || h > 193) return false;
            }
            else if (passport.Hgt?.Contains("in") == true)
            {
                var height = passport.Hgt.Substring(0, passport.Hgt.IndexOf("in", StringComparison.OrdinalIgnoreCase));
                if (!int.TryParse(height, out var h)) return false;
                if (h < 59 || h > 76) return false;
            }

            if (passport.Hcl is null) return false;
            if (!passport.Hcl.StartsWith('#')) return false;
            var hcl = passport.Hcl.Substring(1);
            if (hcl.Length != 6) return false;
            if (!Regex.IsMatch(hcl, @"^[a-zA-Z0-9]+$")) return false;

            if (passport.Ecl is null) return false;
            if (!string.Equals("amb", passport.Ecl, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals("blu", passport.Ecl, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals("brn", passport.Ecl, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals("gry", passport.Ecl, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals("grn", passport.Ecl, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals("hzl", passport.Ecl, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals("oth", passport.Ecl, StringComparison.OrdinalIgnoreCase))
                return false;

            if (passport.Pid is null || passport.Pid.Length != 9) return false;
            if (!passport.Pid.Any(char.IsDigit)) return false;

            return true;
        }
    }
}
