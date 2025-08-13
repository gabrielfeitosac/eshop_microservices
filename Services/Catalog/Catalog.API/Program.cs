var builder = WebApplication.CreateBuilder(args);

//Add services

var app = builder.Build();

//Configure Http request pipeline

app.Run();
