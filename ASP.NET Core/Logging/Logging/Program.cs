using Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

// Add services for Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();


// var attachmentOptions = builder.Configuration.GetSection("Attachments").Get<AttachmentOptions>();
// builder.Services.AddSingleton(attachmentOptions);

// var attachmentOptions = new AttachmentOptions();
// builder.Configuration.GetSection("Attachments").Bind(attachmentOptions);
// builder.Services.AddSingleton(attachmentOptions);

builder.Services.Configure<AttachmentOptions>(builder.Configuration.GetSection("Attachments"));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DefaultConnection"]
    ));

// builder.Configuration.AddJsonFile("config.json");
var app = builder.Build();

// Enable Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.MapControllers();

app.Run();