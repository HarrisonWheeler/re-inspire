using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reinspire.Models;
using Reinspire.Services;

namespace Reinspire.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  // [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
  public class QuotesController : ControllerBase
  {

    private readonly QuotesService _qs;

    public QuotesController(QuotesService qs)
    {
      _qs = qs;
    }

    [HttpGet]

    public ActionResult<IEnumerable<Quote>> Get()
    {
      try
      {
        return Ok(_qs.Get());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]

    public ActionResult<Quote> Post([FromBody] Quote newQuote)
    {
      try
      {
        return Ok(_qs.Create(newQuote));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{quoteId}")]

    public ActionResult<string> Delete(int quoteId)
    {
      try
      {
        return Ok(_qs.Delete(quoteId));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}
