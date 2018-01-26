using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timbr.Views;
using Timbr.Views.Items;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timbr
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateTaskPage : ContentPage
	{
        private CreateTaskView _view;
		public CreateTaskPage ()
		{
			InitializeComponent ();
            Initialize();
        }

        private async void Initialize()
        {
             _view = new CreateTaskView();

            var projects = await App.Database.FetchProjects();

            foreach(var project in projects)
            {
                _view.Projects.Add(new ProjectItem { Id = project.Id, Name = project.Name, StartDate = project.StartDate });
            }

            this.BindingContext = _view;
        }

        private async void OnCreateTaskClick(object sender, EventArgs e)
        {
            await App.Database.CreateTask(new Entities.Task
            {
                Name = _view.TaskName,
                ProjectId = _view.SelectedProject.Id,
                NumberOfDays = _view.NumberOfDays
            });

            await DisplayAlert("Created", string.Format("Task {0} created", _view.TaskName), "Ok");
            await Navigation.PopToRootAsync(true);
        }
    }
}