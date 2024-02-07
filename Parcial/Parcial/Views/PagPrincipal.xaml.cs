using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagPrincipal : ContentPage
    {
        public PagPrincipal()
        {
            InitializeComponent();
        }
        private async void Agregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reservaciones());
        }
        private async void Reservacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagReservacion());
        }
        
            
    }
}