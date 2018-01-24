using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Timbr
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
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
