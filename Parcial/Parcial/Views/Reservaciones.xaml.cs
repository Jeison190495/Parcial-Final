using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservaciones : ContentPage
    {
        public Reservaciones()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItems();
        }

        private async void LoadItems()
        {
            var items = await App.Context.GetItemsAsync();
            lista_tareas.ItemsSource = items;
        }

        private async void Agregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagReservacion());
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Confirmación", "¿Está seguro de querer borrar el elemento?", "Si", "No"))
            {
                var item = (ItemsReserva)(sender as MenuItem).CommandParameter;
                var result = await App.Context.DeleteItemAsync(item);
                if (result == 1)
                {
                    LoadItems();
                }

            }

        }
    }
}