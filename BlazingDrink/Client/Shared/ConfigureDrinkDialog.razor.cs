using BlazingDrink.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingDrink.Client.Shared
{
	public partial class ConfigureDrinkDialog
	{
		#region Servivios
		[Inject]
		public HttpClient HttpClient { get; set; }
		#endregion
		#region Parametros
		[Parameter]
		public Drink Drink { get; set; }
		#endregion
		#region Variables
		IEnumerable<Topping> Toppings;
		#endregion
		#region Overrides
		protected async override Task OnInitializedAsync()
		{
			Toppings = await HttpClient.GetFromJsonAsync<IEnumerable<Topping>>("toppings");
		}
		#endregion
	}
}
