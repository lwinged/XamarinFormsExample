using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamTest
{
	public partial class XamarinStackView : StackLayout
	{
		public XamarinStackView(Person p)
		{
			InitializeComponent();
			BindingContext = p;
			btn.BackgroundColor = Color.Fuchsia;
		}
	}
}

