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

            var Toppings = new Topping[]
            {
                new Topping()
                {
                    Nombre = "Extra cheese",
                    Precio = 2.50m,
                },
                new Topping()
                {
                    Nombre = "American bacon",
                    Precio = 2.99m,
                },
                new Topping()
                {
                    Nombre = "British bacon",
                    Precio = 2.99m,
                },
                new Topping()
                {
                    Nombre = "Canadian bacon",
                    Precio = 2.99m,
                },
                new Topping()
                {
                    Nombre = "Tea and crumpets",
                    Precio = 5.00m
                },
                new Topping()
                {
                    Nombre = "Fresh-baked scones",
                    Precio = 4.50m,
                },
                new Topping()
                {
                    Nombre = "Bell peppers",
                    Precio = 1.00m,
                },
                new Topping()
                {
                    Nombre = "Onions",
                    Precio = 1.00m,
                },
                new Topping()
                {
                    Nombre = "Mushrooms",
                    Precio = 1.00m,
                },
                new Topping()
                {
                    Nombre = "Pepperoni",
                    Precio = 1.00m,
                },
                new Topping()
                {
                    Nombre = "Duck sausage",
                    Precio = 3.20m,
                },
                new Topping()
                {
                    Nombre = "Venison meatballs",
                    Precio = 2.50m,
                },
                new Topping()
                {
                    Nombre = "Served on a silver platter",
                    Precio = 250.99m,
                },
                new Topping()
                {
                    Nombre = "Lobster on top",
                    Precio = 64.50m,
                },
                new Topping()
                {
                    Nombre = "Sturgeon caviar",
                    Precio = 101.75m,
                },
                new Topping()
                {
                    Nombre = "Artichoke hearts",
                    Precio = 3.40m,
                },
                new Topping()
                {
                    Nombre = "Fresh tomatoes",
                    Precio = 1.50m,
                },
                new Topping()
                {
                    Nombre = "Basil",
                    Precio = 1.50m,
                },
                new Topping()
                {
                    Nombre = "Steak (medium-rare)",
                    Precio = 8.50m,
                },
                new Topping()
                {
                    Nombre = "Blazing hot peppers",
                    Precio = 4.20m,
                },
                new Topping()
                {
                    Nombre = "Buffalo chicken",
                    Precio = 5.00m,
                },
                new Topping()
                {
                    Nombre = "Blue cheese",
                    Precio = 2.50m,
                },
            };

            context.Specials.AddRange(Specials);
            context.Toppings.AddRange(Toppings);
			context.SaveChanges();
		}
	}
}
