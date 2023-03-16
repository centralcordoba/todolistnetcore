namespace netcoreTodoList.Context
{
    using Microsoft.EntityFrameworkCore;
    using netcoreTodoList.Models;

    public class TodoContext
        : DbContext
    {
        public TodoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<TaskDiaries> Tasks { get; set; }
    }
}
