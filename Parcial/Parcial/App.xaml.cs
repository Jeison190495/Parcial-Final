using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Parcial.Views;
using Parcial.BaseDeDatos;

namespace Parcial
{
    public partial class App : Application
    {
        public static Datos Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatos();

            MainPage = new NavigationPage(new PagPrincipal());
        }
        private void InitializeDatos()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dbPath = System.IO.Path.Combine(folderApp, "Datos1.db3");
            Context = new Datos(dbPath);
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

