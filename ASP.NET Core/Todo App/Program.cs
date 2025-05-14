var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Todo> todos = new List<Todo>();
app.MapGet("/todos", () => todos);

app.MapGet("/todos/{id}", (int id) =>
 todos.FirstOrDefault(t => t.Id == id));

app.MapPost("/todos", (Todo todo) =>
{
    todo.Id = todos.Count + 1;
    todos.Add(todo);
    return todo;
}); 

app.Ma

app.Run();
