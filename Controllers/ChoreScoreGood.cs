using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace choreScoreGood.Controllers
{
  [ApiController]
  [Route("api/chores")]
  public class ChoreScoreController : ControllerBase
  {
    private readonly ChoresService _choresService;
    public ChoreScoreController(ChoresService choresService)
    {
      _choresService = choresService;
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetAll()
    {
      try
      {
        return Ok(_choresService.GetAllChores());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}