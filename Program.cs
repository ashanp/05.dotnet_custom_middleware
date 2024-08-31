using MyApp.MyAppCustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseCustomMiddleware1();
app.UseCustomMiddleware2();

app.Run(async (context) =>
{
    var response = context.Response;
    await context.Response.WriteAsync("Terminal Run() method executed\n");
    await context.Response.WriteAsync($"{response}\n");

});

app.Run();
