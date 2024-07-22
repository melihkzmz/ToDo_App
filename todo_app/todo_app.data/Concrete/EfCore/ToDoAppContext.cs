using Microsoft.EntityFrameworkCore;
using todo_app.entity;

namespace todo_app.data.Concrete.EfCore
{
    public class ToDoAppContext: DbContext
    {

        public DbSet<Tasks> Tasks {get; set;}
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=todo.db");
            }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<ProductCategory>()
        //         .HasKey(c => new { c.CategoryId, c.ProductId });
        // }
        
    }
}