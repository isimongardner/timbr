using System.Collections.Generic;
using System.Threading.Tasks;
using Timbr.Entities;

namespace Timbr.Data
{
    public interface IDatabase
    {
        Task<int> CreateProject(Project project);
        Task<int> CreateTask(Entities.Task task);
        Task<int> DeleteProject(Project project);
        Task<int> DeleteProject(Entities.Task task);
        Task<List<Project>> FetchPendingProjects();
        Task<Project> FetchProject(int id);
        Task<List<Project>> FetchProjects();
        Task<Entities.Task> FetchTask(int id);
        Task<List<Entities.Task>> FetchTasks();
    }
}