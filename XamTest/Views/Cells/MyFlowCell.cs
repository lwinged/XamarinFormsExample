using System;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace XamTest
{
	public class MyFlowCell : FlowViewCell
	{
		public MyFlowCell()
		{
			Content = new FlowCellContentView();
		}
	}
}

