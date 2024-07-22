using System.Collections.Generic;

namespace todo_app.data.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Delete(T entity);

    }
}