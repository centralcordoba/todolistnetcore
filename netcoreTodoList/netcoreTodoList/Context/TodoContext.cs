namespace netcoreTodoList.Context
{
    using Microsoft.EntityFrameworkCore;

    public class TodoContext
        : DbContext
    {
        public TodoContext(DbContextOptions options)
            : base(options)
        {

        }


        public DbSet<Task> Tasks { get; set; }
    }
}
