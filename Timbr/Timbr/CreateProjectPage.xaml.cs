using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Timbr.Views;

namespace Timbr
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateProjectPage : ContentPage
	{
        private readonly CreateProjectView _view;
        public CreateProjectPage ()
		{
			InitializeComponent ();
            this.BindingContext = _view = new CreateProjectView();
		}

        private async void OnCreateProjectClick(object sender, EventArgs e)
        {
            await App.Database.CreateProject(new Entities.Project
            {
                Name = _view.ProjectName,
                StartDate = _view.ProjectStartDate,
                EstimatedEndDate = _view.ProjectEstimatedEndDate
            });

            await DisplayAlert("Created", string.Format("Project {0} created", _view.ProjectName), "Ok");

            await Navigation.PopToRootAsync(true);
        }
    }
}