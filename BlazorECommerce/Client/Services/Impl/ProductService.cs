using BlazorECommerce.Shared;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services.Impl
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetAll()
        {
            var data = await _http.GetFromJsonAsync<List<Product>>("api/Products");
            if (data != null)
                Products = data;
        }
    }
}
