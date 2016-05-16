using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTest
{
	public partial class ListDataPage : ContentPage
	{
		public ListDataPage ()
		{
			InitializeComponent ();

			this.setData ();
		}
			
		private async void setData()
		{
			listView.ItemsSource = await WebService.getDataItems ();
		}

	}
}

