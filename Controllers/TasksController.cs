using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
  }

}