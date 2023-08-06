namespace BlazorECommerce.Server.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync(string id);
        T GetById(string id);
        IQueryable<T> GetAll();
        Task<T> CreateAsync(T entity);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
