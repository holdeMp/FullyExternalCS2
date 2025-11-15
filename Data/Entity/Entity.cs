namespace CS2Cheat.Data.Entity;

using System.Collections.Concurrent;
using Game;
using SharpDX;
using Utils;

public class Entity : EntityBase
{
    private readonly ConcurrentDictionary<string, Vector3> _bonePositions;
    private bool _dormant = true;

    public Entity(int index)
    {
        Id = index;
        _bonePositions = new ConcurrentDictionary<string, Vector3>(Offsets.Bones.ToDictionary(
            bone => bone.Key,
            _ => Vector3.Zero
        ));
    }

    protected internal bool IsSpotted
    {
        get;
        private set;
    }

    protected internal string Name
    {
        get;
        private set;
    } = string.Empty;

    protected internal int IsInScope
    {
        get;
        private set;
    }

    protected internal int FlashAlpha
    {
        get;
        private set;
    }

    public IReadOnlyDictionary<string, Vector3> BonePos => _bonePositions;

    public int Id
    {
        get;
    }

    public override bool IsAlive() => base.IsAlive() && !_dormant;

    protected override IntPtr ReadControllerBase(GameProcess gameProcess)
    {
        var entryIndex = (Id & 0x7FFF) >> 9;

        if (gameProcess?.Process == null)
        {
            return IntPtr.Zero;
        }

        var listEntry = gameProcess.Process.Read<IntPtr>(EntityList + (8 * entryIndex) + 16);

        return listEntry != IntPtr.Zero
            ? gameProcess.Process.Read<IntPtr>(listEntry + (112 * (Id & 0x1FF)))
            : IntPtr.Zero;
    }

    protected override IntPtr ReadAddressBase(GameProcess gameProcess)
    {
        if (gameProcess?.Process == null)
        {
            return IntPtr.Zero;
        }

        var playerPawn = gameProcess.Process.Read<int>(ControllerBase + Offsets.MhPawn);
        var pawnIndex = (playerPawn & 0x7FFF) >> 9;
        var listEntry = gameProcess.Process.Read<IntPtr>(EntityList + (0x8 * pawnIndex) + 16);

        return listEntry != IntPtr.Zero
            ? gameProcess.Process.Read<IntPtr>(listEntry + (112 * (playerPawn & 0x1FF)))
            : IntPtr.Zero;
    }

    public override bool Update(GameProcess gameProcess)
    {
        if (!base.Update(gameProcess))
        {
            return false;
        }

        _dormant = gameProcess.Process != null && gameProcess.Process.Read<bool>(AddressBase + Offsets.MbDormant);
        IsSpotted = gameProcess.Process?.Read<bool>(AddressBase + Offsets.MEntitySpottedState + 0x8) ?? false;
        IsInScope = gameProcess.Process?.Read<int>(AddressBase + Offsets.MbIsScoped) ?? 0;
        FlashAlpha = gameProcess.Process?.Read<int>(AddressBase + Offsets.MFlFlashDuration) ?? 0;
        Name = gameProcess.Process != null
            ? gameProcess.Process.ReadString(ControllerBase + Offsets.MIszPlayerName)
            : string.Empty;

        return !IsAlive() || UpdateBonePositions(gameProcess);
    }

    private bool UpdateBonePositions(GameProcess gameProcess)
    {
        try
        {
            if (gameProcess?.Process == null)
            {
                return false;
            }

            var gameSceneNode = gameProcess.Process.Read<IntPtr>(AddressBase + Offsets.MpGameSceneNode);
            var boneArray = gameProcess.Process.Read<IntPtr>(gameSceneNode + Offsets.MModelState + 128);

            foreach (var (boneName, boneIndex) in Offsets.Bones)
            {
                var bonePos = gameProcess.Process.Read<Vector3>(boneArray + (boneIndex * 32));
                _bonePositions.AddOrUpdate(boneName, bonePos, (_, _) => bonePos);
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
}
