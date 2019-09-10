using System.Collections.Generic;

namespace Winap.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        
        T Get(string id);

        void Create(T entity);
        
        void Update(T entity);
        
        void Delete(string id);
    }
}