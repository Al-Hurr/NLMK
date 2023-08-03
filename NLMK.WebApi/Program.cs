var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Logging.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "Logs/myapp-{Date}.txt"));

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();