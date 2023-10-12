using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZatemtkiEnd
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "ZametkiVAR.db";
        public static ZametkiSQL database;
        public static ZametkiSQL Database
        {
            get
            {
                if (database == null)
                {
                    database = new ZametkiSQL(
                       Path.Combine(
                           Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
