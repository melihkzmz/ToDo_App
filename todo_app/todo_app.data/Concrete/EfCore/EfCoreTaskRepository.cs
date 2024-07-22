using todo_app.data.Abstract;
using todo_app.entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace todo_app.data.Concrete.EfCore
{

    public class EfCoreTaskRepository: EfCoreGenericRepository<Tasks,ToDoAppContext>,ITaskRepository
    {
        
    }


}