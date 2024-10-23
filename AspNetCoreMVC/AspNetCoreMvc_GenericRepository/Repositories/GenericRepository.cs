using AspNetCoreMvc_GenericRepository.Data;
using AspNetCoreMvc_GenericRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AspNetCoreMvc_GenericRepository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly UrunlerDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(UrunlerDbContext context)
        {
            _context = context;         //arakatmanda veritabanına karşılık
            _dbSet = _context.Set<T>(); //arakatmanda çalışılan entity'ye karşılık
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
            //return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }
    }
}
