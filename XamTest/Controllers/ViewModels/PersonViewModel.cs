using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace XamTest
{
	public class PersonViewModel : INotifyPropertyChanged
	{

		List<Person> _list;
		string currentText;

		public event PropertyChangedEventHandler PropertyChanged;

		public PersonViewModel(List<Person> list)
		{
			_list = list;
		}

		public List<Person> PersonList
		{
			set
			{
				if (_list != value)
				{
					_list = value;

					if (PropertyChanged != null)
					{
						PropertyChanged(this,
							new PropertyChangedEventArgs("PersonList"));
					}
				}
			}
			get
			{
				return _list;
			}
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

