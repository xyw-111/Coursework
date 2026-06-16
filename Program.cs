using FitStudioGym.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adding MVC controller and view support
builder.Services.AddControllersWithViews();

// Registering the SQL Server database context
builder.Services.AddDbContext<FitStudioContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FitStudioConnection")
    )
);

var app = builder.Build();

// Configuring error handling for non-development environments
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Enabling serving static files such as CSS and JavaScript
app.UseStaticFiles();

// Enabling routing
app.UseRouting();

// Enabling authorization middleware
app.UseAuthorization();

// Configuring default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Start the application
app.Run();