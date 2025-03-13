using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRewriter(new RewriteOptions().AddRedirect("tasks/(.*)", "todos/$1"));
app.Use(async (context, next) =>
{
    Console.WriteLine($"[{context.Request.Method} {context.Request.Path} {DateTime.UtcNow}] Started...");
    await next(context);
    Console.WriteLine($"[{context.Request.Method} {context.Request.Path} {DateTime.UtcNow}] Finished.");
});

var todos = new List<ToDo>();

app.MapGet("/todos", () => todos);

app.MapGet("/todos/{id}", Results<Ok<ToDo>, NotFound> (int id) =>
{
    var targetToDo = todos.SingleOrDefault(t => t.Id == id);
    return
        targetToDo is not null
        ? TypedResults.Ok(targetToDo)
        : TypedResults.NotFound();
});

app.MapPost("/todos", (ToDo task) =>
{
    todos.Add(task);
    return TypedResults.Created($"/todos/{task.Id}", task);
})
.AddEndpointFilter(async (context, next) =>
{
    var tastArguement = context.GetArgument<ToDo>(0);
    var errors = new Dictionary<string, string[]>();
    if (tastArguement.DueDate < DateTime.UtcNow)
    {
        errors.Add(nameof(ToDo.DueDate), ["Due date must be in the future."]);
    }
    if (tastArguement.IsCompleted)
    {
        errors.Add(nameof(ToDo.IsCompleted), ["New tasks must not be completed."]);
    }
    if (errors.Count > 0)
    {
        return Results.ValidationProblem(errors);
    }
    return await next(context);
});

app.MapDelete("/todos/{id}", (int id) =>
{
    todos.RemoveAll(t => id == t.Id);
    return TypedResults.NoContent();
});

app.Run();

public record ToDo(int Id, string Name, DateTime DueDate, bool IsCompleted);