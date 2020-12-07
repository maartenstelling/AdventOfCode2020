using AdventOfCode2020.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayController : ControllerBase
    {
        private readonly IDayService _dayService;

        public DayController(IDayService dayService)
        {
            _dayService = dayService;
        }

        [HttpGet("puzzle1")]
        public long GetPuzzle1()
        {
            return _dayService.Puzzle1();
        }

        [HttpGet("puzzle2")]
        public long GetPuzzle2()
        {
            return _dayService.Puzzle2();
        }
    }
}
