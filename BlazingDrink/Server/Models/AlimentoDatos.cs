using BlazingDrink.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDrink.Server.Models
{
	public static class AlimentoDatos
	{
		public static void Initialize(DrinkStoreContext context)
		{
			var Specials = new DrinkSpecial[]
			{
				new DrinkSpecial
				{
					Nombre = "101001",
					Descripcion = "VINO ALMAVIVA 750",
					PrecioBase = 150000,
					ImageUrl = "images/vinos/101001.jpg"
				},
				new DrinkSpecial
				{
					Nombre = "101002",
					Descripcion = "VINO DON MELCHOR  750",
					PrecioBase = 180000,
					ImageUrl = "images/vinos/101002.jpg"
				},
				new DrinkSpecial
				{
					Nombre = "101003",
					Descripcion = "VINO AMELIA CHARDONNAY  750",
					PrecioBase = 200000,
					ImageUrl = "images/vinos/101003.jpg"
				},
				new DrinkSpecial
				{
					Nombre = "101004-1",
					Descripcion = "VINO MARQUES CABERNET 750",
					PrecioBase = 130000,
					ImageUrl = "images/vinos/101004-1.jpg"
				},
				new DrinkSpecial
				{
					Nombre = "101005-1",
					Descripcion = "VINO MARQUES CHARDONNAY  750",
					PrecioBase = 220000,
					ImageUrl = "images/vinos/101005-1.jpg"
				}

			};
			context.Specials.AddRange(Specials);
			context.SaveChanges();
		}
	}
}
