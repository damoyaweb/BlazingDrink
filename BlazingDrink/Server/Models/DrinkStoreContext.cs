using Microsoft.EntityFrameworkCore;
using BlazingDrink.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDrink.Server.Models
{
	public class DrinkStoreContext:DbContext
	{
		public DbSet<DrinkSpecial> Special { get; set; }
		public DrinkStoreContext(DbContextOptions options) : base(options) { }

	}
}
