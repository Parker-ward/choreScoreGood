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

    [HttpGet("{id}")]

    public ActionResult<Chore> GetOneChore(int id)
    {
      try
      {
        Chore chore = _choresService.GetOneChore(id);
        return Ok(chore);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}/done")]
    public ActionResult<Chore> IsDone(int id)
    {
      try
      {
        Chore chore = _choresService.IsDone(id);
        return Ok(chore);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}