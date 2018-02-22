using Autofac;
using System;
using Timbr.Views;
using Xamarin.Forms;

namespace Timbr
{
    public partial class MainPage : ContentPage
    {
        private MainView View { get { return (MainView)this.BindingContext; } }

        public MainPage(MainView view)
        {
            InitializeComponent();
            this.BindingContext = view;
        }

        protected override void OnAppearing()
        {
            View.Update();
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