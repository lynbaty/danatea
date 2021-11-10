using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Specification;

namespace Core.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<T> GetbyIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetbyIdSpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAllSpecAsync(ISpecification<T> spec);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}