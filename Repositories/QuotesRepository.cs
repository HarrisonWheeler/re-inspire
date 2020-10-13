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

    public int Create(Quote newQuote)
    {
      string sql = @"
      INSERT INTO quotes
      (name, description, isExplicit)
      VALUES
      (@name, @description, @isExplicit);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newQuote);
    }

    public bool Delete(int quoteId)
    {
      string sql = "DELETE FROM quotes WHERE id = @quoteId LIMIT 1;";
      int rowsAffected = _db.Execute(sql, new { quoteId });
      return rowsAffected == 1;
    }
  }
}