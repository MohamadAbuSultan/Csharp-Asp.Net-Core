// using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In-memory storage for simplicity
var posts = new List<Post>
{
    new Post { Id = 1, Title = "First Post", Content = "This is the first post." },
    new Post { Id = 2, Title = "Second Post", Content = "This is the second post." }
};

var app = builder.Build();

// Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.MapGet("/", () => "Welcome to the Blog API!").ExculdeFromDescription();

// CRUD Operations

// Get all posts
app.MapGet("/posts", () => Results.Ok(posts));

// Get a single post by ID
app.MapGet("/posts/{id}", /* Results<Ok<Post>, NotFound> */ (int id) =>
{
    var post = posts.FirstOrDefault(p => p.Id == id);
    return post is not null ? Results.Ok(post) : Results.NotFound();
});
// }).WithOpenApi(options =>
// {
//     options.Parameters[0].Description = "The ID of the post to retrieve.";
//     options.Summary = "Get a single blog post";
//     options.Description = "Retrieves a single post based on the provided ID.";
//     return options;
// });

// Create a new post
app.MapPost("/posts", (Post newPost) =>
{
    newPost.Id = posts.Any() ? posts.Max(p => p.Id) + 1 : 1;
    posts.Add(newPost);
    return Results.Created($"/posts/{newPost.Id}", newPost);
});

// Update an existing post
app.MapPut("/posts/{id}", (int id, Post updatedPost) =>
{
    var post = posts.FirstOrDefault(p => p.Id == id);
    if (post is null) return Results.NotFound();

    post.Title = updatedPost.Title;
    post.Content = updatedPost.Content;
    return Results.Ok(post);
});

// Delete a post
app.MapDelete("/posts/{id}", (int id) =>
{
    var post = posts.FirstOrDefault(p => p.Id == id);
    if (post is null) return Results.NotFound();

    posts.Remove(post);
    return Results.NoContent();
});

app.Run();

// Post model
public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
}