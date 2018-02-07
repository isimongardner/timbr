using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Timbr.Services;
using Timbr.Views.Items;

namespace Timbr.Views
{
    public class CreateTaskView : ApplicationView, INotifyPropertyChanged
    {
        private readonly IProjectService _projectService;
        public ObservableCollection<ProjectItem> Projects { get; set; }
        public ProjectItem SelectedProject { get; set; }
        public string TaskName { get; set; }
        public int NumberOfDays { get; set; }
        public decimal NumberOfHours { get; set; }

        public CreateTaskView(IProjectService projectService)
        {
            _projectService = projectService;
            InitializeAsync();
        }

        public async void InitializeAsync()
        {
            Projects = await _projectService.FetchProjectItems();
        }

        public void CreateTask()
        {
            _projectService.CreateTask(TaskName, SelectedProject.Id, NumberOfDays);
        }
    }
}