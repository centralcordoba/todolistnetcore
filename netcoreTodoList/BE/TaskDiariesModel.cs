using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace BE
{
    [Table("TaskDiariesModel")]
    public class TaskDiariesModel
    {

        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }

        public string Status { get; set; }

        public string DeadLine { get; set; }

    }

    public class TaskDiariesModelValidator : AbstractValidator<TaskDiariesModel>
    {
        public TaskDiariesModelValidator()
        {
            RuleFor(x => x.TaskName).NotEmpty();
            RuleFor(x => x.Status).NotEmpty().MaximumLength(40);
            RuleFor(x => x.DeadLine).NotEmpty();

        }
    }
}