namespace CS2Cheat.Utils;

using System.Dynamic;
using ClientDllDto;
using Core;
using Newtonsoft.Json;
using OffsetsDTO;

public static class Offsets
{
    public const float WeaponRecoilScale = 2f;
    public const nint MnCurrentTickThisFrame = 0x34;
    public static int DwLocalPlayerPawn;
    public static int MvOldOrigin;
    public static int MVecViewOffset;
    public static int MAimPunchAngle;
    public static int MModelState;
    public static int MpGameSceneNode;
    public static int MfFlags;
    public static int MiIdEntIndex;
    public static int MLifeState;
    public static int MiHealth;
    public static int MiTeamNum;
    public static int DwEntityList;
    public static int MbDormant;
    public static int MiShotsFired;
    public static int MhPawn;
    public static int DwLocalPlayerController;
    public static int DwViewMatrix;
    public static int DwViewAngles;
    public static int MEntitySpottedState;
    public static int MItem;
    public static int MpClippingWeapon;
    public static int MAttributeManager;
    public static int MiItemDefinitionIndex;
    public static int MbIsScoped;
    public static int MFlFlashDuration;
    public static int MIszPlayerName;
    public static int DwPlantedC4;
    public static int DwGlobalVars;
    public static int MnBombSite;
    public static int MbBombDefused;
    public static int MVecAbsVelocity;
    public static int MFlDefuseCountDown;
    public static int MFlC4Blow;
    public static int MbBeingDefused;

    public static readonly Dictionary<string, int> Bones = new()
    {
        { "head", 6 },
        { "neck_0", 5 },
        { "spine_1", 4 },
        { "spine_2", 2 },
        { "pelvis", 0 },
        { "arm_upper_L", 8 },
        { "arm_lower_L", 9 },
        { "hand_L", 10 },
        { "arm_upper_R", 13 },
        { "arm_lower_R", 14 },
        { "hand_R", 15 },
        { "leg_upper_L", 22 },
        { "leg_lower_L", 23 },
        { "ankle_L", 24 },
        { "leg_upper_R", 25 },
        { "leg_lower_R", 26 },
        { "ankle_R", 27 }
    };

