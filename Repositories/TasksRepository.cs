using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Reinspire.Models;

namespace Reinspire.Repository
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

    public int Create(Task newTask)
    {
      string sql = @"
      INSERT INTO tasks
      (name, description, isDone)
      VALUES
      (@name, @description, @isDone);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newTask);
    }
  }
}