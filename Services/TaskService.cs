using System;
using System.Collections.Generic;
using Reinspire.Models;

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

  }
}