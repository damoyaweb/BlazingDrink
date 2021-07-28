using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDrink.Shared
{
	public class DrinkTopping
	{
		public Topping Topping { get; set; }
		public int ToppingId { get; set; }
		public int DrinkId { get; set; }
	}
}
