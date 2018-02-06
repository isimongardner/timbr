using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Timbr.Data;
using Timbr.Types;
using Timbr.Views.Items;

namespace Timbr.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IDatabase _database;

        public ProjectService(IDatabase database)
        {
            _database = database;
        }

        public async Task<ObservableCollection<ProjectItem>> FetchProjectItems()
        {
            var projects = new ObservableCollection<ProjectItem>();
            var data = await _database.FetchProjects();

            foreach (var item in data)
            {
                projects.Add(new ProjectItem { Id = item.Id, Name = item.Name, StartDate = item.StartDate });
            }

            return projects;
        }

        public async void CreateProject(string name, DateTime startDate, DateTime endDate)
        {
            await _database.CreateProject(new Entities.Project
            {
                Name = name,
                StartDate = startDate,
                EstimatedEndDate = endDate
            });
        }

        public async void CreateTask(string name, int projectId, int numberOfDays)
        {
            await _database.CreateTask(new Entities.Task
            {
                Name = name,
                ProjectId = projectId,
                NumberOfDays = numberOfDays
            });
        }
    }
}