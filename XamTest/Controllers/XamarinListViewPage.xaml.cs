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
				new Person { Age = 2, Name = lorem},
				new Person { Age = 4, Name = lorem},
				new Person { Age = 3, Name = "tes"},
				new Person { Age = 1, Name = "t6u"}
			};

			//prepare view Model

		//var viewmodels = new List<PersonViewModel>() {
		//		new PersonViewModel {CurrentText = "My current text first"},
		//		new PersonViewModel {CurrentText = "My current text second"},
		//	};

			_rows = new ObservableCollection<PersonViewModel>() { 
				new PersonViewModel {CurrentText = "My current text first"},
				new PersonViewModel {CurrentText = "My current text second"},
			};

			mylistview.ItemsSource = _rows;
			mylistview.ItemTemplate = new DataTemplate(typeof(XamarinViewCell));

			var i = 0;
			mylistview.ItemTapped += (sender, e) => {
				var vm = e.Item as PersonViewModel;

				if (vm != null)
				{
					var index = _rows.IndexOf(vm);

					if (i % 2 == 0)
						_rows[index] = new PersonViewModel { CurrentText = lorem };
					else 
						_rows[index] = new PersonViewModel { CurrentText = "My current text" };
			
					++i;
				}

				//if (i % 2 == 0)
				//	person.Name = lorem;
				//else
				//	person.Name = "toto";

				//++i;

				//list[3] = new Person { Age = person.Age, Name = person.Name};
				//mylistview.ItemsSource = list;
				//mylistview.ItemTemplate = new DataTemplate(typeof(XamarinViewCell));

			};

		}
	}
}

