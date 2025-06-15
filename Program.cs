var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<MongoService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();