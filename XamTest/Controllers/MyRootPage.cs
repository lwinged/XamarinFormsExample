using System;

using Xamarin.Forms;

namespace XamTest
{
	public class MyRootPage : MasterDetailPage
	{
		MenuPage masterPage;

		public MyRootPage ()
		{
			masterPage = new MenuPage ();
			masterPage.ListView.ItemSelected += OnItemSelected;

			Master = masterPage;
			Detail = new NavigationPage(new XamarinListViewPage ());
		}

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null) {
				Detail = new NavigationPage ((Page)Activator.CreateInstance (item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}


