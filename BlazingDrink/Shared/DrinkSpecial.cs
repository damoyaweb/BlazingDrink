using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDrink.Shared
{
	public class DrinkSpecial
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public decimal PrecioBase { get; set; }
		public string Descripcion { get; set; }
		public string ImageUrl { get; set; }
		public string GetFormattedPrecioBase() => PrecioBase.ToString("0.00");
	}
}
