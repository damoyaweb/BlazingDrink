using BlazingDrink.Server.Models;
using BlazingDrink.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDrink.Server.Controllers
{
	[Route("toppings")]
	[ApiController]
	public class ToppingsController : ControllerBase
	{
		private readonly DrinkStoreContext Context;
		public ToppingsController(DrinkStoreContext context)
		{
			Context = context;
		}
		[HttpGet]
		public async Task<ActionResult<List<Topping>>> GetToppings()
		{
			return await Context.Toppings
				.OrderBy(t => t.Nombre).ToListAsync();
		}
	}
}
