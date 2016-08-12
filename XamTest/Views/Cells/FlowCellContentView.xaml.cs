using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamTest
{
	public partial class FlowCellContentView : ContentView
	{
		public FlowCellContentView()
		{
			InitializeComponent();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();


			var _viewModel = BindingContext as Person;

			if (_viewModel != null)
			{

			}
		}
	}
}

