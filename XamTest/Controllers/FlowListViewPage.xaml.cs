using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace XamTest
{
	public partial class FlowListViewPage : ContentPage
	{
		private ObservableCollection<Person> _rows;

		public FlowListViewPage()
		{
			InitializeComponent();
			FlowListView.Init();

			var lorem = "BEGIN. Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un peintre anonyme assembla ensemble des morceaux de textes. END";

			ITextMeter textMeter = DependencyService.Get<ITextMeter>();
			int testAge = (int)textMeter.MeasureTextSize("test", App.ScreenWidth / 2.0, 20.0, null) + 30;
			int loremAge = (int)textMeter.MeasureTextSize(lorem, App.ScreenWidth / 2.0, 20.0, null) + 30;

			var list = new List<Person>() {
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = testAge, Name = "test"},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
				new Person { Age = loremAge, Name = lorem},
			};

			_rows = new ObservableCollection<Person>(list);


			var flView = new FlowListView()
			{
				BackgroundColor = Color.Green,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				SeparatorVisibility = SeparatorVisibility.Default,
				HasUnevenRows = true,
				FlowColumnsTemplates = new List<FlowColumnTemplateSelector>() {
					new FlowColumnSimpleTemplateSelector() { ViewType = typeof(FlowCellContentView) },
					new FlowColumnSimpleTemplateSelector() { ViewType = typeof(FlowCellContentView) },


				},
			};

			flView.FlowItemsSource = _rows;
			flView.FlowItemTapped += (sender, e) =>
			{
				var oldPerson = e.Item as Person;

				if (oldPerson != null)
				{
					var index = _rows.IndexOf(oldPerson);
					var nextIndex = index + 1;

					var newPerson = new Person();

					if (oldPerson.IsExpanded)
					{
						var collapsed = "Collapsed";
						int testCollapsed = (int)textMeter.MeasureTextSize(collapsed, App.ScreenWidth / 2.0, 20.0, null) + 30;
						newPerson.Name = collapsed;
						newPerson.Age = testCollapsed;
					}
					else {
						var expanded = "Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded Expanded";
						int testExpanded = (int)textMeter.MeasureTextSize(expanded, App.ScreenWidth / 2.0, 20.0, null) + 30;
						newPerson.Name = expanded;
						newPerson.Age = testExpanded;
					}
					newPerson.IsExpanded = !oldPerson.IsExpanded;
					_rows[index] = newPerson;
					_rows[nextIndex] = newPerson;
				}
			};

			Content = flView;
		}

	}
}

