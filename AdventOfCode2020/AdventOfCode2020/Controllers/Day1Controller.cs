using AdventOfCode2020.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Day1Controller : ControllerBase
    {
        private readonly IDay1Service _day1Service;

        public Day1Controller(IDay1Service day1Service)
        {
            _day1Service = day1Service;
        }

        [HttpGet("puzzle1")]
        public int GetPuzzle1()
        {
            return _day1Service.Puzzle1();
        }

        [HttpGet("puzzle2")]
        public int GetPuzzle2()
        {
            return _day1Service.Puzzle2();
        }
    }
}
