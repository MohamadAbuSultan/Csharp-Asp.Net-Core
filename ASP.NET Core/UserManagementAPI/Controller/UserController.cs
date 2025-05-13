using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace UserManagementAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
            new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Ok(users);
            // throw new Exception("Test error: Something went wrong!");
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound($"User with ID {id} not found.");

            return Ok(user);
        }


        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email))
                    return BadRequest("User name and email are required.");

                if (!user.Email.Contains("@"))
                    return BadRequest("Invalid email format.");

                user.Id = users.Count + 1;
                users.Add(user);
                return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound("User not found.");

            if (string.IsNullOrEmpty(updatedUser.Name) || string.IsNullOrEmpty(updatedUser.Email))
                return BadRequest("User name and email are required.");

            if (!updatedUser.Email.Contains("@"))
                return BadRequest("Invalid email format.");

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound($"User with ID {id} not found.");

            users.Remove(user);
            return NoContent();
        }
    }
}