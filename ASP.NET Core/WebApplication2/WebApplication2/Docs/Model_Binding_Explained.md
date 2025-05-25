# Understanding Model Binding in ASP .NET Core Web API

This document explains the concept of model binding in ASP .NET Core Web API, how it works by default, and how it maps incoming HTTP request data to action method parameters.

---

## What is Model Binding?

* Model binding is the process of **mapping data from HTTP requests** to the **parameters of action methods**.
* It simplifies the task of extracting values from the request and converting them into .NET types.

---

## Default Model Binding

* ASP .NET Core provides built-in model binders for:

  * Simple data types (e.g., int, string, bool)
  * Complex types (e.g., classes like DTOs)
* Model binding works automatically based on naming conventions and request content.

---

## Example: Binding a Simple Type

```csharp
[HttpGet("{id}")]
public IActionResult GetTodoItemById(int id)
{
    // The value from the route will be bound to the 'id' parameter automatically
    var item = todoItems.FirstOrDefault(t => t.Id == id);
    return item == null ? NotFound() : Ok(item);
}
```

* When a GET request is made to `/api/todo/1`, the value `1` is automatically bound to the `id` parameter.
* No custom code is required to perform this mapping.

---

## Example: Binding a Complex Type

```csharp
[HttpPost]
public IActionResult CreateTodoItem([FromBody] TodoItemDto newItemDto)
{
    if (newItemDto == null) return BadRequest();

    var newItem = new TodoItem
    {
        Id = GenerateNewId(),
        Title = newItemDto.Title,
        Completed = newItemDto.Completed
    };

    todoItems.Add(newItem);
    return CreatedAtAction(nameof(GetTodoItemById), new { id = newItem.Id }, newItem);
}
```

* When the client sends a POST request with JSON in the request body, the `[FromBody]` attribute tells ASP .NET Core to deserialize the content into the `TodoItemDto` object.
* Properties like `Title` and `Completed` are automatically mapped.

---

## Sources Used in Model Binding

Model binders can extract data from various sources:

* Route values
* Query strings
* Form data
* Request body
* Headers

---

## Key Behaviors

* The parameter name in the action method must match the key in the data source.
* The type of the parameter must be compatible with the incoming value.

---

## Why Use Model Binding?

* Reduces boilerplate code needed to extract and convert request data.
* Allows working directly with .NET types instead of raw HTTP.
* Central to writing clean, maintainable API logic.

---

## Optional Attributes

* `[FromQuery]`, `[FromRoute]`, `[FromForm]`, `[FromHeader]`, `[FromBody]` can be used to explicitly control where to bind data from.
* Example:

```csharp
public IActionResult GetTodoItem([FromQuery] int id) { ... }
```

---

## Extending Model Binding

* You can implement **custom model binders** for advanced scenarios when the default behavior does not meet your needs.
* Custom binders allow full control over how parameters are bound.

---

## Summary

* Model binding is a core feature in ASP .NET Core Web API.
* It automates mapping HTTP request data to action method parameters.
* It supports both simple and complex data types.
* Understanding how it works is essential for building reliable APIs.
