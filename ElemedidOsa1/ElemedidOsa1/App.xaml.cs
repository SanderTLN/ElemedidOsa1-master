using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ElemedidOsa1.Services;
using ElemedidOsa1.Views;

namespace ElemedidOsa1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
