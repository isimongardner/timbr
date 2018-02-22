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
        private CreateTaskView View { get { return (CreateTaskView)this.BindingContext; } }

        public CreateTaskPage(CreateTaskView view)
        {
            InitializeComponent();
            this.BindingContext = view;
        }

        protected override void OnAppearing()
        {
            View.Update();
        }

        private async void OnCreateTaskClick(object sender, EventArgs e)
        {
            View.Create();

            await DisplayAlert("Created", string.Format("Task {0} created", View.TaskName), "Ok");
            await Navigation.PopToRootAsync(true);
        }
    }
}