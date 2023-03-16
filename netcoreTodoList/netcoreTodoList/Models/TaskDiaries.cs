namespace netcoreTodoList.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TaskDiaries")]
    public class TaskDiaries
    {
       
        [Key]   
        public int TaskId { get; set; }
        public string TaskName { get; set; }

        public string Status { get; set; }

        public string DeadLine { get; set; }    

        
    }
}
