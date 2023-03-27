using aspcore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BugDbContext>(options=>{
    options.UseSqlite("Data Source=bugs.sqlite");
    
    options.LogTo(Console.WriteLine);
});

builder.Services.AddRazorPages();


var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();


//app.MapGet("/", () => "Hello World!");

app.Run();
