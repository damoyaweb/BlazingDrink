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
	[Route("special")]
	[ApiController]
	public class SpecialsController : ControllerBase
	{
		private readonly DrinkStoreContext Context;
		public SpecialsController(DrinkStoreContext context) =>
			Context = context;
		
		[HttpGet]
		public async Task<ActionResult<List<DrinkSpecial>>> GetSpecial()
		{
			return await Context.Specials
				.OrderByDescending(s => s.PrecioBase).ToListAsync();
		}


	}
}
