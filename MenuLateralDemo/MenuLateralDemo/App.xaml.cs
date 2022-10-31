using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuLateralDemo
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetaller{ get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Vistas.Contenedor();
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
