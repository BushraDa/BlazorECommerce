using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.Services
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        public Task GetAll();
        public Task<Product?> GetOne(long id);
        public Task Create(Product product);
        public Task Update(Product product);
        public Task Delete(long id);
    }
}
