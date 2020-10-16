using PlacarBrasileirao.Repository;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlacarBrasileirao
{
    public partial class App : Application
    {
        private static PlacarDatabase dataBase;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static PlacarDatabase Database
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new PlacarDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PlacarSQLite.db3"));
                }

                return dataBase;
            }
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
