using ProyectoFinal_Movil.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using ProyectoFinal_Movil.DataBase;
using System.IO;

namespace ProyectoFinal_Movil
{
    public partial class App : Application
    {
        static DataBaseSQL database;


        public static DataBaseSQL Db
        {
            get
            {
                if (database == null)
                {
                    database = new DataBaseSQL(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBAPP.db"));
                }
                return database;

            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = MainPage = new NavigationPage(new Inicio());
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
