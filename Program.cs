var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapGet("/lessons", () => new[] { new { id = 1, title = "Docker basics" }, new { id = 2, title = "Kubernetes basics" } });
app.Run();
