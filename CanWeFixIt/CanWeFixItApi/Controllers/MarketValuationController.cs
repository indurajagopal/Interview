using CanWeFixItService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanWeFixItApi.Controllers
{
    [Route("v1/Valuations")]
    [ApiController]
    public class MarketValuationController : ControllerBase
    {
        private readonly IDatabaseService _database;
        public MarketValuationController(IDatabaseService databaseService)
        {
            _database = databaseService;
        }
        public async Task<ActionResult<IEnumerable<MarketValuation>>> Get()
        {
            return Ok(_database.MarketValuation().Result);
        }
    }
}
