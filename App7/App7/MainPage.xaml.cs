using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using System.Reflection;

namespace App7
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

    

        }


        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(),true);
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}
