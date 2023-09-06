using CommunityToolkit.Maui;
using StarBucksApp.Pages;
using StarBucksApp.ViewModels;

namespace StarBucksApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>().UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Poppins-Regular.ttf", "Poppins-Regular");
                fonts.AddFont("ProximaNova-Regular.ttf", "ProximaNova-Regular");
                fonts.AddFont("Raleway-Medium.ttf", "Raleway-Medium.ttf");
                fonts.AddFont("Raleway-Regular.ttf", "Raleway-Regular.ttf");
                //fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
		builder.Services.AddScoped<HomePage, HomeViewModel>();
		return builder.Build();
	}
}
