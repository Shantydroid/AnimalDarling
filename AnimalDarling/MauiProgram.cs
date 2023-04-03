namespace AnimalDarling;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<DashboardViewModel>();

		builder.Services.AddSingleton<DashboardPage>();

		builder.Services.AddSingleton<PetDetailViewModel>();

		builder.Services.AddSingleton<PetDetailPage>();

		builder.Services.AddSingleton<PetSearchViewModel>();

		builder.Services.AddSingleton<PetSearchPage>();

		builder.Services.AddSingleton<PetFinderViewModel>();

		builder.Services.AddSingleton<PetFinderPage>();

		builder.Services.AddSingleton<LocalizationViewModel>();

		builder.Services.AddSingleton<LocalizationPage>();

		return builder.Build();
	}
}
