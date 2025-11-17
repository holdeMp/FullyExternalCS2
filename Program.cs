namespace CS2Cheat;

using Data.Game;
using Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Utils;

internal static class Program
{
    private static async Task Main()
    {
        await Offsets.UpdateOffsetsAsync();
        var features = ConfigManager.Load();

        var host = Host.CreateDefaultBuilder()
            .UseSerilog((_, _, configuration) =>
            {
                configuration.WriteTo.Console();
            })
            .ConfigureServices((_, services) =>
            {
                // Register core services
                services.AddSingleton<GameProcess>();
                services.AddHostedService<GameData>();
                services.AddSingleton(features);

                // Register background services
                services.AddHostedService<TriggerBot>();
                services.AddHostedService<AimBot>();

                // Register application orchestrator
            })
            .Build();

        await host.RunAsync();
    }
}
