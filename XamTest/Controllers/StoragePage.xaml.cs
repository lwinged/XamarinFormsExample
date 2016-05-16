using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTest
{
	public partial class StoragePage : ContentPage
	{
		public StoragePage ()
		{
			InitializeComponent ();
			this.setPreviousPerson ();
		}

		async void setPreviousPerson() {
			var person = await FileStorage.readFile<Person>();
			Content.BindingContext = person;
		}
		async void saveFile(object sender, EventArgs args) {

			var age = 0;
			Int32.TryParse (ageEntry.Text, out age);
			var person = new Person { Name = nameEntry.Text, Age = age };
			Content.BindingContext = person;

			await FileStorage.saveFile<Person>(person);
		}
	}
}

