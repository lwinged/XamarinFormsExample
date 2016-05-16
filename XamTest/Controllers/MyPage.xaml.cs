using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTest
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();
		}

		async void OnButtonClicked(object sender, EventArgs args) {
			
				//Passing Data through a Page Constructor
				var dp = new MyDetailPage (nameEntry.Text);

				//Passing Data through a BindingContext
				var person = new Person { Name = "toto" };
				dp.BindingContext = person;

				await Navigation.PushAsync (dp);
			
		}
	}
}

