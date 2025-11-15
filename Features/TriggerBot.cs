using Keys = Process.NET.Native.Types.Keys;

namespace CS2Cheat.Features;

using Data.Game;
using Utils;

public sealed class TriggerBot : IDisposable
{
    private const float MaxVelocityThreshold = 18f;
    private const int TriggerDelayMs = 5;
    private const int EntityListMultiplier = 0x8;
    private const int EntityEntryOffset = 0x10;
    private const int EntityStride = 112;
    private const int EntityIndexMask = 0x1FF;
    private const int EntityIndexShift = 9;
    private static Keys _triggerBotHotKey;
    private static ConfigManager? _config;
    private readonly GameData _gameData;

    private readonly GameProcess _gameProcess;

    public TriggerBot(GameProcess gameProcess, GameData gameData)
    {
        _gameProcess = gameProcess ?? throw new ArgumentNullException(nameof(gameProcess));
        _gameData = gameData ?? throw new ArgumentNullException(nameof(gameData));
        _triggerBotHotKey = Config.TriggerBotKey;
    }

    private static ConfigManager Config => _config ??= ConfigManager.Load();

    protected string ThreadName => nameof(TriggerBot);

    public override void Dispose()
    {
        base.Dispose();
        GC.SuppressFinalize(this);
    }

    protected async void FrameAction()
    {
        if (!ShouldExecuteTriggerBot())
        {
            return;
        }

        var targetEntity = GetTargetEntity();
        if (targetEntity == IntPtr.Zero)
        {
            return;
        }

        if (_gameProcess.Process == null)
        {
            return;
        }

        var entityTeam = _gameProcess.Process.Read<int>(targetEntity + Offsets.MiTeamNum);
        if (!ShouldTriggerOnEntity(entityTeam))
        {
            return;
        }

        await ExecuteTrigger();
    }

    private bool ShouldExecuteTriggerBot() => _gameProcess.IsValid && IsHotKeyDown();

    private IntPtr GetTargetEntity()
    {
        if (_gameProcess.ModuleClient == null)
        {
            return IntPtr.Zero;
        }

        var localPlayerPawn = _gameProcess.ModuleClient.Read<IntPtr>(Offsets.DwLocalPlayerPawn);
        if (localPlayerPawn == IntPtr.Zero)
        {
            return IntPtr.Zero;
        }

        if (_gameProcess.Process == null)
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

    private static async Task ExecuteTrigger()
    {
        await Task.Delay(TriggerDelayMs);
        Utility.MouseLeftDown();
        Utility.MouseLeftUp();
    }

    public static bool IsHotKeyDown() => _triggerBotHotKey.IsKeyDown();
}
