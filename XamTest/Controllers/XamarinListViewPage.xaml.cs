using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamTest
{
	public partial class XamarinListViewPage : ContentPage
	{
		private ObservableCollection<PersonViewModel> _rows = null;

		public XamarinListViewPage()
		{
			InitializeComponent();

			var lorem = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un peintre anonyme assembla ensemble des morceaux de";

			var list = new List<Person>() {
				//currentText = short or long context
				new Person { Age = 2, Name = "toto", CurrentText = "toto"},
				new Person { Age = 4, Name = "tutu", CurrentText = "tutu"},
				new Person { Age = 3, Name = "tes", CurrentText = "tes"},
			};

			//prepare view Model

			//var viewmodels = new List<PersonViewModel>() {
			//		new PersonViewModel {CurrentText = "My current text first"},
			//		new PersonViewModel {CurrentText = "My current text second"},
			//	};

			_rows = new ObservableCollection<PersonViewModel>() { 
				new PersonViewModel(list),
				new PersonViewModel(list),
			};

			mylistview.ItemsSource = _rows;
			mylistview.ItemTemplate = new DataTemplate(typeof(XamarinViewCell));

			var i = 0;
			mylistview.ItemTapped += (sender, e) => {
				var vm = e.Item as PersonViewModel;

				if (vm != null)
				{
					var index = _rows.IndexOf(vm);

					var l = vm.PersonList;

					if (i % 2 == 0) {
						l[0].CurrentText = lorem;
						l[1].CurrentText = lorem;
						_rows[index] = new PersonViewModel(l);
					}
					else {
						l[0].CurrentText = l[0].Name;
						l[1].CurrentText = l[1].Name;
						_rows[index] = new PersonViewModel(l);
					}
			
					++i;
				}

				//mylistview.ItemsSource = list;
				//mylistview.ItemTemplate = new DataTemplate(typeof(XamarinViewCell));

			};

		}
	}
}

