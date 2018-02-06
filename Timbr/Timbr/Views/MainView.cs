using System.Collections.ObjectModel;
using Timbr.Services;
using Timbr.Views.Items;

namespace Timbr.Views
{
    public class MainView
    {
        private readonly IProjectService _projectService;
        public ObservableCollection<ProjectItem> Projects { get; set; }

        public MainView(IProjectService projectService)
        {
            _projectService = projectService;
            Initialize();
        }

        private async void Initialize()
        {
            Projects = await _projectService.FetchProjectItems();
        }
    }
}
