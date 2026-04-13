using AzureApiDemo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TaskService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();