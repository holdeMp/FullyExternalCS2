namespace CS2Cheat;

using System.Windows;
using Data.Game;
using Features;
using Graphics;
using Utils;

internal static class Program
{
    private static async Task Main()
    {
        await Offsets.UpdateOffsetsAsync();
        var features = ConfigManager.Load();
        var CancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = CancellationTokenSource.Token;
        var gameProcess = new GameProcess();
        gameProcess.Start();

        GameData = new GameData(GameProcess);
        GameData.Start();

        WindowOverlay = new WindowOverlay(GameProcess);
        WindowOverlay.Start();

        Graphics = new Graphics.Graphics(GameProcess, GameData, WindowOverlay);
        Graphics.Start();

        Trigger = new TriggerBot(GameProcess, GameData);
        if (features.TriggerBot)
        {
            Trigger.Start();
        }


        AimBot = new AimBot(GameProcess, GameData);
        if (features.AimBot)
        {
            AimBot.Start(cancellationToken);
        }

        BombTimer = new BombTimer(Graphics);
        if (features.BombTimer)
        {
            BombTimer.Start();
        }

        SetWindowDisplayAffinity(WindowOverlay!.Window.Handle, 0x00000011); //obs bypass
    }
}
