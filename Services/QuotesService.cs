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

    public Quote Create(Quote newQuote)
    {
      int id = _repo.Create(newQuote);
      newQuote.Id = id;
      return newQuote;
    }

    public bool Delete(int quoteId)
    {
      return _repo.Delete(quoteId);
    }
  }
}