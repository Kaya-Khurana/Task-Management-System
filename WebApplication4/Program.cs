using Microsoft.EntityFrameworkCore;
using WebApplication4.Models; // Replace `WebApplication4` with your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register TaskManagementDbContext
builder.Services.AddDbContext<TaskManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskManagementDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tasks}/{action=Index}/{id?}");

app.Run();
