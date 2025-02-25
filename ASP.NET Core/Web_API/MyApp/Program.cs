var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/hello", (string name) => $"Hello {name}!");
app.MapGet("/users/{userId}/posts/{slug}", (int userId, string slug) => 
{
    return $"User ID: {userId} - Post ID {slug}";
});

app.MapGet("/products/{id:int:min(0)}" , (int id) => {
    return $"Product ID: {id}";
});

app.MapGet("/report/{year?}" , (int? year = 2019) => {
    return $"Report Year: {year}";
});

app.MapGet("/files/{*filePath}" , (string filePath) => {
    return $"File Path: {filePath}";
});

app.MapGet("/search", (string? query, int? page = 1) => {
    return $"Searching Query: {query} - On Page: {page}";
});

app.MapGet("/store/{category}/{productId:int?}/{*extraPath}",
(string category, int? productId, string? extraPath, bool inStock = true) =>
{
    return $"Category: {category}\n" +
           $"Product ID: {productId}\n" +
           $"Extra Path: {extraPath}\n" +
           $"In Stock: {inStock}";
});

app.Run();
