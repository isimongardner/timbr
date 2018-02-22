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
        private CreateProjectView View { get { return (CreateProjectView)this.BindingContext; } }

        public CreateProjectPage(CreateProjectView view)
        {
            InitializeComponent();
            this.BindingContext = view;
        }

        private async void OnCreateProjectClick(object sender, EventArgs e)
        {
            View.Create();

            await DisplayAlert("Created", string.Format("Project {0} created", View.ProjectName), "Ok");

            await Navigation.PopToRootAsync(true);
        }
    }
}