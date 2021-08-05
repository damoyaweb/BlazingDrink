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
		public DbSet<Topping> Toppings { get; set; }
		public DbSet<Drink> Drinks { get; set; }
		public DbSet<Order> Orders { get; set; }


		public DrinkStoreContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DrinkTopping>()
				.HasKey(dt => new { dt.DrinkId, dt.ToppingId });

			modelBuilder.Entity<DrinkTopping>()
				.HasOne<Drink>().WithMany(dk => dk.Toppings);

			modelBuilder.Entity<DrinkTopping>()
				.HasOne(dt => dt.Topping).WithMany();

			modelBuilder.Entity<Order>()
				.OwnsOne(o => o.DeliveryLocation);
		}
	}
}
