namespace netcoreTodoList.Context
{
    using BE;
    using Microsoft.EntityFrameworkCore;
    

    public class TodoContext
        : DbContext
    {
        public TodoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<TaskDiariesModel> Tasks { get; set; }
    }
}
