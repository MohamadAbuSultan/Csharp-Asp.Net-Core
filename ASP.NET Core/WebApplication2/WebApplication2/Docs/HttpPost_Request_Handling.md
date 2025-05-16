# Handling HTTP POST Requests in ASP .NET Core Web API

This document outlines the structure and implementation of HTTP POST request handling in ASP .NET Core Web API using controller-based routing.

---

## Introduction to HTTP POST

* HTTP POST is used to send data to the server to **create** or **update** a resource.
* The data is sent in the **message body** of the request, typically in **JSON** or **XML** format.
* Compared to GET requests, POST can carry **larger payloads**.

---

## POST Request in a Web API Context

* In a Web API application, POST requests are handled by defining an action method decorated with the `[HttpPost]` attribute.
* The incoming data is received as a parameter and is deserialized from the request body.

```csharp
[HttpPost]
public IActionResult CreateTodoItem([FromBody] TodoItemDto newItemDto)
{
    if (newItemDto == null)
        return BadRequest();

    var newItem = new TodoItem
    {
        Id = GenerateNewId(),
        Title = newItemDto.Title,
        Completed = newItemDto.Completed
    };

    todoItems.Add(newItem);

    return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, newItem);
}
```

---

## Key Concepts

### `[FromBody]` Attribute

* Tells ASP .NET Core to **deserialize** the request body into the provided object.
* Commonly used when the data is sent as JSON or XML.

### Data Transfer Object (DTO)

* A DTO is used to **transfer data safely** between client and server.
* Helps avoid exposing internal domain models directly.

### Domain Model vs DTO

* Domain models represent entities used internally and in the database.
* DTOs represent the data expected from or sent to the client.
* Mapping is performed between DTO and domain model.

---

## Generating a New ID

* In the absence of a database, IDs can be generated manually.
* For example:

```csharp
private int GenerateNewId()
{
    return todoItems.Max(t => t.Id) + 1;
}
```

---

## Returning a Response

### `CreatedAtAction` Method

* Returns a **201 Created** status code.
* Includes a **Location** header with a URL pointing to the newly created resource.

```csharp
return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, newItem);
```

---

## Testing the Endpoint

### Using Swagger

* Open Swagger UI and navigate to the POST endpoint.
* Click **Try it out**, fill in request data, and **Execute**.
* The response should return:

  * Status Code: `201 Created`
  * Response Body: Contains the newly created item.

### Verifying with GET

* Use the `GET /api/todo` endpoint to verify that the new item has been added.

---

## Customizing Route Templates

* By default, endpoints use `[Route("api/[controller]")]`.
* To expose action names in the route, modify it to `[Route("api/[controller]/[action]")]`.
* This makes endpoints clearer and self-documenting.

---

## Summary

* HTTP POST is essential for **creating resources** in Web APIs.
* Use `[HttpPost]` with `[FromBody]` to receive data in the request body.
* Return appropriate status codes such as `400 Bad Request` and `201 Created`.
* Use DTOs to safely transfer data.
* Swagger is a great tool to test and document POST endpoints.
