using BlazingDrink.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingDrink.Client.Pages
{
	public partial class Index
	{
		#region Servicios
		[Inject]
        public HttpClient HttpClient { get; set; }
		#endregion

		#region Variables
		List<DrinkSpecial> Specials;
        Drink ConfiguringDronk;
        bool ShowingConfigureDialog;
		#endregion

		#region Overrides
		protected async override Task OnInitializedAsync()
        {
            Specials = await HttpClient
            .GetFromJsonAsync<List<DrinkSpecial>>("special");
        }
		#endregion

		#region Métodos
		void ShowConfigureDrinkDialog(DrinkSpecial special)
		{
			ConfiguringDronk = new Drink()
			{
				Special = special,
				SpecialId = special.Id,
				Size = Drink.DefaultSize,
				Toppings = new List<DrinkTopping>()
			};
			ShowingConfigureDialog = true;
		}

		#endregion


	}
}