using System;
using System.Collections.Generic;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace XamTest
{
	public partial class FlowListViewPage : ContentPage
	{
		public FlowListViewPage()
		{
			InitializeComponent();

			var lorem = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un peintre anonyme assembla ensemble des morceaux de";

			var list = new List<Person>() {
				new Person { Age = 52, Name = "test"},
				new Person { Age = 45, Name = "t66"},
				new Person { Age = 55, Name = "tes"},
				new Person { Age = 51, Name = "t6u"},
				new Person { Age = 52, Name = "test"},
				new Person { Age = 45, Name = "t66"},
				new Person { Age = 55, Name = "tes"},
				new Person { Age = 51, Name = "t6u"},
				new Person { Age = 52, Name = "test"},
				new Person { Age = 45, Name = "t66"},
				new Person { Age = 55, Name = "tes"},
				new Person { Age = 51, Name = "t6u"},
				new Person { Age = 52, Name = "test"},
				new Person { Age = 45, Name = "t66"},
				new Person { Age = 55, Name = "tes"},
				new Person { Age = 51, Name = "t6u"},
				new Person { Age = 52, Name = "test"},
				new Person { Age = 45, Name = "t66"},
				new Person { Age = 55, Name = "tes"},
				new Person { Age = 51, Name = "t6u"},
			};

			var columnsTemplates = new List<FlowColumnTemplateSelector>();
			columnsTemplates.Add(new FlowColumnSimpleTemplateSelector() { ViewType = typeof(FlowCellContentView) });
			columnsTemplates.Add(new FlowColumnSimpleTemplateSelector() { ViewType = typeof(FlowCellContentView) });


			flView.FlowColumnsTemplates = columnsTemplates;
			flView.FlowItemsSource = list;

			var i = 0;
			flView.FlowItemTapped += (sender, e) =>
			{
				var items = ((FlowListView)sender);
				var person = e.Item as Person;

				if (i % 2 == 0)
				{
					person.Name = lorem;
					person.Age = 150;
				}
				else {
					person.Name = "toto";
					person.Age = 50;
				}

				++i;
				//flView.ItemTemplate = new DataTemplate(() => new FlowListViewInternalCell(new WeakReference<FlowListView>(flView)));
				flView.ForceReload();

			};

		}
	}
}

