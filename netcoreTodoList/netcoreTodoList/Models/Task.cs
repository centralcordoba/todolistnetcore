namespace netcoreTodoList.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Task")]
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        

        public string TaskName { get; set; }

        public string DeadLine { get; set; }    

        
    }
}
