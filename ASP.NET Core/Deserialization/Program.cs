using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Auto Binding
app.MapPost("/auto", (Person personFromClient) =>
{
    return TypedResults.Ok(personFromClient);
});

app.MapPost("/json", async (HttpContext context) =>
{
    var person = await context.Request.ReadFromJsonAsync<Person>();
    return TypedResults.Ok(person);
});

app.MapPost("/custom-options", async (HttpContext context) =>
{
    var options = new JsonSerializerOptions
    {
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
    };

    var person = await context.Request.ReadFromJsonAsync<Person>(options);
    return TypedResults.Ok(person);
});

app.MapPost("/xml", async (HttpContext context) =>
{
    var reader = new StreamReader(context.Request.Body);
    var body = await reader.ReadToEndAsync();

    var xmlSerializer = new XmlSerializer(typeof(Person));
    var stringReader = new StringReader(body);

    var person = xmlSerializer.Deserialize(stringReader);
    return TypedResults.Ok(person);
});

app.Run();

public class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
}