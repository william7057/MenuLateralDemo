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
    public partial class Contenedor : MasterDetailPage
    {
        public Contenedor()
        { 
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detalle());
            App.MasterDetaller = this;
        }
    }
}