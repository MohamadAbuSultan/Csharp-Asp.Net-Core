using System.Text.Json;
using System.Xml.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.KebabCaseUpper;
});

var app = builder.Build();

var samplePerson = new Person
{
    UserName = "JohnDoe",
    UserAge = 30
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/manual-json", () =>
{
    var jsonString = JsonSerializer.Serialize(samplePerson);
    return TypedResults.Text(jsonString, "application/json");
});

app.MapGet("/custom-serializer", () =>
{
    var options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
    };

    var customJsonString = JsonSerializer.Serialize(samplePerson, options);
    return TypedResults.Text(customJsonString, "application/json");
});

app.MapGet("/json", () =>
{
    return TypedResults.Json(samplePerson);
});

app.MapGet("/auto", () =>
{
    return samplePerson;
});

app.MapGet("/xml", () =>
{
    var xmlSerializer = new XmlSerializer(typeof(Person));
    var stringWriter = new StringWriter();
    xmlSerializer.Serialize(stringWriter, samplePerson);
    var xmlOutput = stringWriter.ToString();

    return TypedResults.Text(xmlOutput, "application/xml");
});

app.Run();

public class Person
{
    public required string UserName { get; set; }
    public required int UserAge { get; set; }
}