using BlazingDrink.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
		public async Task<ActionResult<DrinkSpecial>>> GetSpecial()
		{

		}


	}
}
