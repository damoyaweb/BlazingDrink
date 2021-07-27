using BlazingDrink.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDrink.Server.Models
{
	public class DrinkStoreContext:DbContext
	{
		public DbSet<DrinkSpecial> Specials { get; set; }
		public DrinkStoreContext(DbContextOptions options) : base(options) { }
	}
}
