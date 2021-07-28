using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDrink.Shared
{
	public class Topping
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public decimal Precio { get; set; }
		public string GetFormattedPrice() => Precio.ToString("0.00");
	}
}
