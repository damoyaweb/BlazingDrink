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
		[Parameter]
		public EventCallback onCancel { get; set; }
		[Parameter]
		public EventCallback onConfirm { get; set; }

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
		#region Metodos Auxiliares
		void AddTopping(Topping topping)
		{
			if (Drink.Toppings.Find(dt=>dt.Topping == topping) == null)
			{
				Drink.Toppings.Add(new DrinkTopping { Topping = topping });
			}
		}
		#endregion
		#region Manejadores de Enventos
		void ToppingSelected(ChangeEventArgs e)
		{
			int index = Convert.ToInt32(e.Value);
			AddTopping(Toppings.ElementAt(index));
		}
		void RemoveTopping(Topping topping)
		{
			Drink.Toppings.RemoveAll(dt => dt.Topping == topping);
		}
		#endregion
	}
}
