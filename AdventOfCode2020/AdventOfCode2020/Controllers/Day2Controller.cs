using AdventOfCode2020.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Day2Controller : ControllerBase
    {
        private readonly IDay2Service _day2Service;

        public Day2Controller(IDay2Service day2Service)
        {
            _day2Service = day2Service;
        }

        [HttpGet("puzzle1")]
        public int GetPuzzle1()
        {
            return _day2Service.Puzzle1();
        }

        [HttpGet("puzzle2")]
        public int GetPuzzle2()
        {
            return _day2Service.Puzzle2();
        }
    }
}
