using AdventOfCode2020.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Day5Controller : ControllerBase
    {
        private readonly IDay5Service _day5Service;

        public Day5Controller(IDay5Service day5Service)
        {
            _day5Service = day5Service;
        }

        [HttpGet("puzzle1")]
        public long GetPuzzle1()
        {
            return _day5Service.Puzzle1();
        }

        [HttpGet("puzzle2")]
        public long GetPuzzle2()
        {
            return _day5Service.Puzzle2();
        }
    }
}
