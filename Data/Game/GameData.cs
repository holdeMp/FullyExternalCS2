namespace CS2Cheat.Data.Game;

using System.Diagnostics.CodeAnalysis;
using Core;
using Entity;
using Microsoft.Extensions.Hosting;

public sealed class GameData : BackgroundService
{
    public GameData(GameProcess gameProcess)
    {
        GameProcess = gameProcess;
        Player = new Player();
        Entities = Enumerable.Range(0, 64).Select(index => new Entity(index)).ToArray();
    }

    private GameProcess? GameProcess
    {
        get;
        set;
    }

    public Player? Player
    {
        get;
        private set;
    }

    public Entity[]? Entities
    {
        get;
        private set;
    }

    [MemberNotNullWhen(true, nameof(Player))]
    public bool IsPlayerValid => Player != null;

    public override void Dispose()
    {
        base.Dispose();

        Entities = null;
        Player = null;
        GameProcess = null;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (GameProcess is not { IsValid: true })
            {
                return;
            }

            Player?.Update(GameProcess);

            if (Entities == null)
            {
                continue;
            }

            foreach (var entity in Entities)
            {
                entity.Update(GameProcess);
            }

            await Task.Delay(Time.Millisecond, stoppingToken);
        }
    }
}
