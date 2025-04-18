var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/users/{userId}/books/{bookId}",
(int bookId, int userId) =>
$"The user id is {userId} and the book id is {bookId}");

app.Run();
