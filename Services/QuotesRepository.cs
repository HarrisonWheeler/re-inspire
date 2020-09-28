using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Reinspire.Models;

namespace Reinspire.Repository
{
  public class QuotesRepository
  {

    private readonly IDbConnection _db;

    public QuotesRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Quote> Get()
    {
      string sql = "SELECT * FROM quotes";
      return _db.Query<Quote>(sql);
    }
  }
}