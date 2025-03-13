using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using Forge.Data;
//using Forge.Models;
using MudBlazor.Services;

namespace Forge;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
		/*
		// Update Connection String To Match SQL Server Instance
		// TODO: Set up SQL Server
		string connectionString = "Server=SQL_SERVER;Database=Forge;Trusted_Connection=True;MultipleActiveResultSets=True";
		builder.Services.AddDbContext<ApplicationDbContext>(options =>
			options.UseSqlServer(connectionString));

		// Add ASP.NET Core Identity Services
		builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
			.AddEntityFrameworkStores<ApplicationDbContext>()
			.AddDefaultTokenProviders();
		*/
		// Add MudBlazor Services for UI Components
		builder.Services.AddMudServices();

		// Add Authorisation Support
		builder.Services.AddAuthorizationCore();

		return builder.Build();
	}
}
