namespace CS2Cheat.Data.Entity;

using Core;
using Core.Data;
using Game;
using Graphics;
using SharpDX;
using Utils;

public class Player : EntityBase
{
    private Matrix MatrixViewProjection
    {
        get;
        set;
    }

    public Matrix MatrixViewport
    {
        get;
        private set;
    }

    public Matrix MatrixViewProjectionViewport
    {
        get;
        private set;
    }

    private Vector3 ViewOffset
    {
        get;
        set;
    }

    public Vector3 EyePosition
    {
        get;
        private set;
    }

    private Vector3 ViewAngles
    {
        get;
        set;
    }

    public Vector3 AimPunchAngle
    {
        get;
        private set;
    }

    public Vector3 AimDirection
    {
        get;
        private set;
    }

    public Vector3 EyeDirection
    {
        get;
        private set;
    }

    public static int Fov => 90;

    public int FFlags
    {
        get;
        private set;
    }

    private int PreviousTotalHits
    {
        get;
        set;
    }

    protected override IntPtr ReadControllerBase(GameProcess gameProcess) =>
        gameProcess.ModuleClient?.Read<IntPtr>(Offsets.DwLocalPlayerController) ??
        throw new ArgumentNullException(nameof(gameProcess), ErrorMessages.ModuleclientCannotBeNull);

    protected override IntPtr ReadAddressBase(GameProcess gameProcess) =>
        gameProcess.ModuleClient?.Read<IntPtr>(Offsets.DwLocalPlayerPawn) ??
        throw new ArgumentNullException(nameof(gameProcess), ErrorMessages.ModuleclientCannotBeNull);

    public override bool Update(GameProcess gameProcess)
    {
        if (!base.Update(gameProcess))
        {
            return false;
        }


        if (gameProcess.ModuleClient == null)
        {
            throw new ArgumentNullException(nameof(gameProcess), ErrorMessages.ModuleclientCannotBeNull);
        }

        MatrixViewProjection = Matrix.Transpose(gameProcess.ModuleClient.Read<Matrix>(Offsets.DwViewMatrix));
        MatrixViewport = Utility.GetMatrixViewport(gameProcess.WindowRectangleClient.Size);
        MatrixViewProjectionViewport = MatrixViewProjection * MatrixViewport;

        if (gameProcess.Process == null)
        {
            throw new ArgumentNullException(nameof(gameProcess), ErrorMessages.ProcessCannotBeNull);
        }

        ViewOffset = gameProcess.Process.Read<Vector3>(AddressBase + Offsets.MVecViewOffset);
        EyePosition = Origin + ViewOffset;
        ViewAngles = gameProcess.ModuleClient.Read<Vector3>(Offsets.DwViewAngles);
        AimPunchAngle = gameProcess.Process.Read<Vector3>(AddressBase + Offsets.MAimPunchAngle);
        FFlags = gameProcess.Process.Read<int>(AddressBase + Offsets.MfFlags);

        EyeDirection =
            GraphicsMath.GetVectorFromEulerAngles(ViewAngles.X.DegreeToRadian(), ViewAngles.Y.DegreeToRadian());
        AimDirection = GraphicsMath.GetVectorFromEulerAngles
        (
            (ViewAngles.X + (AimPunchAngle.X * Offsets.WeaponRecoilScale)).DegreeToRadian(),
            (ViewAngles.Y + (AimPunchAngle.Y * Offsets.WeaponRecoilScale)).DegreeToRadian()
        );


        var totalHits = gameProcess.Process.Read<int>
        (
            gameProcess.Process.Read<IntPtr>(AddressBase + 0x1518) + 0x40
        );

        PreviousTotalHits = totalHits;


        return true;
    }

    public bool IsGrenade() =>
        new HashSet<string>
        {
            nameof(WeaponIndexes.Smokegrenade),
            nameof(WeaponIndexes.Flashbang),
            nameof(WeaponIndexes.Hegrenade),
            nameof(WeaponIndexes.Molotov)
        }.Contains(CurrentWeaponName);
}
