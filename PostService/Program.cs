var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:5050");
var app = builder.Build();

app.MapGet("/", () => "Це API поштового клієнта.");

app.Run();
