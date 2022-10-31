using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuLateralDemo.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void btnAcerca_Clicked(object sender, EventArgs e)
        {
            App.MasterDetaller.IsPresented = false;
            await App.MasterDetaller.Detail.Navigation.PushAsync(new Acercade());
        }

        private async void btnVentas_Clicked(object sender, EventArgs e)
        {
            App.MasterDetaller.IsPresented = false;
            await App.MasterDetaller.Detail.Navigation.PushAsync(new Ventas());
        }
    }
}