# Handling HTTP GET Requests in ASP.NET Core Web API

This document focuses specifically on how HTTP GET requests are handled in ASP.NET Core Web API, emphasizing routing, parameters, data transfer objects (DTOs), and response handling.

---

## Purpose of HTTP GET in Web API

* **HTTP GET** is used to retrieve data from the server.
* Data is typically included in the **URL query string** or **route parameters**.
* It's a read-only operation; it does not modify server data.

---

## Basic GET Endpoint (`GetAll`)

### Example Setup:

* A controller (e.g., `TodoController`) handles incoming GET requests.
* The `[HttpGet]` attribute marks a method as a GET endpoint.

```csharp
[HttpGet]
public IActionResult GetAll()
{
    // Returns all sample Todo items as DTOs
    return Ok(todoItemDtos);
}
```

* Uses sample data (not connected to a real database).
* Maps domain models to DTOs using a private helper method.

---

## Using DTOs (Data Transfer Objects)

* DTOs are used to safely transfer only necessary data to the client.
* Helps avoid exposing internal model structures.

```csharp
public class TodoItemDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }
}
```

* A private method maps from domain models (`TodoItem`) to DTOs.

---

## GET by ID Endpoint

### Adding a second GET action method:

* Retrieves a single item by its ID from the route.
* Defined using route parameter placeholder:

```csharp
[HttpGet("{id}")]
public IActionResult GetById(int id)
{
    var item = todoItems.FirstOrDefault(t => t.Id == id);
    if (item == null)
        return NotFound();

    var dto = MapToDto(item);
    return Ok(dto);
}
```

### Key Rules:

* Parameter name in `{id}` must match the method parameter.
* If no item is found: return `404 NotFound()`.
* If item exists: map to DTO and return with `200 OK`.

---

## Swagger Testing

* Swagger UI displays both GET endpoints:

  * `GET /api/todo` → returns all items
  * `GET /api/todo/{id}` → returns a specific item

### Test Cases:

* Try a valid ID (e.g., `1`): returns item and `200 OK`
* Try an invalid ID (e.g., `99`): returns `404 Not Found`

---

## Summary

* Use `[HttpGet]` to define GET endpoints.
* Use DTOs to protect internal model details.
* Support both list retrieval and single item lookup.
* Handle valid and invalid requests with proper status codes.

This concludes the implementation of HTTP GET handling in Web API. In future sessions, other HTTP methods such as POST, PUT, and DELETE will be addressed in detail.
