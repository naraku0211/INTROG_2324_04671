var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapDefaultControllerRoute();

//app.MapGet("/", () => "Hello World!");

app.Run();
