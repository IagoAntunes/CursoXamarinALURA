using CursoXamarinALURA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarinALURA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListagemView());
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
