using AE33.DataTransActions;
using AE33.Models;

namespace AE33;

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
        builder.Services.AddSingleton<BaseRepository<ChildModels>>();
        builder.Services.AddSingleton<BaseRepository<ParentModels>>();
        builder.Services.AddSingleton<BaseRepository<AssignmentModels>>();

        return builder.Build();
	}
}
