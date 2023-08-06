namespace BlazorECommerce.Server.Repositories.Impl
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public ApplicationContext _context { get; }

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(string id)
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
