using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timbr.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timbr
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateTaskPage : ContentPage
	{
        private readonly CreateTaskView _view;
		public CreateTaskPage ()
		{
			InitializeComponent ();
            this.BindingContext = _view = new CreateTaskView();

        }

        private async void OnCreateTaskClick(object sender, EventArgs e)
        {

        }
    }
}