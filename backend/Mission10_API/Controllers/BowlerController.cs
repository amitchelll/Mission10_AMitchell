using Microsoft.AspNetCore.Mvc;
using Mission10_API.Data;
using System.Collections.Generic;
using System.Linq;

namespace Mission10_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<BowlerAndTeam> GetBowlersAndTeams()
        {
            return _bowlerRepository.GetBowlersAndTeams();
        }
    }
}
