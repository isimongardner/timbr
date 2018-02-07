using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Timbr.Services;
using Timbr.Views.Items;

namespace Timbr.Views
{
    public class MainView : ApplicationView, INotifyPropertyChanged
    {
        private readonly IProjectService _projectService;

        public ObservableCollection<ProjectItem> Projects { get; set; }

        public string SomeThing { get; set; }

        public MainView(IProjectService projectService)
        {
            _projectService = projectService;
            Update();
        }

        public async void Update()
        {
            Projects = await _projectService.FetchProjectItems();
            OnPropertyChanged("Projects");
        }
    }
}
