﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTest
{
	public partial class XamarinListViewPage : ContentPage
	{
		public XamarinListViewPage()
		{
			InitializeComponent();

			var lorem = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un peintre anonyme assembla ensemble des morceaux de";

			var list = new List<Person>() {
				new Person { Age = 2, Name = "test"},
				new Person { Age = 4, Name = "t66"},
				new Person { Age = 3, Name = "tes"},
				new Person { Age = 1, Name = "t6u"},
			};

			mylistview.ItemsSource = list;
			mylistview.ItemTemplate = new DataTemplate(typeof(XamarinCell));

			var i = 0;
			mylistview.ItemTapped += (sender, e) => {
				var person = e.Item as Person;

				if (i % 2 == 0)
					person.Name = lorem;
				else
					person.Name = "toto";

				++i;

				//mylistview.ItemsSource = list;
				mylistview.ItemTemplate = new DataTemplate(typeof(XamarinCell));
			};
				
		}
	}
}
