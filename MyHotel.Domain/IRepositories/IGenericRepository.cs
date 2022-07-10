using System.Collections.Generic;

namespace PlanBetter.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        IReadOnlyList<T> ListAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
