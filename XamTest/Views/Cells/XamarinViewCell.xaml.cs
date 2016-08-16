using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamTest
{
	public partial class XamarinViewCell : ViewCell
	{
		public XamarinViewCell()
		{
			InitializeComponent();


		}
	
		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			var vm = BindingContext as PersonViewModel;
			if (vm != null) {

				rootStack.Children.Add(new XamarinStackView(vm.PersonList[0]));
				rootStack.Children.Add(new XamarinStackView(vm.PersonList[1]));
			}
		}
	}

}

