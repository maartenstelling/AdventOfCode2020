using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2020.Utilities
{
    public static class InputReader
    {
        public static IEnumerable<string> Get(string filename)
        {
            return File.ReadAllLines($@"D:\AdventOfCode\2020\input\{filename}.txt");
        }
    }
}
