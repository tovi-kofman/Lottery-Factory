using LotteryFactory.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LotteryFactory.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {
        readonly ILotteryService _lotteryService;

        public LotteryController(ILotteryService lotteryService)
        {
            _lotteryService = lotteryService;
        }

        // GET: api/<LotteryController>
        [HttpGet]
        public ActionResult<List<Lottery>> Get()
        {
            return _lotteryService.GetLotteries();
        }

        // GET api/<LotteryController>/5
        [HttpGet("{id}")]
        public ActionResult<Lottery> Get(int id)
        {
            Lottery l= _lotteryService.GetLotteryById(id);
            if(l == null)
            {
                return NotFound();
            }
            return l;
        }

        // POST api/<LotteryController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Lottery lottery)
        {
            if(_lotteryService.AddLottery(lottery))
            {
                return true;
            }
            return BadRequest();
        }

        // PUT api/<LotteryController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Lottery lottery)
        {
            return _lotteryService.UpdateLottery(id,lottery);
        }

        // DELETE api/<LotteryController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _lotteryService.RemoveLottery(id);
        }
    }
}
