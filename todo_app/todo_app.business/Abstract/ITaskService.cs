using todo_app.entity;
using System.Collections.Generic;


namespace todo_app.business.Abstract
{
    
    public interface ITaskService
    {
        Tasks GetById(int id);

        List<Tasks> GetAll();

        void Create(Tasks entity);

        void Delete(Tasks entity);

    }




}