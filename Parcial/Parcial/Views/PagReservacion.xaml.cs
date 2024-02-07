using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Parcial.Models;
using Parcial.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Parcial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagReservacion : ContentPage
    {
        public PagReservacion()
        {
            InitializeComponent();
        }
        private async void Reservacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagReservacion());
        }

        private async void Reservar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var item = new ItemsReserva
                {
                    Name = nombre.Text,
                    Cantidad = Pax.Text,
                    Date = Fecha.Date,
                    Time = Hora.Time// Convierte el valor de TimePicker a string
                };
                var result = await App.Context.InsertItemAsyn(item);
                if (result == 1)
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo guardar la Reserva", "Aceptar");
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message, "Aceptar");
            }

        }
    }
}