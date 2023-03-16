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
       
    }
}
