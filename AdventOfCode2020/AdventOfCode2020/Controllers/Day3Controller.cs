using AdventOfCode2020.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Day3Controller : ControllerBase
    {
        private readonly IDay3Service _day3Service;

        public Day3Controller(IDay3Service day3Service)
        {
            _day3Service = day3Service;
        }

        [HttpGet("puzzle1")]
        public long GetPuzzle1()
        {
            return _day3Service.Puzzle1();
        }

        [HttpGet("puzzle2")]
        public long GetPuzzle2()
        {
            return _day3Service.Puzzle2();
        }
    }
}
