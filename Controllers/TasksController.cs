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

    [HttpGet("{taskId}")]

    public ActionResult<Task> GetById(int taskId)
    {
      try
      {
        return Ok(_ts.GetById(taskId));
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

    [HttpPut("{taskId}")]

    public ActionResult<Task> Update(int taskId, [FromBody] Task updatedTask)
    {
      try
      {
        updatedTask.Id = taskId;
        return Ok(_ts.Update(updatedTask));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }

}