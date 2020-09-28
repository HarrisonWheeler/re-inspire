using System;
using System.Collections.Generic;
using Reinspire.Models;
using Reinspire.Repository;

namespace Reinspire.Services
{
  public class QuotesService
  {

    private readonly QuotesRepository _repo;

    public QuotesService(QuotesRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Quote> Get()
    {
      return _repo.Get();
    }
  }
}