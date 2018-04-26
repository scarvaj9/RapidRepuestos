﻿namespace RapidRepuestos
{
    using Xamarin.Forms;
    using Views;

    public partial class App : Application
	{
        
        public App ()
		{
			InitializeComponent();

            this.MainPage = new FiltroMotoPage();
		}


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
