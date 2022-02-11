using System;
using WorkApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
