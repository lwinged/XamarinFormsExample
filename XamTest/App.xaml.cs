﻿using System;

using Xamarin.Forms;

namespace XamTest
{
	public partial class App : Application
	{
		public static int ScreenWidth;
		public static int ScreenHeight;

		public App()
		{
			InitializeComponent();
			// The root page of your application
			MainPage = new MyRootPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

