// ... existing using directives ...

using Microsoft.EntityFrameworkCore; // Add this directive
using u21657344_HW02.Models.Data; // The namespace where your ApplicationDbContext resides

// ... rest of the code ...

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add the DbContext service
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Use the connection string we set in appsettings.json

var app = builder.Build();

// ... rest of the configuration ...
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();
