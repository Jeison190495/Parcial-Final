using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Parcial.Models;
using Xamarin.Forms;

namespace Parcial.BaseDeDatos
{
    public class Datos
    {
        public SQLiteAsyncConnection Connection { get; set; }

        public Datos(string path)
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<ItemsReserva>().Wait();
        }

        public async Task<int> InsertItemAsyn(ItemsReserva item)
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<List<ItemsReserva>> GetItemsAsync()
        {
            return await Connection.Table<ItemsReserva>().ToListAsync();
        }

        public async Task<int> DeleteItemAsync(ItemsReserva item)
        {
            return await Connection.DeleteAsync(item);
        }
    }
}
