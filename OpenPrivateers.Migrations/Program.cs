
using Microsoft.EntityFrameworkCore;
using OpenPrivateers.Migrations.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OpenPrivateersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OpenPrivateers")));

var app = builder.Build();
// app.MapGet("/", () => "Hello World!");

app.Run();
