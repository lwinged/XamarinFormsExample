using System;
using System.ComponentModel;

namespace XamTest
{
	public class PersonViewModel : INotifyPropertyChanged
	{

		string currentText;

		public event PropertyChangedEventHandler PropertyChanged;

		public PersonViewModel()
		{
			currentText = "my current text";
		}


		public string CurrentText
		{
			set
			{
				if (currentText != value)
				{
					currentText = value;

					if (PropertyChanged != null)
					{
						PropertyChanged(this,
							new PropertyChangedEventArgs("CurrentText"));
					}
				}
			}
			get
			{
				return currentText;
			}
		}

	}
}

