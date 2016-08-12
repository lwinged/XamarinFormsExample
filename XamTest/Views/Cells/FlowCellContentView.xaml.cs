using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamTest
{
	public partial class FlowCellContentView : ContentView
	{
		Person _viewModel;

		public FlowCellContentView()
		{
			InitializeComponent();
		}

		void OnClickedInView(object sender, EventArgs e)
		{
			Debug.WriteLine("CLICK IN VIEW");

			_viewModel.DoMyAction();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();


			 _viewModel = BindingContext as Person;

			if (_viewModel != null)
			{
			
			}
		}
	}
}

