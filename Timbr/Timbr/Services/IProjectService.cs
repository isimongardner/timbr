using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Timbr.Views.Items;

namespace Timbr.Services
{
    public interface IProjectService
    {
        Task<ObservableCollection<ProjectItem>> FetchProjectItems();
        void CreateProject(string name, DateTime startDate, DateTime endDate);
        void CreateTask(string name, int projectId, int numberOfDays);
    }
}