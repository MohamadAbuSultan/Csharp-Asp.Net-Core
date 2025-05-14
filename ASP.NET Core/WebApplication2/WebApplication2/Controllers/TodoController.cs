using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TodoController : ControllerBase
    {
        private static List<ToDoItem> _toDoItems = new List<ToDoItem>
        {
            //new ToDoItem { Id = 1, Title = "Task 1", Completed = true },
            //new ToDoItem { Id = 2, Title = "Task 2", Completed = false }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            if (_toDoItems.Count() == 0)
                return NotFound();


            return Ok(_toDoItems);
        }

    }
}
