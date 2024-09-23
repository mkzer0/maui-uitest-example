using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;

namespace BasicAppiumSample;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		var services = builder.Services;
		// Register services here
		services.AddSingleton<MainPage>();
#if TEST
                // Use the fake authentication service for development or testing
                services.AddSingleton<IAuthenticationService, FakeAuthenticationService>();
#else
		// Use the real authentication service for production
		services.AddSingleton<IAuthenticationService, RealAuthenticationService>();
#endif

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}