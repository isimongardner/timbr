using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timbr.Data;
using Timbr.Interfaces;
using Timbr.Views;
using Xamarin.Forms;

namespace Timbr
{
	public partial class App : Application
	{
        public static IContainer Dependencies { get; private set; }

        public App (ApplicationSetup setup)
		{
			InitializeComponent();

            Dependencies = setup.InitializeContainer();

            MainPage = new NavigationPage(App.Dependencies.Resolve<MainPage>());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
