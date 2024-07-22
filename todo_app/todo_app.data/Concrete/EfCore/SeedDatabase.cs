using System.Linq;
using Microsoft.EntityFrameworkCore;
using todo_app.entity;

namespace todo_app.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ToDoAppContext();
            context.SaveChanges();
        }

  
    }
}