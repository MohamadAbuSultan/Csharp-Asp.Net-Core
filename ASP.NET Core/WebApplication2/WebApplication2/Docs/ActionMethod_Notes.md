# Action Method in ASP .NET Core Web API

This document provides a detailed explanation of **Action Methods** in ASP .NET Core Web API based on a practical walkthrough.

---

## Overview

* Controllers contain **action methods**.
* Action methods are responsible for **handling HTTP requests** and **returning HTTP responses**.
* Each action method is associated with a specific HTTP verb:

  * `GET` for reading data
  * `POST` for creating data
  * `PUT` for updating data
  * `DELETE` for deleting data

---

## Example: `GetAll` Action Method

### Initial Setup

* `GetAll` method is defined in the `TodoController`.
* Return type is `IActionResult`.
* Decorated with `[HttpGet]` to handle GET requests.
* Initially returns `null` (not ideal).

---

## Adding the Model

### Steps:

1. Create a folder named `Models` in the project.
2. Add a class `TodoItem.cs`:

```csharp
public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }
}
```

---

## Sample Data for Testing

* Prepare a list of `TodoItem` in the controller (for learning purposes only):

```csharp
List<TodoItem> todoItems = new List<TodoItem>
{
    new TodoItem { Id = 1, Title = "Learn Web API", Completed = false },
    new TodoItem { Id = 2, Title = "Write Docs", Completed = true }
};
```

* Modify `GetAll()` to return this list:

```csharp
[HttpGet]
public IActionResult GetAll()
{
    return Ok(todoItems);
}
```

---

## Return Types in Action Methods

* Action methods can return:

  * A specific type (`List<TodoItem>`)
  * `IActionResult` (most flexible)
  * `ActionResult<T>` (strongly typed + flexible)
  * Predefined results like `Ok()`, `NotFound()`, `BadRequest()`

### Example with conditional logic:

```csharp
[HttpGet]
public IActionResult GetAll()
{
    if (!todoItems.Any())
        return NotFound(); // Returns 404

    return Ok(todoItems);  // Returns 200 + data
}
```

---

## HTTP Status Codes

* Web servers use status codes to describe the result of an HTTP request.
* Common ones:

  * `200 OK`: Success with data
  * `404 Not Found`: Resource not found

---

## Testing with Swagger

* Run the application.
* Open Swagger UI.
* Test `GET /api/todo` endpoint:

  * Try with data: should return 200 OK with JSON
  * Comment out data: should return 404 Not Found

---

## Summary

* Action methods are the core of Web API functionality.
* Handle specific HTTP verbs.
* Return proper types and status codes.
* Work seamlessly with tools like Swagger for testing.

This concludes the session on action methods. More HTTP verbs and advanced use cases will be covered in upcoming sessions.
