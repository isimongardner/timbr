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
        private readonly CreateTaskView _view;

        public CreateTaskPage(CreateTaskView view)
        {
            _view = view;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = _view;
        }

        private async void OnCreateTaskClick(object sender, EventArgs e)
        {
            _view.CreateTask();

            await DisplayAlert("Created", string.Format("Task {0} created", _view.TaskName), "Ok");
            await Navigation.PopToRootAsync(true);
        }
    }
}