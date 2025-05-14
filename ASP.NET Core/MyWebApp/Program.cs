// Create a WebApplication builder to configure the application
var builder = WebApplication.CreateBuilder(args);

// Build the WebApplication instance
var app = builder.Build();

var people = new List<Person>
{
    new("Tom", "Hanks"),
    new("Denzel", "Washington"),
    new("Leondardo", "DiCaprio"),
    new("Al", "Pacino"),
    new("Morgan", "Freeman"),
};

// Add a middleware to display a welcome page at the root URL ("/")
// This middleware handles requests to "/" and stops further middleware from being executed
app.UseWelcomePage("/");

// Add a middleware to show detailed exception information during development
// This middleware helps detect and display errors that occur during the processing of requests
// It is particularly useful for troubleshooting in a development environment
app.UseDeveloperExceptionPage();

// Enable serving static files (e.g., CSS, JavaScript, images) from the wwwroot folder
// This middleware serves static file requests like "/moon.jpg" from the wwwroot directory
// It handles valid file paths and provides the requested content
app.UseStaticFiles();

// Add routing middleware to enable endpoint routing
// This middleware won't be triggered for "/" because the request is already handled by WelcomePageMiddleware
app.UseRouting();

// Map a GET request to the root URL ("/") to return "Hello World!" as a response
// This endpoint won't execute because WelcomePageMiddleware handles "/" first
app.MapGet("/", () => "Hello World!");

app.MapGet("/person/name", (string name) =>
    people.Where(p => p.FirstName.StartsWith(name)
));

// Run the application
app.Run();

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}