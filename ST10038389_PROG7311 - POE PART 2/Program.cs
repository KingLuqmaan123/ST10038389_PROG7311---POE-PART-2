using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ST10038389_PROG7311___POE_PART_2.Data;
using ST10038389_PROG7311___POE_PART_2.Models;
//ABOVE IS ALL THE IMPORTS/PACKAGES INSTALLED ON EVERY CLASS FILE OR CONTROLLER FILE IN THIS PROJECT TO ALLOW THE CODE LOGIC AND FUNCTIONS TO WORK AS EXPECTED.
var builder = WebApplication.CreateBuilder(args);

//Add DbContext with SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

//Add Identity with custom ApplicationUser
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
    options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

//Add MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); 

app.Run();
//---------------------------------- END OF FILE ------------------------------------------------------------