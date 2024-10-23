using System.Linq.Expressions;

namespace AspNetCoreMvc_GenericRepository.Interfaces
{
    public interface IGenericRepository<T> where T : class, new()
    {
        List<T> GetAll();

        T Get(Expression<Func<T, bool>> filter);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
