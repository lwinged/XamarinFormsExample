using System;
using System.Diagnostics;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace XamTest
{
	public partial class FlowCellContentView : ContentView
	{
		public FlowCellContentView()
		{
			InitializeComponent();
		}

		public void OnTapped()
		{

		}

		public void Expand_Clicked(object sender, EventArgs e)
		{
			Debug.WriteLine("Clicked");
			/*var person = (Person)this.BindingContext;
			person.Name = "New person name";
			person.Age = 3;*/


		}

		//protected override void OnBindingContextChanged()
		//{
		//	base.OnBindingContextChanged();


		//	 _viewModel = BindingContext as Person;

		//	if (_viewModel != null)
		//	{

		//	}
		//}
	}
}

