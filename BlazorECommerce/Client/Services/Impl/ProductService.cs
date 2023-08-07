using BlazorECommerce.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services.Impl
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        private HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ProductService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public async Task GetAll()
        {
            await setProducts();
        }

        public async Task<Product?> GetOne(long id)
        {
            var data = await _http.GetFromJsonAsync<Product>($"api/Products/{id}");

            return data;
        }

        public async Task Create(Product product)
        {
            await _http.PostAsJsonAsync($"api/Products", product);
            await setProducts();
            NavigateToList();
        }

        public async Task Update(Product product)
        {
            await _http.PutAsJsonAsync($"api/Products/{product.Id}", product);
            await setProducts();
            NavigateToList();
        }

        public async Task Delete(long id)
        {
            await _http.DeleteAsync($"api/Products/{id}");
            await setProducts();
            NavigateToList();
        }

        private async Task setProducts()
        {
            var data = await _http.GetFromJsonAsync<List<Product>>("api/Products");
            if (data != null)
                Products = data;
        }

        private void NavigateToList()
        {
            _navigationManager.NavigateTo("/Products");
        }
    }
}
