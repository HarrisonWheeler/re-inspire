using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Reinspire.Models;
using Reinspire.Services;

namespace Reinspire.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class TasksController : ControllerBase
  {
    private readonly TaskService _ts;

    public TasksController(TaskService ts)
    {
      _ts = ts;
    }

    [HttpGet]

    public ActionResult<IEnumerable<Task>> Get()
    {
      try
      {
        return Ok(_ts.Get());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]

    public ActionResult<Task> Post([FromBody] Task newTask)
    {
      try
      {
        return Ok(_ts.Create(newTask));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }

}