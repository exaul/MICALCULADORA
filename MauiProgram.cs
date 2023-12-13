using MICALCULADORA.Services;
using MICALCULADORA.Services.Interface;
using MICALCULADORA.ViewModel;
using MICALCULADORA.Views;
using Microsoft.Extensions.Logging;

namespace MICALCULADORA
{
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

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<CalculadoraPage>();
            builder.Services.AddSingleton<CalculadoraPageViewModel>();
            builder.Services.AddSingleton<ICalculadoraServices, CalculadoraServices>();
            return builder.Build();
        }
    }
}