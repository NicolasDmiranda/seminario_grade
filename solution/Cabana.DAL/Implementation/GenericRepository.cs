using Cabana.DAL.Interfaces;
using Cabana.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Cabana.DAL.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal cabanasContext _context;
        internal DbSet<T> table;

        public GenericRepository()
        {
            _context = new cabanasContext();
            table = _context.Set<T>();
        }

        public IQueryable<T> GetByCriteria(
            Expression<Func<T, bool>> filter,
            string includeProperties = "")
        {
            IQueryable<T> query = table;

            query = query.Where(filter);

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query;
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public T Insert(T obj)
        {
            table.Add(obj);

            return obj;
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}