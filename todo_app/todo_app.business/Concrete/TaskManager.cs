using todo_app.entity;
using System.Collections.Generic;
using todo_app.data.Concrete.EfCore;
using todo_app.business.Abstract;
using todo_app.data.Abstract;
namespace todo_app.business.Concrete
{

    public class TaskManager : ITaskService        
    {
        private ITaskRepository _taskRepository;

        public TaskManager(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public void Create(Tasks entity)
        {
            _taskRepository.Create(entity);
        }

        public void Delete (Tasks entity)
        {

            _taskRepository.Delete(entity);
        }

        public List<Tasks> GetAll()
        {
                return _taskRepository.GetAll();
        }

        public Tasks GetById(int id)
        {
                return _taskRepository.GetById(id);

        }

    }


}