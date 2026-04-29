var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Logging Requests
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseStaticFiles();

// Endpoint for testing
app.MapGet("/", () => "Middleware App Running");

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy",
        "default-src 'self'; script-src 'self'; style-src 'self';");
    await next();
});

app.Run();