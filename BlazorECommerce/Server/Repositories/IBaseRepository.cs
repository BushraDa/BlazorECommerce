namespace BlazorECommerce.Server.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(long id);
        T? GetById(long id);
        IQueryable<T> GetAll();
        Task CreateAsync(T entity);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
