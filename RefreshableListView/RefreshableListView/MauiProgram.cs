﻿using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace RefreshableListView
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Medium.ttf", "Roboto-Medium");
                    fonts.AddFont("Roboto-Regular.ttf", "Roboto-Regular");
                    fonts.AddFont("PullToRefreshFontIcon.ttf", "PullToRefreshFontIcon");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