    public static async Task UpdateOffsetsAsync()
    {
        try
        {
            var sourceDataDw = JsonConvert.DeserializeObject<OffsetsDto>(
                await FetchJson(Constants.OffsetsDllUri));
            var sourceDataClient = JsonConvert.DeserializeObject<ClientDll>(
                await FetchJson(Constants.ClientDllUri));

            dynamic destData = new ExpandoObject();

            // Offsets
            if (sourceDataDw != null)
            {
                if (sourceDataDw.Engine2Dll != null)
                {
                    destData.dwBuildNumber = sourceDataDw.Engine2Dll.DwBuildNumber;
                }

                if (sourceDataDw.ClientDll != null)
                {
                    destData.dwLocalPlayerController = sourceDataDw.ClientDll.DwLocalPlayerController;
                    destData.dwEntityList = sourceDataDw.ClientDll.DwEntityList;
                    destData.dwViewMatrix = sourceDataDw.ClientDll.DwViewMatrix;
                    destData.dwPlantedC4 = sourceDataDw.ClientDll.DwPlantedC4;
                    destData.dwLocalPlayerPawn = sourceDataDw.ClientDll.DwLocalPlayerPawn;
                    destData.dwViewAngles = sourceDataDw.ClientDll.DwViewAngles;
                    destData.dwPlantedC4 = sourceDataDw.ClientDll.DwPlantedC4;
                    destData.dwGlobalVars = sourceDataDw.ClientDll.DwGlobalVars;
                }
            }

            // client.dll
            if (sourceDataClient is not null)
            {
                destData.m_fFlags = sourceDataClient.Classes.CBaseEntity.Fields.MFlags;
                destData.m_vOldOrigin = sourceDataClient.Classes.CBasePlayerPawn.Fields.MVOldOrigin;
                destData.m_vecViewOffset =
                    sourceDataClient.Classes.CBaseModelEntity.Fields.MVecViewOffset;
                destData.m_aimPunchAngle = sourceDataClient.Classes.CCSPlayerPawn.Fields.MAimPunchAngle;
                destData.m_modelState = sourceDataClient.Classes.CSkeletonInstance.Fields.MModelState;
                destData.m_pGameSceneNode = sourceDataClient.Classes.CBaseEntity.Fields.MPGameSceneNode;
                destData.m_iIDEntIndex = sourceDataClient.Classes.CCSPlayerPawn.Fields.MIIDEntIndex;
                destData.m_lifeState = sourceDataClient.Classes.CBaseEntity.Fields.MLifeState;
                destData.m_iHealth = sourceDataClient.Classes.CBaseEntity.Fields.MIHealth;
                destData.m_iTeamNum = sourceDataClient.Classes.CBaseEntity.Fields.MITeamNum;
                destData.m_bDormant = sourceDataClient.Classes.CGameSceneNode.Fields.MBDormant;
                destData.m_iShotsFired = sourceDataClient.Classes.CCSPlayerPawn.Fields.MIShotsFired;
                destData.m_hPawn = sourceDataClient.Classes.CBasePlayerController.Fields.MHPawn;
                destData.m_entitySpottedState =
                    sourceDataClient.Classes.CCSPlayerPawn.Fields.MEntitySpottedState;
                destData.m_Item = sourceDataClient.Classes.CAttributeContainer.Fields.MItem;
                destData.m_pClippingWeapon =
                    sourceDataClient.Classes.CCSPlayerPawnBase.Fields.MPClippingWeapon;
                destData.m_AttributeManager =
                    sourceDataClient.Classes.CEconEntity.Fields.MAttributeManager;
                destData.m_iItemDefinitionIndex =
                    sourceDataClient.Classes.CEconItemView.Fields.MIItemDefinitionIndex;
                destData.m_bIsScoped = sourceDataClient.Classes.CCSPlayerPawnBase.Fields.MBIsScoped;
                destData.m_flFlashDuration =
                    sourceDataClient.Classes.CCSPlayerPawnBase.Fields.MFlFlashDuration;
                destData.m_iszPlayerName =
                    sourceDataClient.Classes.CBasePlayerController.Fields.MIszPlayerName;
                destData.m_nBombSite = sourceDataClient.Classes.CPlantedC4.Fields.MNBombSite;
                destData.m_bBombDefused = sourceDataClient.Classes.CPlantedC4.Fields.MBBombDefused;
                destData.m_vecAbsVelocity =
                    sourceDataClient.Classes.CBaseEntity.Fields.MVecAbsVelocity;
                destData.m_flDefuseCountDown =
                    sourceDataClient.Classes.CPlantedC4.Fields.MFlDefuseCountDown;
                destData.m_flC4Blow = sourceDataClient.Classes.CPlantedC4.Fields.MFlC4Blow;
                destData.m_bBeingDefused = sourceDataClient.Classes.CPlantedC4.Fields.MBBeingDefused;
            }


            UpdateStaticFields(destData);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }

    private static async Task<string> FetchJson(Uri url)
    {
        using var client = new HttpClient();
        return await client.GetStringAsync(url);
    }

    private static void UpdateStaticFields(dynamic data)
    {
        DwLocalPlayerPawn = data.dwLocalPlayerPawn;
        MvOldOrigin = data.m_vOldOrigin;
        MVecViewOffset = data.m_vecViewOffset;
        MAimPunchAngle = data.m_aimPunchAngle;
        MModelState = data.m_modelState;
        MpGameSceneNode = data.m_pGameSceneNode;
        MiIdEntIndex = data.m_iIDEntIndex;
        MLifeState = data.m_lifeState;
        MiHealth = data.m_iHealth;
        MiTeamNum = data.m_iTeamNum;
        MbDormant = data.m_bDormant;
        MiShotsFired = data.m_iShotsFired;
        MhPawn = data.m_hPawn;
        MfFlags = data.m_fFlags;
        DwLocalPlayerController = data.dwLocalPlayerController;
        DwViewMatrix = data.dwViewMatrix;
        DwViewAngles = data.dwViewAngles;
        DwEntityList = data.dwEntityList;
        MEntitySpottedState = data.m_entitySpottedState;
        MItem = data.m_Item;
        MpClippingWeapon = data.m_pClippingWeapon;
        MAttributeManager = data.m_AttributeManager;
        MiItemDefinitionIndex = data.m_iItemDefinitionIndex;
        MbIsScoped = data.m_bIsScoped;
        MFlFlashDuration = data.m_flFlashDuration;
        MIszPlayerName = data.m_iszPlayerName;
        DwPlantedC4 = data.dwPlantedC4;
        DwGlobalVars = data.dwGlobalVars;
        MnBombSite = data.m_nBombSite;
        MbBombDefused = data.m_bBombDefused;
        MVecAbsVelocity = data.m_vecAbsVelocity;
        MFlDefuseCountDown = data.m_flDefuseCountDown;
        MFlC4Blow = data.m_flC4Blow;
        MbBeingDefused = data.m_bBeingDefused;
    }
}
