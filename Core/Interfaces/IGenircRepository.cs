using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenircRepository<T> where T : class
    {
        Task<IEnumerable<T>> GettAll();

        Task<T> GetById(object id);

        Task Add(T entity);

        void Update(T entity);

        Task Remove(object id);
    }
}