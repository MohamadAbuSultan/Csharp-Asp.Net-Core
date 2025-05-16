using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class TodoController : ControllerBase
    {
        private static List<ToDoItem> _toDoItems = new List<ToDoItem>
        {
            new ToDoItem { Id = 1, Title = "Task 1", IsComplete = true },
            new ToDoItem { Id = 2, Title = "Task 2", IsComplete = false }
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

        [HttpPost]
        public IActionResult Create([FromBody] ToDoItemDTO toDoItemDTO)
        {
            if (toDoItemDTO == null)
                return BadRequest();

            var newItem = new ToDoItem
            {
                Id = _toDoItems.Max(i => i.Id) + 1,
                Title = toDoItemDTO.Title,
                IsComplete = toDoItemDTO.IsComplete
            };

            _toDoItems.Add(newItem);
            return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, MapToDoItemToDTO(newItem));
        }

        private ToDoItemDTO MapToDoItemToDTO(ToDoItem item)
        {
            return new ToDoItemDTO
            {
                Id = item.Id,
                Title = item.Title,
                IsComplete = item.IsComplete
            };
        }
    }
}
