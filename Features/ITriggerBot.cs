namespace CS2Cheat.Features;

public interface ITriggerBot
{
    Task? ExecuteTask
    {
        get;
    }

    bool IsHotKeyDown();
    Task StartAsync(CancellationToken cancellationToken);
    Task StopAsync(CancellationToken cancellationToken);
    void Dispose();
}
