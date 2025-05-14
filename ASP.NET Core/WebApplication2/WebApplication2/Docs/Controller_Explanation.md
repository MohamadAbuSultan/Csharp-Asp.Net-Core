
# Controller Explanation in ASP.NET Core Web API

This document explains the basic structure and purpose of the `Controller` in an ASP.NET Core Web API.

---

##  Purpose of the Controller

In ASP.NET Core Web API, a controller is a key component.

- It is a **class** responsible for handling **HTTP requests** and returning **HTTP responses**.
- Controllers typically inherit from `ControllerBase` in Web API projects.

---

## `[ApiController]` Attribute

The `[ApiController]` attribute enables the following features:

- Automatic model validation  
- Automatic binding of parameters from the request  
- Enables attribute routing by default  

It makes the controller easier to work with by reducing boilerplate validation logic.

---

##  `[Route]` Attribute

```csharp
[Route("api/[controller]")]
```

This attribute defines how the controller is accessed via the URL.

* Using `[controller]` in the route automatically maps the controller's class name without the `Controller` suffix.
* For example: `TodoController` → `api/todo`

##  The `TodoController` Class

```csharp
[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    // Action methods go here...
}
```

* Inherits from `ControllerBase` which provides essential HTTP handling methods.
* Decorated with both `[ApiController]` and `[Route]`.

## Action Methods

[HttpGet]
public IActionResult GetAll()
{
    return Ok("This is a placeholder response.");
}


* This method responds to HTTP GET requests.
* IActionResult is the return type used to return various types of responses.
* Ok(...) is a helper method that returns HTTP 200 with data.


### HTTP Verbs in Action Methods

Each action method in a controller corresponds to an HTTP verb:

| Attribute      | Purpose              |
| -------------- | -------------------- |
| `[HttpGet]`    | Retrieve data        |
| `[HttpPost]`   | Create new data      |
| `[HttpPut]`    | Update existing data |
| `[HttpDelete]` | Delete data          |

The controller will route incoming HTTP requests to the correct method based on the verb and route.

## Summary

This controller is a basic template for handling Web API requests.
In the future, you can extend it by adding:

* More HTTP methods (POST, PUT, DELETE)
* Dependency injection
* Model validation
* Business logic

This document serves as a reference for understanding the structure and functionality of Web API controllers in ASP.NET Core.
