
using Microsoft.EntityFrameworkCore;
using OrnekProje_DataAcces.Data;

var builder = WebApplication.CreateBuilder(args);

string conn = builder.Configuration.GetConnectionString("DefaultConnectionString");

builder.Services.AddDbContext<OrnekDbContext>(opt => opt.UseSqlServer(conn));

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
