namespace CS2Cheat.Utils;

using System.Dynamic;
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
                await FetchJson("https://raw.githubusercontent.com/a2x/cs2-dumper/main/output/offsets.json"));
            var sourceDataClient = JsonConvert.DeserializeObject<ClientDllDto>(
                await FetchJson("https://raw.githubusercontent.com/a2x/cs2-dumper/main/output/client_dll.json"));

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
            if (sourceDataClient is { ClientDll: not null })
            {
                destData.m_fFlags = sourceDataClient.ClientDll.Classes.CBaseEntity.Fields.MfFlags;
                destData.m_vOldOrigin = sourceDataClient.ClientDll.Classes.CBasePlayerPawn.Fields.MvOldOrigin;
                destData.m_vecViewOffset =
                    sourceDataClient.ClientDll.Classes.CBaseModelEntity.Fields.MVecViewOffset;
                destData.m_aimPunchAngle = sourceDataClient.ClientDll.Classes.CCsPlayerPawn.Fields.MAimPunchAngle;
                destData.m_modelState = sourceDataClient.ClientDll.Classes.CSkeletonInstance.Fields.MModelState;
                destData.m_pGameSceneNode = sourceDataClient.ClientDll.Classes.CBaseEntity.Fields.MpGameSceneNode;
                destData.m_iIDEntIndex = sourceDataClient.ClientDll.Classes.CCsPlayerPawn.Fields.MiIdEntIndex;
                destData.m_lifeState = sourceDataClient.ClientDll.Classes.CBaseEntity.Fields.MLifeState;
                destData.m_iHealth = sourceDataClient.ClientDll.Classes.CBaseEntity.Fields.MiHealth;
                destData.m_iTeamNum = sourceDataClient.ClientDll.Classes.CBaseEntity.Fields.MiTeamNum;
                destData.m_bDormant = sourceDataClient.ClientDll.Classes.CGameSceneNode.Fields.MbDormant;
                destData.m_iShotsFired = sourceDataClient.ClientDll.Classes.CCsPlayerPawn.Fields.MiShotsFired;
                destData.m_hPawn = sourceDataClient.ClientDll.Classes.CBasePlayerController.Fields.MhPawn;
                destData.m_entitySpottedState =
                    sourceDataClient.ClientDll.Classes.CCsPlayerPawn.Fields.MEntitySpottedState;
                destData.m_Item = sourceDataClient.ClientDll.Classes.CAttributeContainer.Fields.MItem;
                destData.m_pClippingWeapon =
                    sourceDataClient.ClientDll.Classes.CCsPlayerPawnBase.Fields.MpClippingWeapon;
                destData.m_AttributeManager =
                    sourceDataClient.ClientDll.Classes.CEconEntity.Fields.MAttributeManager;
                destData.m_iItemDefinitionIndex =
                    sourceDataClient.ClientDll.Classes.CEconItemView.Fields.MiItemDefinitionIndex;
                destData.m_bIsScoped = sourceDataClient.ClientDll.Classes.CCsPlayerPawnBase.Fields.MbIsScoped;
                destData.m_flFlashDuration =
                    sourceDataClient.ClientDll.Classes.CCsPlayerPawnBase.Fields.MFlFlashDuration;
                destData.m_iszPlayerName =
                    sourceDataClient.ClientDll.Classes.CBasePlayerController.Fields.MIszPlayerName;
                destData.m_nBombSite = sourceDataClient.ClientDll.Classes.CPlantedC4.Fields.MnBombSite;
                destData.m_bBombDefused = sourceDataClient.ClientDll.Classes.CPlantedC4.Fields.MbBombDefused;
                destData.m_vecAbsVelocity =
                    sourceDataClient.ClientDll.Classes.CBaseEntity.Fields.MVecAbsVelocity;
                destData.m_flDefuseCountDown =
                    sourceDataClient.ClientDll.Classes.CPlantedC4.Fields.MFlDefuseCountDown;
                destData.m_flC4Blow = sourceDataClient.ClientDll.Classes.CPlantedC4.Fields.MFlC4Blow;
                destData.m_bBeingDefused = sourceDataClient.ClientDll.Classes.CPlantedC4.Fields.MbBeingDefused;
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

    private static async Task<string> FetchJson(string url)
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
