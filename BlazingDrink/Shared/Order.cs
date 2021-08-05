using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDrink.Shared
{
	public class Order
	{
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public LatLong DeliveryLocation { get; set; }

        public List<Drink> Drinks { get; set; } = new List<Drink>();

        public decimal GetPrecioTotal() => Drinks.Sum(p => p.GetPrecioTotal());

        public string GetFormattedTotalPrice() => GetPrecioTotal().ToString("0.00");
    }
}
