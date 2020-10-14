using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Reinspire.Models;

namespace Reinspire.Services
{
  public class TasksRepository
  {

    private readonly IDbConnection _db;

    public TasksRepository(IDbConnection db)
    {
      _db = db;
    }
    public IEnumerable<Task> Get()
    {
      string sql = "SELECT * FROM tasks";
      return _db.Query<Task>(sql);
    }
  }
}