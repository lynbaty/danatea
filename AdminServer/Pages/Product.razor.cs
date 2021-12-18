using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Dtos.Store;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace AdminServer.Pages
{
    public partial class Product
    {
        
        [Inject] private  HttpClient _httpClient {set; get;}
        [Inject] private  IConfiguration _config {set; get;}
        public IReadOnlyList<ProductDto> Products { get; set; }

        public async Task LoadProduct()
        {
            Products = await _httpClient.GetFromJsonAsync<IReadOnlyList<ProductDto>>("product");
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadProduct();
        }
   
    }
}