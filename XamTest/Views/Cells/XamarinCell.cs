using System;
using Xamarin.Forms;

namespace XamTest
{
	public class XamarinCell : ViewCell
	{
		public XamarinCell()
		{
			View = new XamarinCellContentView();
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

