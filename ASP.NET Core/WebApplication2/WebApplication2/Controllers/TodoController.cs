using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    // In ASP.NET Core Web API, the controller is a key component.
    // It's a class responsible for handling HTTP requests
    // and returning HTTP responses.

    [ApiController] // Enables model validation, parameter binding, and attribute routing
    // The [ApiController] attribute provides:
    // - Automatic model validation
    // - Automatic binding of parameters from requests
    // - Enables attribute routing by default

    [Route("api/[controller]")] // Defines the route pattern: api/Todo
    // The [Route] attribute defines how this controller
    // is accessed via URL.
    // Using [controller] in the route automatically uses
    // the class name without the 'Controller' suffix.


    // We apply attributes like [ApiController] and
    // [Route] to define routing and enable API-specific features.
    public class TodoController : ControllerBase
    // Our controller class inherits from ControllerBase.
    // ControllerBase provides useful properties and
    // methods for handling requests.
    {

        // Inside the controller, we define action methods.
        // These methods handle specific HTTP verbs like GET, POST, PUT, DELETE.

        [HttpGet] // Maps this method to HTTP GET requests
        public IActionResult GetAll()
        {
            // This method will handle fetching all items (GET request)
            return Ok("This is a placeholder response.");
        }

        // Each action method corresponds to an HTTP verb:
        // - [HttpGet] for retrieving data
        // - [HttpPost] for creating data
        // - [HttpPut] for updating data
        // - [HttpDelete] for deleting data

        // The controller delegates the request to
        // the correct action method based on the HTTP verb.

    }
}
