using BlazorECommerce.Shared;

namespace BlazorECommerce.Server.Repositories.Impl
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
