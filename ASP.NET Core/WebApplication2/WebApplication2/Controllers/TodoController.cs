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
            new ToDoItem { Id = 1, Title = "Task 1", Completed = true },
            new ToDoItem { Id = 2, Title = "Task 2", Completed = false }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            if (_toDoItems.Count() == 0)
                return NotFound();

            var toDoItemDTOs = _toDoItems.Select(item => MapToDoItemToDTO(item)).ToList();

            return Ok(toDoItemDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (_toDoItems.Count() == 0)
                return NotFound();
            var item = _toDoItems.FirstOrDefault(i => i.Id == id);
            if (item == null)
                return NotFound();

            var toDoItemDTO = MapToDoItemToDTO(item);
            return Ok(toDoItemDTO);
        }

        private ToDoItemDTO MapToDoItemToDTO(ToDoItem item)
        {
            return new ToDoItemDTO
            {
                Id = item.Id,
                Title = item.Title,
                Completed = item.Completed
            };
        }
    }
}
