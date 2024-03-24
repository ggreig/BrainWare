using Api.Infrastructure;
using Microsoft.OpenApi.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc(
        "v1", 
        new OpenApiInfo
        {
            Title = "BrainWare API", 
            Version = "v1",
            Description = "An API to retrieve company order details from the BrainWare database.",
            Contact = new OpenApiContact
            {
                Name = "Gavin Greig",
                Email="example@example.com",
                Url = new Uri("http://ggreig.com/")
            }
        }
    );
    string filePath = Path.Combine(AppContext.BaseDirectory, "Api.xml");
    options.IncludeXmlComments(filePath);
});

// Configure in-project DI.
builder.Services.AddScoped<IDatabase, Database>();
builder.Services.AddScoped<IOrderService, OrderService>();

// Use "appsettings.json", with environmental overrides.
IHostEnvironment env = builder.Environment;
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();