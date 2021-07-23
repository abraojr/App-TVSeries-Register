using System.Collections.Generic;

namespace app_Series_Register.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T GetById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int nextId();
    }
}
