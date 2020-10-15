using System;
using System.Collections.Generic;
using Reinspire.Models;
using Reinspire.Repository;


namespace Reinspire.Services
{
  public class TaskService
  {

    public readonly TasksRepository _repo;

    public TaskService(TasksRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Task> Get()
    {
      return _repo.Get();
    }
    public Task GetById(int taskId)
    {
      Task exists = _repo.GetById(taskId);
      if (exists == null)
      {
        throw new Exception("Invalid Task Id");
      }
      return exists;
    }
    public Task Create(Task newTask)
    {
      int id = _repo.Create(newTask);
      newTask.Id = id;
      return newTask;
    }

    public Task Update(Task updatedTask)
    {
      Task foundTask = GetById(updatedTask.Id);
      updatedTask.Name = updatedTask.Name != null ? updatedTask.Name : foundTask.Name;
      updatedTask.Description = updatedTask.Description != null ? updatedTask.Description : foundTask.Description;
      updatedTask.isDone = updatedTask.isDone != foundTask.isDone ? updatedTask.isDone : foundTask.isDone;
      bool updated = _repo.Update(updatedTask);
      if (!updated)
      {
        throw new Exception("Task was not updated!");
      }
      return updatedTask;
    }

    public bool Delete(int taskId)
    {
      return _repo.Delete(taskId);
    }
  }
}