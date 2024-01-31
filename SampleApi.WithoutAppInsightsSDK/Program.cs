var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    app.Logger.LogWarning("Get invoked. Not Using App Insights SDK");
    return "Hello World! Not Using App Insights SDK";
});
app.Run();