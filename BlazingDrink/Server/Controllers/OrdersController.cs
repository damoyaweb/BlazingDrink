using BlazingDrink.Server.Models;
using BlazingDrink.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDrink.Server.Controllers
{
	[Route("orders")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly DrinkStoreContext Context;
		public OrdersController(DrinkStoreContext context) =>
			Context = context;

        [HttpPost]
        public async Task<ActionResult<int>> PlaceOrder(Order order)
        {
            order.CreatedTime = DateTime.Now;
            order.DeliveryLocation = 
                new LatLong(51.5001, -0.1239);

            foreach (var Drink in order.Drinks)
            {
                Drink.SpecialId = Drink.Special.Id;
                Drink.Special = null;

                foreach (var topping in Drink.Toppings)
                {
                    topping.ToppingId = topping.Topping.Id;
                    topping.Topping = null;
                }
            }

            Context.Orders.Attach(order);
            await Context.SaveChangesAsync();

            return order.OrderId;
        }

    }
}
