using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scrinium.ViewModels;
using Scrinium.Views;

public static class DependencyInjection
{
    public static IServiceProvider ConfigureService()
    {
        var services = new ServiceCollection();

        // #########################################
        // Register all DI here
        // #########################################

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=db_scrinium.db")
        );

        // #########################################
        // Register all ViewModels and Views here
        // #########################################

        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<MainWindow>();

        // #########################################
        // #########################################

        return services.BuildServiceProvider();
    }
}
