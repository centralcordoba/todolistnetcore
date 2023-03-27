using BE;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcoreTodoList.Context;


namespace netcoreTodoList.Controllers
{
    public class TodoTaskController : ControllerBase

    {

        private TodoContext _todoTaskContext;

        public TodoTaskController(TodoContext todoTaskContext)
        {
            _todoTaskContext = todoTaskContext;
        }

        [HttpGet]
        public IEnumerable<TaskDiariesModel> Get()
        {
            return _todoTaskContext.Tasks;
        }

        [HttpPost]
        public void Post([FromBody] TaskDiariesModel value)
        {
            var validator = new TaskDiariesModelValidator();
            ValidationResult result = validator.Validate(value);
            if (result.IsValid)
            {
                _todoTaskContext.Tasks.Add(value);
                _todoTaskContext.SaveChanges();
            }
           
        }

       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TaskDiariesModel value)
        {
            var taskDiaries = _todoTaskContext.Tasks.FirstOrDefault(s => s.TaskId == id);
            if (taskDiaries != null)
            {
                _todoTaskContext.Entry<TaskDiariesModel>(taskDiaries).CurrentValues.SetValues(value);
                _todoTaskContext.SaveChanges();
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _todoTaskContext.Tasks.FirstOrDefault(s => s.TaskId == id);
            if (student != null)
            {
                _todoTaskContext.Tasks.Remove(student);
                _todoTaskContext.SaveChanges();
            }
        }
    }
}
