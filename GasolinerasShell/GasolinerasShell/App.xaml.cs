using GasolinerasShell.Data;
using GasolinerasShell.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GasolinerasShell
{
    public partial class App : Application
    {
        private static Databases _SQLiteDatabase;
        public static Databases SQLiteDatabase
        {
            get
            {
                if (_SQLiteDatabase == null) _SQLiteDatabase = new Databases();
                return _SQLiteDatabase;
            }
        }


        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new ShellListView());
            navPage.BarBackgroundColor = (Color)App.Current.Resources["Secondary"];
            navPage.BarTextColor = (Color)App.Current.Resources["Primary"];
            MainPage = navPage;


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
