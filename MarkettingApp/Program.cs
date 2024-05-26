using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductMarketingApp.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure Entity Framework Core with SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

// Configure Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 6; // Set to the minimum length you prefer
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Map routes for Products controller
app.MapControllerRoute(
    name: "products",
    pattern: "Products/{action=Index}/{id?}",
    defaults: new { controller = "Products" });

// Map route for viewing user's posts
app.MapControllerRoute(
    name: "myPosts",
    pattern: "Products/MyPosts",
    defaults: new { controller = "Products", action = "MyPosts" });


// Map routes for Account controller
app.MapControllerRoute(
    name: "account",
    pattern: "Account/{action=Login}/{id?}",
    defaults: new { controller = "Account" });

// Map routes for Account controller (Register)
app.MapControllerRoute(
    name: "accountRegister",
    pattern: "Account/{action=Register}/{id?}",
    defaults: new { controller = "Account"});

app.Run();
