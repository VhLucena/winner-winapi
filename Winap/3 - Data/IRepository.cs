using System.Collections.Generic;

namespace Winap.Database
{
    public interface IRepository<T, K>
    {
        List<T> GetAll();
        
        T Get(K id);

        void Create(T entity);
        
        void Update(T entity);
        
        void Delete(K id);
    }
}