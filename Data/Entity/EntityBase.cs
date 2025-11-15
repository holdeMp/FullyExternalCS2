namespace CS2Cheat.Data.Entity;

using Core;
using Core.Data;
using Game;
using SharpDX;
using Utils;

public abstract class EntityBase
{
    protected IntPtr EntityList
    {
        get;
        private set;
    }

    protected IntPtr ControllerBase
    {
        get;
        private set;
    }

    public IntPtr AddressBase
    {
        get;
        private set;
    }

    private bool LifeState
    {
        get;
        set;
    }

    public int Health
    {
        get;
        private set;
    }

    public Team Team
    {
        get;
        private set;
    }

    protected Vector3 Origin
    {
        get;
        private set;
    }

    public int ShotsFired
    {
        get;
        private set;
    }

    private IntPtr CurrentWeapon
    {
        get;
        set;
    }

    public string CurrentWeaponName
    {
        get;
        private set;
    } = string.Empty;

    private short WeaponIndex
    {
        get;
        set;
    }

    public Vector3 Velocity
    {
        get;
        private set;
    }


    public virtual bool IsAlive() =>
        ControllerBase != IntPtr.Zero &&
        AddressBase != IntPtr.Zero &&
        LifeState &&
        Health > 0 &&
        Team is Team.Terrorists or Team.CounterTerrorists;

    protected abstract IntPtr ReadControllerBase(GameProcess gameProcess);
    protected abstract IntPtr ReadAddressBase(GameProcess gameProcess);

    public virtual bool Update(GameProcess gameProcess)
    {
        if (gameProcess.ModuleClient == null)
        {
            throw new ArgumentNullException(nameof(gameProcess), ErrorMessages.ModuleclientCannotBeNull);
        }

        EntityList = gameProcess.ModuleClient.Read<IntPtr>(Offsets.DwEntityList);
        ControllerBase = ReadControllerBase(gameProcess);
        AddressBase = ReadAddressBase(gameProcess);
        if (ControllerBase == IntPtr.Zero || AddressBase == IntPtr.Zero)
        {
            return false;
        }

        if (gameProcess.Process == null)
        {
            throw new ArgumentNullException(nameof(gameProcess), ErrorMessages.ProcessCannotBeNull);
        }

        LifeState = gameProcess.Process.Read<bool>(AddressBase + Offsets.MLifeState);
        Health = gameProcess.Process.Read<int>(AddressBase + Offsets.MiHealth);
        Team = gameProcess.Process.Read<int>(AddressBase + Offsets.MiTeamNum).ToTeam();
        Origin = gameProcess.Process.Read<Vector3>(AddressBase + Offsets.MvOldOrigin);
        ShotsFired = gameProcess.Process.Read<int>(AddressBase + Offsets.MiShotsFired);

        CurrentWeapon = gameProcess.Process.Read<IntPtr>(AddressBase + Offsets.MpClippingWeapon);
        WeaponIndex = gameProcess.Process.Read<short>(CurrentWeapon + Offsets.MAttributeManager + Offsets.MItem +
                                                      Offsets.MiItemDefinitionIndex);
        CurrentWeaponName = Enum.GetName(typeof(WeaponIndexes), WeaponIndex)!;
        Velocity = gameProcess.Process.Read<Vector3>(AddressBase + Offsets.MVecAbsVelocity);

        return true;
    }
}
