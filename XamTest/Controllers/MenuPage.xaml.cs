using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTest
{
	public partial class MenuPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MenuPage ()
		{
			InitializeComponent ();

			var list = new List<MasterPageItem> ();
			list.Add(new MasterPageItem{ Title = "Home", TargetType = typeof(MyPage) });
			list.Add(new MasterPageItem{ Title = "Listview", TargetType = typeof(ListDataPage) });
			list.Add(new MasterPageItem{ Title = "Storage", TargetType = typeof(StoragePage) });

			listView.ItemsSource = list;

		}
	}
}

