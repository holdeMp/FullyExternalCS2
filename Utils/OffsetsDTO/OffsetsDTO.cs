namespace CS2Cheat.Utils.OffsetsDTO;

using Newtonsoft.Json;

[JsonObject]
[Serializable]
public class OffsetsDto
{
    [JsonProperty("client_dll")]
    public ClientDllOffsets? ClientDll
    {
        get;
        set;
    }

    [JsonProperty("engine2_dll")]
    public Engine2Dll? Engine2Dll
    {
        get;
        set;
    }

    [JsonProperty("inputsystem_dll")]
    public InputsystemDll? InputsystemDll
    {
        get;
        set;
    }

    [JsonProperty("matchmaking_dll")]
    public MatchmakingDll? MatchmakingDll
    {
        get;
        set;
    }

    [JsonProperty("soundsystem_dll")]
    public SoundsystemDll? SoundSystemDll
    {
        get;
        set;
    }
}

[JsonObject]
[Serializable]
public class ClientDllOffsets
{
    [JsonProperty("dwCSGOInput")]
    public int DwCsgoInput
    {
        get;
        set;
    }

    [JsonProperty("dwEntityList")]
    public int DwEntityList
    {
        get;
        set;
    }

    [JsonProperty("dwGameEntitySystem")]
    public int DwGameEntitySystem
    {
        get;
        set;
    }

    [JsonProperty("dwGameEntitySystem_highestEntityIndex")]
    public int DwGameEntitySystemHighestEntityIndex
    {
        get;
        set;
    }

    [JsonProperty("dwGameRules")]
    public int DwGameRules
    {
        get;
        set;
    }

    [JsonProperty("dwGlobalVars")]
    public int DwGlobalVars
    {
        get;
        set;
    }

    [JsonProperty("dwGlowManager")]
    public int DwGlowManager
    {
        get;
        set;
    }

    [JsonProperty("dwLocalPlayerController")]
    public int DwLocalPlayerController
    {
        get;
        set;
    }

    [JsonProperty("dwLocalPlayerPawn")]
    public int DwLocalPlayerPawn
    {
        get;
        set;
    }

    [JsonProperty("dwPlantedC4")]
    public int DwPlantedC4
    {
        get;
        set;
    }

    [JsonProperty("dwPrediction")]
    public int DwPrediction
    {
        get;
        set;
    }

    [JsonProperty("dwSensitivity")]
    public int DwSensitivity
    {
        get;
        set;
    }

    [JsonProperty("dwSensitivity_sensitivity")]
    public int DwSensitivitySensitivity
    {
        get;
        set;
    }

    [JsonProperty("dwViewAngles")]
    public int DwViewAngles
    {
        get;
        set;
    }

    [JsonProperty("dwViewMatrix")]
    public int DwViewMatrix
    {
        get;
        set;
    }

    [JsonProperty("dwViewRender")]
    public int DwViewRender
    {
        get;
        set;
    }

    [JsonProperty("dwWeaponC4")]
    public int DwWeaponC4
    {
        get;
        set;
    }
}

[JsonObject]
[Serializable]
public class Engine2Dll
{
    [JsonProperty("dwBuildNumber")]
    public int DwBuildNumber
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient")]
    public int DwNetworkGameClient
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_clientTickCount")]
    public int DwNetworkGameClientClientTickCount
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_deltaTick")]
    public int DwNetworkGameClientDeltaTick
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_isBackgroundMap")]
    public int DwNetworkGameClientIsBackgroundMap
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_localPlayer")]
    public int DwNetworkGameClientLocalPlayer
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_maxClients")]
    public int DwNetworkGameClientMaxClients
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_serverTickCount")]
    public int DwNetworkGameClientServerTickCount
    {
        get;
        set;
    }

    [JsonProperty("dwNetworkGameClient_signOnState")]
    public int DwNetworkGameClientSignOnState
    {
        get;
        set;
    }

    [JsonProperty("dwWindowHeight")]
    public int DwWindowHeight
    {
        get;
        set;
    }

    [JsonProperty("dwWindowWidth")]
    public int DwWindowWidth
    {
        get;
        set;
    }
}

[JsonObject]
[Serializable]
public class InputsystemDll
{
    [JsonProperty("dwInputSystem")]
    public int DwInputSystem
    {
        get;
        set;
    }
}

[JsonObject]
[Serializable]
public class MatchmakingDll
{
    [JsonProperty("dwGameTypes")]
    public int DwGameTypes
    {
        get;
        set;
    }
}

[JsonObject]
[Serializable]
public class SoundsystemDll
{
    [JsonProperty("dwSoundSystem")]
    public int DwSoundSystem
    {
        get;
        set;
    }

    [JsonProperty("dwSoundSystem_engineViewData")]
    public int DwSoundSystemEngineViewData
    {
        get;
        set;
    }
}
