using AdventOfCode2020.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Day4Controller : ControllerBase
    {
        private readonly IDay4Service _day4Service;

        public Day4Controller(IDay4Service day4Service)
        {
            _day4Service = day4Service;
        }

        [HttpGet("puzzle1")]
        public long GetPuzzle1()
        {
            return _day4Service.Puzzle1();
        }

        [HttpGet("puzzle2")]
        public long GetPuzzle2()
        {
            return _day4Service.Puzzle2();
        }
    }
}
