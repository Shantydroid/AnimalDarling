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


        builder.Services.AddSingletonWithShellRoute<DashboardPage, DashboardViewModel>(nameof(DashboardPage));

        //builder.Services.AddSingletonWithShellRoute<PetDetailPage, PetDetailViewModel>(nameof(PetDetailPage));

        builder.Services.AddSingletonWithShellRoute<LocalizationPage, LocalizationViewModel>(nameof(LocalizationPage));

        builder.Services.AddSingletonWithShellRoute<PetFinderPage, PetFinderViewModel>(nameof(PetFinderPage));

        builder.Services.AddSingletonWithShellRoute<PetSearchPage, PetSearchViewModel>(nameof(PetSearchPage));

        return builder.Build();
    }
}
