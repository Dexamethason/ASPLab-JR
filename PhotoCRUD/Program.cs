using Data;
using Microsoft.AspNetCore.Identity;
using PhotoCRUD.Services;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddDbContext<AppDbContext>();
		// Add services to the container.
		builder.Services.AddControllersWithViews();

		builder.Services.AddRazorPages();
		builder.Services.AddScoped<IPhotoService, PhotoService>();
		builder.Services.AddScoped<IAuthorService, AuthorService>();
		builder.Services.AddScoped<IAddressService, AddressService>();

		builder.Services.AddDefaultIdentity<IdentityUser>(
				options =>
				{
					options.SignIn.RequireConfirmedAccount = true;
					options.Password.RequireDigit = false;
					options.Password.RequireNonAlphanumeric = false;
					options.Password.RequiredLength = 4;
					options.Password.RequireUppercase = false;
				})
			.AddRoles<IdentityRole>()
			.AddEntityFrameworkStores<AppDbContext>();
		builder.Services.AddMemoryCache();
		builder.Services.AddSession();

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthentication();
		app.UseAuthorization();
		app.UseSession();
		app.MapRazorPages();

		app.UseAuthentication();
		app.UseAuthorization();

		app.MapControllerRoute(
			"default",
			"{controller=Home}/{action=Index}/{id?}");

		app.Run();
	}
}