using System.Linq.Expressions;

namespace Cabana.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetByCriteria(
            Expression<Func<T, bool>> filter,
            string includeProperties = "");

        IEnumerable<T> GetAll();

        T GetById(object id);

        T Insert(T entity);

        void Update(T obj);

        void Delete(object id);      

        void SaveChanges();
    }
}