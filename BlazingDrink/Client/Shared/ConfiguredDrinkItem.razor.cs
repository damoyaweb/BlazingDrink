using BlazingDrink.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDrink.Client.Shared
{
	public partial class ConfiguredDrinkItem
	{
		[Parameter]
		public Drink Drink { get; set; }

		[Parameter]
		public EventCallback OnRemoved { get; set; }



	}
}
