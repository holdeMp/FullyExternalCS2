namespace CS2Cheat;

using Data.Game;
using Features;
using Graphics;

public sealed class Program1 : IDisposable
{
    private GameProcess GameProcess
    {
        get;
        set;
    } = null!;

    private GameData GameData
    {
        get;
        set;
    } = null!;

    private WindowOverlay WindowOverlay
    {
        get;
        set;
    } = null!;

    private Graphics.Graphics Graphics
    {
        get;
        set;
    } = null!;

    private TriggerBot Trigger
    {
        get;
        set;
    } = null!;

    private AimBot AimBot
    {
        get;
        set;
    } = null!;

    private BombTimer BombTimer
    {
        get;
        set;
    } = null!;

    public void Dispose()
    {
        GameProcess.Dispose();
        GameProcess = null!;

        GameData.Dispose();
        GameData = null!;

        WindowOverlay.Dispose();
        WindowOverlay = null!;

        Graphics.Dispose();
        Graphics = null!;

        Trigger.Dispose();
        Trigger = null!;

        AimBot.Dispose();
        AimBot = null!;

        BombTimer.Dispose();
        BombTimer = null!;
    }


    private void InitializeComponent()
    {
    }
}
