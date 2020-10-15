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
    public Task GetById(int taskId)
    {
      string sql = @"
      SELECT * FROM tasks WHERE id = @taskId";
      return _db.QueryFirstOrDefault<Task>(sql, new { taskId });
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

    public bool Update(Task updatedTask)
    {
      string sql = @"UPDATE tasks
      SET
      name = @name,
      description = @description,
      isDone = @isDone
      WHERE id = @id LIMIT 1;";
      int rowsAffected = _db.Execute(sql, updatedTask);
      return rowsAffected == 1;
    }

    public bool Delete(int taskId)
    {
      string sql = "DELETE FROM tasks WHERE id = @taskId LIMIT 1;";
      int rowsAffected = _db.Execute(sql, new { taskId });
      return rowsAffected == 1;
    }
  }
}