using System;
using System.Collections.Generic;
using System.Diagnostics;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace XamTest
{
	public partial class FlowListViewPage : ContentPage
	{
		public FlowListViewPage()
		{
			InitializeComponent();
			FlowListView.Init();

			var lorem = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un peintre anonyme assembla ensemble des morceaux de";

			var list = new List<Person>() {
				new Person { Age = 52, Name = "test"},
				new Person { Age = 45, Name = lorem},
				new Person { Age = 45, Name = lorem},
				new Person { Age = 55, Name = "tes"},
				new Person { Age = 51, Name = "t6u"},
			};


			var flView = new FlowListView()
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				SeparatorVisibility = SeparatorVisibility.None,
				HasUnevenRows = true,
				FlowColumnsTemplates = new List<FlowColumnTemplateSelector>() {
					// First column definition:
					new FlowColumnSimpleTemplateSelector() { ViewType = typeof(FlowCellContentView) },
					//new FlowColumnSimpleTemplateSelector() { ViewType = typeof(FlowCellContentView) },


				},
			};

			//flView.ItemTemplate = new DataTemplate(typeof(XamarinCell));


			//var columnsTemplates = new List<FlowColumnTemplateSelector>();
			////var f = new FlowColumnFuncTemplateSelector(new Func<object, Type>((bindingContext) => typeof(MyFlowCell)));

			//columnsTemplates.Add(new FlowColumnSimpleTemplateSelector() { ViewType = typeof(MyFlowCell) });

			//flView.HasUnevenRows = true;
			//flView.RowHeight = -1;
			//flView.FlowColumnsTemplates = columnsTemplates;
			flView.FlowItemsSource = list;

			Content = flView;
		}

	}
}

