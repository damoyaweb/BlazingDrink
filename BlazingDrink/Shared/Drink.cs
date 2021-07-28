using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDrink.Shared
{
	public class Drink
	{
        public const int DefaultSize = 700;
        public const int MinimumSize = 350;
        public const int MaximumSize = 750;
        public const int IncrementSize = 50;

        public int Id { get; set; }

        public int OrdenId { get; set; }

        public DrinkSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Size { get; set; }

        public List<DrinkTopping> Toppings { get; set; }

        public decimal GetPrecioBase()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.PrecioBase;
        }

        public decimal GetPrecioTotal()
        {
            return GetPrecioBase() + Toppings.Sum(t => t.Topping.Precio);
        }

        public string GetFormattedTotalPrice()
        {
            return GetPrecioTotal().ToString("0.00");
        }
    }
}
