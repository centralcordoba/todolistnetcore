using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcoreTodoList.Context;
using netcoreTodoList.Models;

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
        public IEnumerable<TaskDiaries> Get()
        {
            return _todoTaskContext.Tasks;
        }

        [HttpPost]
        public void Post([FromBody] TaskDiaries value)
        {
            _todoTaskContext.Tasks.Add(value);
            _todoTaskContext.SaveChanges();
        }

       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TaskDiaries value)
        {
            var taskDiaries = _todoTaskContext.Tasks.FirstOrDefault(s => s.TaskId == id);
            if (taskDiaries != null)
            {
                _todoTaskContext.Entry<TaskDiaries>(taskDiaries).CurrentValues.SetValues(value);
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
