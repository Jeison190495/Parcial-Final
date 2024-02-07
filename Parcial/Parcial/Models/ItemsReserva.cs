using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace Parcial.Models
{
    public class ItemsReserva
    {
       

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cantidad { get; set; }
        public DateTime Date { get; set; }
        public  TimeSpan Time { get; set; }
    }
}