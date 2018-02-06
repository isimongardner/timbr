using System;
using Timbr.Views;
using Xamarin.Forms;
using Autofac;

namespace Timbr
{
    public partial class MainPage : ContentPage
    {
        private MainView _view;

        public MainPage(MainView view)
        {
            InitializeComponent();

            _view = view;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ProjectView.ItemsSource = _view.Projects;
        }

        private async void OnCreateProjectClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Dependencies.Resolve<CreateProjectPage>());
        }

        private async void OnCreateTaskClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Dependencies.Resolve<CreateTaskPage>());
        }

    }
}
