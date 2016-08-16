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

			rootStack.Children.Add(new XamarinStackView());
			rootStack.Children.Add(new XamarinStackView());
		}
	}
}

