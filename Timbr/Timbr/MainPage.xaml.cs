using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timbr.Views.Items;
using Xamarin.Forms;

namespace Timbr
{
	public partial class MainPage : ContentPage
	{
        private List<ProjectItem> _projects;

		public MainPage()
		{
			InitializeComponent();
            Initialize();
		}

        public async void Initialize()
        {
            _projects = new List<ProjectItem>();

            var projects = await App.Database.FetchProjects();

            foreach(var project in projects)
            {
                _projects.Add(new ProjectItem { Id = project.Id, Name = project.Name, StartDate = project.StartDate });
            }

            ProjectView.ItemsSource = _projects;
        }

        private async void OnCreateProjectClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateProjectPage());
        }

        private async void OnCreateTaskClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateTaskPage());
        }

    }
}
