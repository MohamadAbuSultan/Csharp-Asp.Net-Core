using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todos = new List<Todo>();

app.MapGet("/todos", () => todos);
app.MapGet("/todos/{Id}", Results<Ok<Todo>, NotFound> (int Id) =>
{
    var targetTodo = todos.SingleOrDefault(t => t.Id == Id);
    return targetTodo is null
            ? TypedResults.NotFound()
            : TypedResults.Ok(targetTodo);
});

app.MapPost("/todos", (Todo task) =>
{
    todos.Add(task);
    return TypedResults.Created($"/todos/{task.Id}", task);
});

app.MapDelete("/todos/{id}", (int id) =>
{
    todos.RemoveAll(t => t.Id == id);
    return TypedResults.NoContent();
});

app.Run();

public record Todo(int Id, string Title, DateTime DueDate, bool Completed);