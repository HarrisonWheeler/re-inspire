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

    public Task Create(Task newTask)
    {
      int id = _repo.Create(newTask);
      newTask.Id = id;
      return newTask;
    }
  }
}