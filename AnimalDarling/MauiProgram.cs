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


        builder.Services.AddScopedWithShellRoute<DashboardPage, DashboardViewModel>(nameof(DashboardPage));

        builder.Services.AddScopedWithShellRoute<PetDetailPage, PetDetailViewModel>(nameof(PetDetailPage));

        builder.Services.AddScopedWithShellRoute<LocalizationPage, LocalizationViewModel>(nameof(LocalizationPage));

        builder.Services.AddScopedWithShellRoute<PetFinderPage, PetFinderViewModel>(nameof(PetFinderPage));

        builder.Services.AddScopedWithShellRoute<PetSearchPage, PetSearchViewModel>(nameof(PetSearchPage));

        return builder.Build();
	}
}
