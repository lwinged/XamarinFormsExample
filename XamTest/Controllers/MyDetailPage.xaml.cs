using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTest
{
	public partial class MyDetailPage : ContentPage
	{
		public MyDetailPage (String name)
		{
			InitializeComponent ();
			nameLabel.Text = "HELLO : " + name;
		}
			
		async void OnClicked(object sender, EventArgs args) {
			spinner.IsRunning = true;
			resultLabel.Text = await WebService.getStrData ();
			spinner.IsRunning = false;

		}
	}
}

