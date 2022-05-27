using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RouletteGame.BetsData;
using RouletteGame.Models;
using System;
using System.Threading.Tasks;

namespace RouletteGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetsController : ControllerBase
    {
        private IBetsData _betsData;
        public BetsController(IBetsData betsData)
        {
            _betsData = betsData;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> GetPreviousSpins( Guid id)
        {
            return Ok(_betsData.GetPreviousSpins());
        }
        
        [HttpGet]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetNextSpins()
        {
            return Ok(_betsData.GetNextSpins());
        }
        
        [HttpGet]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetBestSpins()
        {
            return Ok(_betsData.GetBestSpins());
        }
        
         
        
        [HttpPost]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> AddBetsAsync(Guid id)
        {
           // var result = await 
            return base.Ok();

        }
    }
}
