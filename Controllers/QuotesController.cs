﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Reinspire.Models;
using Reinspire.Services;

namespace Reinspire.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

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
