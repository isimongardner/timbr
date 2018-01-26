using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timbr.Data;
using Timbr.Interfaces;
using Xamarin.Forms;

namespace Timbr
{
	public partial class App : Application
	{
        private static Database _database;

		public App ()
		{
			InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
			//MainPage = new Timbr.MainPage();
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

        public static Database Database
        {
            get
            {
                if (_database == null)
                    _database = new Database(DependencyService.Get<IFileHelper>().GetLocalFilePath("Timbr.db3"));

                return _database;
            }
        }
	}
}
