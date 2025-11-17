using Keys = Process.NET.Native.Types.Keys;

namespace CS2Cheat.Features;

using Data.Game;
using Microsoft.Extensions.Hosting;
using Utils;

public sealed class TriggerBot(GameProcess gameProcess, GameData gameData, ConfigManager config)
    : BackgroundService, ITriggerBot
{
    private const float MaxVelocityThreshold = 18f;
    private const int TriggerDelayMs = 5;
    private const int EntityListMultiplier = 0x8;
    private const int EntityEntryOffset = 0x10;
    private const int EntityStride = 112;
    private const int EntityIndexMask = 0x1FF;
    private const int EntityIndexShift = 9;
    private readonly ConfigManager _config = config ?? throw new ArgumentNullException(nameof(config));
    private readonly GameData _gameData = gameData ?? throw new ArgumentNullException(nameof(gameData));
    private readonly GameProcess _gameProcess = gameProcess ?? throw new ArgumentNullException(nameof(gameProcess));
    private readonly Keys _triggerBotHotKey = config.TriggerBotKey;

    public bool IsHotKeyDown() => _triggerBotHotKey.IsKeyDown();

    public override void Dispose()
    {
        base.Dispose();
        _gameData.Dispose();
        _gameProcess.Dispose();
    }

    private bool ShouldExecuteTriggerBot() => _gameProcess.IsValid && IsHotKeyDown();

    private IntPtr GetTargetEntity()
    {
        if (_gameProcess.ModuleClient == null)
        {
            return IntPtr.Zero;
        }

        var localPlayerPawn = _gameProcess.ModuleClient.Read<IntPtr>(Offsets.DwLocalPlayerPawn);
        if (localPlayerPawn == IntPtr.Zero || _gameProcess.Process == null)
        {
            return IntPtr.Zero;
        }

        var entityId = _gameProcess.Process.Read<int>(localPlayerPawn + Offsets.MiIdEntIndex);

        if (entityId < 0)
        {
            return IntPtr.Zero;
        }

        var entityList = _gameProcess.ModuleClient.Read<IntPtr>(Offsets.DwEntityList);
        var entityEntry = _gameProcess.Process.Read<IntPtr>(
            entityList + (EntityListMultiplier * (entityId >> EntityIndexShift)) + EntityEntryOffset);

        return _gameProcess.Process.Read<IntPtr>(
            entityEntry + (EntityStride * (entityId & EntityIndexMask)));
    }

    // The code checks _gameData.Player.FFlags == 65664. That numeric literal in decimal is 65664.
    // In hexadecimal 65664 = 0x10080. So the FFlags value has exactly two bits set: 0x80 (decimal 128) and 0x10000 (decimal 65536).
    // 0x80 is the well-known Source/Source2 bit usually named FL_CLIENT (a "client" / player flag). So one bit says "this entity is a client/player".
    // 0x10000 is a higher-order flag bit (1<<16). Its exact meaning depends on the engine SDK/version; it's not defined anywhere in this repo. It likely represents an engine-specific state (an extra flag added in this engine version or a composite state).
    private bool ShouldTriggerOnEntity(int entityTeam)
    {
        if (_gameData.Player == null)
        {
            return false;
        }

        var isDifferentTeam = _gameData.Player.Team != entityTeam.ToTeam();
        var isSpecialCondition = _gameData.Player.FFlags == 65664;
        var isWithinVelocityLimit = Math.Abs(_gameData.Player.Velocity.Z) <= MaxVelocityThreshold;

        return (isDifferentTeam || isSpecialCondition) && isWithinVelocityLimit;
    }

    private static async Task ExecuteTriggerAsync()
    {
        await Task.Delay(TriggerDelayMs);
        Utility.MouseLeftDown();
        Utility.MouseLeftUp();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (!_config.TriggerBot)
            {
                await Task.Delay(100, stoppingToken).ConfigureAwait(false);
                continue;
            }

            if (!ShouldExecuteTriggerBot())
            {
                await Task.Delay(10, stoppingToken).ConfigureAwait(false);
                continue;
            }

            var targetEntity = GetTargetEntity();
            if (targetEntity == IntPtr.Zero || _gameProcess.Process == null)
            {
                await Task.Delay(10, stoppingToken).ConfigureAwait(false);
                continue;
            }

            var entityTeam = _gameProcess.Process.Read<int>(targetEntity + Offsets.MiTeamNum);
            if (ShouldTriggerOnEntity(entityTeam))
            {
                await ExecuteTriggerAsync();
            }

            await Task.Delay(TriggerDelayMs, stoppingToken).ConfigureAwait(false);
        }
    }
}
