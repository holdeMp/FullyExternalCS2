namespace CS2Cheat.Data.Game;

using System.Diagnostics.CodeAnalysis;
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

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (GameProcess is not { IsValid: true })
        {
            return Task.CompletedTask;
        }

        Player?.Update(GameProcess);

        if (Entities != null)
        {
            foreach (var entity in Entities)
            {
                entity.Update(GameProcess);
            }
        }
    }
}
