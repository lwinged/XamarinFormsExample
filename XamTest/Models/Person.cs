using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamTest
{
	
	public class Person : INotifyPropertyChanged
	{
		public delegate void MediaEventHandler(object sender, EventArgs args);

		public event MediaEventHandler ButtonClicked;

		private String _name { get; set; }
		public int Age { get; set; }
		public bool IsExpanded { get; set; }


		public void DoMyAction()
		{
			if (ButtonClicked != null)
			{
				ButtonClicked(this, null);
			}
		}

		public String Name
		{
			get
			{
				return (_name);
			}

			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName]string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

