using LoveBoot.Application;
using LoveBoot.Core.Interfaces;
using LoveBoot.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IConfigurationService, ConfigurationService>();
                services.AddSingleton<IImageRecognitionService, MediaPipeRecognitionService>();
                services.AddSingleton<IInputSimulatorService, InputSimulatorService>();
                services.AddSingleton<IGameStateDetector, GameStateDetector>();
                services.AddHostedService<BotEngine>();
            });

        var app = builder.Build();
        await app.RunAsync();
    }
}
