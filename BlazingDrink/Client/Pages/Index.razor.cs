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
        [Inject]
        public HttpClient HttpClient { get; set; }

        List<DrinkSpecial> Specials;

        protected async override Task OnInitializedAsync()
        {
            Specials = await HttpClient
            .GetFromJsonAsync<List<DrinkSpecial>>("special");
        }
    }
}