namespace CS2Cheat.Utils.ClientDllDto;

using System.Text.Json.Serialization;
using Newtonsoft.Json;
#pragma warning disable CA1507


public class CAttributeContainer : ClientDllDtoBase
{
}

public class CAttributeList : ClientDllDtoBase{
}

public class CAttributeManager: ClientDllDtoBase
{

}



public class CBaseAnimGraphController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseButton
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseClientUIEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseCombatCharacter
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseCSGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseCSGrenadeProjectile
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseDoor
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseEntityAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBaseFilter
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseFlex
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseFlexEmphasizedPhoneme
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBaseGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseModelEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBasePlayerController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBasePlayerControllerAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBasePlayerPawn
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBasePlayerVData
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBasePlayerWeapon
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBasePlayerWeaponVData
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBasePropDoor
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBasePulseGraphInstance
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBaseToggle
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseTrigger
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBaseTriggerAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBeam
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBodyComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBodyComponentBaseAnimGraph
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBodyComponentBaseModelEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBodyComponentPoint
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBodyComponentSkeletonInstance
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBombTarget
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBreakable
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBreakableProp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CBulletHitModel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CBuoyancyHelper
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CC4
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CChicken
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCitadelSoundOpvarSetOBB
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CClientRagdoll
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCollisionProperty
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CColorCorrection
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CColorCorrectionVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCS2HudModelAddon
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCS2HudModelArms
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCS2HudModelBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCS2HudModelWeapon
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCS2WeaponModuleBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGameModeRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CCSGameModeRulesArmsRace
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CCSGameModeRulesNoop
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CCSGameRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CCSGameRulesProxy
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOCounterTerroristTeamIntroCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOCounterTerroristWingmanIntroCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOEndOfMatchCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOEndOfMatchCharacterPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOEndOfMatchLineupEnd
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOEndOfMatchLineupEndpoint
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOEndOfMatchLineupStart
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOMapPreviewCameraPath
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOMapPreviewCameraPathNode
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOPreviewModel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOPreviewModelAliasCsgoItemPreviewmodel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOPreviewPlayer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOPreviewPlayerAliasCsgoPlayerPreviewmodel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamIntroCharacterPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamIntroCounterTerroristPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamIntroTerroristPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamPreviewCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamPreviewCharacterPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamPreviewModel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamSelectCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamSelectCharacterPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamSelectCounterTerroristPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTeamSelectTerroristPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTerroristTeamIntroCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOTerroristWingmanIntroCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOWingmanIntroCharacterPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOWingmanIntroCounterTerroristPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSGOWingmanIntroTerroristPosition
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCsmFovOverride
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSMinimapBoundary
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSObserverCameraServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSObserverMovementServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSObserverObserverServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSObserverPawn
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSObserverUseServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPetPlacement
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerActionTrackingServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerBaseCameraServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerBulletServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerBuyServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerCameraServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerControllerActionTrackingServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerControllerDamageServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerControllerInGameMoneyServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerControllerInventoryServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerControllerInventoryServicesNetworkedLoadoutSlotT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CCSPlayerDamageReactServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerGlowServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerHostageServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerItemServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerMovementServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerPawn
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerPawnBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerPingServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerResource
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerUseServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerWaterServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPlayerWeaponServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSPortraitWorldCallbackHandler
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSTeam
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSWeaponBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSWeaponBaseGun
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSWeaponBaseShotgun
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CCSWeaponBaseVData
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CDamageRecord
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CDEagle
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDecoyGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDecoyProjectile
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDestructiblePartsComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDynamicLight
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDynamicProp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDynamicPropAliasCableDynamic
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDynamicPropAliasDynamicProp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CDynamicPropAliasPropDynamicOverride
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEconEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEconEntityAttachedModelDataT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CEconItemAttribute
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CEconItemView
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEconWearable
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEffectData
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CEntityComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEntityDissolve
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEntityFlame
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEntityIdentity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEntityInstance
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CEnvCombinedLightProbeVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvCombinedLightProbeVolumeAliasFuncCombinedLightProbeVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvCubemap
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvCubemapBox
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvCubemapFog
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvDecal
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvDetailController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvLightProbeVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvParticleGlow
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSky
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSoundscape
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSoundscapeAliasSndSoundscape
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSoundscapeProxy
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSoundscapeProxyAliasSndSoundscapeProxy
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSoundscapeTriggerable
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvSoundscapeTriggerableAliasSndSoundscapeTriggerable
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvVolumetricFogController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvVolumetricFogVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvWind
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvWindClientside
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvWindController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvWindShared
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CEnvWindVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterAttributeInt
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterClass
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterLOS
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterMassGreater
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterModel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterMultiple
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterMultipleAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CFilterName
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterProximity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFilterTeam
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFireCrackerBlast
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFish
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFlashbang
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFlashbangProjectile
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFogController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFogplayerparamsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFootstepControl
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncBrush
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncConveyor
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncElectrifiedVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncLadder
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncMonitor
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncMoveLinear
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncMover
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncRetakeBarrier
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncRotating
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncTrackTrain
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CFuncWater
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGameRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CGameRulesProxy
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGameSceneNode
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGameSceneNodeHandle
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGlobalLight
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGlowProperty
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGradientFog
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CGrenadeTracer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHandleTest
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHEGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHEGrenadeProjectile
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHitboxComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHostage
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHostageCarriableProp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHostageRescueZone
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CHostageRescueZoneShim
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CIncendiaryGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInferno
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoDynamicShadowHint
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoDynamicShadowHintBox
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoFan
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoInstructorHintHostageRescueZone
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoLadderDismount
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoOffscreenPanoramaTexture
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoParticleTarget
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoTarget
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoVisibilityBox
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CInfoWorldLayer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CItem
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CItemDogtags
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CItemHealthshot
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CKeychainModule
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CKnife
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class Classes
{
    [JsonProperty("ActiveModelConfig_t")]
    [JsonPropertyName("ActiveModelConfig_t")]
    public ActiveModelConfigT ActiveModelConfigT
    {
        get;
        set;
    }


    [JsonProperty("CAttributeList")]
    [JsonPropertyName("CAttributeList")]
    public CAttributeList CAttributeList
    {
        get;
        set;
    }

    [JsonProperty("CAttributeManager")]
    [JsonPropertyName("CAttributeManager")]
    public CAttributeManager CAttributeManager
    {
        get;
        set;
    }



    [JsonProperty("CBasePlayerController")]
    [JsonPropertyName("CBasePlayerController")]
    public CBasePlayerController CBasePlayerController
    {
        get;
        set;
    }


    [JsonProperty("CBasePlayerVData")]
    [JsonPropertyName("CBasePlayerVData")]
    public CBasePlayerVData CBasePlayerVData
    {
        get;
        set;
    }

    [JsonProperty("CBasePlayerWeaponVData")]
    [JsonPropertyName("CBasePlayerWeaponVData")]
    public CBasePlayerWeaponVData CBasePlayerWeaponVData
    {
        get;
        set;
    }

    [JsonProperty("CBaseProp")]
    [JsonPropertyName("CBaseProp")]
    public CBaseProp CBaseProp
    {
        get;
        set;
    }

    [JsonProperty("CBasePulseGraphInstance")]
    [JsonPropertyName("CBasePulseGraphInstance")]
    public CBasePulseGraphInstance CBasePulseGraphInstance
    {
        get;
        set;
    }

    [JsonProperty("CBaseTriggerAPI")]
    [JsonPropertyName("CBaseTriggerAPI")]
    public CBaseTriggerAPI CBaseTriggerAPI
    {
        get;
        set;
    }

    [JsonProperty("CBodyComponent")]
    [JsonPropertyName("CBodyComponent")]
    public CBodyComponent CBodyComponent
    {
        get;
        set;
    }

    [JsonProperty("CBodyComponentBaseAnimGraph")]
    [JsonPropertyName("CBodyComponentBaseAnimGraph")]
    public CBodyComponentBaseAnimGraph CBodyComponentBaseAnimGraph
    {
        get;
        set;
    }

    [JsonProperty("CBodyComponentBaseModelEntity")]
    [JsonPropertyName("CBodyComponentBaseModelEntity")]
    public CBodyComponentBaseModelEntity CBodyComponentBaseModelEntity
    {
        get;
        set;
    }

    [JsonProperty("CBodyComponentPoint")]
    [JsonPropertyName("CBodyComponentPoint")]
    public CBodyComponentPoint CBodyComponentPoint
    {
        get;
        set;
    }

    [JsonProperty("CBodyComponentSkeletonInstance")]
    [JsonPropertyName("CBodyComponentSkeletonInstance")]
    public CBodyComponentSkeletonInstance CBodyComponentSkeletonInstance
    {
        get;
        set;
    }

    [JsonProperty("CBombTarget")]
    [JsonPropertyName("CBombTarget")]
    public CBombTarget CBombTarget
    {
        get;
        set;
    }

    [JsonProperty("CBuoyancyHelper")]
    [JsonPropertyName("CBuoyancyHelper")]
    public CBuoyancyHelper CBuoyancyHelper
    {
        get;
        set;
    }

    [JsonProperty("CCSGO_WingmanIntroCharacterPosition")]
    [JsonPropertyName("CCSGO_WingmanIntroCharacterPosition")]
    public CCSGOWingmanIntroCharacterPosition CCSGOWingmanIntroCharacterPosition
    {
        get;
        set;
    }

    [JsonProperty("CCSGO_WingmanIntroCounterTerroristPosition")]
    [JsonPropertyName("CCSGO_WingmanIntroCounterTerroristPosition")]
    public CCSGOWingmanIntroCounterTerroristPosition CCSGOWingmanIntroCounterTerroristPosition
    {
        get;
        set;
    }

    [JsonProperty("CCSGO_WingmanIntroTerroristPosition")]
    [JsonPropertyName("CCSGO_WingmanIntroTerroristPosition")]
    public CCSGOWingmanIntroTerroristPosition CCSGOWingmanIntroTerroristPosition
    {
        get;
        set;
    }

    [JsonProperty("CCSGameModeRules")]
    [JsonPropertyName("CCSGameModeRules")]
    public CCSGameModeRules CCSGameModeRules
    {
        get;
        set;
    }

    [JsonProperty("CCSGameModeRules_ArmsRace")]
    [JsonPropertyName("CCSGameModeRules_ArmsRace")]
    public CCSGameModeRulesArmsRace CCSGameModeRulesArmsRace
    {
        get;
        set;
    }

    [JsonProperty("CCSGameModeRules_Deathmatch")]
    [JsonPropertyName("CCSGameModeRules_Deathmatch")]
    public CcsGameModeRulesDeathmatch CCSGameModeRulesDeathmatch
    {
        get;
        set;
    }

    [JsonProperty("CCSGameModeRules_Noop")]
    [JsonPropertyName("CCSGameModeRules_Noop")]
    public CCSGameModeRulesNoop CCSGameModeRulesNoop
    {
        get;
        set;
    }

    [JsonProperty("CCSObserver_CameraServices")]
    [JsonPropertyName("CCSObserver_CameraServices")]
    public CCSObserverCameraServices CCSObserverCameraServices
    {
        get;
        set;
    }

    [JsonProperty("CCSObserver_MovementServices")]
    [JsonPropertyName("CCSObserver_MovementServices")]
    public CCSObserverMovementServices CCSObserverMovementServices
    {
        get;
        set;
    }

    [JsonProperty("CCSObserver_ObserverServices")]
    [JsonPropertyName("CCSObserver_ObserverServices")]
    public CCSObserverObserverServices CCSObserverObserverServices
    {
        get;
        set;
    }

    [JsonProperty("CCSObserver_UseServices")]
    [JsonPropertyName("CCSObserver_UseServices")]
    public CCSObserverUseServices CCSObserverUseServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerBase_CameraServices")]
    [JsonPropertyName("CCSPlayerBase_CameraServices")]
    public CCSPlayerBaseCameraServices CCSPlayerBaseCameraServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerController")]
    [JsonPropertyName("CCSPlayerController")]
    public CCSPlayerController CCSPlayerController
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerController_ActionTrackingServices")]
    [JsonPropertyName("CCSPlayerController_ActionTrackingServices")]
    public CCSPlayerControllerActionTrackingServices CCSPlayerControllerActionTrackingServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerController_DamageServices")]
    [JsonPropertyName("CCSPlayerController_DamageServices")]
    public CCSPlayerControllerDamageServices CCSPlayerControllerDamageServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerController_InGameMoneyServices")]
    [JsonPropertyName("CCSPlayerController_InGameMoneyServices")]
    public CCSPlayerControllerInGameMoneyServices CCSPlayerControllerInGameMoneyServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerController_InventoryServices")]
    [JsonPropertyName("CCSPlayerController_InventoryServices")]
    public CCSPlayerControllerInventoryServices CCSPlayerControllerInventoryServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t")]
    [JsonPropertyName("CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t")]
    public CCSPlayerControllerInventoryServicesNetworkedLoadoutSlotT
        CCSPlayerControllerInventoryServicesNetworkedLoadoutSlotT
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_ActionTrackingServices")]
    [JsonPropertyName("CCSPlayer_ActionTrackingServices")]
    public CCSPlayerActionTrackingServices CCSPlayerActionTrackingServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_BulletServices")]
    [JsonPropertyName("CCSPlayer_BulletServices")]
    public CCSPlayerBulletServices CCSPlayerBulletServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_BuyServices")]
    [JsonPropertyName("CCSPlayer_BuyServices")]
    public CCSPlayerBuyServices CCSPlayerBuyServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_CameraServices")]
    [JsonPropertyName("CCSPlayer_CameraServices")]
    public CCSPlayerCameraServices CCSPlayerCameraServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_DamageReactServices")]
    [JsonPropertyName("CCSPlayer_DamageReactServices")]
    public CCSPlayerDamageReactServices CCSPlayerDamageReactServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_GlowServices")]
    [JsonPropertyName("CCSPlayer_GlowServices")]
    public CCSPlayerGlowServices CCSPlayerGlowServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_HostageServices")]
    [JsonPropertyName("CCSPlayer_HostageServices")]
    public CCSPlayerHostageServices CCSPlayerHostageServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_ItemServices")]
    [JsonPropertyName("CCSPlayer_ItemServices")]
    public CCSPlayerItemServices CCSPlayerItemServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_MovementServices")]
    [JsonPropertyName("CCSPlayer_MovementServices")]
    public CCSPlayerMovementServices CCSPlayerMovementServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_PingServices")]
    [JsonPropertyName("CCSPlayer_PingServices")]
    public CCSPlayerPingServices CCSPlayerPingServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_UseServices")]
    [JsonPropertyName("CCSPlayer_UseServices")]
    public CCSPlayerUseServices CCSPlayerUseServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_WaterServices")]
    [JsonPropertyName("CCSPlayer_WaterServices")]
    public CCSPlayerWaterServices CCSPlayerWaterServices
    {
        get;
        set;
    }

    [JsonProperty("CCSPlayer_WeaponServices")]
    [JsonPropertyName("CCSPlayer_WeaponServices")]
    public CCSPlayerWeaponServices CCSPlayerWeaponServices
    {
        get;
        set;
    }

    [JsonProperty("CCSWeaponBaseVData")]
    [JsonPropertyName("CCSWeaponBaseVData")]
    public CCSWeaponBaseVData CCSWeaponBaseVData
    {
        get;
        set;
    }

    [JsonProperty("CCS_PortraitWorldCallbackHandler")]
    [JsonPropertyName("CCS_PortraitWorldCallbackHandler")]
    public CCSPortraitWorldCallbackHandler CCSPortraitWorldCallbackHandler
    {
        get;
        set;
    }

    [JsonProperty("CCitadelSoundOpvarSetOBB")]
    [JsonPropertyName("CCitadelSoundOpvarSetOBB")]
    public CCitadelSoundOpvarSetOBB CCitadelSoundOpvarSetOBB
    {
        get;
        set;
    }

    [JsonProperty("CCollisionProperty")]
    [JsonPropertyName("CCollisionProperty")]
    public CCollisionProperty CCollisionProperty
    {
        get;
        set;
    }

    [JsonProperty("CDamageRecord")]
    [JsonPropertyName("CDamageRecord")]
    public CDamageRecord CDamageRecord
    {
        get;
        set;
    }

    [JsonProperty("CDestructiblePartsComponent")]
    [JsonPropertyName("CDestructiblePartsComponent")]
    public CDestructiblePartsComponent CDestructiblePartsComponent
    {
        get;
        set;
    }

    [JsonProperty("CEconItemAttribute")]
    [JsonPropertyName("CEconItemAttribute")]
    public CEconItemAttribute CEconItemAttribute
    {
        get;
        set;
    }

    [JsonProperty("CEffectData")]
    [JsonPropertyName("CEffectData")]
    public CEffectData CEffectData
    {
        get;
        set;
    }

    [JsonProperty("CEntityComponent")]
    [JsonPropertyName("CEntityComponent")]
    public CEntityComponent CEntityComponent
    {
        get;
        set;
    }

    [JsonProperty("CEntityIdentity")]
    [JsonPropertyName("CEntityIdentity")]
    public CEntityIdentity CEntityIdentity
    {
        get;
        set;
    }

    [JsonProperty("CEntityInstance")]
    [JsonPropertyName("CEntityInstance")]
    public CEntityInstance CEntityInstance
    {
        get;
        set;
    }

    [JsonProperty("CEnvSoundscape")]
    [JsonPropertyName("CEnvSoundscape")]
    public CEnvSoundscape CEnvSoundscape
    {
        get;
        set;
    }

    [JsonProperty("CEnvSoundscapeAlias_snd_soundscape")]
    [JsonPropertyName("CEnvSoundscapeAlias_snd_soundscape")]
    public CEnvSoundscapeAliasSndSoundscape CEnvSoundscapeAliasSndSoundscape
    {
        get;
        set;
    }

    [JsonProperty("CEnvSoundscapeProxy")]
    [JsonPropertyName("CEnvSoundscapeProxy")]
    public CEnvSoundscapeProxy CEnvSoundscapeProxy
    {
        get;
        set;
    }

    [JsonProperty("CEnvSoundscapeProxyAlias_snd_soundscape_proxy")]
    [JsonPropertyName("CEnvSoundscapeProxyAlias_snd_soundscape_proxy")]
    public CEnvSoundscapeProxyAliasSndSoundscapeProxy CEnvSoundscapeProxyAliasSndSoundscapeProxy
    {
        get;
        set;
    }

    [JsonProperty("CEnvSoundscapeTriggerable")]
    [JsonPropertyName("CEnvSoundscapeTriggerable")]
    public CEnvSoundscapeTriggerable CEnvSoundscapeTriggerable
    {
        get;
        set;
    }

    [JsonProperty("CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable")]
    [JsonPropertyName("CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable")]
    public CEnvSoundscapeTriggerableAliasSndSoundscapeTriggerable CEnvSoundscapeTriggerableAliasSndSoundscapeTriggerable
    {
        get;
        set;
    }

    [JsonProperty("CFilterAttributeInt")]
    [JsonPropertyName("CFilterAttributeInt")]
    public CFilterAttributeInt CFilterAttributeInt
    {
        get;
        set;
    }

    [JsonProperty("CFilterClass")]
    [JsonPropertyName("CFilterClass")]
    public CFilterClass CFilterClass
    {
        get;
        set;
    }

    [JsonProperty("CFilterLOS")]
    [JsonPropertyName("CFilterLOS")]
    public CFilterLOS CFilterLOS
    {
        get;
        set;
    }

    [JsonProperty("CFilterMassGreater")]
    [JsonPropertyName("CFilterMassGreater")]
    public CFilterMassGreater CFilterMassGreater
    {
        get;
        set;
    }

    [JsonProperty("CFilterModel")]
    [JsonPropertyName("CFilterModel")]
    public CFilterModel CFilterModel
    {
        get;
        set;
    }

    [JsonProperty("CFilterMultiple")]
    [JsonPropertyName("CFilterMultiple")]
    public CFilterMultiple CFilterMultiple
    {
        get;
        set;
    }

    [JsonProperty("CFilterMultipleAPI")]
    [JsonPropertyName("CFilterMultipleAPI")]
    public CFilterMultipleAPI CFilterMultipleAPI
    {
        get;
        set;
    }

    [JsonProperty("CFilterName")]
    [JsonPropertyName("CFilterName")]
    public CFilterName CFilterName
    {
        get;
        set;
    }

    [JsonProperty("CFilterProximity")]
    [JsonPropertyName("CFilterProximity")]
    public CFilterProximity CFilterProximity
    {
        get;
        set;
    }

    [JsonProperty("CFilterTeam")]
    [JsonPropertyName("CFilterTeam")]
    public CFilterTeam CFilterTeam
    {
        get;
        set;
    }

    [JsonProperty("CFuncRetakeBarrier")]
    [JsonPropertyName("CFuncRetakeBarrier")]
    public CFuncRetakeBarrier CFuncRetakeBarrier
    {
        get;
        set;
    }

    [JsonProperty("CFuncWater")]
    [JsonPropertyName("CFuncWater")]
    public CFuncWater CFuncWater
    {
        get;
        set;
    }

    [JsonProperty("CGameSceneNode")]
    [JsonPropertyName("CGameSceneNode")]
    public CGameSceneNode CGameSceneNode
    {
        get;
        set;
    }

    [JsonProperty("CGameSceneNodeHandle")]
    [JsonPropertyName("CGameSceneNodeHandle")]
    public CGameSceneNodeHandle CGameSceneNodeHandle
    {
        get;
        set;
    }

    [JsonProperty("CGlowProperty")]
    [JsonPropertyName("CGlowProperty")]
    public CGlowProperty CGlowProperty
    {
        get;
        set;
    }

    [JsonProperty("CGrenadeTracer")]
    [JsonPropertyName("CGrenadeTracer")]
    public CGrenadeTracer CGrenadeTracer
    {
        get;
        set;
    }

    [JsonProperty("CHitboxComponent")]
    [JsonPropertyName("CHitboxComponent")]
    public CHitboxComponent CHitboxComponent
    {
        get;
        set;
    }

    [JsonProperty("CHostageRescueZone")]
    [JsonPropertyName("CHostageRescueZone")]
    public CHostageRescueZone CHostageRescueZone
    {
        get;
        set;
    }

    [JsonProperty("CHostageRescueZoneShim")]
    [JsonPropertyName("CHostageRescueZoneShim")]
    public CHostageRescueZoneShim CHostageRescueZoneShim
    {
        get;
        set;
    }

    [JsonProperty("CInfoDynamicShadowHint")]
    [JsonPropertyName("CInfoDynamicShadowHint")]
    public CInfoDynamicShadowHint CInfoDynamicShadowHint
    {
        get;
        set;
    }

    [JsonProperty("CInfoDynamicShadowHintBox")]
    [JsonPropertyName("CInfoDynamicShadowHintBox")]
    public CInfoDynamicShadowHintBox CInfoDynamicShadowHintBox
    {
        get;
        set;
    }

    [JsonProperty("CInfoFan")]
    [JsonPropertyName("CInfoFan")]
    public CInfoFan CInfoFan
    {
        get;
        set;
    }

    [JsonProperty("CInfoOffscreenPanoramaTexture")]
    [JsonPropertyName("CInfoOffscreenPanoramaTexture")]
    public CInfoOffscreenPanoramaTexture CInfoOffscreenPanoramaTexture
    {
        get;
        set;
    }

    [JsonProperty("CInfoParticleTarget")]
    [JsonPropertyName("CInfoParticleTarget")]
    public CInfoParticleTarget CInfoParticleTarget
    {
        get;
        set;
    }

    [JsonProperty("CInfoTarget")]
    [JsonPropertyName("CInfoTarget")]
    public CInfoTarget CInfoTarget
    {
        get;
        set;
    }

    [JsonProperty("CInfoWorldLayer")]
    [JsonPropertyName("CInfoWorldLayer")]
    public CInfoWorldLayer CInfoWorldLayer
    {
        get;
        set;
    }

    [JsonProperty("CLightComponent")]
    [JsonPropertyName("CLightComponent")]
    public CLightComponent CLightComponent
    {
        get;
        set;
    }

    [JsonProperty("CLogicRelay")]
    [JsonPropertyName("CLogicRelay")]
    public CLogicRelay CLogicRelay
    {
        get;
        set;
    }

    [JsonProperty("CLogicRelayAPI")]
    [JsonPropertyName("CLogicRelayAPI")]
    public CLogicRelayAPI CLogicRelayAPI
    {
        get;
        set;
    }

    [JsonProperty("CLogicalEntity")]
    [JsonPropertyName("CLogicalEntity")]
    public CLogicalEntity CLogicalEntity
    {
        get;
        set;
    }

    [JsonProperty("CMapInfo")]
    [JsonPropertyName("CMapInfo")]
    public CMapInfo CMapInfo
    {
        get;
        set;
    }

    [JsonProperty("CModelState")]
    [JsonPropertyName("CModelState")]
    public CModelState CModelState
    {
        get;
        set;
    }

    [JsonProperty("CNetworkedSequenceOperation")]
    [JsonPropertyName("CNetworkedSequenceOperation")]
    public CNetworkedSequenceOperation CNetworkedSequenceOperation
    {
        get;
        set;
    }

    [JsonProperty("CPathQueryComponent")]
    [JsonPropertyName("CPathQueryComponent")]
    public CPathQueryComponent CPathQueryComponent
    {
        get;
        set;
    }

    [JsonProperty("CPathSimple")]
    [JsonPropertyName("CPathSimple")]
    public CPathSimple CPathSimple
    {
        get;
        set;
    }

    [JsonProperty("CPathSimpleAPI")]
    [JsonPropertyName("CPathSimpleAPI")]
    public CPathSimpleAPI CPathSimpleAPI
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_AutoaimServices")]
    [JsonPropertyName("CPlayer_AutoaimServices")]
    public CPlayerAutoaimServices CPlayerAutoaimServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_CameraServices")]
    [JsonPropertyName("CPlayer_CameraServices")]
    public CPlayerCameraServices CPlayerCameraServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_FlashlightServices")]
    [JsonPropertyName("CPlayer_FlashlightServices")]
    public CPlayerFlashlightServices CPlayerFlashlightServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_ItemServices")]
    [JsonPropertyName("CPlayer_ItemServices")]
    public CPlayerItemServices CPlayerItemServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_MovementServices")]
    [JsonPropertyName("CPlayer_MovementServices")]
    public CPlayerMovementServices CPlayerMovementServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_MovementServices_Humanoid")]
    [JsonPropertyName("CPlayer_MovementServices_Humanoid")]
    public CPlayerMovementServicesHumanoid CPlayerMovementServicesHumanoid
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_ObserverServices")]
    [JsonPropertyName("CPlayer_ObserverServices")]
    public CPlayerObserverServices CPlayerObserverServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_UseServices")]
    [JsonPropertyName("CPlayer_UseServices")]
    public CPlayerUseServices CPlayerUseServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_WaterServices")]
    [JsonPropertyName("CPlayer_WaterServices")]
    public CPlayerWaterServices CPlayerWaterServices
    {
        get;
        set;
    }

    [JsonProperty("CPlayer_WeaponServices")]
    [JsonPropertyName("CPlayer_WeaponServices")]
    public CPlayerWeaponServices CPlayerWeaponServices
    {
        get;
        set;
    }

    [JsonProperty("CPointChildModifier")]
    [JsonPropertyName("CPointChildModifier")]
    public CPointChildModifier CPointChildModifier
    {
        get;
        set;
    }

    [JsonProperty("CPointOffScreenIndicatorUi")]
    [JsonPropertyName("CPointOffScreenIndicatorUi")]
    public CPointOffScreenIndicatorUi CPointOffScreenIndicatorUi
    {
        get;
        set;
    }

    [JsonProperty("CPointOrient")]
    [JsonPropertyName("CPointOrient")]
    public CPointOrient CPointOrient
    {
        get;
        set;
    }

    [JsonProperty("CPointTemplate")]
    [JsonPropertyName("CPointTemplate")]
    public CPointTemplate CPointTemplate
    {
        get;
        set;
    }

    [JsonProperty("CPointTemplateAPI")]
    [JsonPropertyName("CPointTemplateAPI")]
    public CPointTemplateAPI CPointTemplateAPI
    {
        get;
        set;
    }

    [JsonProperty("CPrecipitationVData")]
    [JsonPropertyName("CPrecipitationVData")]
    public CPrecipitationVData CPrecipitationVData
    {
        get;
        set;
    }

    [JsonProperty("CPropDataComponent")]
    [JsonPropertyName("CPropDataComponent")]
    public CPropDataComponent CPropDataComponent
    {
        get;
        set;
    }

    [JsonProperty("CPulseAnimFuncs")]
    [JsonPropertyName("CPulseAnimFuncs")]
    public CPulseAnimFuncs CPulseAnimFuncs
    {
        get;
        set;
    }

    [JsonProperty("CPulseArraylib")]
    [JsonPropertyName("CPulseArraylib")]
    public CPulseArraylib CPulseArraylib
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Base")]
    [JsonPropertyName("CPulseCell_Base")]
    public CPulseCellBase CPulseCellBase
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseFlow")]
    [JsonPropertyName("CPulseCell_BaseFlow")]
    public CPulseCellBaseFlow CPulseCellBaseFlow
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseLerp")]
    [JsonPropertyName("CPulseCell_BaseLerp")]
    public CPulseCellBaseLerp CPulseCellBaseLerp
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseLerp__CursorState_t")]
    [JsonPropertyName("CPulseCell_BaseLerp__CursorState_t")]
    public CPulseCellBaseLerpCursorStateT CPulseCellBaseLerpCursorStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseRequirement")]
    [JsonPropertyName("CPulseCell_BaseRequirement")]
    public CPulseCellBaseRequirement CPulseCellBaseRequirement
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseState")]
    [JsonPropertyName("CPulseCell_BaseState")]
    public CPulseCellBaseState CPulseCellBaseState
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseValue")]
    [JsonPropertyName("CPulseCell_BaseValue")]
    public CPulseCellBaseValue CPulseCellBaseValue
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BaseYieldingInflow")]
    [JsonPropertyName("CPulseCell_BaseYieldingInflow")]
    public CPulseCellBaseYieldingInflow CPulseCellBaseYieldingInflow
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_BooleanSwitchState")]
    [JsonPropertyName("CPulseCell_BooleanSwitchState")]
    public CPulseCellBooleanSwitchState CPulseCellBooleanSwitchState
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_CursorQueue")]
    [JsonPropertyName("CPulseCell_CursorQueue")]
    public CPulseCellCursorQueue CPulseCellCursorQueue
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_FireCursors")]
    [JsonPropertyName("CPulseCell_FireCursors")]
    public CPulseCellFireCursors CPulseCellFireCursors
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_BaseEntrypoint")]
    [JsonPropertyName("CPulseCell_Inflow_BaseEntrypoint")]
    public CPulseCellInflowBaseEntrypoint CPulseCellInflowBaseEntrypoint
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_EntOutputHandler")]
    [JsonPropertyName("CPulseCell_Inflow_EntOutputHandler")]
    public CPulseCellInflowEntOutputHandler CPulseCellInflowEntOutputHandler
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_EventHandler")]
    [JsonPropertyName("CPulseCell_Inflow_EventHandler")]
    public CPulseCellInflowEventHandler CPulseCellInflowEventHandler
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_GraphHook")]
    [JsonPropertyName("CPulseCell_Inflow_GraphHook")]
    public CPulseCellInflowGraphHook CPulseCellInflowGraphHook
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_Method")]
    [JsonPropertyName("CPulseCell_Inflow_Method")]
    public CPulseCellInflowMethod CPulseCellInflowMethod
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_ObservableVariableListener")]
    [JsonPropertyName("CPulseCell_Inflow_ObservableVariableListener")]
    public CPulseCellInflowObservableVariableListener CPulseCellInflowObservableVariableListener
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_Wait")]
    [JsonPropertyName("CPulseCell_Inflow_Wait")]
    public CPulseCellInflowWait CPulseCellInflowWait
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Inflow_Yield")]
    [JsonPropertyName("CPulseCell_Inflow_Yield")]
    public CPulseCellInflowYield CPulseCellInflowYield
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_InlineNodeSkipSelector")]
    [JsonPropertyName("CPulseCell_InlineNodeSkipSelector")]
    public CPulseCellInlineNodeSkipSelector CPulseCellInlineNodeSkipSelector
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_IntervalTimer")]
    [JsonPropertyName("CPulseCell_IntervalTimer")]
    public CPulseCellIntervalTimer CPulseCellIntervalTimer
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_IntervalTimer__CursorState_t")]
    [JsonPropertyName("CPulseCell_IntervalTimer__CursorState_t")]
    public CPulseCellIntervalTimerCursorStateT CPulseCellIntervalTimerCursorStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_IsRequirementValid")]
    [JsonPropertyName("CPulseCell_IsRequirementValid")]
    public CPulseCellIsRequirementValid CPulseCellIsRequirementValid
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_IsRequirementValid__Criteria_t")]
    [JsonPropertyName("CPulseCell_IsRequirementValid__Criteria_t")]
    public CPulseCellIsRequirementValidCriteriaT CPulseCellIsRequirementValidCriteriaT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_LerpCameraSettings")]
    [JsonPropertyName("CPulseCell_LerpCameraSettings")]
    public CPulseCellLerpCameraSettings CPulseCellLerpCameraSettings
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_LerpCameraSettings__CursorState_t")]
    [JsonPropertyName("CPulseCell_LerpCameraSettings__CursorState_t")]
    public CPulseCellLerpCameraSettingsCursorStateT CPulseCellLerpCameraSettingsCursorStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_LimitCount")]
    [JsonPropertyName("CPulseCell_LimitCount")]
    public CPulseCellLimitCount CPulseCellLimitCount
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_LimitCount__Criteria_t")]
    [JsonPropertyName("CPulseCell_LimitCount__Criteria_t")]
    public CPulseCellLimitCountCriteriaT CPulseCellLimitCountCriteriaT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_LimitCount__InstanceState_t")]
    [JsonPropertyName("CPulseCell_LimitCount__InstanceState_t")]
    public CPulseCellLimitCountInstanceStateT CPulseCellLimitCountInstanceStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Outflow_CycleOrdered")]
    [JsonPropertyName("CPulseCell_Outflow_CycleOrdered")]
    public CPulseCellOutflowCycleOrdered CPulseCellOutflowCycleOrdered
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Outflow_CycleOrdered__InstanceState_t")]
    [JsonPropertyName("CPulseCell_Outflow_CycleOrdered__InstanceState_t")]
    public CPulseCellOutflowCycleOrderedInstanceStateT CPulseCellOutflowCycleOrderedInstanceStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Outflow_CycleRandom")]
    [JsonPropertyName("CPulseCell_Outflow_CycleRandom")]
    public CPulseCellOutflowCycleRandom CPulseCellOutflowCycleRandom
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Outflow_CycleShuffled")]
    [JsonPropertyName("CPulseCell_Outflow_CycleShuffled")]
    public CPulseCellOutflowCycleShuffled CPulseCellOutflowCycleShuffled
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Outflow_CycleShuffled__InstanceState_t")]
    [JsonPropertyName("CPulseCell_Outflow_CycleShuffled__InstanceState_t")]
    public CPulseCellOutflowCycleShuffledInstanceStateT CPulseCellOutflowCycleShuffledInstanceStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_PickBestOutflowSelector")]
    [JsonPropertyName("CPulseCell_PickBestOutflowSelector")]
    public CPulseCellPickBestOutflowSelector CPulseCellPickBestOutflowSelector
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_PlaySequence")]
    [JsonPropertyName("CPulseCell_PlaySequence")]
    public CPulseCellPlaySequence CPulseCellPlaySequence
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_PlaySequence__CursorState_t")]
    [JsonPropertyName("CPulseCell_PlaySequence__CursorState_t")]
    public CPulseCellPlaySequenceCursorStateT CPulseCellPlaySequenceCursorStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Step_CallExternalMethod")]
    [JsonPropertyName("CPulseCell_Step_CallExternalMethod")]
    public CPulseCellStepCallExternalMethod CPulseCellStepCallExternalMethod
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Step_DebugLog")]
    [JsonPropertyName("CPulseCell_Step_DebugLog")]
    public CPulseCellStepDebugLog CPulseCellStepDebugLog
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Step_EntFire")]
    [JsonPropertyName("CPulseCell_Step_EntFire")]
    public CPulseCellStepEntFire CPulseCellStepEntFire
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Step_PublicOutput")]
    [JsonPropertyName("CPulseCell_Step_PublicOutput")]
    public CPulseCellStepPublicOutput CPulseCellStepPublicOutput
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Timeline")]
    [JsonPropertyName("CPulseCell_Timeline")]
    public CPulseCellTimeline CPulseCellTimeline
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Timeline__TimelineEvent_t")]
    [JsonPropertyName("CPulseCell_Timeline__TimelineEvent_t")]
    public CPulseCellTimelineTimelineEventT CPulseCellTimelineTimelineEventT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Unknown")]
    [JsonPropertyName("CPulseCell_Unknown")]
    public CPulseCellUnknown CPulseCellUnknown
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Value_Curve")]
    [JsonPropertyName("CPulseCell_Value_Curve")]
    public CPulseCellValueCurve CPulseCellValueCurve
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Value_Gradient")]
    [JsonPropertyName("CPulseCell_Value_Gradient")]
    public CPulseCellValueGradient CPulseCellValueGradient
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Value_RandomFloat")]
    [JsonPropertyName("CPulseCell_Value_RandomFloat")]
    public CPulseCellValueRandomFloat CPulseCellValueRandomFloat
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_Value_RandomInt")]
    [JsonPropertyName("CPulseCell_Value_RandomInt")]
    public CPulseCellValueRandomInt CPulseCellValueRandomInt
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_WaitForCursorsWithTag")]
    [JsonPropertyName("CPulseCell_WaitForCursorsWithTag")]
    public CPulseCellWaitForCursorsWithTag CPulseCellWaitForCursorsWithTag
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_WaitForCursorsWithTagBase")]
    [JsonPropertyName("CPulseCell_WaitForCursorsWithTagBase")]
    public CPulseCellWaitForCursorsWithTagBase CPulseCellWaitForCursorsWithTagBase
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_WaitForCursorsWithTagBase__CursorState_t")]
    [JsonPropertyName("CPulseCell_WaitForCursorsWithTagBase__CursorState_t")]
    public CPulseCellWaitForCursorsWithTagBaseCursorStateT CPulseCellWaitForCursorsWithTagBaseCursorStateT
    {
        get;
        set;
    }

    [JsonProperty("CPulseCell_WaitForObservable")]
    [JsonPropertyName("CPulseCell_WaitForObservable")]
    public CPulseCellWaitForObservable CPulseCellWaitForObservable
    {
        get;
        set;
    }

    [JsonProperty("CPulseCursorFuncs")]
    [JsonPropertyName("CPulseCursorFuncs")]
    public CPulseCursorFuncs CPulseCursorFuncs
    {
        get;
        set;
    }

    [JsonProperty("CPulseExecCursor")]
    [JsonPropertyName("CPulseExecCursor")]
    public CPulseExecCursor CPulseExecCursor
    {
        get;
        set;
    }

    [JsonProperty("CPulseGameBlackboard")]
    [JsonPropertyName("CPulseGameBlackboard")]
    public CPulseGameBlackboard CPulseGameBlackboard
    {
        get;
        set;
    }

    [JsonProperty("CPulseGraphDef")]
    [JsonPropertyName("CPulseGraphDef")]
    public CPulseGraphDef CPulseGraphDef
    {
        get;
        set;
    }

    [JsonProperty("CPulseMathlib")]
    [JsonPropertyName("CPulseMathlib")]
    public CPulseMathlib CPulseMathlib
    {
        get;
        set;
    }

    [JsonProperty("CPulseTestScriptLib")]
    [JsonPropertyName("CPulseTestScriptLib")]
    public CPulseTestScriptLib CPulseTestScriptLib
    {
        get;
        set;
    }

    [JsonProperty("CPulse_BlackboardReference")]
    [JsonPropertyName("CPulse_BlackboardReference")]
    public CPulseBlackboardReference CPulseBlackboardReference
    {
        get;
        set;
    }

    [JsonProperty("CPulse_CallInfo")]
    [JsonPropertyName("CPulse_CallInfo")]
    public CPulseCallInfo CPulseCallInfo
    {
        get;
        set;
    }

    [JsonProperty("CPulse_InvokeBinding")]
    [JsonPropertyName("CPulse_InvokeBinding")]
    public CPulseInvokeBinding CPulseInvokeBinding
    {
        get;
        set;
    }

    [JsonProperty("CPulse_OutflowConnection")]
    [JsonPropertyName("CPulse_OutflowConnection")]
    public CPulseOutflowConnection CPulseOutflowConnection
    {
        get;
        set;
    }

    [JsonProperty("CPulse_ResumePoint")]
    [JsonPropertyName("CPulse_ResumePoint")]
    public CPulseResumePoint CPulseResumePoint
    {
        get;
        set;
    }

    [JsonProperty("CRagdollManager")]
    [JsonPropertyName("CRagdollManager")]
    public CRagdollManager CRagdollManager
    {
        get;
        set;
    }

    [JsonProperty("CRenderComponent")]
    [JsonPropertyName("CRenderComponent")]
    public CRenderComponent CRenderComponent
    {
        get;
        set;
    }

    [JsonProperty("CSMatchStats_t")]
    [JsonPropertyName("CSMatchStats_t")]
    public CSMatchStatsT CSMatchStatsT
    {
        get;
        set;
    }

    [JsonProperty("CSPerRoundStats_t")]
    [JsonPropertyName("CSPerRoundStats_t")]
    public CSPerRoundStatsT CSPerRoundStatsT
    {
        get;
        set;
    }

    [JsonProperty("CScriptComponent")]
    [JsonPropertyName("CScriptComponent")]
    public CScriptComponent CScriptComponent
    {
        get;
        set;
    }

    [JsonProperty("CServerOnlyModelEntity")]
    [JsonPropertyName("CServerOnlyModelEntity")]
    public CServerOnlyModelEntity CServerOnlyModelEntity
    {
        get;
        set;
    }

    [JsonProperty("CSkeletonInstance")]
    [JsonPropertyName("CSkeletonInstance")]
    public CSkeletonInstance CSkeletonInstance
    {
        get;
        set;
    }

    [JsonProperty("CSkyboxReference")]
    [JsonPropertyName("CSkyboxReference")]
    public CSkyboxReference CSkyboxReference
    {
        get;
        set;
    }

    [JsonProperty("CSpriteOriented")]
    [JsonPropertyName("CSpriteOriented")]
    public CSpriteOriented CSpriteOriented
    {
        get;
        set;
    }

    [JsonProperty("CTakeDamageInfoAPI")]
    [JsonPropertyName("CTakeDamageInfoAPI")]
    public CTakeDamageInfoAPI CTakeDamageInfoAPI
    {
        get;
        set;
    }

    [JsonProperty("CTimeline")]
    [JsonPropertyName("CTimeline")]
    public CTimeline CTimeline
    {
        get;
        set;
    }

    [JsonProperty("CTriggerFan")]
    [JsonPropertyName("CTriggerFan")]
    public CTriggerFan CTriggerFan
    {
        get;
        set;
    }

    [JsonProperty("CWaterSplasher")]
    [JsonPropertyName("CWaterSplasher")]
    public CWaterSplasher CWaterSplasher
    {
        get;
        set;
    }

    [JsonProperty("C_AK47")]
    [JsonPropertyName("C_AK47")]
    public Cak47 CAK47
    {
        get;
        set;
    }

    [JsonProperty("C_AttributeContainer")]
    [JsonPropertyName("C_AttributeContainer")]
    public CAttributeContainer CAttributeContainer
    {
        get;
        set;
    }


    [JsonProperty("C_BaseButton")]
    [JsonPropertyName("C_BaseButton")]
    public CBaseButton CBaseButton
    {
        get;
        set;
    }

    [JsonProperty("C_BaseCSGrenade")]
    [JsonPropertyName("C_BaseCSGrenade")]
    public CBaseCSGrenade CBaseCSGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_BaseCSGrenadeProjectile")]
    [JsonPropertyName("C_BaseCSGrenadeProjectile")]
    public CBaseCSGrenadeProjectile CBaseCSGrenadeProjectile
    {
        get;
        set;
    }

    [JsonProperty("C_BaseClientUIEntity")]
    [JsonPropertyName("C_BaseClientUIEntity")]
    public CBaseClientUIEntity CBaseClientUIEntity
    {
        get;
        set;
    }

    [JsonProperty("C_BaseCombatCharacter")]
    [JsonPropertyName("C_BaseCombatCharacter")]
    public CBaseCombatCharacter CBaseCombatCharacter
    {
        get;
        set;
    }

    [JsonProperty("C_BaseDoor")]
    [JsonPropertyName("C_BaseDoor")]
    public CBaseDoor CBaseDoor
    {
        get;
        set;
    }

    [JsonProperty("C_BaseEntity")]
    [JsonPropertyName("C_BaseEntity")]
    public CBaseEntity CBaseEntity
    {
        get;
        set;
    }

    [JsonProperty("C_BaseEntityAPI")]
    [JsonPropertyName("C_BaseEntityAPI")]
    public CBaseEntityAPI CBaseEntityAPI
    {
        get;
        set;
    }

    [JsonProperty("C_BaseFlex")]
    [JsonPropertyName("C_BaseFlex")]
    public CBaseFlex CBaseFlex
    {
        get;
        set;
    }

    [JsonProperty("C_BaseFlex__Emphasized_Phoneme")]
    [JsonPropertyName("C_BaseFlex__Emphasized_Phoneme")]
    public CBaseFlexEmphasizedPhoneme CBaseFlexEmphasizedPhoneme
    {
        get;
        set;
    }

    [JsonProperty("C_BaseGrenade")]
    [JsonPropertyName("C_BaseGrenade")]
    public CBaseGrenade CBaseGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_BaseModelEntity")]
    [JsonPropertyName("C_BaseModelEntity")]
    public CBaseModelEntity CBaseModelEntity
    {
        get;
        set;
    }

    [JsonProperty("C_BasePlayerPawn")]
    [JsonPropertyName("C_BasePlayerPawn")]
    public CBasePlayerPawn CBasePlayerPawn
    {
        get;
        set;
    }

    [JsonProperty("C_BasePlayerWeapon")]
    [JsonPropertyName("C_BasePlayerWeapon")]
    public CBasePlayerWeapon CBasePlayerWeapon
    {
        get;
        set;
    }

    [JsonProperty("C_BasePropDoor")]
    [JsonPropertyName("C_BasePropDoor")]
    public CBasePropDoor CBasePropDoor
    {
        get;
        set;
    }

    [JsonProperty("C_BaseToggle")]
    [JsonPropertyName("C_BaseToggle")]
    public CBaseToggle CBaseToggle
    {
        get;
        set;
    }

    [JsonProperty("C_BaseTrigger")]
    [JsonPropertyName("C_BaseTrigger")]
    public CBaseTrigger CBaseTrigger
    {
        get;
        set;
    }

    [JsonProperty("C_Beam")]
    [JsonPropertyName("C_Beam")]
    public CBeam CBeam
    {
        get;
        set;
    }

    [JsonProperty("C_Breakable")]
    [JsonPropertyName("C_Breakable")]
    public CBreakable CBreakable
    {
        get;
        set;
    }

    [JsonProperty("C_BreakableProp")]
    [JsonPropertyName("C_BreakableProp")]
    public CBreakableProp CBreakableProp
    {
        get;
        set;
    }

    [JsonProperty("C_BulletHitModel")]
    [JsonPropertyName("C_BulletHitModel")]
    public CBulletHitModel CBulletHitModel
    {
        get;
        set;
    }

    [JsonProperty("C_C4")]
    [JsonPropertyName("C_C4")]
    public CC4 CC4
    {
        get;
        set;
    }

    [JsonProperty("C_CS2HudModelAddon")]
    [JsonPropertyName("C_CS2HudModelAddon")]
    public CCS2HudModelAddon CCS2HudModelAddon
    {
        get;
        set;
    }

    [JsonProperty("C_CS2HudModelArms")]
    [JsonPropertyName("C_CS2HudModelArms")]
    public CCS2HudModelArms CCS2HudModelArms
    {
        get;
        set;
    }

    [JsonProperty("C_CS2HudModelBase")]
    [JsonPropertyName("C_CS2HudModelBase")]
    public CCS2HudModelBase CCS2HudModelBase
    {
        get;
        set;
    }

    [JsonProperty("C_CS2HudModelWeapon")]
    [JsonPropertyName("C_CS2HudModelWeapon")]
    public CCS2HudModelWeapon CCS2HudModelWeapon
    {
        get;
        set;
    }

    [JsonProperty("C_CS2WeaponModuleBase")]
    [JsonPropertyName("C_CS2WeaponModuleBase")]
    public CCS2WeaponModuleBase CCS2WeaponModuleBase
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_CounterTerroristTeamIntroCamera")]
    [JsonPropertyName("C_CSGO_CounterTerroristTeamIntroCamera")]
    public CCSGOCounterTerroristTeamIntroCamera CCSGOCounterTerroristTeamIntroCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_CounterTerroristWingmanIntroCamera")]
    [JsonPropertyName("C_CSGO_CounterTerroristWingmanIntroCamera")]
    public CCSGOCounterTerroristWingmanIntroCamera CCSGOCounterTerroristWingmanIntroCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_EndOfMatchCamera")]
    [JsonPropertyName("C_CSGO_EndOfMatchCamera")]
    public CCSGOEndOfMatchCamera CCSGOEndOfMatchCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_EndOfMatchCharacterPosition")]
    [JsonPropertyName("C_CSGO_EndOfMatchCharacterPosition")]
    public CCSGOEndOfMatchCharacterPosition CCSGOEndOfMatchCharacterPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_EndOfMatchLineupEnd")]
    [JsonPropertyName("C_CSGO_EndOfMatchLineupEnd")]
    public CCSGOEndOfMatchLineupEnd CCSGOEndOfMatchLineupEnd
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_EndOfMatchLineupEndpoint")]
    [JsonPropertyName("C_CSGO_EndOfMatchLineupEndpoint")]
    public CCSGOEndOfMatchLineupEndpoint CCSGOEndOfMatchLineupEndpoint
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_EndOfMatchLineupStart")]
    [JsonPropertyName("C_CSGO_EndOfMatchLineupStart")]
    public CCSGOEndOfMatchLineupStart CCSGOEndOfMatchLineupStart
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_MapPreviewCameraPath")]
    [JsonPropertyName("C_CSGO_MapPreviewCameraPath")]
    public CCSGOMapPreviewCameraPath CCSGOMapPreviewCameraPath
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_MapPreviewCameraPathNode")]
    [JsonPropertyName("C_CSGO_MapPreviewCameraPathNode")]
    public CCSGOMapPreviewCameraPathNode CCSGOMapPreviewCameraPathNode
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_PreviewModel")]
    [JsonPropertyName("C_CSGO_PreviewModel")]
    public CCSGOPreviewModel CCSGOPreviewModel
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_PreviewModelAlias_csgo_item_previewmodel")]
    [JsonPropertyName("C_CSGO_PreviewModelAlias_csgo_item_previewmodel")]
    public CCSGOPreviewModelAliasCsgoItemPreviewmodel CCSGOPreviewModelAliasCsgoItemPreviewmodel
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_PreviewPlayer")]
    [JsonPropertyName("C_CSGO_PreviewPlayer")]
    public CCSGOPreviewPlayer CCSGOPreviewPlayer
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel")]
    [JsonPropertyName("C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel")]
    public CCSGOPreviewPlayerAliasCsgoPlayerPreviewmodel CCSGOPreviewPlayerAliasCsgoPlayerPreviewmodel
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamIntroCharacterPosition")]
    [JsonPropertyName("C_CSGO_TeamIntroCharacterPosition")]
    public CCSGOTeamIntroCharacterPosition CCSGOTeamIntroCharacterPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamIntroCounterTerroristPosition")]
    [JsonPropertyName("C_CSGO_TeamIntroCounterTerroristPosition")]
    public CCSGOTeamIntroCounterTerroristPosition CCSGOTeamIntroCounterTerroristPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamIntroTerroristPosition")]
    [JsonPropertyName("C_CSGO_TeamIntroTerroristPosition")]
    public CCSGOTeamIntroTerroristPosition CCSGOTeamIntroTerroristPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamPreviewCamera")]
    [JsonPropertyName("C_CSGO_TeamPreviewCamera")]
    public CCSGOTeamPreviewCamera CCSGOTeamPreviewCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamPreviewCharacterPosition")]
    [JsonPropertyName("C_CSGO_TeamPreviewCharacterPosition")]
    public CCSGOTeamPreviewCharacterPosition CCSGOTeamPreviewCharacterPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamPreviewModel")]
    [JsonPropertyName("C_CSGO_TeamPreviewModel")]
    public CCSGOTeamPreviewModel CCSGOTeamPreviewModel
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamSelectCamera")]
    [JsonPropertyName("C_CSGO_TeamSelectCamera")]
    public CCSGOTeamSelectCamera CCSGOTeamSelectCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamSelectCharacterPosition")]
    [JsonPropertyName("C_CSGO_TeamSelectCharacterPosition")]
    public CCSGOTeamSelectCharacterPosition CCSGOTeamSelectCharacterPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamSelectCounterTerroristPosition")]
    [JsonPropertyName("C_CSGO_TeamSelectCounterTerroristPosition")]
    public CCSGOTeamSelectCounterTerroristPosition CCSGOTeamSelectCounterTerroristPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TeamSelectTerroristPosition")]
    [JsonPropertyName("C_CSGO_TeamSelectTerroristPosition")]
    public CCSGOTeamSelectTerroristPosition CCSGOTeamSelectTerroristPosition
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TerroristTeamIntroCamera")]
    [JsonPropertyName("C_CSGO_TerroristTeamIntroCamera")]
    public CCSGOTerroristTeamIntroCamera CCSGOTerroristTeamIntroCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGO_TerroristWingmanIntroCamera")]
    [JsonPropertyName("C_CSGO_TerroristWingmanIntroCamera")]
    public CCSGOTerroristWingmanIntroCamera CCSGOTerroristWingmanIntroCamera
    {
        get;
        set;
    }

    [JsonProperty("C_CSGameRules")]
    [JsonPropertyName("C_CSGameRules")]
    public CCSGameRules CCSGameRules
    {
        get;
        set;
    }

    [JsonProperty("C_CSGameRulesProxy")]
    [JsonPropertyName("C_CSGameRulesProxy")]
    public CCSGameRulesProxy CCSGameRulesProxy
    {
        get;
        set;
    }

    [JsonProperty("C_CSMinimapBoundary")]
    [JsonPropertyName("C_CSMinimapBoundary")]
    public CCSMinimapBoundary CCSMinimapBoundary
    {
        get;
        set;
    }

    [JsonProperty("C_CSObserverPawn")]
    [JsonPropertyName("C_CSObserverPawn")]
    public CCSObserverPawn CCSObserverPawn
    {
        get;
        set;
    }

    [JsonProperty("C_CSPetPlacement")]
    [JsonPropertyName("C_CSPetPlacement")]
    public CCSPetPlacement CCSPetPlacement
    {
        get;
        set;
    }

    [JsonProperty("C_CSPlayerPawn")]
    [JsonPropertyName("C_CSPlayerPawn")]
    public CCSPlayerPawn CCSPlayerPawn
    {
        get;
        set;
    }

    [JsonProperty("C_CSPlayerPawnBase")]
    [JsonPropertyName("C_CSPlayerPawnBase")]
    public CCSPlayerPawnBase CCSPlayerPawnBase
    {
        get;
        set;
    }

    [JsonProperty("C_CSPlayerResource")]
    [JsonPropertyName("C_CSPlayerResource")]
    public CCSPlayerResource CCSPlayerResource
    {
        get;
        set;
    }

    [JsonProperty("C_CSTeam")]
    [JsonPropertyName("C_CSTeam")]
    public CCSTeam CCSTeam
    {
        get;
        set;
    }

    [JsonProperty("C_CSWeaponBase")]
    [JsonPropertyName("C_CSWeaponBase")]
    public CCSWeaponBase CCSWeaponBase
    {
        get;
        set;
    }

    [JsonProperty("C_CSWeaponBaseGun")]
    [JsonPropertyName("C_CSWeaponBaseGun")]
    public CCSWeaponBaseGun CCSWeaponBaseGun
    {
        get;
        set;
    }

    [JsonProperty("C_CSWeaponBaseShotgun")]
    [JsonPropertyName("C_CSWeaponBaseShotgun")]
    public CCSWeaponBaseShotgun CCSWeaponBaseShotgun
    {
        get;
        set;
    }

    [JsonProperty("C_Chicken")]
    [JsonPropertyName("C_Chicken")]
    public CChicken CChicken
    {
        get;
        set;
    }

    [JsonProperty("C_ClientRagdoll")]
    [JsonPropertyName("C_ClientRagdoll")]
    public CClientRagdoll CClientRagdoll
    {
        get;
        set;
    }

    [JsonProperty("C_ColorCorrection")]
    [JsonPropertyName("C_ColorCorrection")]
    public CColorCorrection CColorCorrection
    {
        get;
        set;
    }

    [JsonProperty("C_ColorCorrectionVolume")]
    [JsonPropertyName("C_ColorCorrectionVolume")]
    public CColorCorrectionVolume CColorCorrectionVolume
    {
        get;
        set;
    }

    [JsonProperty("C_CsmFovOverride")]
    [JsonPropertyName("C_CsmFovOverride")]
    public CCsmFovOverride CCsmFovOverride
    {
        get;
        set;
    }

    [JsonProperty("C_DEagle")]
    [JsonPropertyName("C_DEagle")]
    public CDEagle CDEagle
    {
        get;
        set;
    }

    [JsonProperty("C_DecoyGrenade")]
    [JsonPropertyName("C_DecoyGrenade")]
    public CDecoyGrenade CDecoyGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_DecoyProjectile")]
    [JsonPropertyName("C_DecoyProjectile")]
    public CDecoyProjectile CDecoyProjectile
    {
        get;
        set;
    }

    [JsonProperty("C_DynamicLight")]
    [JsonPropertyName("C_DynamicLight")]
    public CDynamicLight CDynamicLight
    {
        get;
        set;
    }

    [JsonProperty("C_DynamicProp")]
    [JsonPropertyName("C_DynamicProp")]
    public CDynamicProp CDynamicProp
    {
        get;
        set;
    }

    [JsonProperty("C_DynamicPropAlias_cable_dynamic")]
    [JsonPropertyName("C_DynamicPropAlias_cable_dynamic")]
    public CDynamicPropAliasCableDynamic CDynamicPropAliasCableDynamic
    {
        get;
        set;
    }

    [JsonProperty("C_DynamicPropAlias_dynamic_prop")]
    [JsonPropertyName("C_DynamicPropAlias_dynamic_prop")]
    public CDynamicPropAliasDynamicProp CDynamicPropAliasDynamicProp
    {
        get;
        set;
    }

    [JsonProperty("C_DynamicPropAlias_prop_dynamic_override")]
    [JsonPropertyName("C_DynamicPropAlias_prop_dynamic_override")]
    public CDynamicPropAliasPropDynamicOverride CDynamicPropAliasPropDynamicOverride
    {
        get;
        set;
    }

    [JsonProperty("C_EconEntity")]
    [JsonPropertyName("C_EconEntity")]
    public CEconEntity CEconEntity
    {
        get;
        set;
    }

    [JsonProperty("C_EconEntity__AttachedModelData_t")]
    [JsonPropertyName("C_EconEntity__AttachedModelData_t")]
    public CEconEntityAttachedModelDataT CEconEntityAttachedModelDataT
    {
        get;
        set;
    }

    [JsonProperty("C_EconItemView")]
    [JsonPropertyName("C_EconItemView")]
    public CEconItemView CEconItemView
    {
        get;
        set;
    }

    [JsonProperty("C_EconWearable")]
    [JsonPropertyName("C_EconWearable")]
    public CEconWearable CEconWearable
    {
        get;
        set;
    }

    [JsonProperty("C_EntityDissolve")]
    [JsonPropertyName("C_EntityDissolve")]
    public CEntityDissolve CEntityDissolve
    {
        get;
        set;
    }

    [JsonProperty("C_EntityFlame")]
    [JsonPropertyName("C_EntityFlame")]
    public CEntityFlame CEntityFlame
    {
        get;
        set;
    }

    [JsonProperty("C_EnvCombinedLightProbeVolume")]
    [JsonPropertyName("C_EnvCombinedLightProbeVolume")]
    public CEnvCombinedLightProbeVolume CEnvCombinedLightProbeVolume
    {
        get;
        set;
    }

    [JsonProperty("C_EnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume")]
    [JsonPropertyName("C_EnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume")]
    public CEnvCombinedLightProbeVolumeAliasFuncCombinedLightProbeVolume
        CEnvCombinedLightProbeVolumeAliasFuncCombinedLightProbeVolume
    {
        get;
        set;
    }

    [JsonProperty("C_EnvCubemap")]
    [JsonPropertyName("C_EnvCubemap")]
    public CEnvCubemap CEnvCubemap
    {
        get;
        set;
    }

    [JsonProperty("C_EnvCubemapBox")]
    [JsonPropertyName("C_EnvCubemapBox")]
    public CEnvCubemapBox CEnvCubemapBox
    {
        get;
        set;
    }

    [JsonProperty("C_EnvCubemapFog")]
    [JsonPropertyName("C_EnvCubemapFog")]
    public CEnvCubemapFog CEnvCubemapFog
    {
        get;
        set;
    }

    [JsonProperty("C_EnvDecal")]
    [JsonPropertyName("C_EnvDecal")]
    public CEnvDecal CEnvDecal
    {
        get;
        set;
    }

    [JsonProperty("C_EnvDetailController")]
    [JsonPropertyName("C_EnvDetailController")]
    public CEnvDetailController CEnvDetailController
    {
        get;
        set;
    }

    [JsonProperty("C_EnvLightProbeVolume")]
    [JsonPropertyName("C_EnvLightProbeVolume")]
    public CEnvLightProbeVolume CEnvLightProbeVolume
    {
        get;
        set;
    }

    [JsonProperty("C_EnvParticleGlow")]
    [JsonPropertyName("C_EnvParticleGlow")]
    public CEnvParticleGlow CEnvParticleGlow
    {
        get;
        set;
    }

    [JsonProperty("C_EnvSky")]
    [JsonPropertyName("C_EnvSky")]
    public CEnvSky CEnvSky
    {
        get;
        set;
    }

    [JsonProperty("C_EnvVolumetricFogController")]
    [JsonPropertyName("C_EnvVolumetricFogController")]
    public CEnvVolumetricFogController CEnvVolumetricFogController
    {
        get;
        set;
    }

    [JsonProperty("C_EnvVolumetricFogVolume")]
    [JsonPropertyName("C_EnvVolumetricFogVolume")]
    public CEnvVolumetricFogVolume CEnvVolumetricFogVolume
    {
        get;
        set;
    }

    [JsonProperty("C_EnvWind")]
    [JsonPropertyName("C_EnvWind")]
    public CEnvWind CEnvWind
    {
        get;
        set;
    }

    [JsonProperty("C_EnvWindClientside")]
    [JsonPropertyName("C_EnvWindClientside")]
    public CEnvWindClientside CEnvWindClientside
    {
        get;
        set;
    }

    [JsonProperty("C_EnvWindController")]
    [JsonPropertyName("C_EnvWindController")]
    public CEnvWindController CEnvWindController
    {
        get;
        set;
    }

    [JsonProperty("C_EnvWindShared")]
    [JsonPropertyName("C_EnvWindShared")]
    public CEnvWindShared CEnvWindShared
    {
        get;
        set;
    }

    [JsonProperty("C_EnvWindVolume")]
    [JsonPropertyName("C_EnvWindVolume")]
    public CEnvWindVolume CEnvWindVolume
    {
        get;
        set;
    }

    [JsonProperty("C_FireCrackerBlast")]
    [JsonPropertyName("C_FireCrackerBlast")]
    public CFireCrackerBlast CFireCrackerBlast
    {
        get;
        set;
    }

    [JsonProperty("C_Fish")]
    [JsonPropertyName("C_Fish")]
    public CFish CFish
    {
        get;
        set;
    }

    [JsonProperty("C_Flashbang")]
    [JsonPropertyName("C_Flashbang")]
    public CFlashbang CFlashbang
    {
        get;
        set;
    }

    [JsonProperty("C_FlashbangProjectile")]
    [JsonPropertyName("C_FlashbangProjectile")]
    public CFlashbangProjectile CFlashbangProjectile
    {
        get;
        set;
    }

    [JsonProperty("C_FogController")]
    [JsonPropertyName("C_FogController")]
    public CFogController CFogController
    {
        get;
        set;
    }

    [JsonProperty("C_FootstepControl")]
    [JsonPropertyName("C_FootstepControl")]
    public CFootstepControl CFootstepControl
    {
        get;
        set;
    }

    [JsonProperty("C_FuncBrush")]
    [JsonPropertyName("C_FuncBrush")]
    public CFuncBrush CFuncBrush
    {
        get;
        set;
    }

    [JsonProperty("C_FuncConveyor")]
    [JsonPropertyName("C_FuncConveyor")]
    public CFuncConveyor CFuncConveyor
    {
        get;
        set;
    }

    [JsonProperty("C_FuncElectrifiedVolume")]
    [JsonPropertyName("C_FuncElectrifiedVolume")]
    public CFuncElectrifiedVolume CFuncElectrifiedVolume
    {
        get;
        set;
    }

    [JsonProperty("C_FuncLadder")]
    [JsonPropertyName("C_FuncLadder")]
    public CFuncLadder CFuncLadder
    {
        get;
        set;
    }

    [JsonProperty("C_FuncMonitor")]
    [JsonPropertyName("C_FuncMonitor")]
    public CFuncMonitor CFuncMonitor
    {
        get;
        set;
    }

    [JsonProperty("C_FuncMoveLinear")]
    [JsonPropertyName("C_FuncMoveLinear")]
    public CFuncMoveLinear CFuncMoveLinear
    {
        get;
        set;
    }

    [JsonProperty("C_FuncMover")]
    [JsonPropertyName("C_FuncMover")]
    public CFuncMover CFuncMover
    {
        get;
        set;
    }

    [JsonProperty("C_FuncRotating")]
    [JsonPropertyName("C_FuncRotating")]
    public CFuncRotating CFuncRotating
    {
        get;
        set;
    }

    [JsonProperty("C_FuncTrackTrain")]
    [JsonPropertyName("C_FuncTrackTrain")]
    public CFuncTrackTrain CFuncTrackTrain
    {
        get;
        set;
    }

    [JsonProperty("C_GameRules")]
    [JsonPropertyName("C_GameRules")]
    public CGameRules CGameRules
    {
        get;
        set;
    }

    [JsonProperty("C_GameRulesProxy")]
    [JsonPropertyName("C_GameRulesProxy")]
    public CGameRulesProxy CGameRulesProxy
    {
        get;
        set;
    }

    [JsonProperty("C_GlobalLight")]
    [JsonPropertyName("C_GlobalLight")]
    public CGlobalLight CGlobalLight
    {
        get;
        set;
    }

    [JsonProperty("C_GradientFog")]
    [JsonPropertyName("C_GradientFog")]
    public CGradientFog CGradientFog
    {
        get;
        set;
    }

    [JsonProperty("C_HEGrenade")]
    [JsonPropertyName("C_HEGrenade")]
    public CHEGrenade CHEGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_HEGrenadeProjectile")]
    [JsonPropertyName("C_HEGrenadeProjectile")]
    public CHEGrenadeProjectile CHEGrenadeProjectile
    {
        get;
        set;
    }

    [JsonProperty("C_HandleTest")]
    [JsonPropertyName("C_HandleTest")]
    public CHandleTest CHandleTest
    {
        get;
        set;
    }

    [JsonProperty("C_Hostage")]
    [JsonPropertyName("C_Hostage")]
    public CHostage CHostage
    {
        get;
        set;
    }

    [JsonProperty("C_HostageCarriableProp")]
    [JsonPropertyName("C_HostageCarriableProp")]
    public CHostageCarriableProp CHostageCarriableProp
    {
        get;
        set;
    }

    [JsonProperty("C_IncendiaryGrenade")]
    [JsonPropertyName("C_IncendiaryGrenade")]
    public CIncendiaryGrenade CIncendiaryGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_Inferno")]
    [JsonPropertyName("C_Inferno")]
    public CInferno CInferno
    {
        get;
        set;
    }

    [JsonProperty("C_InfoInstructorHintHostageRescueZone")]
    [JsonPropertyName("C_InfoInstructorHintHostageRescueZone")]
    public CInfoInstructorHintHostageRescueZone CInfoInstructorHintHostageRescueZone
    {
        get;
        set;
    }

    [JsonProperty("C_InfoLadderDismount")]
    [JsonPropertyName("C_InfoLadderDismount")]
    public CInfoLadderDismount CInfoLadderDismount
    {
        get;
        set;
    }

    [JsonProperty("C_InfoVisibilityBox")]
    [JsonPropertyName("C_InfoVisibilityBox")]
    public CInfoVisibilityBox CInfoVisibilityBox
    {
        get;
        set;
    }

    [JsonProperty("C_Item")]
    [JsonPropertyName("C_Item")]
    public CItem CItem
    {
        get;
        set;
    }

    [JsonProperty("C_ItemDogtags")]
    [JsonPropertyName("C_ItemDogtags")]
    public CItemDogtags CItemDogtags
    {
        get;
        set;
    }

    [JsonProperty("C_Item_Healthshot")]
    [JsonPropertyName("C_Item_Healthshot")]
    public CItemHealthshot CItemHealthshot
    {
        get;
        set;
    }

    [JsonProperty("C_KeychainModule")]
    [JsonPropertyName("C_KeychainModule")]
    public CKeychainModule CKeychainModule
    {
        get;
        set;
    }

    [JsonProperty("C_Knife")]
    [JsonPropertyName("C_Knife")]
    public CKnife CKnife
    {
        get;
        set;
    }

    [JsonProperty("C_LateUpdatedAnimating")]
    [JsonPropertyName("C_LateUpdatedAnimating")]
    public CLateUpdatedAnimating CLateUpdatedAnimating
    {
        get;
        set;
    }

    [JsonProperty("C_LightDirectionalEntity")]
    [JsonPropertyName("C_LightDirectionalEntity")]
    public CLightDirectionalEntity CLightDirectionalEntity
    {
        get;
        set;
    }

    [JsonProperty("C_LightEntity")]
    [JsonPropertyName("C_LightEntity")]
    public CLightEntity CLightEntity
    {
        get;
        set;
    }

    [JsonProperty("C_LightEnvironmentEntity")]
    [JsonPropertyName("C_LightEnvironmentEntity")]
    public CLightEnvironmentEntity CLightEnvironmentEntity
    {
        get;
        set;
    }

    [JsonProperty("C_LightOrthoEntity")]
    [JsonPropertyName("C_LightOrthoEntity")]
    public CLightOrthoEntity CLightOrthoEntity
    {
        get;
        set;
    }

    [JsonProperty("C_LightSpotEntity")]
    [JsonPropertyName("C_LightSpotEntity")]
    public CLightSpotEntity CLightSpotEntity
    {
        get;
        set;
    }

    [JsonProperty("C_LocalTempEntity")]
    [JsonPropertyName("C_LocalTempEntity")]
    public CLocalTempEntity CLocalTempEntity
    {
        get;
        set;
    }

    [JsonProperty("C_MapPreviewParticleSystem")]
    [JsonPropertyName("C_MapPreviewParticleSystem")]
    public CMapPreviewParticleSystem CMapPreviewParticleSystem
    {
        get;
        set;
    }

    [JsonProperty("C_MapVetoPickController")]
    [JsonPropertyName("C_MapVetoPickController")]
    public CMapVetoPickController CMapVetoPickController
    {
        get;
        set;
    }

    [JsonProperty("C_ModelPointEntity")]
    [JsonPropertyName("C_ModelPointEntity")]
    public CModelPointEntity CModelPointEntity
    {
        get;
        set;
    }

    [JsonProperty("C_MolotovGrenade")]
    [JsonPropertyName("C_MolotovGrenade")]
    public CMolotovGrenade CMolotovGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_MolotovProjectile")]
    [JsonPropertyName("C_MolotovProjectile")]
    public CMolotovProjectile CMolotovProjectile
    {
        get;
        set;
    }

    [JsonProperty("C_Multimeter")]
    [JsonPropertyName("C_Multimeter")]
    public CMultimeter CMultimeter
    {
        get;
        set;
    }

    [JsonProperty("C_MultiplayRules")]
    [JsonPropertyName("C_MultiplayRules")]
    public CMultiplayRules CMultiplayRules
    {
        get;
        set;
    }

    [JsonProperty("C_NametagModule")]
    [JsonPropertyName("C_NametagModule")]
    public CNametagModule CNametagModule
    {
        get;
        set;
    }

    [JsonProperty("C_NetTestBaseCombatCharacter")]
    [JsonPropertyName("C_NetTestBaseCombatCharacter")]
    public CNetTestBaseCombatCharacter CNetTestBaseCombatCharacter
    {
        get;
        set;
    }

    [JsonProperty("C_OmniLight")]
    [JsonPropertyName("C_OmniLight")]
    public COmniLight COmniLight
    {
        get;
        set;
    }

    [JsonProperty("C_ParticleSystem")]
    [JsonPropertyName("C_ParticleSystem")]
    public CParticleSystem CParticleSystem
    {
        get;
        set;
    }

    [JsonProperty("C_PathParticleRope")]
    [JsonPropertyName("C_PathParticleRope")]
    public CPathParticleRope CPathParticleRope
    {
        get;
        set;
    }

    [JsonProperty("C_PathParticleRopeAlias_path_particle_rope_clientside")]
    [JsonPropertyName("C_PathParticleRopeAlias_path_particle_rope_clientside")]
    public CPathParticleRopeAliasPathParticleRopeClientside CPathParticleRopeAliasPathParticleRopeClientside
    {
        get;
        set;
    }

    [JsonProperty("C_PhysBox")]
    [JsonPropertyName("C_PhysBox")]
    public CPhysBox CPhysBox
    {
        get;
        set;
    }

    [JsonProperty("C_PhysMagnet")]
    [JsonPropertyName("C_PhysMagnet")]
    public CPhysMagnet CPhysMagnet
    {
        get;
        set;
    }

    [JsonProperty("C_PhysPropClientside")]
    [JsonPropertyName("C_PhysPropClientside")]
    public CPhysPropClientside CPhysPropClientside
    {
        get;
        set;
    }

    [JsonProperty("C_PhysicsProp")]
    [JsonPropertyName("C_PhysicsProp")]
    public CPhysicsProp CPhysicsProp
    {
        get;
        set;
    }

    [JsonProperty("C_PhysicsPropMultiplayer")]
    [JsonPropertyName("C_PhysicsPropMultiplayer")]
    public CPhysicsPropMultiplayer CPhysicsPropMultiplayer
    {
        get;
        set;
    }

    [JsonProperty("C_PlantedC4")]
    [JsonPropertyName("C_PlantedC4")]
    public CPlantedC4 CPlantedC4
    {
        get;
        set;
    }

    [JsonProperty("C_PlayerPing")]
    [JsonPropertyName("C_PlayerPing")]
    public CPlayerPing CPlayerPing
    {
        get;
        set;
    }

    [JsonProperty("C_PlayerSprayDecal")]
    [JsonPropertyName("C_PlayerSprayDecal")]
    public CPlayerSprayDecal CPlayerSprayDecal
    {
        get;
        set;
    }

    [JsonProperty("C_PlayerVisibility")]
    [JsonPropertyName("C_PlayerVisibility")]
    public CPlayerVisibility CPlayerVisibility
    {
        get;
        set;
    }

    [JsonProperty("C_PointCamera")]
    [JsonPropertyName("C_PointCamera")]
    public CPointCamera CPointCamera
    {
        get;
        set;
    }

    [JsonProperty("C_PointCameraVFOV")]
    [JsonPropertyName("C_PointCameraVFOV")]
    public CPointCameraVFOV CPointCameraVFOV
    {
        get;
        set;
    }

    [JsonProperty("C_PointClientUIDialog")]
    [JsonPropertyName("C_PointClientUIDialog")]
    public CPointClientUIDialog CPointClientUIDialog
    {
        get;
        set;
    }

    [JsonProperty("C_PointClientUIHUD")]
    [JsonPropertyName("C_PointClientUIHUD")]
    public CPointClientUIHUD CPointClientUIHUD
    {
        get;
        set;
    }

    [JsonProperty("C_PointClientUIWorldPanel")]
    [JsonPropertyName("C_PointClientUIWorldPanel")]
    public CPointClientUIWorldPanel CPointClientUIWorldPanel
    {
        get;
        set;
    }

    [JsonProperty("C_PointClientUIWorldTextPanel")]
    [JsonPropertyName("C_PointClientUIWorldTextPanel")]
    public CPointClientUIWorldTextPanel CPointClientUIWorldTextPanel
    {
        get;
        set;
    }

    [JsonProperty("C_PointCommentaryNode")]
    [JsonPropertyName("C_PointCommentaryNode")]
    public CPointCommentaryNode CPointCommentaryNode
    {
        get;
        set;
    }

    [JsonProperty("C_PointEntity")]
    [JsonPropertyName("C_PointEntity")]
    public CPointEntity CPointEntity
    {
        get;
        set;
    }

    [JsonProperty("C_PointValueRemapper")]
    [JsonPropertyName("C_PointValueRemapper")]
    public CPointValueRemapper CPointValueRemapper
    {
        get;
        set;
    }

    [JsonProperty("C_PointWorldText")]
    [JsonPropertyName("C_PointWorldText")]
    public CPointWorldText CPointWorldText
    {
        get;
        set;
    }

    [JsonProperty("C_PortraitWorldCallbackHandler")]
    [JsonPropertyName("C_PortraitWorldCallbackHandler")]
    public CPortraitWorldCallbackHandler CPortraitWorldCallbackHandler
    {
        get;
        set;
    }

    [JsonProperty("C_PostProcessingVolume")]
    [JsonPropertyName("C_PostProcessingVolume")]
    public CPostProcessingVolume CPostProcessingVolume
    {
        get;
        set;
    }

    [JsonProperty("C_Precipitation")]
    [JsonPropertyName("C_Precipitation")]
    public CPrecipitation CPrecipitation
    {
        get;
        set;
    }

    [JsonProperty("C_PrecipitationBlocker")]
    [JsonPropertyName("C_PrecipitationBlocker")]
    public CPrecipitationBlocker CPrecipitationBlocker
    {
        get;
        set;
    }

    [JsonProperty("C_PropDoorRotating")]
    [JsonPropertyName("C_PropDoorRotating")]
    public CPropDoorRotating CPropDoorRotating
    {
        get;
        set;
    }

    [JsonProperty("C_RagdollProp")]
    [JsonPropertyName("C_RagdollProp")]
    public CRagdollProp CRagdollProp
    {
        get;
        set;
    }

    [JsonProperty("C_RagdollPropAttached")]
    [JsonPropertyName("C_RagdollPropAttached")]
    public CRagdollPropAttached CRagdollPropAttached
    {
        get;
        set;
    }

    [JsonProperty("C_RectLight")]
    [JsonPropertyName("C_RectLight")]
    public CRectLight CRectLight
    {
        get;
        set;
    }

    [JsonProperty("C_RetakeGameRules")]
    [JsonPropertyName("C_RetakeGameRules")]
    public CRetakeGameRules CRetakeGameRules
    {
        get;
        set;
    }

    [JsonProperty("C_RopeKeyframe")]
    [JsonPropertyName("C_RopeKeyframe")]
    public CRopeKeyframe CRopeKeyframe
    {
        get;
        set;
    }

    [JsonProperty("C_RopeKeyframe__CPhysicsDelegate")]
    [JsonPropertyName("C_RopeKeyframe__CPhysicsDelegate")]
    public CRopeKeyframeCPhysicsDelegate CRopeKeyframeCPhysicsDelegate
    {
        get;
        set;
    }

    [JsonProperty("C_SceneEntity")]
    [JsonPropertyName("C_SceneEntity")]
    public CSceneEntity CSceneEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SceneEntity__QueuedEvents_t")]
    [JsonPropertyName("C_SceneEntity__QueuedEvents_t")]
    public CSceneEntityQueuedEventsT CSceneEntityQueuedEventsT
    {
        get;
        set;
    }

    [JsonProperty("C_ShatterGlassShardPhysics")]
    [JsonPropertyName("C_ShatterGlassShardPhysics")]
    public CShatterGlassShardPhysics CShatterGlassShardPhysics
    {
        get;
        set;
    }

    [JsonProperty("C_SingleplayRules")]
    [JsonPropertyName("C_SingleplayRules")]
    public CSingleplayRules CSingleplayRules
    {
        get;
        set;
    }

    [JsonProperty("C_SkyCamera")]
    [JsonPropertyName("C_SkyCamera")]
    public CSkyCamera CSkyCamera
    {
        get;
        set;
    }

    [JsonProperty("C_SmokeGrenade")]
    [JsonPropertyName("C_SmokeGrenade")]
    public CSmokeGrenade CSmokeGrenade
    {
        get;
        set;
    }

    [JsonProperty("C_SmokeGrenadeProjectile")]
    [JsonPropertyName("C_SmokeGrenadeProjectile")]
    public CSmokeGrenadeProjectile CSmokeGrenadeProjectile
    {
        get;
        set;
    }

    [JsonProperty("C_SoundAreaEntityBase")]
    [JsonPropertyName("C_SoundAreaEntityBase")]
    public CSoundAreaEntityBase CSoundAreaEntityBase
    {
        get;
        set;
    }

    [JsonProperty("C_SoundAreaEntityOrientedBox")]
    [JsonPropertyName("C_SoundAreaEntityOrientedBox")]
    public CSoundAreaEntityOrientedBox CSoundAreaEntityOrientedBox
    {
        get;
        set;
    }

    [JsonProperty("C_SoundAreaEntitySphere")]
    [JsonPropertyName("C_SoundAreaEntitySphere")]
    public CSoundAreaEntitySphere CSoundAreaEntitySphere
    {
        get;
        set;
    }

    [JsonProperty("C_SoundEventAABBEntity")]
    [JsonPropertyName("C_SoundEventAABBEntity")]
    public CSoundEventAABBEntity CSoundEventAABBEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundEventEntity")]
    [JsonPropertyName("C_SoundEventEntity")]
    public CSoundEventEntity CSoundEventEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundEventEntityAlias_snd_event_point")]
    [JsonPropertyName("C_SoundEventEntityAlias_snd_event_point")]
    public CSoundEventEntityAliasSndEventPoint CSoundEventEntityAliasSndEventPoint
    {
        get;
        set;
    }

    [JsonProperty("C_SoundEventOBBEntity")]
    [JsonPropertyName("C_SoundEventOBBEntity")]
    public CSoundEventOBBEntity CSoundEventOBBEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundEventPathCornerEntity")]
    [JsonPropertyName("C_SoundEventPathCornerEntity")]
    public CSoundEventPathCornerEntity CSoundEventPathCornerEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundEventSphereEntity")]
    [JsonPropertyName("C_SoundEventSphereEntity")]
    public CSoundEventSphereEntity CSoundEventSphereEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetAABBEntity")]
    [JsonPropertyName("C_SoundOpvarSetAABBEntity")]
    public CSoundOpvarSetAABBEntity CSoundOpvarSetAABBEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetAutoRoomEntity")]
    [JsonPropertyName("C_SoundOpvarSetAutoRoomEntity")]
    public CSoundOpvarSetAutoRoomEntity CSoundOpvarSetAutoRoomEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetOBBEntity")]
    [JsonPropertyName("C_SoundOpvarSetOBBEntity")]
    public CSoundOpvarSetOBBEntity CSoundOpvarSetOBBEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetOBBWindEntity")]
    [JsonPropertyName("C_SoundOpvarSetOBBWindEntity")]
    public CSoundOpvarSetOBBWindEntity CSoundOpvarSetOBBWindEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetPathCornerEntity")]
    [JsonPropertyName("C_SoundOpvarSetPathCornerEntity")]
    public CSoundOpvarSetPathCornerEntity CSoundOpvarSetPathCornerEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetPointBase")]
    [JsonPropertyName("C_SoundOpvarSetPointBase")]
    public CSoundOpvarSetPointBase CSoundOpvarSetPointBase
    {
        get;
        set;
    }

    [JsonProperty("C_SoundOpvarSetPointEntity")]
    [JsonPropertyName("C_SoundOpvarSetPointEntity")]
    public CSoundOpvarSetPointEntity CSoundOpvarSetPointEntity
    {
        get;
        set;
    }

    [JsonProperty("C_SpotlightEnd")]
    [JsonPropertyName("C_SpotlightEnd")]
    public CSpotlightEnd CSpotlightEnd
    {
        get;
        set;
    }

    [JsonProperty("C_Sprite")]
    [JsonPropertyName("C_Sprite")]
    public CSprite CSprite
    {
        get;
        set;
    }

    [JsonProperty("C_StattrakModule")]
    [JsonPropertyName("C_StattrakModule")]
    public CStattrakModule CStattrakModule
    {
        get;
        set;
    }

    [JsonProperty("C_Team")]
    [JsonPropertyName("C_Team")]
    public CTeam CTeam
    {
        get;
        set;
    }

    [JsonProperty("C_TeamplayRules")]
    [JsonPropertyName("C_TeamplayRules")]
    public CTeamplayRules CTeamplayRules
    {
        get;
        set;
    }

    [JsonProperty("C_TextureBasedAnimatable")]
    [JsonPropertyName("C_TextureBasedAnimatable")]
    public CTextureBasedAnimatable CTextureBasedAnimatable
    {
        get;
        set;
    }

    [JsonProperty("C_TintController")]
    [JsonPropertyName("C_TintController")]
    public CTintController CTintController
    {
        get;
        set;
    }

    [JsonProperty("C_TonemapController2")]
    [JsonPropertyName("C_TonemapController2")]
    public CTonemapController2 CTonemapController2
    {
        get;
        set;
    }

    [JsonProperty("C_TonemapController2Alias_env_tonemap_controller2")]
    [JsonPropertyName("C_TonemapController2Alias_env_tonemap_controller2")]
    public CTonemapController2AliasEnvTonemapController2 CTonemapController2AliasEnvTonemapController2
    {
        get;
        set;
    }

    [JsonProperty("C_TriggerBuoyancy")]
    [JsonPropertyName("C_TriggerBuoyancy")]
    public CTriggerBuoyancy CTriggerBuoyancy
    {
        get;
        set;
    }

    [JsonProperty("C_TriggerLerpObject")]
    [JsonPropertyName("C_TriggerLerpObject")]
    public CTriggerLerpObject CTriggerLerpObject
    {
        get;
        set;
    }

    [JsonProperty("C_TriggerMultiple")]
    [JsonPropertyName("C_TriggerMultiple")]
    public CTriggerMultiple CTriggerMultiple
    {
        get;
        set;
    }

    [JsonProperty("C_TriggerPhysics")]
    [JsonPropertyName("C_TriggerPhysics")]
    public CTriggerPhysics CTriggerPhysics
    {
        get;
        set;
    }

    [JsonProperty("C_TriggerVolume")]
    [JsonPropertyName("C_TriggerVolume")]
    public CTriggerVolume CTriggerVolume
    {
        get;
        set;
    }

    [JsonProperty("C_VoteController")]
    [JsonPropertyName("C_VoteController")]
    public CVoteController CVoteController
    {
        get;
        set;
    }

    [JsonProperty("C_WaterBullet")]
    [JsonPropertyName("C_WaterBullet")]
    public CWaterBullet CWaterBullet
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponAWP")]
    [JsonPropertyName("C_WeaponAWP")]
    public CWeaponAWP CWeaponAWP
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponAug")]
    [JsonPropertyName("C_WeaponAug")]
    public CWeaponAug CWeaponAug
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponBaseItem")]
    [JsonPropertyName("C_WeaponBaseItem")]
    public CWeaponBaseItem CWeaponBaseItem
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponBizon")]
    [JsonPropertyName("C_WeaponBizon")]
    public CWeaponBizon CWeaponBizon
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponCZ75a")]
    [JsonPropertyName("C_WeaponCZ75a")]
    public CWeaponCZ75a CWeaponCZ75a
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponElite")]
    [JsonPropertyName("C_WeaponElite")]
    public CWeaponElite CWeaponElite
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponFamas")]
    [JsonPropertyName("C_WeaponFamas")]
    public CWeaponFamas CWeaponFamas
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponFiveSeven")]
    [JsonPropertyName("C_WeaponFiveSeven")]
    public CWeaponFiveSeven CWeaponFiveSeven
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponG3SG1")]
    [JsonPropertyName("C_WeaponG3SG1")]
    public CWeaponG3SG1 CWeaponG3SG1
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponGalilAR")]
    [JsonPropertyName("C_WeaponGalilAR")]
    public CWeaponGalilAR CWeaponGalilAR
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponGlock")]
    [JsonPropertyName("C_WeaponGlock")]
    public CWeaponGlock CWeaponGlock
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponHKP2000")]
    [JsonPropertyName("C_WeaponHKP2000")]
    public CWeaponHKP2000 CWeaponHKP2000
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponM249")]
    [JsonPropertyName("C_WeaponM249")]
    public CWeaponM249 CWeaponM249
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponM4A1")]
    [JsonPropertyName("C_WeaponM4A1")]
    public CWeaponM4A1 CWeaponM4A1
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponM4A1Silencer")]
    [JsonPropertyName("C_WeaponM4A1Silencer")]
    public CWeaponM4A1Silencer CWeaponM4A1Silencer
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponMAC10")]
    [JsonPropertyName("C_WeaponMAC10")]
    public CWeaponMAC10 CWeaponMAC10
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponMP5SD")]
    [JsonPropertyName("C_WeaponMP5SD")]
    public CWeaponMP5SD CWeaponMP5SD
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponMP7")]
    [JsonPropertyName("C_WeaponMP7")]
    public CWeaponMP7 CWeaponMP7
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponMP9")]
    [JsonPropertyName("C_WeaponMP9")]
    public CWeaponMP9 CWeaponMP9
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponMag7")]
    [JsonPropertyName("C_WeaponMag7")]
    public CWeaponMag7 CWeaponMag7
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponNOVA")]
    [JsonPropertyName("C_WeaponNOVA")]
    public CWeaponNOVA CWeaponNOVA
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponNegev")]
    [JsonPropertyName("C_WeaponNegev")]
    public CWeaponNegev CWeaponNegev
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponP250")]
    [JsonPropertyName("C_WeaponP250")]
    public CWeaponP250 CWeaponP250
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponP90")]
    [JsonPropertyName("C_WeaponP90")]
    public CWeaponP90 CWeaponP90
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponRevolver")]
    [JsonPropertyName("C_WeaponRevolver")]
    public CWeaponRevolver CWeaponRevolver
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponSCAR20")]
    [JsonPropertyName("C_WeaponSCAR20")]
    public CWeaponSCAR20 CWeaponSCAR20
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponSG556")]
    [JsonPropertyName("C_WeaponSG556")]
    public CWeaponSG556 CWeaponSG556
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponSSG08")]
    [JsonPropertyName("C_WeaponSSG08")]
    public CWeaponSSG08 CWeaponSSG08
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponSawedoff")]
    [JsonPropertyName("C_WeaponSawedoff")]
    public CWeaponSawedoff CWeaponSawedoff
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponTaser")]
    [JsonPropertyName("C_WeaponTaser")]
    public CWeaponTaser CWeaponTaser
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponTec9")]
    [JsonPropertyName("C_WeaponTec9")]
    public CWeaponTec9 CWeaponTec9
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponUMP45")]
    [JsonPropertyName("C_WeaponUMP45")]
    public CWeaponUMP45 CWeaponUMP45
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponUSPSilencer")]
    [JsonPropertyName("C_WeaponUSPSilencer")]
    public CWeaponUSPSilencer CWeaponUSPSilencer
    {
        get;
        set;
    }

    [JsonProperty("C_WeaponXM1014")]
    [JsonPropertyName("C_WeaponXM1014")]
    public CWeaponXM1014 CWeaponXM1014
    {
        get;
        set;
    }

    [JsonProperty("C_World")]
    [JsonPropertyName("C_World")]
    public CWorld CWorld
    {
        get;
        set;
    }

    [JsonProperty("C_WorldModelGloves")]
    [JsonPropertyName("C_WorldModelGloves")]
    public CWorldModelGloves CWorldModelGloves
    {
        get;
        set;
    }

    [JsonProperty("C_fogplayerparams_t")]
    [JsonPropertyName("C_fogplayerparams_t")]
    public CFogplayerparamsT CFogplayerparamsT
    {
        get;
        set;
    }

    [JsonProperty("CountdownTimer")]
    [JsonPropertyName("CountdownTimer")]
    public CountdownTimer CountdownTimer
    {
        get;
        set;
    }

    [JsonProperty("EngineCountdownTimer")]
    [JsonPropertyName("EngineCountdownTimer")]
    public EngineCountdownTimer EngineCountdownTimer
    {
        get;
        set;
    }

    [JsonProperty("EntityRenderAttribute_t")]
    [JsonPropertyName("EntityRenderAttribute_t")]
    public EntityRenderAttributeT EntityRenderAttributeT
    {
        get;
        set;
    }

    [JsonProperty("EntitySpottedState_t")]
    [JsonPropertyName("EntitySpottedState_t")]
    public EntitySpottedStateT EntitySpottedStateT
    {
        get;
        set;
    }

    [JsonProperty("FilterDamageType")]
    [JsonPropertyName("FilterDamageType")]
    public FilterDamageType FilterDamageType
    {
        get;
        set;
    }

    [JsonProperty("FilterHealth")]
    [JsonPropertyName("FilterHealth")]
    public FilterHealth FilterHealth
    {
        get;
        set;
    }

    [JsonProperty("IntervalTimer")]
    [JsonPropertyName("IntervalTimer")]
    public IntervalTimer IntervalTimer
    {
        get;
        set;
    }

    [JsonProperty("OutflowWithRequirements_t")]
    [JsonPropertyName("OutflowWithRequirements_t")]
    public OutflowWithRequirementsT OutflowWithRequirementsT
    {
        get;
        set;
    }

    [JsonProperty("PhysicsRagdollPose_t")]
    [JsonPropertyName("PhysicsRagdollPose_t")]
    public PhysicsRagdollPoseT PhysicsRagdollPoseT
    {
        get;
        set;
    }

    [JsonProperty("PredictedDamageTag_t")]
    [JsonPropertyName("PredictedDamageTag_t")]
    public PredictedDamageTagT PredictedDamageTagT
    {
        get;
        set;
    }

    [JsonProperty("PulseNodeDynamicOutflows_t")]
    [JsonPropertyName("PulseNodeDynamicOutflows_t")]
    public PulseNodeDynamicOutflowsT PulseNodeDynamicOutflowsT
    {
        get;
        set;
    }

    [JsonProperty("PulseNodeDynamicOutflows_t__DynamicOutflow_t")]
    [JsonPropertyName("PulseNodeDynamicOutflows_t__DynamicOutflow_t")]
    public PulseNodeDynamicOutflowsTDynamicOutflowT PulseNodeDynamicOutflowsTDynamicOutflowT
    {
        get;
        set;
    }

    [JsonProperty("PulseObservableBoolExpression_t")]
    [JsonPropertyName("PulseObservableBoolExpression_t")]
    public PulseObservableBoolExpressionT PulseObservableBoolExpressionT
    {
        get;
        set;
    }

    [JsonProperty("PulseSelectorOutflowList_t")]
    [JsonPropertyName("PulseSelectorOutflowList_t")]
    public PulseSelectorOutflowListT PulseSelectorOutflowListT
    {
        get;
        set;
    }

    [JsonProperty("SellbackPurchaseEntry_t")]
    [JsonPropertyName("SellbackPurchaseEntry_t")]
    public SellbackPurchaseEntryT SellbackPurchaseEntryT
    {
        get;
        set;
    }

    [JsonProperty("SequenceHistory_t")]
    [JsonPropertyName("SequenceHistory_t")]
    public SequenceHistoryT SequenceHistoryT
    {
        get;
        set;
    }

    [JsonProperty("SignatureOutflow_Continue")]
    [JsonPropertyName("SignatureOutflow_Continue")]
    public SignatureOutflowContinue SignatureOutflowContinue
    {
        get;
        set;
    }

    [JsonProperty("SignatureOutflow_Resume")]
    [JsonPropertyName("SignatureOutflow_Resume")]
    public SignatureOutflowResume SignatureOutflowResume
    {
        get;
        set;
    }

    [JsonProperty("VPhysicsCollisionAttribute_t")]
    [JsonPropertyName("VPhysicsCollisionAttribute_t")]
    public VPhysicsCollisionAttributeT VPhysicsCollisionAttributeT
    {
        get;
        set;
    }

    [JsonProperty("ViewAngleServerChange_t")]
    [JsonPropertyName("ViewAngleServerChange_t")]
    public ViewAngleServerChangeT ViewAngleServerChangeT
    {
        get;
        set;
    }

    [JsonProperty("WeaponPurchaseCount_t")]
    [JsonPropertyName("WeaponPurchaseCount_t")]
    public WeaponPurchaseCountT WeaponPurchaseCountT
    {
        get;
        set;
    }

    [JsonProperty("WeaponPurchaseTracker_t")]
    [JsonPropertyName("WeaponPurchaseTracker_t")]
    public WeaponPurchaseTrackerT WeaponPurchaseTrackerT
    {
        get;
        set;
    }

    [JsonProperty("audioparams_t")]
    [JsonPropertyName("audioparams_t")]
    public AudioparamsT AudioparamsT
    {
        get;
        set;
    }

    [JsonProperty("fogparams_t")]
    [JsonPropertyName("fogparams_t")]
    public FogparamsT FogparamsT
    {
        get;
        set;
    }

    [JsonProperty("shard_model_desc_t")]
    [JsonPropertyName("shard_model_desc_t")]
    public ShardModelDescT ShardModelDescT
    {
        get;
        set;
    }

    [JsonProperty("sky3dparams_t")]
    [JsonPropertyName("sky3dparams_t")]
    public Sky3dparamsT Sky3dparamsT
    {
        get;
        set;
    }
}

public class CLateUpdatedAnimating
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class ClientDll
{
    [JsonProperty("classes")]
    [JsonPropertyName("classes")]
    public Classes Classes
    {
        get;
        set;
    }

    [JsonProperty("enums")]
    [JsonPropertyName("enums")]
    public Enums Enums
    {
        get;
        set;
    }
}

public class CLightComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLightDirectionalEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLightEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLightEnvironmentEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLightOrthoEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLightSpotEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLocalTempEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLogicalEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLogicRelay
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CLogicRelayAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CMapInfo
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CMapPreviewParticleSystem
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CMapVetoPickController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CModelPointEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CModelState
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CMolotovGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CMolotovProjectile
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CMultimeter
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CMultiplayRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CNametagModule
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CNetTestBaseCombatCharacter
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CNetworkedSequenceOperation
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class COmniLight
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CompMatPropertyMutatorConditionTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CompMatPropertyMutatorTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CompositeMaterialInputContainerSourceTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CompositeMaterialInputLooseVariableTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CompositeMaterialInputTextureTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CompositeMaterialMatchFilterTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CompositeMaterialVarSystemVarT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class CountdownTimer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CParticleSystem
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPathParticleRope
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPathParticleRopeAliasPathParticleRopeClientside
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPathQueryComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPathSimple
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPathSimpleAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPhysBox
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPhysicsProp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPhysicsPropMultiplayer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPhysMagnet
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPhysPropClientside
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlantedC4
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerAutoaimServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerCameraServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerFlashlightServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerItemServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerMovementServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerMovementServicesHumanoid
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerObserverServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerPing
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerSprayDecal
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerUseServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerVisibility
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerWaterServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPlayerWeaponServices
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointCameraVFOV
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointChildModifier
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointClientUIDialog
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointClientUIHUD
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointClientUIWorldPanel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointClientUIWorldTextPanel
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointCommentaryNode
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointOffScreenIndicatorUi
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointOrient
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointTemplate
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointTemplateAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPointValueRemapper
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPointWorldText
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPortraitWorldCallbackHandler
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPostProcessingVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPrecipitation
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPrecipitationBlocker
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPrecipitationVData
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPropDataComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPropDoorRotating
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPulseAnimFuncs
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseArraylib
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseBlackboardReference
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCallInfo
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseFlow
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseLerp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseLerpCursorStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseRequirement
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseState
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseValue
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBaseYieldingInflow
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellBooleanSwitchState
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellCursorQueue
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellFireCursors
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowBaseEntrypoint
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowEntOutputHandler
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowEventHandler
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowGraphHook
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowMethod
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowObservableVariableListener
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowWait
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInflowYield
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellInlineNodeSkipSelector
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellIntervalTimer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellIntervalTimerCursorStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellIsRequirementValid
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellIsRequirementValidCriteriaT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellLerpCameraSettings
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellLerpCameraSettingsCursorStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellLimitCount
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellLimitCountCriteriaT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellLimitCountInstanceStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellOutflowCycleOrdered
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellOutflowCycleOrderedInstanceStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellOutflowCycleRandom
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellOutflowCycleShuffled
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellOutflowCycleShuffledInstanceStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellPickBestOutflowSelector
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellPlaySequence
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellPlaySequenceCursorStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellStepCallExternalMethod
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellStepDebugLog
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellStepEntFire
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellStepPublicOutput
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellTimeline
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellTimelineTimelineEventT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellUnknown
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellValueCurve
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellValueGradient
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellValueRandomFloat
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellValueRandomInt
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellWaitForCursorsWithTag
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellWaitForCursorsWithTagBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellWaitForCursorsWithTagBaseCursorStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCellWaitForObservable
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseCursorFuncs
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseExecCursor
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseGameBlackboard
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CPulseGraphDef
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseInvokeBinding
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseMathlib
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseOutflowConnection
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseResumePoint
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CPulseTestScriptLib
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CRagdollManager
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CRagdollProp
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CRagdollPropAttached
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CRectLight
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CRenderComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CRetakeGameRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CRopeKeyframe
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CRopeKeyframeCPhysicsDelegate
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CSceneEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSceneEntityQueuedEventsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CScriptComponent
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CServerOnlyModelEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CShatterGlassShardPhysics
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSingleplayRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CSkeletonInstance
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSkyboxReference
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSkyCamera
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSMatchStatsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CSmokeGrenade
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSmokeGrenadeProjectile
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundAreaEntityBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundAreaEntityOrientedBox
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundAreaEntitySphere
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundEventAABBEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundEventEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundEventEntityAliasSndEventPoint
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundEventOBBEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundEventPathCornerEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundEventSphereEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetAABBEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetAutoRoomEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetOBBEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetOBBWindEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetPathCornerEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetPointBase
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSoundOpvarSetPointEntity
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSPerRoundStatsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CSpotlightEnd
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSprite
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CSpriteOriented
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CStattrakModule
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTakeDamageInfoAPI
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CTeam
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTeamplayRules
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class CTextureBasedAnimatable
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTimeline
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTintController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTonemapController2
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTonemapController2AliasEnvTonemapController2
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTriggerBuoyancy
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTriggerFan
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTriggerLerpObject
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTriggerMultiple
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTriggerPhysics
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CTriggerVolume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CVoteController
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWaterBullet
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWaterSplasher
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponAug
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponAWP
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponBaseItem
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponBizon
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponCZ75a
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponElite
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponFamas
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponFiveSeven
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponG3SG1
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponGalilAR
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponGlock
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponHKP2000
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponM249
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponM4A1
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponM4A1Silencer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponMAC10
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponMag7
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponMP5SD
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponMP7
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponMP9
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponNegev
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponNOVA
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponP250
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponP90
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponRevolver
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponSawedoff
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponSCAR20
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponSG556
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponSSG08
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponTaser
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponTec9
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponUMP45
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponUSPSilencer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWeaponXM1014
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWorld
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class CWorldModelGloves
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class EngineCountdownTimer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class EntityRenderAttributeT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class EntitySpottedStateT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class Enums
{
    [JsonProperty("CompMatPropertyMutatorConditionType_t")]
    [JsonPropertyName("CompMatPropertyMutatorConditionType_t")]
    public CompMatPropertyMutatorConditionTypeT CompMatPropertyMutatorConditionTypeT
    {
        get;
        set;
    }

    [JsonProperty("CompMatPropertyMutatorType_t")]
    [JsonPropertyName("CompMatPropertyMutatorType_t")]
    public CompMatPropertyMutatorTypeT CompMatPropertyMutatorTypeT
    {
        get;
        set;
    }

    [JsonProperty("CompositeMaterialInputContainerSourceType_t")]
    [JsonPropertyName("CompositeMaterialInputContainerSourceType_t")]
    public CompositeMaterialInputContainerSourceTypeT CompositeMaterialInputContainerSourceTypeT
    {
        get;
        set;
    }

    [JsonProperty("CompositeMaterialInputLooseVariableType_t")]
    [JsonPropertyName("CompositeMaterialInputLooseVariableType_t")]
    public CompositeMaterialInputLooseVariableTypeT CompositeMaterialInputLooseVariableTypeT
    {
        get;
        set;
    }

    [JsonProperty("CompositeMaterialInputTextureType_t")]
    [JsonPropertyName("CompositeMaterialInputTextureType_t")]
    public CompositeMaterialInputTextureTypeT CompositeMaterialInputTextureTypeT
    {
        get;
        set;
    }

    [JsonProperty("CompositeMaterialMatchFilterType_t")]
    [JsonPropertyName("CompositeMaterialMatchFilterType_t")]
    public CompositeMaterialMatchFilterTypeT CompositeMaterialMatchFilterTypeT
    {
        get;
        set;
    }

    [JsonProperty("CompositeMaterialVarSystemVar_t")]
    [JsonPropertyName("CompositeMaterialVarSystemVar_t")]
    public CompositeMaterialVarSystemVarT CompositeMaterialVarSystemVarT
    {
        get;
        set;
    }

    [JsonProperty("InventoryNodeType_t")]
    [JsonPropertyName("InventoryNodeType_t")]
    public InventoryNodeTypeT InventoryNodeTypeT
    {
        get;
        set;
    }
}

public class Fields
{
    [JsonProperty("m_AssociatedEntities")]
    [JsonPropertyName("m_AssociatedEntities")]
    public int? MAssociatedEntities
    {
        get;
        set;
    }

    [JsonProperty("m_AssociatedEntityNames")]
    [JsonPropertyName("m_AssociatedEntityNames")]
    public int? MAssociatedEntityNames
    {
        get;
        set;
    }

    [JsonProperty("m_Handle")]
    [JsonPropertyName("m_Handle")]
    public int? MHandle
    {
        get;
        set;
    }

    [JsonProperty("m_Name")]
    [JsonPropertyName("m_Name")]
    public int? MName
    {
        get;
        set;
    }

    [JsonProperty("m_bDisableAutoGeneratedDMSpawns")]
    [JsonPropertyName("m_bDisableAutoGeneratedDMSpawns")]
    public int? MBDisableAutoGeneratedDMSpawns
    {
        get;
        set;
    }

    [JsonProperty("m_bFadePlayerVisibilityFarZ")]
    [JsonPropertyName("m_bFadePlayerVisibilityFarZ")]
    public int? MBFadePlayerVisibilityFarZ
    {
        get;
        set;
    }

    [JsonProperty("m_bRainTraceToSkyEnabled")]
    [JsonPropertyName("m_bRainTraceToSkyEnabled")]
    public int? MBRainTraceToSkyEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bUseNormalSpawnsForDM")]
    [JsonPropertyName("m_bUseNormalSpawnsForDM")]
    public int? MBUseNormalSpawnsForDM
    {
        get;
        set;
    }

    [JsonProperty("m_flBombRadius")]
    [JsonPropertyName("m_flBombRadius")]
    public int? MFlBombRadius
    {
        get;
        set;
    }

    [JsonProperty("m_flBotMaxVisionDistance")]
    [JsonPropertyName("m_flBotMaxVisionDistance")]
    public int? MFlBotMaxVisionDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flEnvPuddleRippleDirection")]
    [JsonPropertyName("m_flEnvPuddleRippleDirection")]
    public int? MFlEnvPuddleRippleDirection
    {
        get;
        set;
    }

    [JsonProperty("m_flEnvPuddleRippleStrength")]
    [JsonPropertyName("m_flEnvPuddleRippleStrength")]
    public int? MFlEnvPuddleRippleStrength
    {
        get;
        set;
    }

    [JsonProperty("m_flEnvRainStrength")]
    [JsonPropertyName("m_flEnvRainStrength")]
    public int? MFlEnvRainStrength
    {
        get;
        set;
    }

    [JsonProperty("m_flEnvWetnessCoverage")]
    [JsonPropertyName("m_flEnvWetnessCoverage")]
    public int? MFlEnvWetnessCoverage
    {
        get;
        set;
    }

    [JsonProperty("m_flEnvWetnessDryingAmount")]
    [JsonPropertyName("m_flEnvWetnessDryingAmount")]
    public int? MFlEnvWetnessDryingAmount
    {
        get;
        set;
    }

    [JsonProperty("m_iBuyingStatus")]
    [JsonPropertyName("m_iBuyingStatus")]
    public int? MIBuyingStatus
    {
        get;
        set;
    }

    [JsonProperty("m_iHostageCount")]
    [JsonPropertyName("m_iHostageCount")]
    public int? MIHostageCount
    {
        get;
        set;
    }

    [JsonProperty("m_iPetPopulation")]
    [JsonPropertyName("m_iPetPopulation")]
    public int? MIPetPopulation
    {
        get;
        set;
    }

    [JsonProperty("m_MeshGroupMask")]
    [JsonPropertyName("m_MeshGroupMask")]
    public int? MMeshGroupMask
    {
        get;
        set;
    }

    [JsonProperty("m_ModelName")]
    [JsonPropertyName("m_ModelName")]
    public int? MModelName
    {
        get;
        set;
    }

    [JsonProperty("m_bClientClothCreationSuppressed")]
    [JsonPropertyName("m_bClientClothCreationSuppressed")]
    public int? MBClientClothCreationSuppressed
    {
        get;
        set;
    }

    [JsonProperty("m_hModel")]
    [JsonPropertyName("m_hModel")]
    public int? MHModel
    {
        get;
        set;
    }

    [JsonProperty("m_nBodyGroupChoices")]
    [JsonPropertyName("m_nBodyGroupChoices")]
    public int? MNBodyGroupChoices
    {
        get;
        set;
    }

    [JsonProperty("m_nClothUpdateFlags")]
    [JsonPropertyName("m_nClothUpdateFlags")]
    public int? MNClothUpdateFlags
    {
        get;
        set;
    }

    [JsonProperty("m_nForceLOD")]
    [JsonPropertyName("m_nForceLOD")]
    public int? MNForceLOD
    {
        get;
        set;
    }

    [JsonProperty("m_nIdealMotionType")]
    [JsonPropertyName("m_nIdealMotionType")]
    public int? MNIdealMotionType
    {
        get;
        set;
    }

    [JsonProperty("m_bDiscontinuity")]
    [JsonPropertyName("m_bDiscontinuity")]
    public int? MBDiscontinuity
    {
        get;
        set;
    }

    [JsonProperty("m_bSequenceChangeNetworked")]
    [JsonPropertyName("m_bSequenceChangeNetworked")]
    public int? MBSequenceChangeNetworked
    {
        get;
        set;
    }

    [JsonProperty("m_flCycle")]
    [JsonPropertyName("m_flCycle")]
    public int? MFlCycle
    {
        get;
        set;
    }

    [JsonProperty("m_flPrevCycle")]
    [JsonPropertyName("m_flPrevCycle")]
    public int? MFlPrevCycle
    {
        get;
        set;
    }

    [JsonProperty("m_flPrevCycleForAnimEventDetection")]
    [JsonPropertyName("m_flPrevCycleForAnimEventDetection")]
    public int? MFlPrevCycleForAnimEventDetection
    {
        get;
        set;
    }

    [JsonProperty("m_flPrevCycleFromDiscontinuity")]
    [JsonPropertyName("m_flPrevCycleFromDiscontinuity")]
    public int? MFlPrevCycleFromDiscontinuity
    {
        get;
        set;
    }

    [JsonProperty("m_flWeight")]
    [JsonPropertyName("m_flWeight")]
    public int? MFlWeight
    {
        get;
        set;
    }

    [JsonProperty("m_hSequence")]
    [JsonPropertyName("m_hSequence")]
    public int? MHSequence
    {
        get;
        set;
    }

    [JsonProperty("m_CPathQueryComponent")]
    [JsonPropertyName("m_CPathQueryComponent")]
    public int? MCPathQueryComponent
    {
        get;
        set;
    }

    [JsonProperty("m_bClosedLoop")]
    [JsonPropertyName("m_bClosedLoop")]
    public int? MBClosedLoop
    {
        get;
        set;
    }

    [JsonProperty("m_pathString")]
    [JsonPropertyName("m_pathString")]
    public int? MPathString
    {
        get;
        set;
    }

    [JsonProperty("m_CurrentFog")]
    [JsonPropertyName("m_CurrentFog")]
    public int? MCurrentFog
    {
        get;
        set;
    }

    [JsonProperty("m_OverrideFogColor")]
    [JsonPropertyName("m_OverrideFogColor")]
    public int? MOverrideFogColor
    {
        get;
        set;
    }

    [JsonProperty("m_PlayerFog")]
    [JsonPropertyName("m_PlayerFog")]
    public int? MPlayerFog
    {
        get;
        set;
    }

    [JsonProperty("m_PostProcessingVolumes")]
    [JsonPropertyName("m_PostProcessingVolumes")]
    public int? MPostProcessingVolumes
    {
        get;
        set;
    }

    [JsonProperty("m_angDemoViewAngles")]
    [JsonPropertyName("m_angDemoViewAngles")]
    public int? MAngDemoViewAngles
    {
        get;
        set;
    }

    [JsonProperty("m_audio")]
    [JsonPropertyName("m_audio")]
    public int? MAudio
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideFogColor")]
    [JsonPropertyName("m_bOverrideFogColor")]
    public int? MBOverrideFogColor
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideFogStartEnd")]
    [JsonPropertyName("m_bOverrideFogStartEnd")]
    public int? MBOverrideFogStartEnd
    {
        get;
        set;
    }

    [JsonProperty("m_fOverrideFogEnd")]
    [JsonPropertyName("m_fOverrideFogEnd")]
    public int? MFOverrideFogEnd
    {
        get;
        set;
    }

    [JsonProperty("m_fOverrideFogStart")]
    [JsonPropertyName("m_fOverrideFogStart")]
    public int? MFOverrideFogStart
    {
        get;
        set;
    }

    [JsonProperty("m_flCsViewPunchAngleTickRatio")]
    [JsonPropertyName("m_flCsViewPunchAngleTickRatio")]
    public int? MFlCsViewPunchAngleTickRatio
    {
        get;
        set;
    }

    [JsonProperty("m_flOldPlayerViewOffsetZ")]
    [JsonPropertyName("m_flOldPlayerViewOffsetZ")]
    public int? MFlOldPlayerViewOffsetZ
    {
        get;
        set;
    }

    [JsonProperty("m_flOldPlayerZ")]
    [JsonPropertyName("m_flOldPlayerZ")]
    public int? MFlOldPlayerZ
    {
        get;
        set;
    }

    [JsonProperty("m_hActivePostProcessingVolume")]
    [JsonPropertyName("m_hActivePostProcessingVolume")]
    public int? MHActivePostProcessingVolume
    {
        get;
        set;
    }

    [JsonProperty("m_hColorCorrectionCtrl")]
    [JsonPropertyName("m_hColorCorrectionCtrl")]
    public int? MHColorCorrectionCtrl
    {
        get;
        set;
    }

    [JsonProperty("m_hOldFogController")]
    [JsonPropertyName("m_hOldFogController")]
    public int? MHOldFogController
    {
        get;
        set;
    }

    [JsonProperty("m_hTonemapController")]
    [JsonPropertyName("m_hTonemapController")]
    public int? MHTonemapController
    {
        get;
        set;
    }

    [JsonProperty("m_hViewEntity")]
    [JsonPropertyName("m_hViewEntity")]
    public int? MHViewEntity
    {
        get;
        set;
    }

    [JsonProperty("m_nCsViewPunchAngleTick")]
    [JsonPropertyName("m_nCsViewPunchAngleTick")]
    public int? MNCsViewPunchAngleTick
    {
        get;
        set;
    }

    [JsonProperty("m_vecCsViewPunchAngle")]
    [JsonPropertyName("m_vecCsViewPunchAngle")]
    public int? MVecCsViewPunchAngle
    {
        get;
        set;
    }

    [JsonProperty("m_flArmDamageMultiplier")]
    [JsonPropertyName("m_flArmDamageMultiplier")]
    public int? MFlArmDamageMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flChestDamageMultiplier")]
    [JsonPropertyName("m_flChestDamageMultiplier")]
    public int? MFlChestDamageMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flCrouchTime")]
    [JsonPropertyName("m_flCrouchTime")]
    public int? MFlCrouchTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDrowningDamageInterval")]
    [JsonPropertyName("m_flDrowningDamageInterval")]
    public int? MFlDrowningDamageInterval
    {
        get;
        set;
    }

    [JsonProperty("m_flHeadDamageMultiplier")]
    [JsonPropertyName("m_flHeadDamageMultiplier")]
    public int? MFlHeadDamageMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flHoldBreathTime")]
    [JsonPropertyName("m_flHoldBreathTime")]
    public int? MFlHoldBreathTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLegDamageMultiplier")]
    [JsonPropertyName("m_flLegDamageMultiplier")]
    public int? MFlLegDamageMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flStomachDamageMultiplier")]
    [JsonPropertyName("m_flStomachDamageMultiplier")]
    public int? MFlStomachDamageMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flUseAngleTolerance")]
    [JsonPropertyName("m_flUseAngleTolerance")]
    public int? MFlUseAngleTolerance
    {
        get;
        set;
    }

    [JsonProperty("m_flUseRange")]
    [JsonPropertyName("m_flUseRange")]
    public int? MFlUseRange
    {
        get;
        set;
    }

    [JsonProperty("m_nDrowningDamageInitial")]
    [JsonPropertyName("m_nDrowningDamageInitial")]
    public int? MNDrowningDamageInitial
    {
        get;
        set;
    }

    [JsonProperty("m_nDrowningDamageMax")]
    [JsonPropertyName("m_nDrowningDamageMax")]
    public int? MNDrowningDamageMax
    {
        get;
        set;
    }

    [JsonProperty("m_nWaterSpeed")]
    [JsonPropertyName("m_nWaterSpeed")]
    public int? MNWaterSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_sModelName")]
    [JsonPropertyName("m_sModelName")]
    public int? MSModelName
    {
        get;
        set;
    }

    [JsonProperty("m_arrForceSubtickMoveWhen")]
    [JsonPropertyName("m_arrForceSubtickMoveWhen")]
    public int? MArrForceSubtickMoveWhen
    {
        get;
        set;
    }

    [JsonProperty("m_flForwardMove")]
    [JsonPropertyName("m_flForwardMove")]
    public int? MFlForwardMove
    {
        get;
        set;
    }

    [JsonProperty("m_flLeftMove")]
    [JsonPropertyName("m_flLeftMove")]
    public int? MFlLeftMove
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxspeed")]
    [JsonPropertyName("m_flMaxspeed")]
    public int? MFlMaxspeed
    {
        get;
        set;
    }

    [JsonProperty("m_flUpMove")]
    [JsonPropertyName("m_flUpMove")]
    public int? MFlUpMove
    {
        get;
        set;
    }

    [JsonProperty("m_nButtonDoublePressed")]
    [JsonPropertyName("m_nButtonDoublePressed")]
    public int? MNButtonDoublePressed
    {
        get;
        set;
    }

    [JsonProperty("m_nButtons")]
    [JsonPropertyName("m_nButtons")]
    public int? MNButtons
    {
        get;
        set;
    }

    [JsonProperty("m_nImpulse")]
    [JsonPropertyName("m_nImpulse")]
    public int? MNImpulse
    {
        get;
        set;
    }

    [JsonProperty("m_nLastCommandNumberProcessed")]
    [JsonPropertyName("m_nLastCommandNumberProcessed")]
    public int? MNLastCommandNumberProcessed
    {
        get;
        set;
    }

    [JsonProperty("m_nQueuedButtonChangeMask")]
    [JsonPropertyName("m_nQueuedButtonChangeMask")]
    public int? MNQueuedButtonChangeMask
    {
        get;
        set;
    }

    [JsonProperty("m_nQueuedButtonDownMask")]
    [JsonPropertyName("m_nQueuedButtonDownMask")]
    public int? MNQueuedButtonDownMask
    {
        get;
        set;
    }

    [JsonProperty("m_nToggleButtonDownMask")]
    [JsonPropertyName("m_nToggleButtonDownMask")]
    public int? MNToggleButtonDownMask
    {
        get;
        set;
    }

    [JsonProperty("m_pButtonPressedCmdNumber")]
    [JsonPropertyName("m_pButtonPressedCmdNumber")]
    public int? MPButtonPressedCmdNumber
    {
        get;
        set;
    }

    [JsonProperty("m_vecLastMovementImpulses")]
    [JsonPropertyName("m_vecLastMovementImpulses")]
    public int? MVecLastMovementImpulses
    {
        get;
        set;
    }

    [JsonProperty("m_vecOldViewAngles")]
    [JsonPropertyName("m_vecOldViewAngles")]
    public int? MVecOldViewAngles
    {
        get;
        set;
    }

    [JsonProperty("m_bDucked")]
    [JsonPropertyName("m_bDucked")]
    public int? MBDucked
    {
        get;
        set;
    }

    [JsonProperty("m_bDucking")]
    [JsonPropertyName("m_bDucking")]
    public int? MBDucking
    {
        get;
        set;
    }

    [JsonProperty("m_bInCrouch")]
    [JsonPropertyName("m_bInCrouch")]
    public int? MBInCrouch
    {
        get;
        set;
    }

    [JsonProperty("m_bInDuckJump")]
    [JsonPropertyName("m_bInDuckJump")]
    public int? MBInDuckJump
    {
        get;
        set;
    }

    [JsonProperty("m_flCrouchTransitionStartTime")]
    [JsonPropertyName("m_flCrouchTransitionStartTime")]
    public int? MFlCrouchTransitionStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFallVelocity")]
    [JsonPropertyName("m_flFallVelocity")]
    public int? MFlFallVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_flStepSoundTime")]
    [JsonPropertyName("m_flStepSoundTime")]
    public int? MFlStepSoundTime
    {
        get;
        set;
    }

    [JsonProperty("m_flSurfaceFriction")]
    [JsonPropertyName("m_flSurfaceFriction")]
    public int? MFlSurfaceFriction
    {
        get;
        set;
    }

    [JsonProperty("m_groundNormal")]
    [JsonPropertyName("m_groundNormal")]
    public int? MGroundNormal
    {
        get;
        set;
    }

    [JsonProperty("m_nCrouchState")]
    [JsonPropertyName("m_nCrouchState")]
    public int? MNCrouchState
    {
        get;
        set;
    }

    [JsonProperty("m_nStepside")]
    [JsonPropertyName("m_nStepside")]
    public int? MNStepside
    {
        get;
        set;
    }

    [JsonProperty("m_surfaceProps")]
    [JsonPropertyName("m_surfaceProps")]
    public int? MSurfaceProps
    {
        get;
        set;
    }

    [JsonProperty("m_bForcedObserverMode")]
    [JsonPropertyName("m_bForcedObserverMode")]
    public int? MBForcedObserverMode
    {
        get;
        set;
    }

    [JsonProperty("m_flObserverChaseDistance")]
    [JsonPropertyName("m_flObserverChaseDistance")]
    public int? MFlObserverChaseDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flObserverChaseDistanceCalcTime")]
    [JsonPropertyName("m_flObserverChaseDistanceCalcTime")]
    public int? MFlObserverChaseDistanceCalcTime
    {
        get;
        set;
    }

    [JsonProperty("m_hObserverTarget")]
    [JsonPropertyName("m_hObserverTarget")]
    public int? MHObserverTarget
    {
        get;
        set;
    }

    [JsonProperty("m_iObserverLastMode")]
    [JsonPropertyName("m_iObserverLastMode")]
    public int? MIObserverLastMode
    {
        get;
        set;
    }

    [JsonProperty("m_iObserverMode")]
    [JsonPropertyName("m_iObserverMode")]
    public int? MIObserverMode
    {
        get;
        set;
    }

    [JsonProperty("m_hActiveWeapon")]
    [JsonPropertyName("m_hActiveWeapon")]
    public int? MHActiveWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_hLastWeapon")]
    [JsonPropertyName("m_hLastWeapon")]
    public int? MHLastWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_hMyWeapons")]
    [JsonPropertyName("m_hMyWeapons")]
    public int? MHMyWeapons
    {
        get;
        set;
    }

    [JsonProperty("m_iAmmo")]
    [JsonPropertyName("m_iAmmo")]
    public int? MIAmmo
    {
        get;
        set;
    }

    [JsonProperty("m_bOrphanInsteadOfDeletingChildrenOnRemove")]
    [JsonPropertyName("m_bOrphanInsteadOfDeletingChildrenOnRemove")]
    public int? MBOrphanInsteadOfDeletingChildrenOnRemove
    {
        get;
        set;
    }

    [JsonProperty("m_bBeenEnabled")]
    [JsonPropertyName("m_bBeenEnabled")]
    public int? MBBeenEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bHide")]
    [JsonPropertyName("m_bHide")]
    public int? MBHide
    {
        get;
        set;
    }

    [JsonProperty("m_flSeenTargetTime")]
    [JsonPropertyName("m_flSeenTargetTime")]
    public int? MFlSeenTargetTime
    {
        get;
        set;
    }

    [JsonProperty("m_pTargetPanel")]
    [JsonPropertyName("m_pTargetPanel")]
    public int? MPTargetPanel
    {
        get;
        set;
    }

    [JsonProperty("m_bActive")]
    [JsonPropertyName("m_bActive")]
    public int? MBActive
    {
        get;
        set;
    }

    [JsonProperty("m_flLastGameTime")]
    [JsonPropertyName("m_flLastGameTime")]
    public int? MFlLastGameTime
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxTurnRate")]
    [JsonPropertyName("m_flMaxTurnRate")]
    public int? MFlMaxTurnRate
    {
        get;
        set;
    }

    [JsonProperty("m_hTarget")]
    [JsonPropertyName("m_hTarget")]
    public int? MHTarget
    {
        get;
        set;
    }

    [JsonProperty("m_iszSpawnTargetName")]
    [JsonPropertyName("m_iszSpawnTargetName")]
    public int? MIszSpawnTargetName
    {
        get;
        set;
    }

    [JsonProperty("m_nConstraint")]
    [JsonPropertyName("m_nConstraint")]
    public int? MNConstraint
    {
        get;
        set;
    }

    [JsonProperty("m_nGoalDirection")]
    [JsonPropertyName("m_nGoalDirection")]
    public int? MNGoalDirection
    {
        get;
        set;
    }

    [JsonProperty("m_aShootSounds")]
    [JsonPropertyName("m_aShootSounds")]
    public int? MAShootSounds
    {
        get;
        set;
    }

    [JsonProperty("m_bAllowFlipping")]
    [JsonPropertyName("m_bAllowFlipping")]
    public int? MBAllowFlipping
    {
        get;
        set;
    }

    [JsonProperty("m_bAutoSwitchFrom")]
    [JsonPropertyName("m_bAutoSwitchFrom")]
    public int? MBAutoSwitchFrom
    {
        get;
        set;
    }

    [JsonProperty("m_bAutoSwitchTo")]
    [JsonPropertyName("m_bAutoSwitchTo")]
    public int? MBAutoSwitchTo
    {
        get;
        set;
    }

    [JsonProperty("m_bBuiltRightHanded")]
    [JsonPropertyName("m_bBuiltRightHanded")]
    public int? MBBuiltRightHanded
    {
        get;
        set;
    }

    [JsonProperty("m_bKeepLoadedAmmo")]
    [JsonPropertyName("m_bKeepLoadedAmmo")]
    public int? MBKeepLoadedAmmo
    {
        get;
        set;
    }

    [JsonProperty("m_bLinkedCooldowns")]
    [JsonPropertyName("m_bLinkedCooldowns")]
    public int? MBLinkedCooldowns
    {
        get;
        set;
    }

    [JsonProperty("m_bReserveAmmoAsClips")]
    [JsonPropertyName("m_bReserveAmmoAsClips")]
    public int? MBReserveAmmoAsClips
    {
        get;
        set;
    }

    [JsonProperty("m_bTreatAsSingleClip")]
    [JsonPropertyName("m_bTreatAsSingleClip")]
    public int? MBTreatAsSingleClip
    {
        get;
        set;
    }

    [JsonProperty("m_flDropSpeed")]
    [JsonPropertyName("m_flDropSpeed")]
    public int? MFlDropSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flMuzzleSmokeDecrementRate")]
    [JsonPropertyName("m_flMuzzleSmokeDecrementRate")]
    public int? MFlMuzzleSmokeDecrementRate
    {
        get;
        set;
    }

    [JsonProperty("m_flMuzzleSmokeTimeout")]
    [JsonPropertyName("m_flMuzzleSmokeTimeout")]
    public int? MFlMuzzleSmokeTimeout
    {
        get;
        set;
    }

    [JsonProperty("m_iDefaultClip1")]
    [JsonPropertyName("m_iDefaultClip1")]
    public int? MIDefaultClip1
    {
        get;
        set;
    }

    [JsonProperty("m_iDefaultClip2")]
    [JsonPropertyName("m_iDefaultClip2")]
    public int? MIDefaultClip2
    {
        get;
        set;
    }

    [JsonProperty("m_iFlags")]
    [JsonPropertyName("m_iFlags")]
    public int? MIFlags
    {
        get;
        set;
    }

    [JsonProperty("m_iMaxClip1")]
    [JsonPropertyName("m_iMaxClip1")]
    public int? MIMaxClip1
    {
        get;
        set;
    }

    [JsonProperty("m_iMaxClip2")]
    [JsonPropertyName("m_iMaxClip2")]
    public int? MIMaxClip2
    {
        get;
        set;
    }

    [JsonProperty("m_iPosition")]
    [JsonPropertyName("m_iPosition")]
    public int? MIPosition
    {
        get;
        set;
    }

    [JsonProperty("m_iRumbleEffect")]
    [JsonPropertyName("m_iRumbleEffect")]
    public int? MIRumbleEffect
    {
        get;
        set;
    }

    [JsonProperty("m_iSlot")]
    [JsonPropertyName("m_iSlot")]
    public int? MISlot
    {
        get;
        set;
    }

    [JsonProperty("m_iWeight")]
    [JsonPropertyName("m_iWeight")]
    public int? MIWeight
    {
        get;
        set;
    }

    [JsonProperty("m_nMuzzleSmokeShotThreshold")]
    [JsonPropertyName("m_nMuzzleSmokeShotThreshold")]
    public int? MNMuzzleSmokeShotThreshold
    {
        get;
        set;
    }

    [JsonProperty("m_nPrimaryAmmoType")]
    [JsonPropertyName("m_nPrimaryAmmoType")]
    public int? MNPrimaryAmmoType
    {
        get;
        set;
    }

    [JsonProperty("m_nSecondaryAmmoType")]
    [JsonPropertyName("m_nSecondaryAmmoType")]
    public int? MNSecondaryAmmoType
    {
        get;
        set;
    }

    [JsonProperty("m_sMuzzleAttachment")]
    [JsonPropertyName("m_sMuzzleAttachment")]
    public int? MSMuzzleAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_sToolsOnlyOwnerModelName")]
    [JsonPropertyName("m_sToolsOnlyOwnerModelName")]
    public int? MSToolsOnlyOwnerModelName
    {
        get;
        set;
    }

    [JsonProperty("m_szBarrelSmokeParticle")]
    [JsonPropertyName("m_szBarrelSmokeParticle")]
    public int? MSzBarrelSmokeParticle
    {
        get;
        set;
    }

    [JsonProperty("m_szMuzzleFlashParticle")]
    [JsonPropertyName("m_szMuzzleFlashParticle")]
    public int? MSzMuzzleFlashParticle
    {
        get;
        set;
    }

    [JsonProperty("m_szMuzzleFlashParticleConfig")]
    [JsonPropertyName("m_szMuzzleFlashParticleConfig")]
    public int? MSzMuzzleFlashParticleConfig
    {
        get;
        set;
    }

    [JsonProperty("m_szWorldModel")]
    [JsonPropertyName("m_szWorldModel")]
    public int? MSzWorldModel
    {
        get;
        set;
    }

    [JsonProperty("m_ScriptCallbackScope")]
    [JsonPropertyName("m_ScriptCallbackScope")]
    public int? MScriptCallbackScope
    {
        get;
        set;
    }

    [JsonProperty("m_ScriptSpawnCallback")]
    [JsonPropertyName("m_ScriptSpawnCallback")]
    public int? MScriptSpawnCallback
    {
        get;
        set;
    }

    [JsonProperty("m_SpawnedEntityHandles")]
    [JsonPropertyName("m_SpawnedEntityHandles")]
    public int? MSpawnedEntityHandles
    {
        get;
        set;
    }

    [JsonProperty("m_bAsynchronouslySpawnEntities")]
    [JsonPropertyName("m_bAsynchronouslySpawnEntities")]
    public int? MBAsynchronouslySpawnEntities
    {
        get;
        set;
    }

    [JsonProperty("m_clientOnlyEntityBehavior")]
    [JsonPropertyName("m_clientOnlyEntityBehavior")]
    public int? MClientOnlyEntityBehavior
    {
        get;
        set;
    }

    [JsonProperty("m_createdSpawnGroupHandles")]
    [JsonPropertyName("m_createdSpawnGroupHandles")]
    public int? MCreatedSpawnGroupHandles
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeoutInterval")]
    [JsonPropertyName("m_flTimeoutInterval")]
    public int? MFlTimeoutInterval
    {
        get;
        set;
    }

    [JsonProperty("m_iszEntityFilterName")]
    [JsonPropertyName("m_iszEntityFilterName")]
    public int? MIszEntityFilterName
    {
        get;
        set;
    }

    [JsonProperty("m_iszSource2EntityLumpName")]
    [JsonPropertyName("m_iszSource2EntityLumpName")]
    public int? MIszSource2EntityLumpName
    {
        get;
        set;
    }

    [JsonProperty("m_iszWorldName")]
    [JsonPropertyName("m_iszWorldName")]
    public int? MIszWorldName
    {
        get;
        set;
    }

    [JsonProperty("m_ownerSpawnGroupType")]
    [JsonPropertyName("m_ownerSpawnGroupType")]
    public int? MOwnerSpawnGroupType
    {
        get;
        set;
    }

    [JsonProperty("m_bBatchSameVolumeType")]
    [JsonPropertyName("m_bBatchSameVolumeType")]
    public int? MBBatchSameVolumeType
    {
        get;
        set;
    }

    [JsonProperty("m_flInnerDistance")]
    [JsonPropertyName("m_flInnerDistance")]
    public int? MFlInnerDistance
    {
        get;
        set;
    }

    [JsonProperty("m_nAttachType")]
    [JsonPropertyName("m_nAttachType")]
    public int? MNAttachType
    {
        get;
        set;
    }

    [JsonProperty("m_nRTEnvCP")]
    [JsonPropertyName("m_nRTEnvCP")]
    public int? MNRTEnvCP
    {
        get;
        set;
    }

    [JsonProperty("m_nRTEnvCPComponent")]
    [JsonPropertyName("m_nRTEnvCPComponent")]
    public int? MNRTEnvCPComponent
    {
        get;
        set;
    }

    [JsonProperty("m_szModifier")]
    [JsonPropertyName("m_szModifier")]
    public int? MSzModifier
    {
        get;
        set;
    }

    [JsonProperty("m_szParticlePrecipitationEffect")]
    [JsonPropertyName("m_szParticlePrecipitationEffect")]
    public int? MSzParticlePrecipitationEffect
    {
        get;
        set;
    }

    [JsonProperty("m_bSpawnMotionDisabled")]
    [JsonPropertyName("m_bSpawnMotionDisabled")]
    public int? MBSpawnMotionDisabled
    {
        get;
        set;
    }

    [JsonProperty("m_flDmgModBullet")]
    [JsonPropertyName("m_flDmgModBullet")]
    public int? MFlDmgModBullet
    {
        get;
        set;
    }

    [JsonProperty("m_flDmgModClub")]
    [JsonPropertyName("m_flDmgModClub")]
    public int? MFlDmgModClub
    {
        get;
        set;
    }

    [JsonProperty("m_flDmgModExplosive")]
    [JsonPropertyName("m_flDmgModExplosive")]
    public int? MFlDmgModExplosive
    {
        get;
        set;
    }

    [JsonProperty("m_flDmgModFire")]
    [JsonPropertyName("m_flDmgModFire")]
    public int? MFlDmgModFire
    {
        get;
        set;
    }

    [JsonProperty("m_iszBasePropData")]
    [JsonPropertyName("m_iszBasePropData")]
    public int? MIszBasePropData
    {
        get;
        set;
    }

    [JsonProperty("m_iszPhysicsDamageTableName")]
    [JsonPropertyName("m_iszPhysicsDamageTableName")]
    public int? MIszPhysicsDamageTableName
    {
        get;
        set;
    }

    [JsonProperty("m_nDisableTakePhysicsDamageSpawnFlag")]
    [JsonPropertyName("m_nDisableTakePhysicsDamageSpawnFlag")]
    public int? MNDisableTakePhysicsDamageSpawnFlag
    {
        get;
        set;
    }

    [JsonProperty("m_nInteractions")]
    [JsonPropertyName("m_nInteractions")]
    public int? MNInteractions
    {
        get;
        set;
    }

    [JsonProperty("m_nMotionDisabledSpawnFlag")]
    [JsonPropertyName("m_nMotionDisabledSpawnFlag")]
    public int? MNMotionDisabledSpawnFlag
    {
        get;
        set;
    }

    [JsonProperty("m_nEditorNodeID")]
    [JsonPropertyName("m_nEditorNodeID")]
    public int? MNEditorNodeID
    {
        get;
        set;
    }

    [JsonProperty("m_WakeResume")]
    [JsonPropertyName("m_WakeResume")]
    public int? MWakeResume
    {
        get;
        set;
    }

    [JsonProperty("m_EndTime")]
    [JsonPropertyName("m_EndTime")]
    public int? MEndTime
    {
        get;
        set;
    }

    [JsonProperty("m_StartTime")]
    [JsonPropertyName("m_StartTime")]
    public int? MStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_bConformToCollisionBounds")]
    [JsonPropertyName("m_bConformToCollisionBounds")]
    public int? MBConformToCollisionBounds
    {
        get;
        set;
    }

    [JsonProperty("m_bModelOverrodeBlockLOS")]
    [JsonPropertyName("m_bModelOverrodeBlockLOS")]
    public int? MBModelOverrodeBlockLOS
    {
        get;
        set;
    }

    [JsonProperty("m_iShapeType")]
    [JsonPropertyName("m_iShapeType")]
    public int? MIShapeType
    {
        get;
        set;
    }

    [JsonProperty("m_mPreferredCatchTransform")]
    [JsonPropertyName("m_mPreferredCatchTransform")]
    public int? MMPreferredCatchTransform
    {
        get;
        set;
    }

    [JsonProperty("m_Condition")]
    [JsonPropertyName("m_Condition")]
    public int? MCondition
    {
        get;
        set;
    }

    [JsonProperty("m_SubGraph")]
    [JsonPropertyName("m_SubGraph")]
    public int? MSubGraph
    {
        get;
        set;
    }

    [JsonProperty("m_WhenFalse")]
    [JsonPropertyName("m_WhenFalse")]
    public int? MWhenFalse
    {
        get;
        set;
    }

    [JsonProperty("m_WhenTrue")]
    [JsonPropertyName("m_WhenTrue")]
    public int? MWhenTrue
    {
        get;
        set;
    }

    [JsonProperty("m_nCursorsAllowedToRunParallel")]
    [JsonPropertyName("m_nCursorsAllowedToRunParallel")]
    public int? MNCursorsAllowedToRunParallel
    {
        get;
        set;
    }

    [JsonProperty("m_OnCanceled")]
    [JsonPropertyName("m_OnCanceled")]
    public int? MOnCanceled
    {
        get;
        set;
    }

    [JsonProperty("m_OnFinished")]
    [JsonPropertyName("m_OnFinished")]
    public int? MOnFinished
    {
        get;
        set;
    }

    [JsonProperty("m_Outflows")]
    [JsonPropertyName("m_Outflows")]
    public int? MOutflows
    {
        get;
        set;
    }

    [JsonProperty("m_bWaitForChildOutflows")]
    [JsonPropertyName("m_bWaitForChildOutflows")]
    public int? MBWaitForChildOutflows
    {
        get;
        set;
    }

    [JsonProperty("m_EntryChunk")]
    [JsonPropertyName("m_EntryChunk")]
    public int? MEntryChunk
    {
        get;
        set;
    }

    [JsonProperty("m_RegisterMap")]
    [JsonPropertyName("m_RegisterMap")]
    public int? MRegisterMap
    {
        get;
        set;
    }

    [JsonProperty("m_ExpectedParamType")]
    [JsonPropertyName("m_ExpectedParamType")]
    public int? MExpectedParamType
    {
        get;
        set;
    }

    [JsonProperty("m_SourceEntity")]
    [JsonPropertyName("m_SourceEntity")]
    public int? MSourceEntity
    {
        get;
        set;
    }

    [JsonProperty("m_SourceOutput")]
    [JsonPropertyName("m_SourceOutput")]
    public int? MSourceOutput
    {
        get;
        set;
    }

    [JsonProperty("m_EventName")]
    [JsonPropertyName("m_EventName")]
    public int? MEventName
    {
        get;
        set;
    }

    [JsonProperty("m_HookName")]
    [JsonPropertyName("m_HookName")]
    public int? MHookName
    {
        get;
        set;
    }

    [JsonProperty("m_Args")]
    [JsonPropertyName("m_Args")]
    public int? MArgs
    {
        get;
        set;
    }

    [JsonProperty("m_Description")]
    [JsonPropertyName("m_Description")]
    public int? MDescription
    {
        get;
        set;
    }

    [JsonProperty("m_MethodName")]
    [JsonPropertyName("m_MethodName")]
    public int? MMethodName
    {
        get;
        set;
    }

    [JsonProperty("m_ReturnType")]
    [JsonPropertyName("m_ReturnType")]
    public int? MReturnType
    {
        get;
        set;
    }

    [JsonProperty("m_bIsPublic")]
    [JsonPropertyName("m_bIsPublic")]
    public int? MBIsPublic
    {
        get;
        set;
    }

    [JsonProperty("m_bSelfReference")]
    [JsonPropertyName("m_bSelfReference")]
    public int? MBSelfReference
    {
        get;
        set;
    }

    [JsonProperty("m_nBlackboardReference")]
    [JsonPropertyName("m_nBlackboardReference")]
    public int? MNBlackboardReference
    {
        get;
        set;
    }

    [JsonProperty("m_UnyieldResume")]
    [JsonPropertyName("m_UnyieldResume")]
    public int? MUnyieldResume
    {
        get;
        set;
    }

    [JsonProperty("m_FailOutflow")]
    [JsonPropertyName("m_FailOutflow")]
    public int? MFailOutflow
    {
        get;
        set;
    }

    [JsonProperty("m_PassOutflow")]
    [JsonPropertyName("m_PassOutflow")]
    public int? MPassOutflow
    {
        get;
        set;
    }

    [JsonProperty("m_bAnd")]
    [JsonPropertyName("m_bAnd")]
    public int? MBAnd
    {
        get;
        set;
    }

    [JsonProperty("m_nFlowNodeID")]
    [JsonPropertyName("m_nFlowNodeID")]
    public int? MNFlowNodeID
    {
        get;
        set;
    }

    [JsonProperty("m_Completed")]
    [JsonPropertyName("m_Completed")]
    public int? MCompleted
    {
        get;
        set;
    }

    [JsonProperty("m_OnInterval")]
    [JsonPropertyName("m_OnInterval")]
    public int? MOnInterval
    {
        get;
        set;
    }

    [JsonProperty("m_bCompleteOnNextWake")]
    [JsonPropertyName("m_bCompleteOnNextWake")]
    public int? MBCompleteOnNextWake
    {
        get;
        set;
    }

    [JsonProperty("m_flWaitInterval")]
    [JsonPropertyName("m_flWaitInterval")]
    public int? MFlWaitInterval
    {
        get;
        set;
    }

    [JsonProperty("m_flWaitIntervalHigh")]
    [JsonPropertyName("m_flWaitIntervalHigh")]
    public int? MFlWaitIntervalHigh
    {
        get;
        set;
    }

    [JsonProperty("m_bIsValid")]
    [JsonPropertyName("m_bIsValid")]
    public int? MBIsValid
    {
        get;
        set;
    }

    [JsonProperty("m_End")]
    [JsonPropertyName("m_End")]
    public int? MEnd
    {
        get;
        set;
    }

    [JsonProperty("m_Start")]
    [JsonPropertyName("m_Start")]
    public int? MStart
    {
        get;
        set;
    }

    [JsonProperty("m_flSeconds")]
    [JsonPropertyName("m_flSeconds")]
    public int? MFlSeconds
    {
        get;
        set;
    }

    [JsonProperty("m_OverlaidEnd")]
    [JsonPropertyName("m_OverlaidEnd")]
    public int? MOverlaidEnd
    {
        get;
        set;
    }

    [JsonProperty("m_OverlaidStart")]
    [JsonPropertyName("m_OverlaidStart")]
    public int? MOverlaidStart
    {
        get;
        set;
    }

    [JsonProperty("m_hCamera")]
    [JsonPropertyName("m_hCamera")]
    public int? MHCamera
    {
        get;
        set;
    }

    [JsonProperty("m_nLimitCount")]
    [JsonPropertyName("m_nLimitCount")]
    public int? MNLimitCount
    {
        get;
        set;
    }

    [JsonProperty("m_bLimitCountPasses")]
    [JsonPropertyName("m_bLimitCountPasses")]
    public int? MBLimitCountPasses
    {
        get;
        set;
    }

    [JsonProperty("m_nCurrentCount")]
    [JsonPropertyName("m_nCurrentCount")]
    public int? MNCurrentCount
    {
        get;
        set;
    }

    [JsonProperty("m_Outputs")]
    [JsonPropertyName("m_Outputs")]
    public int? MOutputs
    {
        get;
        set;
    }

    [JsonProperty("m_nNextIndex")]
    [JsonPropertyName("m_nNextIndex")]
    public int? MNNextIndex
    {
        get;
        set;
    }

    [JsonProperty("m_Shuffle")]
    [JsonPropertyName("m_Shuffle")]
    public int? MShuffle
    {
        get;
        set;
    }

    [JsonProperty("m_nNextShuffle")]
    [JsonPropertyName("m_nNextShuffle")]
    public int? MNNextShuffle
    {
        get;
        set;
    }

    [JsonProperty("__m_pChainEntity")]
    [JsonPropertyName("__m_pChainEntity")]
    public int? MPChainEntity
    {
        get;
        set;
    }

    [JsonProperty("m_pSceneNode")]
    [JsonPropertyName("m_pSceneNode")]
    public int? MPSceneNode
    {
        get;
        set;
    }

    [JsonProperty("m_OutflowList")]
    [JsonPropertyName("m_OutflowList")]
    public int? MOutflowList
    {
        get;
        set;
    }

    [JsonProperty("m_nCheckType")]
    [JsonPropertyName("m_nCheckType")]
    public int? MNCheckType
    {
        get;
        set;
    }

    [JsonProperty("m_PulseAnimEvents")]
    [JsonPropertyName("m_PulseAnimEvents")]
    public int? MPulseAnimEvents
    {
        get;
        set;
    }

    [JsonProperty("m_SequenceName")]
    [JsonPropertyName("m_SequenceName")]
    public int? MSequenceName
    {
        get;
        set;
    }

    [JsonProperty("m_ExpectedArgs")]
    [JsonPropertyName("m_ExpectedArgs")]
    public int? MExpectedArgs
    {
        get;
        set;
    }

    [JsonProperty("m_GameBlackboard")]
    [JsonPropertyName("m_GameBlackboard")]
    public int? MGameBlackboard
    {
        get;
        set;
    }

    [JsonProperty("m_nAsyncCallMode")]
    [JsonPropertyName("m_nAsyncCallMode")]
    public int? MNAsyncCallMode
    {
        get;
        set;
    }

    [JsonProperty("m_Input")]
    [JsonPropertyName("m_Input")]
    public int? MInput
    {
        get;
        set;
    }

    [JsonProperty("m_OutputIndex")]
    [JsonPropertyName("m_OutputIndex")]
    public int? MOutputIndex
    {
        get;
        set;
    }

    [JsonProperty("m_TimelineEvents")]
    [JsonPropertyName("m_TimelineEvents")]
    public int? MTimelineEvents
    {
        get;
        set;
    }

    [JsonProperty("m_EventOutflow")]
    [JsonPropertyName("m_EventOutflow")]
    public int? MEventOutflow
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeFromPrevious")]
    [JsonPropertyName("m_flTimeFromPrevious")]
    public int? MFlTimeFromPrevious
    {
        get;
        set;
    }

    [JsonProperty("m_UnknownKeys")]
    [JsonPropertyName("m_UnknownKeys")]
    public int? MUnknownKeys
    {
        get;
        set;
    }

    [JsonProperty("m_animationController")]
    [JsonPropertyName("m_animationController")]
    public int? MAnimationController
    {
        get;
        set;
    }

    [JsonProperty("m_Curve")]
    [JsonPropertyName("m_Curve")]
    public int? MCurve
    {
        get;
        set;
    }

    [JsonProperty("m_Gradient")]
    [JsonPropertyName("m_Gradient")]
    public int? MGradient
    {
        get;
        set;
    }

    [JsonProperty("m_bTagSelfWhenComplete")]
    [JsonPropertyName("m_bTagSelfWhenComplete")]
    public int? MBTagSelfWhenComplete
    {
        get;
        set;
    }

    [JsonProperty("m_nDesiredKillPriority")]
    [JsonPropertyName("m_nDesiredKillPriority")]
    public int? MNDesiredKillPriority
    {
        get;
        set;
    }

    [JsonProperty("m_WaitComplete")]
    [JsonPropertyName("m_WaitComplete")]
    public int? MWaitComplete
    {
        get;
        set;
    }

    [JsonProperty("m_nCursorsAllowedToWait")]
    [JsonPropertyName("m_nCursorsAllowedToWait")]
    public int? MNCursorsAllowedToWait
    {
        get;
        set;
    }

    [JsonProperty("m_TagName")]
    [JsonPropertyName("m_TagName")]
    public int? MTagName
    {
        get;
        set;
    }

    [JsonProperty("m_OnTrue")]
    [JsonPropertyName("m_OnTrue")]
    public int? MOnTrue
    {
        get;
        set;
    }

    [JsonProperty("m_strGraphName")]
    [JsonPropertyName("m_strGraphName")]
    public int? MStrGraphName
    {
        get;
        set;
    }

    [JsonProperty("m_strStateBlob")]
    [JsonPropertyName("m_strStateBlob")]
    public int? MStrStateBlob
    {
        get;
        set;
    }

    [JsonProperty("m_BlackboardReferences")]
    [JsonPropertyName("m_BlackboardReferences")]
    public int? MBlackboardReferences
    {
        get;
        set;
    }

    [JsonProperty("m_CallInfos")]
    [JsonPropertyName("m_CallInfos")]
    public int? MCallInfos
    {
        get;
        set;
    }

    [JsonProperty("m_Cells")]
    [JsonPropertyName("m_Cells")]
    public int? MCells
    {
        get;
        set;
    }

    [JsonProperty("m_Chunks")]
    [JsonPropertyName("m_Chunks")]
    public int? MChunks
    {
        get;
        set;
    }

    [JsonProperty("m_Constants")]
    [JsonPropertyName("m_Constants")]
    public int? MConstants
    {
        get;
        set;
    }

    [JsonProperty("m_DomainIdentifier")]
    [JsonPropertyName("m_DomainIdentifier")]
    public int? MDomainIdentifier
    {
        get;
        set;
    }

    [JsonProperty("m_DomainSubType")]
    [JsonPropertyName("m_DomainSubType")]
    public int? MDomainSubType
    {
        get;
        set;
    }

    [JsonProperty("m_DomainValues")]
    [JsonPropertyName("m_DomainValues")]
    public int? MDomainValues
    {
        get;
        set;
    }

    [JsonProperty("m_InvokeBindings")]
    [JsonPropertyName("m_InvokeBindings")]
    public int? MInvokeBindings
    {
        get;
        set;
    }

    [JsonProperty("m_OutputConnections")]
    [JsonPropertyName("m_OutputConnections")]
    public int? MOutputConnections
    {
        get;
        set;
    }

    [JsonProperty("m_ParentMapName")]
    [JsonPropertyName("m_ParentMapName")]
    public int? MParentMapName
    {
        get;
        set;
    }

    [JsonProperty("m_ParentXmlName")]
    [JsonPropertyName("m_ParentXmlName")]
    public int? MParentXmlName
    {
        get;
        set;
    }

    [JsonProperty("m_PublicOutputs")]
    [JsonPropertyName("m_PublicOutputs")]
    public int? MPublicOutputs
    {
        get;
        set;
    }

    [JsonProperty("m_Vars")]
    [JsonPropertyName("m_Vars")]
    public int? MVars
    {
        get;
        set;
    }

    [JsonProperty("m_BlackboardResource")]
    [JsonPropertyName("m_BlackboardResource")]
    public int? MBlackboardResource
    {
        get;
        set;
    }

    [JsonProperty("m_NodeName")]
    [JsonPropertyName("m_NodeName")]
    public int? MNodeName
    {
        get;
        set;
    }

    [JsonProperty("m_hBlackboardResource")]
    [JsonPropertyName("m_hBlackboardResource")]
    public int? MHBlackboardResource
    {
        get;
        set;
    }

    [JsonProperty("m_nNodeID")]
    [JsonPropertyName("m_nNodeID")]
    public int? MNNodeID
    {
        get;
        set;
    }

    [JsonProperty("m_CallMethodID")]
    [JsonPropertyName("m_CallMethodID")]
    public int? MCallMethodID
    {
        get;
        set;
    }

    [JsonProperty("m_PortName")]
    [JsonPropertyName("m_PortName")]
    public int? MPortName
    {
        get;
        set;
    }

    [JsonProperty("m_nSrcChunk")]
    [JsonPropertyName("m_nSrcChunk")]
    public int? MNSrcChunk
    {
        get;
        set;
    }

    [JsonProperty("m_nSrcInstruction")]
    [JsonPropertyName("m_nSrcInstruction")]
    public int? MNSrcInstruction
    {
        get;
        set;
    }

    [JsonProperty("m_FuncName")]
    [JsonPropertyName("m_FuncName")]
    public int? MFuncName
    {
        get;
        set;
    }

    [JsonProperty("m_nCellIndex")]
    [JsonPropertyName("m_nCellIndex")]
    public int? MNCellIndex
    {
        get;
        set;
    }

    [JsonProperty("m_OutflowRegisterMap")]
    [JsonPropertyName("m_OutflowRegisterMap")]
    public int? MOutflowRegisterMap
    {
        get;
        set;
    }

    [JsonProperty("m_SourceOutflowName")]
    [JsonPropertyName("m_SourceOutflowName")]
    public int? MSourceOutflowName
    {
        get;
        set;
    }

    [JsonProperty("m_nDestChunk")]
    [JsonPropertyName("m_nDestChunk")]
    public int? MNDestChunk
    {
        get;
        set;
    }

    [JsonProperty("m_nInstruction")]
    [JsonPropertyName("m_nInstruction")]
    public int? MNInstruction
    {
        get;
        set;
    }

    [JsonProperty("m_iCurrentMaxRagdollCount")]
    [JsonPropertyName("m_iCurrentMaxRagdollCount")]
    public int? MICurrentMaxRagdollCount
    {
        get;
        set;
    }

    [JsonProperty("m_sceneNode")]
    [JsonPropertyName("m_sceneNode")]
    public int? MSceneNode
    {
        get;
        set;
    }

    [JsonProperty("m_bEnableRendering")]
    [JsonPropertyName("m_bEnableRendering")]
    public int? MBEnableRendering
    {
        get;
        set;
    }

    [JsonProperty("m_bInterpolationReadyToDraw")]
    [JsonPropertyName("m_bInterpolationReadyToDraw")]
    public int? MBInterpolationReadyToDraw
    {
        get;
        set;
    }

    [JsonProperty("m_bIsRenderingWithViewModels")]
    [JsonPropertyName("m_bIsRenderingWithViewModels")]
    public int? MBIsRenderingWithViewModels
    {
        get;
        set;
    }

    [JsonProperty("m_nSplitscreenFlags")]
    [JsonPropertyName("m_nSplitscreenFlags")]
    public int? MNSplitscreenFlags
    {
        get;
        set;
    }

    [JsonProperty("m_iEnemy3Ks")]
    [JsonPropertyName("m_iEnemy3Ks")]
    public int? MIEnemy3Ks
    {
        get;
        set;
    }

    [JsonProperty("m_iEnemy4Ks")]
    [JsonPropertyName("m_iEnemy4Ks")]
    public int? MIEnemy4Ks
    {
        get;
        set;
    }

    [JsonProperty("m_iEnemy5Ks")]
    [JsonPropertyName("m_iEnemy5Ks")]
    public int? MIEnemy5Ks
    {
        get;
        set;
    }

    [JsonProperty("m_iEnemyKnifeKills")]
    [JsonPropertyName("m_iEnemyKnifeKills")]
    public int? MIEnemyKnifeKills
    {
        get;
        set;
    }

    [JsonProperty("m_iEnemyTaserKills")]
    [JsonPropertyName("m_iEnemyTaserKills")]
    public int? MIEnemyTaserKills
    {
        get;
        set;
    }

    [JsonProperty("m_iAssists")]
    [JsonPropertyName("m_iAssists")]
    public int? MIAssists
    {
        get;
        set;
    }

    [JsonProperty("m_iCashEarned")]
    [JsonPropertyName("m_iCashEarned")]
    public int? MICashEarned
    {
        get;
        set;
    }

    [JsonProperty("m_iDamage")]
    [JsonPropertyName("m_iDamage")]
    public int? MIDamage
    {
        get;
        set;
    }

    [JsonProperty("m_iDeaths")]
    [JsonPropertyName("m_iDeaths")]
    public int? MIDeaths
    {
        get;
        set;
    }

    [JsonProperty("m_iEnemiesFlashed")]
    [JsonPropertyName("m_iEnemiesFlashed")]
    public int? MIEnemiesFlashed
    {
        get;
        set;
    }

    [JsonProperty("m_iEquipmentValue")]
    [JsonPropertyName("m_iEquipmentValue")]
    public int? MIEquipmentValue
    {
        get;
        set;
    }

    [JsonProperty("m_iHeadShotKills")]
    [JsonPropertyName("m_iHeadShotKills")]
    public int? MIHeadShotKills
    {
        get;
        set;
    }

    [JsonProperty("m_iKillReward")]
    [JsonPropertyName("m_iKillReward")]
    public int? MIKillReward
    {
        get;
        set;
    }

    [JsonProperty("m_iKills")]
    [JsonPropertyName("m_iKills")]
    public int? MIKills
    {
        get;
        set;
    }

    [JsonProperty("m_iLiveTime")]
    [JsonPropertyName("m_iLiveTime")]
    public int? MILiveTime
    {
        get;
        set;
    }

    [JsonProperty("m_iMoneySaved")]
    [JsonPropertyName("m_iMoneySaved")]
    public int? MIMoneySaved
    {
        get;
        set;
    }

    [JsonProperty("m_iObjective")]
    [JsonPropertyName("m_iObjective")]
    public int? MIObjective
    {
        get;
        set;
    }

    [JsonProperty("m_iUtilityDamage")]
    [JsonPropertyName("m_iUtilityDamage")]
    public int? MIUtilityDamage
    {
        get;
        set;
    }

    [JsonProperty("m_scriptClassName")]
    [JsonPropertyName("m_scriptClassName")]
    public int? MScriptClassName
    {
        get;
        set;
    }

    [JsonProperty("m_bDirtyMotionType")]
    [JsonPropertyName("m_bDirtyMotionType")]
    public int? MBDirtyMotionType
    {
        get;
        set;
    }

    [JsonProperty("m_bDisableSolidCollisionsForHierarchy")]
    [JsonPropertyName("m_bDisableSolidCollisionsForHierarchy")]
    public int? MBDisableSolidCollisionsForHierarchy
    {
        get;
        set;
    }

    [JsonProperty("m_bIsAnimationEnabled")]
    [JsonPropertyName("m_bIsAnimationEnabled")]
    public int? MBIsAnimationEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bIsGeneratingLatchedParentSpaceState")]
    [JsonPropertyName("m_bIsGeneratingLatchedParentSpaceState")]
    public int? MBIsGeneratingLatchedParentSpaceState
    {
        get;
        set;
    }

    [JsonProperty("m_bUseParentRenderBounds")]
    [JsonPropertyName("m_bUseParentRenderBounds")]
    public int? MBUseParentRenderBounds
    {
        get;
        set;
    }

    [JsonProperty("m_materialGroup")]
    [JsonPropertyName("m_materialGroup")]
    public int? MMaterialGroup
    {
        get;
        set;
    }

    [JsonProperty("m_modelState")]
    [JsonPropertyName("m_modelState")]
    public int? MModelState
    {
        get;
        set;
    }

    [JsonProperty("m_nHitboxSet")]
    [JsonPropertyName("m_nHitboxSet")]
    public int? MNHitboxSet
    {
        get;
        set;
    }

    [JsonProperty("m_hSkyCamera")]
    [JsonPropertyName("m_hSkyCamera")]
    public int? MHSkyCamera
    {
        get;
        set;
    }

    [JsonProperty("m_worldGroupId")]
    [JsonPropertyName("m_worldGroupId")]
    public int? MWorldGroupId
    {
        get;
        set;
    }

    [JsonProperty("m_bStopped")]
    [JsonPropertyName("m_bStopped")]
    public int? MBStopped
    {
        get;
        set;
    }

    [JsonProperty("m_flFinalValue")]
    [JsonPropertyName("m_flFinalValue")]
    public int? MFlFinalValue
    {
        get;
        set;
    }

    [JsonProperty("m_flInterval")]
    [JsonPropertyName("m_flInterval")]
    public int? MFlInterval
    {
        get;
        set;
    }

    [JsonProperty("m_flValues")]
    [JsonPropertyName("m_flValues")]
    public int? MFlValues
    {
        get;
        set;
    }

    [JsonProperty("m_nBucketCount")]
    [JsonPropertyName("m_nBucketCount")]
    public int? MNBucketCount
    {
        get;
        set;
    }

    [JsonProperty("m_nCompressionType")]
    [JsonPropertyName("m_nCompressionType")]
    public int? MNCompressionType
    {
        get;
        set;
    }

    [JsonProperty("m_nValueCounts")]
    [JsonPropertyName("m_nValueCounts")]
    public int? MNValueCounts
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetBoolVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetBoolVariables")]
    public int? MOwnerOnlyPredNetBoolVariables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetByteVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetByteVariables")]
    public int? MOwnerOnlyPredNetByteVariables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetFloatVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetFloatVariables")]
    public int? MOwnerOnlyPredNetFloatVariables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetGlobalSymbolVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetGlobalSymbolVariables")]
    public int? MOwnerOnlyPredNetGlobalSymbolVariables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetIntVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetIntVariables")]
    public int? MOwnerOnlyPredNetIntVariables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetQuaternionVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetQuaternionVariables")]
    public int? MOwnerOnlyPredNetQuaternionVariables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetUInt16Variables")]
    [JsonPropertyName("m_OwnerOnlyPredNetUInt16Variables")]
    public int? MOwnerOnlyPredNetUInt16Variables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetUInt32Variables")]
    [JsonPropertyName("m_OwnerOnlyPredNetUInt32Variables")]
    public int? MOwnerOnlyPredNetUInt32Variables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetUInt64Variables")]
    [JsonPropertyName("m_OwnerOnlyPredNetUInt64Variables")]
    public int? MOwnerOnlyPredNetUInt64Variables
    {
        get;
        set;
    }

    [JsonProperty("m_OwnerOnlyPredNetVectorVariables")]
    [JsonPropertyName("m_OwnerOnlyPredNetVectorVariables")]
    public int? MOwnerOnlyPredNetVectorVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetBoolVariables")]
    [JsonPropertyName("m_PredNetBoolVariables")]
    public int? MPredNetBoolVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetByteVariables")]
    [JsonPropertyName("m_PredNetByteVariables")]
    public int? MPredNetByteVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetFloatVariables")]
    [JsonPropertyName("m_PredNetFloatVariables")]
    public int? MPredNetFloatVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetGlobalSymbolVariables")]
    [JsonPropertyName("m_PredNetGlobalSymbolVariables")]
    public int? MPredNetGlobalSymbolVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetIntVariables")]
    [JsonPropertyName("m_PredNetIntVariables")]
    public int? MPredNetIntVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetQuaternionVariables")]
    [JsonPropertyName("m_PredNetQuaternionVariables")]
    public int? MPredNetQuaternionVariables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetUInt16Variables")]
    [JsonPropertyName("m_PredNetUInt16Variables")]
    public int? MPredNetUInt16Variables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetUInt32Variables")]
    [JsonPropertyName("m_PredNetUInt32Variables")]
    public int? MPredNetUInt32Variables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetUInt64Variables")]
    [JsonPropertyName("m_PredNetUInt64Variables")]
    public int? MPredNetUInt64Variables
    {
        get;
        set;
    }

    [JsonProperty("m_PredNetVectorVariables")]
    [JsonPropertyName("m_PredNetVectorVariables")]
    public int? MPredNetVectorVariables
    {
        get;
        set;
    }

    [JsonProperty("m_flLastTeleportTime")]
    [JsonPropertyName("m_flLastTeleportTime")]
    public int? MFlLastTeleportTime
    {
        get;
        set;
    }

    [JsonProperty("m_nBoolVariablesCount")]
    [JsonPropertyName("m_nBoolVariablesCount")]
    public int? MNBoolVariablesCount
    {
        get;
        set;
    }

    [JsonProperty("m_nOwnerOnlyBoolVariablesCount")]
    [JsonPropertyName("m_nOwnerOnlyBoolVariablesCount")]
    public int? MNOwnerOnlyBoolVariablesCount
    {
        get;
        set;
    }

    [JsonProperty("m_nRandomSeedOffset")]
    [JsonPropertyName("m_nRandomSeedOffset")]
    public int? MNRandomSeedOffset
    {
        get;
        set;
    }

    [JsonProperty("m_skeletonInstance")]
    [JsonPropertyName("m_skeletonInstance")]
    public int? MSkeletonInstance
    {
        get;
        set;
    }

    [JsonProperty("m_RampTimer")]
    [JsonPropertyName("m_RampTimer")]
    public int? MRampTimer
    {
        get;
        set;
    }

    [JsonProperty("m_bFalloff")]
    [JsonPropertyName("m_bFalloff")]
    public int? MBFalloff
    {
        get;
        set;
    }

    [JsonProperty("m_bPushAwayFromInfoTarget")]
    [JsonPropertyName("m_bPushAwayFromInfoTarget")]
    public int? MBPushAwayFromInfoTarget
    {
        get;
        set;
    }

    [JsonProperty("m_bPushTowardsInfoTarget")]
    [JsonPropertyName("m_bPushTowardsInfoTarget")]
    public int? MBPushTowardsInfoTarget
    {
        get;
        set;
    }

    [JsonProperty("m_flForce")]
    [JsonPropertyName("m_flForce")]
    public int? MFlForce
    {
        get;
        set;
    }

    [JsonProperty("m_hInfoFan")]
    [JsonPropertyName("m_hInfoFan")]
    public int? MHInfoFan
    {
        get;
        set;
    }

    [JsonProperty("m_qNoiseDelta")]
    [JsonPropertyName("m_qNoiseDelta")]
    public int? MQNoiseDelta
    {
        get;
        set;
    }

    [JsonProperty("m_vDirection")]
    [JsonPropertyName("m_vDirection")]
    public int? MVDirection
    {
        get;
        set;
    }

    [JsonProperty("m_vFanOriginOffset")]
    [JsonPropertyName("m_vFanOriginOffset")]
    public int? MVFanOriginOffset
    {
        get;
        set;
    }

    [JsonProperty("m_Item")]
    [JsonPropertyName("m_Item")]
    public int? MItem
    {
        get;
        set;
    }

    [JsonProperty("m_iExternalItemProviderRegisteredToken")]
    [JsonPropertyName("m_iExternalItemProviderRegisteredToken")]
    public int? MIExternalItemProviderRegisteredToken
    {
        get;
        set;
    }

    [JsonProperty("m_ullRegisteredAsItemID")]
    [JsonPropertyName("m_ullRegisteredAsItemID")]
    public int? MUllRegisteredAsItemID
    {
        get;
        set;
    }

    [JsonProperty("m_Color")]
    [JsonPropertyName("m_Color")]
    public int? MColor
    {
        get;
        set;
    }

    [JsonProperty("m_LightStyleEvents")]
    [JsonPropertyName("m_LightStyleEvents")]
    public int? MLightStyleEvents
    {
        get;
        set;
    }

    [JsonProperty("m_LightStyleString")]
    [JsonPropertyName("m_LightStyleString")]
    public int? MLightStyleString
    {
        get;
        set;
    }

    [JsonProperty("m_LightStyleTargets")]
    [JsonPropertyName("m_LightStyleTargets")]
    public int? MLightStyleTargets
    {
        get;
        set;
    }

    [JsonProperty("m_QueuedLightStyleStrings")]
    [JsonPropertyName("m_QueuedLightStyleStrings")]
    public int? MQueuedLightStyleStrings
    {
        get;
        set;
    }

    [JsonProperty("m_StyleEvent")]
    [JsonPropertyName("m_StyleEvent")]
    public int? MStyleEvent
    {
        get;
        set;
    }

    [JsonProperty("m_VisClusters")]
    [JsonPropertyName("m_VisClusters")]
    public int? MVisClusters
    {
        get;
        set;
    }

    [JsonProperty("m_bContactShadow")]
    [JsonPropertyName("m_bContactShadow")]
    public int? MBContactShadow
    {
        get;
        set;
    }

    [JsonProperty("m_bEnabled")]
    [JsonPropertyName("m_bEnabled")]
    public int? MBEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bFogMixedShadows")]
    [JsonPropertyName("m_bFogMixedShadows")]
    public int? MBFogMixedShadows
    {
        get;
        set;
    }

    [JsonProperty("m_bForceShadowsEnabled")]
    [JsonPropertyName("m_bForceShadowsEnabled")]
    public int? MBForceShadowsEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bInitialBoneSetup")]
    [JsonPropertyName("m_bInitialBoneSetup")]
    public int? MBInitialBoneSetup
    {
        get;
        set;
    }

    [JsonProperty("m_bPrecomputedFieldsValid")]
    [JsonPropertyName("m_bPrecomputedFieldsValid")]
    public int? MBPrecomputedFieldsValid
    {
        get;
        set;
    }

    [JsonProperty("m_fAlternateColorBrightness")]
    [JsonPropertyName("m_fAlternateColorBrightness")]
    public int? MFAlternateColorBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_flBounceScale")]
    [JsonPropertyName("m_flBounceScale")]
    public int? MFlBounceScale
    {
        get;
        set;
    }

    [JsonProperty("m_flBrightness")]
    [JsonPropertyName("m_flBrightness")]
    public int? MFlBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_flBrightnessScale")]
    [JsonPropertyName("m_flBrightnessScale")]
    public int? MFlBrightnessScale
    {
        get;
        set;
    }

    [JsonProperty("m_flColorTemperature")]
    [JsonPropertyName("m_flColorTemperature")]
    public int? MFlColorTemperature
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeSizeEnd")]
    [JsonPropertyName("m_flFadeSizeEnd")]
    public int? MFlFadeSizeEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeSizeStart")]
    [JsonPropertyName("m_flFadeSizeStart")]
    public int? MFlFadeSizeStart
    {
        get;
        set;
    }

    [JsonProperty("m_flFogScale")]
    [JsonPropertyName("m_flFogScale")]
    public int? MFlFogScale
    {
        get;
        set;
    }

    [JsonProperty("m_flFogStrength")]
    [JsonPropertyName("m_flFogStrength")]
    public int? MFlFogStrength
    {
        get;
        set;
    }

    [JsonProperty("m_flLightStyleStartTime")]
    [JsonPropertyName("m_flLightStyleStartTime")]
    public int? MFlLightStyleStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLuminaireAnisotropy")]
    [JsonPropertyName("m_flLuminaireAnisotropy")]
    public int? MFlLuminaireAnisotropy
    {
        get;
        set;
    }

    [JsonProperty("m_flLuminaireSize")]
    [JsonPropertyName("m_flLuminaireSize")]
    public int? MFlLuminaireSize
    {
        get;
        set;
    }

    [JsonProperty("m_flMinRoughness")]
    [JsonPropertyName("m_flMinRoughness")]
    public int? MFlMinRoughness
    {
        get;
        set;
    }

    [JsonProperty("m_flRange")]
    [JsonPropertyName("m_flRange")]
    public int? MFlRange
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowFadeSizeEnd")]
    [JsonPropertyName("m_flShadowFadeSizeEnd")]
    public int? MFlShadowFadeSizeEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowFadeSizeStart")]
    [JsonPropertyName("m_flShadowFadeSizeStart")]
    public int? MFlShadowFadeSizeStart
    {
        get;
        set;
    }

    [JsonProperty("m_flShape")]
    [JsonPropertyName("m_flShape")]
    public int? MFlShape
    {
        get;
        set;
    }

    [JsonProperty("m_flSkirt")]
    [JsonPropertyName("m_flSkirt")]
    public int? MFlSkirt
    {
        get;
        set;
    }

    [JsonProperty("m_flSkirtNear")]
    [JsonPropertyName("m_flSkirtNear")]
    public int? MFlSkirtNear
    {
        get;
        set;
    }

    [JsonProperty("m_flSoftX")]
    [JsonPropertyName("m_flSoftX")]
    public int? MFlSoftX
    {
        get;
        set;
    }

    [JsonProperty("m_flSoftY")]
    [JsonPropertyName("m_flSoftY")]
    public int? MFlSoftY
    {
        get;
        set;
    }

    [JsonProperty("m_hLightCookie")]
    [JsonPropertyName("m_hLightCookie")]
    public int? MHLightCookie
    {
        get;
        set;
    }

    [JsonProperty("m_nBakeSpecularToCubemaps")]
    [JsonPropertyName("m_nBakeSpecularToCubemaps")]
    public int? MNBakeSpecularToCubemaps
    {
        get;
        set;
    }

    [JsonProperty("m_nBakedShadowIndex")]
    [JsonPropertyName("m_nBakedShadowIndex")]
    public int? MNBakedShadowIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nBounceLight")]
    [JsonPropertyName("m_nBounceLight")]
    public int? MNBounceLight
    {
        get;
        set;
    }

    [JsonProperty("m_nCastShadows")]
    [JsonPropertyName("m_nCastShadows")]
    public int? MNCastShadows
    {
        get;
        set;
    }

    [JsonProperty("m_nColorMode")]
    [JsonPropertyName("m_nColorMode")]
    public int? MNColorMode
    {
        get;
        set;
    }

    [JsonProperty("m_nDirectLight")]
    [JsonPropertyName("m_nDirectLight")]
    public int? MNDirectLight
    {
        get;
        set;
    }

    [JsonProperty("m_nFog")]
    [JsonPropertyName("m_nFog")]
    public int? MNFog
    {
        get;
        set;
    }

    [JsonProperty("m_nFogShadows")]
    [JsonPropertyName("m_nFogShadows")]
    public int? MNFogShadows
    {
        get;
        set;
    }

    [JsonProperty("m_nLightMapUniqueId")]
    [JsonPropertyName("m_nLightMapUniqueId")]
    public int? MNLightMapUniqueId
    {
        get;
        set;
    }

    [JsonProperty("m_nLightPathUniqueId")]
    [JsonPropertyName("m_nLightPathUniqueId")]
    public int? MNLightPathUniqueId
    {
        get;
        set;
    }

    [JsonProperty("m_nLuminaireShape")]
    [JsonPropertyName("m_nLuminaireShape")]
    public int? MNLuminaireShape
    {
        get;
        set;
    }

    [JsonProperty("m_nPrecomputedSubFrusta")]
    [JsonPropertyName("m_nPrecomputedSubFrusta")]
    public int? MNPrecomputedSubFrusta
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowMapSize")]
    [JsonPropertyName("m_nShadowMapSize")]
    public int? MNShadowMapSize
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowPriority")]
    [JsonPropertyName("m_nShadowPriority")]
    public int? MNShadowPriority
    {
        get;
        set;
    }

    [JsonProperty("m_vAlternateColor")]
    [JsonPropertyName("m_vAlternateColor")]
    public int? MVAlternateColor
    {
        get;
        set;
    }

    [JsonProperty("m_vBakeSpecularToCubemapsSize")]
    [JsonPropertyName("m_vBakeSpecularToCubemapsSize")]
    public int? MVBakeSpecularToCubemapsSize
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedBoundsMaxs")]
    [JsonPropertyName("m_vPrecomputedBoundsMaxs")]
    public int? MVPrecomputedBoundsMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedBoundsMins")]
    [JsonPropertyName("m_vPrecomputedBoundsMins")]
    public int? MVPrecomputedBoundsMins
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles")]
    [JsonPropertyName("m_vPrecomputedOBBAngles")]
    public int? MVPrecomputedOBBAngles
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles0")]
    [JsonPropertyName("m_vPrecomputedOBBAngles0")]
    public int? MVPrecomputedOBBAngles0
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles1")]
    [JsonPropertyName("m_vPrecomputedOBBAngles1")]
    public int? MVPrecomputedOBBAngles1
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles2")]
    [JsonPropertyName("m_vPrecomputedOBBAngles2")]
    public int? MVPrecomputedOBBAngles2
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles3")]
    [JsonPropertyName("m_vPrecomputedOBBAngles3")]
    public int? MVPrecomputedOBBAngles3
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles4")]
    [JsonPropertyName("m_vPrecomputedOBBAngles4")]
    public int? MVPrecomputedOBBAngles4
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBAngles5")]
    [JsonPropertyName("m_vPrecomputedOBBAngles5")]
    public int? MVPrecomputedOBBAngles5
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent")]
    [JsonPropertyName("m_vPrecomputedOBBExtent")]
    public int? MVPrecomputedOBBExtent
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent0")]
    [JsonPropertyName("m_vPrecomputedOBBExtent0")]
    public int? MVPrecomputedOBBExtent0
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent1")]
    [JsonPropertyName("m_vPrecomputedOBBExtent1")]
    public int? MVPrecomputedOBBExtent1
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent2")]
    [JsonPropertyName("m_vPrecomputedOBBExtent2")]
    public int? MVPrecomputedOBBExtent2
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent3")]
    [JsonPropertyName("m_vPrecomputedOBBExtent3")]
    public int? MVPrecomputedOBBExtent3
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent4")]
    [JsonPropertyName("m_vPrecomputedOBBExtent4")]
    public int? MVPrecomputedOBBExtent4
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBExtent5")]
    [JsonPropertyName("m_vPrecomputedOBBExtent5")]
    public int? MVPrecomputedOBBExtent5
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin")]
    public int? MVPrecomputedOBBOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin0")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin0")]
    public int? MVPrecomputedOBBOrigin0
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin1")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin1")]
    public int? MVPrecomputedOBBOrigin1
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin2")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin2")]
    public int? MVPrecomputedOBBOrigin2
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin3")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin3")]
    public int? MVPrecomputedOBBOrigin3
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin4")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin4")]
    public int? MVPrecomputedOBBOrigin4
    {
        get;
        set;
    }

    [JsonProperty("m_vPrecomputedOBBOrigin5")]
    [JsonPropertyName("m_vPrecomputedOBBOrigin5")]
    public int? MVPrecomputedOBBOrigin5
    {
        get;
        set;
    }

    [JsonProperty("m_vShear")]
    [JsonPropertyName("m_vShear")]
    public int? MVShear
    {
        get;
        set;
    }

    [JsonProperty("m_vSizeParams")]
    [JsonPropertyName("m_vSizeParams")]
    public int? MVSizeParams
    {
        get;
        set;
    }

    [JsonProperty("m_glowEntity")]
    [JsonPropertyName("m_glowEntity")]
    public int? MGlowEntity
    {
        get;
        set;
    }

    [JsonProperty("m_szDisplayText")]
    [JsonPropertyName("m_szDisplayText")]
    public int? MSzDisplayText
    {
        get;
        set;
    }

    [JsonProperty("m_usable")]
    [JsonPropertyName("m_usable")]
    public int? MUsable
    {
        get;
        set;
    }

    [JsonProperty("m_bClientPredictDelete")]
    [JsonPropertyName("m_bClientPredictDelete")]
    public int? MBClientPredictDelete
    {
        get;
        set;
    }

    [JsonProperty("m_bIsHeldByPlayer")]
    [JsonPropertyName("m_bIsHeldByPlayer")]
    public int? MBIsHeldByPlayer
    {
        get;
        set;
    }

    [JsonProperty("m_bJumpThrow")]
    [JsonPropertyName("m_bJumpThrow")]
    public int? MBJumpThrow
    {
        get;
        set;
    }

    [JsonProperty("m_bJustPulledPin")]
    [JsonPropertyName("m_bJustPulledPin")]
    public int? MBJustPulledPin
    {
        get;
        set;
    }

    [JsonProperty("m_bPinPulled")]
    [JsonPropertyName("m_bPinPulled")]
    public int? MBPinPulled
    {
        get;
        set;
    }

    [JsonProperty("m_bRedraw")]
    [JsonPropertyName("m_bRedraw")]
    public int? MBRedraw
    {
        get;
        set;
    }

    [JsonProperty("m_bThrowAnimating")]
    [JsonPropertyName("m_bThrowAnimating")]
    public int? MBThrowAnimating
    {
        get;
        set;
    }

    [JsonProperty("m_fDropTime")]
    [JsonPropertyName("m_fDropTime")]
    public int? MFDropTime
    {
        get;
        set;
    }

    [JsonProperty("m_fPinPullTime")]
    [JsonPropertyName("m_fPinPullTime")]
    public int? MFPinPullTime
    {
        get;
        set;
    }

    [JsonProperty("m_fThrowTime")]
    [JsonPropertyName("m_fThrowTime")]
    public int? MFThrowTime
    {
        get;
        set;
    }

    [JsonProperty("m_flNextHoldFrac")]
    [JsonPropertyName("m_flNextHoldFrac")]
    public int? MFlNextHoldFrac
    {
        get;
        set;
    }

    [JsonProperty("m_flThrowStrength")]
    [JsonPropertyName("m_flThrowStrength")]
    public int? MFlThrowStrength
    {
        get;
        set;
    }

    [JsonProperty("m_hSwitchToWeaponAfterThrow")]
    [JsonPropertyName("m_hSwitchToWeaponAfterThrow")]
    public int? MHSwitchToWeaponAfterThrow
    {
        get;
        set;
    }

    [JsonProperty("m_nNextHoldTick")]
    [JsonPropertyName("m_nNextHoldTick")]
    public int? MNNextHoldTick
    {
        get;
        set;
    }

    [JsonProperty("flNextTrailLineTime")]
    [JsonPropertyName("flNextTrailLineTime")]
    public int? FlNextTrailLineTime
    {
        get;
        set;
    }

    [JsonProperty("m_arrTrajectoryTrailPointCreationTimes")]
    [JsonPropertyName("m_arrTrajectoryTrailPointCreationTimes")]
    public int? MArrTrajectoryTrailPointCreationTimes
    {
        get;
        set;
    }

    [JsonProperty("m_arrTrajectoryTrailPoints")]
    [JsonPropertyName("m_arrTrajectoryTrailPoints")]
    public int? MArrTrajectoryTrailPoints
    {
        get;
        set;
    }

    [JsonProperty("m_bCanCreateGrenadeTrail")]
    [JsonPropertyName("m_bCanCreateGrenadeTrail")]
    public int? MBCanCreateGrenadeTrail
    {
        get;
        set;
    }

    [JsonProperty("m_bExplodeEffectBegan")]
    [JsonPropertyName("m_bExplodeEffectBegan")]
    public int? MBExplodeEffectBegan
    {
        get;
        set;
    }

    [JsonProperty("m_flSpawnTime")]
    [JsonPropertyName("m_flSpawnTime")]
    public int? MFlSpawnTime
    {
        get;
        set;
    }

    [JsonProperty("m_flTrajectoryTrailEffectCreationTime")]
    [JsonPropertyName("m_flTrajectoryTrailEffectCreationTime")]
    public int? MFlTrajectoryTrailEffectCreationTime
    {
        get;
        set;
    }

    [JsonProperty("m_hSnapshotTrajectoryParticleSnapshot")]
    [JsonPropertyName("m_hSnapshotTrajectoryParticleSnapshot")]
    public int? MHSnapshotTrajectoryParticleSnapshot
    {
        get;
        set;
    }

    [JsonProperty("m_nBounces")]
    [JsonPropertyName("m_nBounces")]
    public int? MNBounces
    {
        get;
        set;
    }

    [JsonProperty("m_nExplodeEffectIndex")]
    [JsonPropertyName("m_nExplodeEffectIndex")]
    public int? MNExplodeEffectIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nExplodeEffectTickBegin")]
    [JsonPropertyName("m_nExplodeEffectTickBegin")]
    public int? MNExplodeEffectTickBegin
    {
        get;
        set;
    }

    [JsonProperty("m_nSnapshotTrajectoryEffectIndex")]
    [JsonPropertyName("m_nSnapshotTrajectoryEffectIndex")]
    public int? MNSnapshotTrajectoryEffectIndex
    {
        get;
        set;
    }

    [JsonProperty("m_vInitialPosition")]
    [JsonPropertyName("m_vInitialPosition")]
    public int? MVInitialPosition
    {
        get;
        set;
    }

    [JsonProperty("m_vInitialVelocity")]
    [JsonPropertyName("m_vInitialVelocity")]
    public int? MVInitialVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecExplodeEffectOrigin")]
    [JsonPropertyName("m_vecExplodeEffectOrigin")]
    public int? MVecExplodeEffectOrigin
    {
        get;
        set;
    }

    [JsonProperty("vecLastTrailLinePos")]
    [JsonPropertyName("vecLastTrailLinePos")]
    public int? VecLastTrailLinePos
    {
        get;
        set;
    }

    [JsonProperty("m_DialogXMLName")]
    [JsonPropertyName("m_DialogXMLName")]
    public int? MDialogXMLName
    {
        get;
        set;
    }

    [JsonProperty("m_PanelClassName")]
    [JsonPropertyName("m_PanelClassName")]
    public int? MPanelClassName
    {
        get;
        set;
    }

    [JsonProperty("m_PanelID")]
    [JsonPropertyName("m_PanelID")]
    public int? MPanelID
    {
        get;
        set;
    }

    [JsonProperty("m_flWaterNextTraceTime")]
    [JsonPropertyName("m_flWaterNextTraceTime")]
    public int? MFlWaterNextTraceTime
    {
        get;
        set;
    }

    [JsonProperty("m_flWaterWorldZ")]
    [JsonPropertyName("m_flWaterWorldZ")]
    public int? MFlWaterWorldZ
    {
        get;
        set;
    }

    [JsonProperty("m_hMyWearables")]
    [JsonPropertyName("m_hMyWearables")]
    public int? MHMyWearables
    {
        get;
        set;
    }

    [JsonProperty("m_leftFootAttachment")]
    [JsonPropertyName("m_leftFootAttachment")]
    public int? MLeftFootAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_nWaterWakeMode")]
    [JsonPropertyName("m_nWaterWakeMode")]
    public int? MNWaterWakeMode
    {
        get;
        set;
    }

    [JsonProperty("m_rightFootAttachment")]
    [JsonPropertyName("m_rightFootAttachment")]
    public int? MRightFootAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_bBombPlantedHere")]
    [JsonPropertyName("m_bBombPlantedHere")]
    public int? MBBombPlantedHere
    {
        get;
        set;
    }

    [JsonProperty("m_bIsUsable")]
    [JsonPropertyName("m_bIsUsable")]
    public int? MBIsUsable
    {
        get;
        set;
    }

    [JsonProperty("m_CBodyComponent")]
    [JsonPropertyName("m_CBodyComponent")]
    public int? MCBodyComponent
    {
        get;
        set;
    }

    [JsonProperty("m_DataChangeEventRef")]
    [JsonPropertyName("m_DataChangeEventRef")]
    public int? MDataChangeEventRef
    {
        get;
        set;
    }

    [JsonProperty("m_EntClientFlags")]
    [JsonPropertyName("m_EntClientFlags")]
    public int? MEntClientFlags
    {
        get;
        set;
    }

    [JsonProperty("m_ListEntry")]
    [JsonPropertyName("m_ListEntry")]
    public int? MListEntry
    {
        get;
        set;
    }

    [JsonProperty("m_MoveCollide")]
    [JsonPropertyName("m_MoveCollide")]
    public int? MMoveCollide
    {
        get;
        set;
    }

    [JsonProperty("m_MoveType")]
    [JsonPropertyName("m_MoveType")]
    public int? MMoveType
    {
        get;
        set;
    }

    [JsonProperty("m_NetworkTransmitComponent")]
    [JsonPropertyName("m_NetworkTransmitComponent")]
    public int? MNetworkTransmitComponent
    {
        get;
        set;
    }

    [JsonProperty("m_Particles")]
    [JsonPropertyName("m_Particles")]
    public int? MParticles
    {
        get;
        set;
    }

    [JsonProperty("m_aThinkFunctions")]
    [JsonPropertyName("m_aThinkFunctions")]
    public int? MAThinkFunctions
    {
        get;
        set;
    }

    [JsonProperty("m_bAnimTimeChanged")]
    [JsonPropertyName("m_bAnimTimeChanged")]
    public int? MBAnimTimeChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bAnimatedEveryTick")]
    [JsonPropertyName("m_bAnimatedEveryTick")]
    public int? MBAnimatedEveryTick
    {
        get;
        set;
    }

    [JsonProperty("m_bApplyLayerMatchIDToModel")]
    [JsonPropertyName("m_bApplyLayerMatchIDToModel")]
    public int? MBApplyLayerMatchIDToModel
    {
        get;
        set;
    }

    [JsonProperty("m_bClientSideRagdoll")]
    [JsonPropertyName("m_bClientSideRagdoll")]
    public int? MBClientSideRagdoll
    {
        get;
        set;
    }

    [JsonProperty("m_bDisabledContextThinks")]
    [JsonPropertyName("m_bDisabledContextThinks")]
    public int? MBDisabledContextThinks
    {
        get;
        set;
    }

    [JsonProperty("m_bGravityActuallyDisabled")]
    [JsonPropertyName("m_bGravityActuallyDisabled")]
    public int? MBGravityActuallyDisabled
    {
        get;
        set;
    }

    [JsonProperty("m_bGravityDisabled")]
    [JsonPropertyName("m_bGravityDisabled")]
    public int? MBGravityDisabled
    {
        get;
        set;
    }

    [JsonProperty("m_bHasAddedVarsToInterpolation")]
    [JsonPropertyName("m_bHasAddedVarsToInterpolation")]
    public int? MBHasAddedVarsToInterpolation
    {
        get;
        set;
    }

    [JsonProperty("m_bHasSuccessfullyInterpolated")]
    [JsonPropertyName("m_bHasSuccessfullyInterpolated")]
    public int? MBHasSuccessfullyInterpolated
    {
        get;
        set;
    }

    [JsonProperty("m_bInterpolateEvenWithNoModel")]
    [JsonPropertyName("m_bInterpolateEvenWithNoModel")]
    public int? MBInterpolateEvenWithNoModel
    {
        get;
        set;
    }

    [JsonProperty("m_bPredictable")]
    [JsonPropertyName("m_bPredictable")]
    public int? MBPredictable
    {
        get;
        set;
    }

    [JsonProperty("m_bPredictionEligible")]
    [JsonPropertyName("m_bPredictionEligible")]
    public int? MBPredictionEligible
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderEvenWhenNotSuccessfullyInterpolated")]
    [JsonPropertyName("m_bRenderEvenWhenNotSuccessfullyInterpolated")]
    public int? MBRenderEvenWhenNotSuccessfullyInterpolated
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderWithViewModels")]
    [JsonPropertyName("m_bRenderWithViewModels")]
    public int? MBRenderWithViewModels
    {
        get;
        set;
    }

    [JsonProperty("m_bSimulationTimeChanged")]
    [JsonPropertyName("m_bSimulationTimeChanged")]
    public int? MBSimulationTimeChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bTakesDamage")]
    [JsonPropertyName("m_bTakesDamage")]
    public int? MBTakesDamage
    {
        get;
        set;
    }

    [JsonProperty("m_dependencies")]
    [JsonPropertyName("m_dependencies")]
    public int? MDependencies
    {
        get;
        set;
    }

    [JsonProperty("m_fBBoxVisFlags")]
    [JsonPropertyName("m_fBBoxVisFlags")]
    public int? MFBBoxVisFlags
    {
        get;
        set;
    }

    [JsonProperty("m_fEffects")]
    [JsonPropertyName("m_fEffects")]
    public int? MFEffects
    {
        get;
        set;
    }

    [JsonProperty("m_fFlags")]
    [JsonPropertyName("m_fFlags")]
    public int? MFFlags
    {
        get;
        set;
    }

    [JsonProperty("m_flActualGravityScale")]
    [JsonPropertyName("m_flActualGravityScale")]
    public int? MFlActualGravityScale
    {
        get;
        set;
    }

    [JsonProperty("m_flAnimTime")]
    [JsonPropertyName("m_flAnimTime")]
    public int? MFlAnimTime
    {
        get;
        set;
    }

    [JsonProperty("m_flCreateTime")]
    [JsonPropertyName("m_flCreateTime")]
    public int? MFlCreateTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDamageAccumulator")]
    [JsonPropertyName("m_flDamageAccumulator")]
    public int? MFlDamageAccumulator
    {
        get;
        set;
    }

    [JsonProperty("m_flElasticity")]
    [JsonPropertyName("m_flElasticity")]
    public int? MFlElasticity
    {
        get;
        set;
    }

    [JsonProperty("m_flFriction")]
    [JsonPropertyName("m_flFriction")]
    public int? MFlFriction
    {
        get;
        set;
    }

    [JsonProperty("m_flGravityScale")]
    [JsonPropertyName("m_flGravityScale")]
    public int? MFlGravityScale
    {
        get;
        set;
    }

    [JsonProperty("m_flNavIgnoreUntilTime")]
    [JsonPropertyName("m_flNavIgnoreUntilTime")]
    public int? MFlNavIgnoreUntilTime
    {
        get;
        set;
    }

    [JsonProperty("m_flProxyRandomValue")]
    [JsonPropertyName("m_flProxyRandomValue")]
    public int? MFlProxyRandomValue
    {
        get;
        set;
    }

    [JsonProperty("m_flSimulationTime")]
    [JsonPropertyName("m_flSimulationTime")]
    public int? MFlSimulationTime
    {
        get;
        set;
    }

    [JsonProperty("m_flSpeed")]
    [JsonPropertyName("m_flSpeed")]
    public int? MFlSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeScale")]
    [JsonPropertyName("m_flTimeScale")]
    public int? MFlTimeScale
    {
        get;
        set;
    }

    [JsonProperty("m_flWaterLevel")]
    [JsonPropertyName("m_flWaterLevel")]
    public int? MFlWaterLevel
    {
        get;
        set;
    }

    [JsonProperty("m_hEffectEntity")]
    [JsonPropertyName("m_hEffectEntity")]
    public int? MHEffectEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hGroundEntity")]
    [JsonPropertyName("m_hGroundEntity")]
    public int? MHGroundEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hOldMoveParent")]
    [JsonPropertyName("m_hOldMoveParent")]
    public int? MHOldMoveParent
    {
        get;
        set;
    }

    [JsonProperty("m_hOwnerEntity")]
    [JsonPropertyName("m_hOwnerEntity")]
    public int? MHOwnerEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hSceneObjectController")]
    [JsonPropertyName("m_hSceneObjectController")]
    public int? MHSceneObjectController
    {
        get;
        set;
    }

    [JsonProperty("m_hThink")]
    [JsonPropertyName("m_hThink")]
    public int? MHThink
    {
        get;
        set;
    }

    [JsonProperty("m_iCurrentThinkContext")]
    [JsonPropertyName("m_iCurrentThinkContext")]
    public int? MICurrentThinkContext
    {
        get;
        set;
    }

    [JsonProperty("m_iEFlags")]
    [JsonPropertyName("m_iEFlags")]
    public int? MIEFlags
    {
        get;
        set;
    }

    [JsonProperty("m_iHealth")]
    [JsonPropertyName("m_iHealth")]
    public int? MIHealth
    {
        get;
        set;
    }

    [JsonProperty("m_iMaxHealth")]
    [JsonPropertyName("m_iMaxHealth")]
    public int? MIMaxHealth
    {
        get;
        set;
    }

    [JsonProperty("m_iTeamNum")]
    [JsonPropertyName("m_iTeamNum")]
    public int? MITeamNum
    {
        get;
        set;
    }

    [JsonProperty("m_lifeState")]
    [JsonPropertyName("m_lifeState")]
    public int? MLifeState
    {
        get;
        set;
    }

    [JsonProperty("m_nActualMoveType")]
    [JsonPropertyName("m_nActualMoveType")]
    public int? MNActualMoveType
    {
        get;
        set;
    }

    [JsonProperty("m_nBloodType")]
    [JsonPropertyName("m_nBloodType")]
    public int? MNBloodType
    {
        get;
        set;
    }

    [JsonProperty("m_nCreationTick")]
    [JsonPropertyName("m_nCreationTick")]
    public int? MNCreationTick
    {
        get;
        set;
    }

    [JsonProperty("m_nFirstPredictableCommand")]
    [JsonPropertyName("m_nFirstPredictableCommand")]
    public int? MNFirstPredictableCommand
    {
        get;
        set;
    }

    [JsonProperty("m_nGroundBodyIndex")]
    [JsonPropertyName("m_nGroundBodyIndex")]
    public int? MNGroundBodyIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nInterpolationLatchDirtyFlags")]
    [JsonPropertyName("m_nInterpolationLatchDirtyFlags")]
    public int? MNInterpolationLatchDirtyFlags
    {
        get;
        set;
    }

    [JsonProperty("m_nLastPredictableCommand")]
    [JsonPropertyName("m_nLastPredictableCommand")]
    public int? MNLastPredictableCommand
    {
        get;
        set;
    }

    [JsonProperty("m_nLastThinkTick")]
    [JsonPropertyName("m_nLastThinkTick")]
    public int? MNLastThinkTick
    {
        get;
        set;
    }

    [JsonProperty("m_nNextThinkTick")]
    [JsonPropertyName("m_nNextThinkTick")]
    public int? MNNextThinkTick
    {
        get;
        set;
    }

    [JsonProperty("m_nNoInterpolationTick")]
    [JsonPropertyName("m_nNoInterpolationTick")]
    public int? MNNoInterpolationTick
    {
        get;
        set;
    }

    [JsonProperty("m_nPlatformType")]
    [JsonPropertyName("m_nPlatformType")]
    public int? MNPlatformType
    {
        get;
        set;
    }

    [JsonProperty("m_nSceneObjectOverrideFlags")]
    [JsonPropertyName("m_nSceneObjectOverrideFlags")]
    public int? MNSceneObjectOverrideFlags
    {
        get;
        set;
    }

    [JsonProperty("m_nSimulationTick")]
    [JsonPropertyName("m_nSimulationTick")]
    public int? MNSimulationTick
    {
        get;
        set;
    }

    [JsonProperty("m_nSubclassID")]
    [JsonPropertyName("m_nSubclassID")]
    public int? MNSubclassID
    {
        get;
        set;
    }

    [JsonProperty("m_nTakeDamageFlags")]
    [JsonPropertyName("m_nTakeDamageFlags")]
    public int? MNTakeDamageFlags
    {
        get;
        set;
    }

    [JsonProperty("m_nVisibilityNoInterpolationTick")]
    [JsonPropertyName("m_nVisibilityNoInterpolationTick")]
    public int? MNVisibilityNoInterpolationTick
    {
        get;
        set;
    }

    [JsonProperty("m_nWaterType")]
    [JsonPropertyName("m_nWaterType")]
    public int? MNWaterType
    {
        get;
        set;
    }

    [JsonProperty("m_pCollision")]
    [JsonPropertyName("m_pCollision")]
    public int? MPCollision
    {
        get;
        set;
    }

    [JsonProperty("m_pGameSceneNode")]
    [JsonPropertyName("m_pGameSceneNode")]
    public int? MPGameSceneNode
    {
        get;
        set;
    }

    [JsonProperty("m_pRenderComponent")]
    [JsonPropertyName("m_pRenderComponent")]
    public int? MPRenderComponent
    {
        get;
        set;
    }

    [JsonProperty("m_sUniqueHammerID")]
    [JsonPropertyName("m_sUniqueHammerID")]
    public int? MSUniqueHammerID
    {
        get;
        set;
    }

    [JsonProperty("m_spawnflags")]
    [JsonPropertyName("m_spawnflags")]
    public int? MSpawnflags
    {
        get;
        set;
    }

    [JsonProperty("m_tokLayerMatchID")]
    [JsonPropertyName("m_tokLayerMatchID")]
    public int? MTokLayerMatchID
    {
        get;
        set;
    }

    [JsonProperty("m_ubInterpolationFrame")]
    [JsonPropertyName("m_ubInterpolationFrame")]
    public int? MUbInterpolationFrame
    {
        get;
        set;
    }

    [JsonProperty("m_vecAbsVelocity")]
    [JsonPropertyName("m_vecAbsVelocity")]
    public int? MVecAbsVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecAngVelocity")]
    [JsonPropertyName("m_vecAngVelocity")]
    public int? MVecAngVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecBaseVelocity")]
    [JsonPropertyName("m_vecBaseVelocity")]
    public int? MVecBaseVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecServerVelocity")]
    [JsonPropertyName("m_vecServerVelocity")]
    public int? MVecServerVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecVelocity")]
    [JsonPropertyName("m_vecVelocity")]
    public int? MVecVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_CachedViewTarget")]
    [JsonPropertyName("m_CachedViewTarget")]
    public int? MCachedViewTarget
    {
        get;
        set;
    }

    [JsonProperty("m_PhonemeClasses")]
    [JsonPropertyName("m_PhonemeClasses")]
    public int? MPhonemeClasses
    {
        get;
        set;
    }

    [JsonProperty("m_bResetFlexWeightsOnModelChange")]
    [JsonPropertyName("m_bResetFlexWeightsOnModelChange")]
    public int? MBResetFlexWeightsOnModelChange
    {
        get;
        set;
    }

    [JsonProperty("m_blinktime")]
    [JsonPropertyName("m_blinktime")]
    public int? MBlinktime
    {
        get;
        set;
    }

    [JsonProperty("m_blinktoggle")]
    [JsonPropertyName("m_blinktoggle")]
    public int? MBlinktoggle
    {
        get;
        set;
    }

    [JsonProperty("m_flBlinkAmount")]
    [JsonPropertyName("m_flBlinkAmount")]
    public int? MFlBlinkAmount
    {
        get;
        set;
    }

    [JsonProperty("m_flJawOpenAmount")]
    [JsonPropertyName("m_flJawOpenAmount")]
    public int? MFlJawOpenAmount
    {
        get;
        set;
    }

    [JsonProperty("m_flexWeight")]
    [JsonPropertyName("m_flexWeight")]
    public int? MFlexWeight
    {
        get;
        set;
    }

    [JsonProperty("m_iBlink")]
    [JsonPropertyName("m_iBlink")]
    public int? MIBlink
    {
        get;
        set;
    }

    [JsonProperty("m_iEyeAttachment")]
    [JsonPropertyName("m_iEyeAttachment")]
    public int? MIEyeAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_iJawOpen")]
    [JsonPropertyName("m_iJawOpen")]
    public int? MIJawOpen
    {
        get;
        set;
    }

    [JsonProperty("m_iMouthAttachment")]
    [JsonPropertyName("m_iMouthAttachment")]
    public int? MIMouthAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_mEyeOcclusionRendererCameraToBoneTransform")]
    [JsonPropertyName("m_mEyeOcclusionRendererCameraToBoneTransform")]
    public int? MMEyeOcclusionRendererCameraToBoneTransform
    {
        get;
        set;
    }

    [JsonProperty("m_nEyeOcclusionRendererBone")]
    [JsonPropertyName("m_nEyeOcclusionRendererBone")]
    public int? MNEyeOcclusionRendererBone
    {
        get;
        set;
    }

    [JsonProperty("m_nLastFlexUpdateFrameCount")]
    [JsonPropertyName("m_nLastFlexUpdateFrameCount")]
    public int? MNLastFlexUpdateFrameCount
    {
        get;
        set;
    }

    [JsonProperty("m_nNextSceneEventId")]
    [JsonPropertyName("m_nNextSceneEventId")]
    public int? MNNextSceneEventId
    {
        get;
        set;
    }

    [JsonProperty("m_prevblinktoggle")]
    [JsonPropertyName("m_prevblinktoggle")]
    public int? MPrevblinktoggle
    {
        get;
        set;
    }

    [JsonProperty("m_vEyeOcclusionRendererHalfExtent")]
    [JsonPropertyName("m_vEyeOcclusionRendererHalfExtent")]
    public int? MVEyeOcclusionRendererHalfExtent
    {
        get;
        set;
    }

    [JsonProperty("m_vLookTargetPosition")]
    [JsonPropertyName("m_vLookTargetPosition")]
    public int? MVLookTargetPosition
    {
        get;
        set;
    }

    [JsonProperty("m_bBasechecked")]
    [JsonPropertyName("m_bBasechecked")]
    public int? MBBasechecked
    {
        get;
        set;
    }

    [JsonProperty("m_bRequired")]
    [JsonPropertyName("m_bRequired")]
    public int? MBRequired
    {
        get;
        set;
    }

    [JsonProperty("m_bValid")]
    [JsonPropertyName("m_bValid")]
    public int? MBValid
    {
        get;
        set;
    }

    [JsonProperty("m_flAmount")]
    [JsonPropertyName("m_flAmount")]
    public int? MFlAmount
    {
        get;
        set;
    }

    [JsonProperty("m_sClassName")]
    [JsonPropertyName("m_sClassName")]
    public int? MSClassName
    {
        get;
        set;
    }

    [JsonProperty("m_DmgRadius")]
    [JsonPropertyName("m_DmgRadius")]
    public int? MDmgRadius
    {
        get;
        set;
    }

    [JsonProperty("m_ExplosionSound")]
    [JsonPropertyName("m_ExplosionSound")]
    public int? MExplosionSound
    {
        get;
        set;
    }

    [JsonProperty("m_bHasWarnedAI")]
    [JsonPropertyName("m_bHasWarnedAI")]
    public int? MBHasWarnedAI
    {
        get;
        set;
    }

    [JsonProperty("m_bIsLive")]
    [JsonPropertyName("m_bIsLive")]
    public int? MBIsLive
    {
        get;
        set;
    }

    [JsonProperty("m_bIsSmokeGrenade")]
    [JsonPropertyName("m_bIsSmokeGrenade")]
    public int? MBIsSmokeGrenade
    {
        get;
        set;
    }

    [JsonProperty("m_flDamage")]
    [JsonPropertyName("m_flDamage")]
    public int? MFlDamage
    {
        get;
        set;
    }

    [JsonProperty("m_flDetonateTime")]
    [JsonPropertyName("m_flDetonateTime")]
    public int? MFlDetonateTime
    {
        get;
        set;
    }

    [JsonProperty("m_flNextAttack")]
    [JsonPropertyName("m_flNextAttack")]
    public int? MFlNextAttack
    {
        get;
        set;
    }

    [JsonProperty("m_flWarnAITime")]
    [JsonPropertyName("m_flWarnAITime")]
    public int? MFlWarnAITime
    {
        get;
        set;
    }

    [JsonProperty("m_hOriginalThrower")]
    [JsonPropertyName("m_hOriginalThrower")]
    public int? MHOriginalThrower
    {
        get;
        set;
    }

    [JsonProperty("m_hThrower")]
    [JsonPropertyName("m_hThrower")]
    public int? MHThrower
    {
        get;
        set;
    }

    [JsonProperty("m_iszBounceSound")]
    [JsonPropertyName("m_iszBounceSound")]
    public int? MIszBounceSound
    {
        get;
        set;
    }

    [JsonProperty("m_CHitboxComponent")]
    [JsonPropertyName("m_CHitboxComponent")]
    public int? MCHitboxComponent
    {
        get;
        set;
    }

    [JsonProperty("m_CRenderComponent")]
    [JsonPropertyName("m_CRenderComponent")]
    public int? MCRenderComponent
    {
        get;
        set;
    }

    [JsonProperty("m_ClientOverrideTint")]
    [JsonPropertyName("m_ClientOverrideTint")]
    public int? MClientOverrideTint
    {
        get;
        set;
    }

    [JsonProperty("m_Collision")]
    [JsonPropertyName("m_Collision")]
    public int? MCollision
    {
        get;
        set;
    }

    [JsonProperty("m_ConfigEntitiesToPropagateMaterialDecalsTo")]
    [JsonPropertyName("m_ConfigEntitiesToPropagateMaterialDecalsTo")]
    public int? MConfigEntitiesToPropagateMaterialDecalsTo
    {
        get;
        set;
    }

    [JsonProperty("m_Glow")]
    [JsonPropertyName("m_Glow")]
    public int? MGlow
    {
        get;
        set;
    }

    [JsonProperty("m_LastHitGroup")]
    [JsonPropertyName("m_LastHitGroup")]
    public int? MLastHitGroup
    {
        get;
        set;
    }

    [JsonProperty("m_bAllowFadeInView")]
    [JsonPropertyName("m_bAllowFadeInView")]
    public int? MBAllowFadeInView
    {
        get;
        set;
    }

    [JsonProperty("m_bInitModelEffects")]
    [JsonPropertyName("m_bInitModelEffects")]
    public int? MBInitModelEffects
    {
        get;
        set;
    }

    [JsonProperty("m_bIsStaticProp")]
    [JsonPropertyName("m_bIsStaticProp")]
    public int? MBIsStaticProp
    {
        get;
        set;
    }

    [JsonProperty("m_bNoInterpolate")]
    [JsonPropertyName("m_bNoInterpolate")]
    public int? MBNoInterpolate
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderToCubemaps")]
    [JsonPropertyName("m_bRenderToCubemaps")]
    public int? MBRenderToCubemaps
    {
        get;
        set;
    }

    [JsonProperty("m_bUseClientOverrideTint")]
    [JsonPropertyName("m_bUseClientOverrideTint")]
    public int? MBUseClientOverrideTint
    {
        get;
        set;
    }

    [JsonProperty("m_bvDisabledHitGroups")]
    [JsonPropertyName("m_bvDisabledHitGroups")]
    public int? MBvDisabledHitGroups
    {
        get;
        set;
    }

    [JsonProperty("m_clrRender")]
    [JsonPropertyName("m_clrRender")]
    public int? MClrRender
    {
        get;
        set;
    }

    [JsonProperty("m_fadeMaxDist")]
    [JsonPropertyName("m_fadeMaxDist")]
    public int? MFadeMaxDist
    {
        get;
        set;
    }

    [JsonProperty("m_fadeMinDist")]
    [JsonPropertyName("m_fadeMinDist")]
    public int? MFadeMinDist
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeScale")]
    [JsonPropertyName("m_flFadeScale")]
    public int? MFlFadeScale
    {
        get;
        set;
    }

    [JsonProperty("m_flGlowBackfaceMult")]
    [JsonPropertyName("m_flGlowBackfaceMult")]
    public int? MFlGlowBackfaceMult
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowStrength")]
    [JsonPropertyName("m_flShadowStrength")]
    public int? MFlShadowStrength
    {
        get;
        set;
    }

    [JsonProperty("m_iOldHealth")]
    [JsonPropertyName("m_iOldHealth")]
    public int? MIOldHealth
    {
        get;
        set;
    }

    [JsonProperty("m_nAddDecal")]
    [JsonPropertyName("m_nAddDecal")]
    public int? MNAddDecal
    {
        get;
        set;
    }

    [JsonProperty("m_nDecalMode")]
    [JsonPropertyName("m_nDecalMode")]
    public int? MNDecalMode
    {
        get;
        set;
    }

    [JsonProperty("m_nDecalsAdded")]
    [JsonPropertyName("m_nDecalsAdded")]
    public int? MNDecalsAdded
    {
        get;
        set;
    }

    [JsonProperty("m_nLastAddDecal")]
    [JsonPropertyName("m_nLastAddDecal")]
    public int? MNLastAddDecal
    {
        get;
        set;
    }

    [JsonProperty("m_nObjectCulling")]
    [JsonPropertyName("m_nObjectCulling")]
    public int? MNObjectCulling
    {
        get;
        set;
    }

    [JsonProperty("m_nRenderFX")]
    [JsonPropertyName("m_nRenderFX")]
    public int? MNRenderFX
    {
        get;
        set;
    }

    [JsonProperty("m_nRenderMode")]
    [JsonPropertyName("m_nRenderMode")]
    public int? MNRenderMode
    {
        get;
        set;
    }

    [JsonProperty("m_nRequiredDecalMode")]
    [JsonPropertyName("m_nRequiredDecalMode")]
    public int? MNRequiredDecalMode
    {
        get;
        set;
    }

    [JsonProperty("m_pClientAlphaProperty")]
    [JsonPropertyName("m_pClientAlphaProperty")]
    public int? MPClientAlphaProperty
    {
        get;
        set;
    }

    [JsonProperty("m_pDestructiblePartsSystemComponent")]
    [JsonPropertyName("m_pDestructiblePartsSystemComponent")]
    public int? MPDestructiblePartsSystemComponent
    {
        get;
        set;
    }

    [JsonProperty("m_sLastDamageSourceName")]
    [JsonPropertyName("m_sLastDamageSourceName")]
    public int? MSLastDamageSourceName
    {
        get;
        set;
    }

    [JsonProperty("m_vDecalForwardAxis")]
    [JsonPropertyName("m_vDecalForwardAxis")]
    public int? MVDecalForwardAxis
    {
        get;
        set;
    }

    [JsonProperty("m_vDecalPosition")]
    [JsonPropertyName("m_vDecalPosition")]
    public int? MVDecalPosition
    {
        get;
        set;
    }

    [JsonProperty("m_vLastDamagePosition")]
    [JsonPropertyName("m_vLastDamagePosition")]
    public int? MVLastDamagePosition
    {
        get;
        set;
    }

    [JsonProperty("m_vecRenderAttributes")]
    [JsonPropertyName("m_vecRenderAttributes")]
    public int? MVecRenderAttributes
    {
        get;
        set;
    }

    [JsonProperty("m_vecViewOffset")]
    [JsonPropertyName("m_vecViewOffset")]
    public int? MVecViewOffset
    {
        get;
        set;
    }

    [JsonProperty("m_ServerViewAngleChanges")]
    [JsonPropertyName("m_ServerViewAngleChanges")]
    public int? MServerViewAngleChanges
    {
        get;
        set;
    }

    [JsonProperty("m_bIsSwappingToPredictableController")]
    [JsonPropertyName("m_bIsSwappingToPredictableController")]
    public int? MBIsSwappingToPredictableController
    {
        get;
        set;
    }

    [JsonProperty("m_flDeathTime")]
    [JsonPropertyName("m_flDeathTime")]
    public int? MFlDeathTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFOVSensitivityAdjust")]
    [JsonPropertyName("m_flFOVSensitivityAdjust")]
    public int? MFlFOVSensitivityAdjust
    {
        get;
        set;
    }

    [JsonProperty("m_flLastCameraSetupTime")]
    [JsonPropertyName("m_flLastCameraSetupTime")]
    public int? MFlLastCameraSetupTime
    {
        get;
        set;
    }

    [JsonProperty("m_flMouseSensitivity")]
    [JsonPropertyName("m_flMouseSensitivity")]
    public int? MFlMouseSensitivity
    {
        get;
        set;
    }

    [JsonProperty("m_flOldSimulationTime")]
    [JsonPropertyName("m_flOldSimulationTime")]
    public int? MFlOldSimulationTime
    {
        get;
        set;
    }

    [JsonProperty("m_flPredictionErrorTime")]
    [JsonPropertyName("m_flPredictionErrorTime")]
    public int? MFlPredictionErrorTime
    {
        get;
        set;
    }

    [JsonProperty("m_hController")]
    [JsonPropertyName("m_hController")]
    public int? MHController
    {
        get;
        set;
    }

    [JsonProperty("m_hDefaultController")]
    [JsonPropertyName("m_hDefaultController")]
    public int? MHDefaultController
    {
        get;
        set;
    }

    [JsonProperty("m_iHideHUD")]
    [JsonPropertyName("m_iHideHUD")]
    public int? MIHideHUD
    {
        get;
        set;
    }

    [JsonProperty("m_nLastExecutedCommandNumber")]
    [JsonPropertyName("m_nLastExecutedCommandNumber")]
    public int? MNLastExecutedCommandNumber
    {
        get;
        set;
    }

    [JsonProperty("m_nLastExecutedCommandTick")]
    [JsonPropertyName("m_nLastExecutedCommandTick")]
    public int? MNLastExecutedCommandTick
    {
        get;
        set;
    }

    [JsonProperty("m_pAutoaimServices")]
    [JsonPropertyName("m_pAutoaimServices")]
    public int? MPAutoaimServices
    {
        get;
        set;
    }

    [JsonProperty("m_pCameraServices")]
    [JsonPropertyName("m_pCameraServices")]
    public int? MPCameraServices
    {
        get;
        set;
    }

    [JsonProperty("m_pFlashlightServices")]
    [JsonPropertyName("m_pFlashlightServices")]
    public int? MPFlashlightServices
    {
        get;
        set;
    }

    [JsonProperty("m_pItemServices")]
    [JsonPropertyName("m_pItemServices")]
    public int? MPItemServices
    {
        get;
        set;
    }

    [JsonProperty("m_pMovementServices")]
    [JsonPropertyName("m_pMovementServices")]
    public int? MPMovementServices
    {
        get;
        set;
    }

    [JsonProperty("m_pObserverServices")]
    [JsonPropertyName("m_pObserverServices")]
    public int? MPObserverServices
    {
        get;
        set;
    }

    [JsonProperty("m_pUseServices")]
    [JsonPropertyName("m_pUseServices")]
    public int? MPUseServices
    {
        get;
        set;
    }

    [JsonProperty("m_pWaterServices")]
    [JsonPropertyName("m_pWaterServices")]
    public int? MPWaterServices
    {
        get;
        set;
    }

    [JsonProperty("m_pWeaponServices")]
    [JsonPropertyName("m_pWeaponServices")]
    public int? MPWeaponServices
    {
        get;
        set;
    }

    [JsonProperty("m_skybox3d")]
    [JsonPropertyName("m_skybox3d")]
    public int? MSkybox3d
    {
        get;
        set;
    }

    [JsonProperty("m_vOldOrigin")]
    [JsonPropertyName("m_vOldOrigin")]
    public int? MVOldOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecLastCameraSetupLocalOrigin")]
    [JsonPropertyName("m_vecLastCameraSetupLocalOrigin")]
    public int? MVecLastCameraSetupLocalOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecPredictionError")]
    [JsonPropertyName("m_vecPredictionError")]
    public int? MVecPredictionError
    {
        get;
        set;
    }

    [JsonProperty("v_angle")]
    [JsonPropertyName("v_angle")]
    public int? VAngle
    {
        get;
        set;
    }

    [JsonProperty("v_anglePrevious")]
    [JsonPropertyName("v_anglePrevious")]
    public int? VAnglePrevious
    {
        get;
        set;
    }

    [JsonProperty("m_flNextPrimaryAttackTickRatio")]
    [JsonPropertyName("m_flNextPrimaryAttackTickRatio")]
    public int? MFlNextPrimaryAttackTickRatio
    {
        get;
        set;
    }

    [JsonProperty("m_flNextSecondaryAttackTickRatio")]
    [JsonPropertyName("m_flNextSecondaryAttackTickRatio")]
    public int? MFlNextSecondaryAttackTickRatio
    {
        get;
        set;
    }

    [JsonProperty("m_iClip1")]
    [JsonPropertyName("m_iClip1")]
    public int? MIClip1
    {
        get;
        set;
    }

    [JsonProperty("m_iClip2")]
    [JsonPropertyName("m_iClip2")]
    public int? MIClip2
    {
        get;
        set;
    }

    [JsonProperty("m_nNextPrimaryAttackTick")]
    [JsonPropertyName("m_nNextPrimaryAttackTick")]
    public int? MNNextPrimaryAttackTick
    {
        get;
        set;
    }

    [JsonProperty("m_nNextSecondaryAttackTick")]
    [JsonPropertyName("m_nNextSecondaryAttackTick")]
    public int? MNNextSecondaryAttackTick
    {
        get;
        set;
    }

    [JsonProperty("m_pReserveAmmo")]
    [JsonPropertyName("m_pReserveAmmo")]
    public int? MPReserveAmmo
    {
        get;
        set;
    }

    [JsonProperty("m_bLocked")]
    [JsonPropertyName("m_bLocked")]
    public int? MBLocked
    {
        get;
        set;
    }

    [JsonProperty("m_bNoNPCs")]
    [JsonPropertyName("m_bNoNPCs")]
    public int? MBNoNPCs
    {
        get;
        set;
    }

    [JsonProperty("m_closedAngles")]
    [JsonPropertyName("m_closedAngles")]
    public int? MClosedAngles
    {
        get;
        set;
    }

    [JsonProperty("m_closedPosition")]
    [JsonPropertyName("m_closedPosition")]
    public int? MClosedPosition
    {
        get;
        set;
    }

    [JsonProperty("m_eDoorState")]
    [JsonPropertyName("m_eDoorState")]
    public int? MEDoorState
    {
        get;
        set;
    }

    [JsonProperty("m_hMaster")]
    [JsonPropertyName("m_hMaster")]
    public int? MHMaster
    {
        get;
        set;
    }

    [JsonProperty("m_modelChanged")]
    [JsonPropertyName("m_modelChanged")]
    public int? MModelChanged
    {
        get;
        set;
    }

    [JsonProperty("m_vWhereToSetLightingOrigin")]
    [JsonPropertyName("m_vWhereToSetLightingOrigin")]
    public int? MVWhereToSetLightingOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_bNeutrallyBuoyant")]
    [JsonPropertyName("m_bNeutrallyBuoyant")]
    public int? MBNeutrallyBuoyant
    {
        get;
        set;
    }

    [JsonProperty("m_flFluidDensity")]
    [JsonPropertyName("m_flFluidDensity")]
    public int? MFlFluidDensity
    {
        get;
        set;
    }

    [JsonProperty("m_flNeutrallyBuoyantAngularDamping")]
    [JsonPropertyName("m_flNeutrallyBuoyantAngularDamping")]
    public int? MFlNeutrallyBuoyantAngularDamping
    {
        get;
        set;
    }

    [JsonProperty("m_flNeutrallyBuoyantGravity")]
    [JsonPropertyName("m_flNeutrallyBuoyantGravity")]
    public int? MFlNeutrallyBuoyantGravity
    {
        get;
        set;
    }

    [JsonProperty("m_flNeutrallyBuoyantLinearDamping")]
    [JsonPropertyName("m_flNeutrallyBuoyantLinearDamping")]
    public int? MFlNeutrallyBuoyantLinearDamping
    {
        get;
        set;
    }

    [JsonProperty("m_nFluidType")]
    [JsonPropertyName("m_nFluidType")]
    public int? MNFluidType
    {
        get;
        set;
    }

    [JsonProperty("m_vecFractionOfWheelSubmergedForWheelDrag")]
    [JsonPropertyName("m_vecFractionOfWheelSubmergedForWheelDrag")]
    public int? MVecFractionOfWheelSubmergedForWheelDrag
    {
        get;
        set;
    }

    [JsonProperty("m_vecFractionOfWheelSubmergedForWheelFriction")]
    [JsonPropertyName("m_vecFractionOfWheelSubmergedForWheelFriction")]
    public int? MVecFractionOfWheelSubmergedForWheelFriction
    {
        get;
        set;
    }

    [JsonProperty("m_vecWheelDrag")]
    [JsonPropertyName("m_vecWheelDrag")]
    public int? MVecWheelDrag
    {
        get;
        set;
    }

    [JsonProperty("m_vecWheelFrictionScales")]
    [JsonPropertyName("m_vecWheelFrictionScales")]
    public int? MVecWheelFrictionScales
    {
        get;
        set;
    }

    [JsonProperty("m_OnEndTouch")]
    [JsonPropertyName("m_OnEndTouch")]
    public int? MOnEndTouch
    {
        get;
        set;
    }

    [JsonProperty("m_OnEndTouchAll")]
    [JsonPropertyName("m_OnEndTouchAll")]
    public int? MOnEndTouchAll
    {
        get;
        set;
    }

    [JsonProperty("m_OnNotTouching")]
    [JsonPropertyName("m_OnNotTouching")]
    public int? MOnNotTouching
    {
        get;
        set;
    }

    [JsonProperty("m_OnStartTouch")]
    [JsonPropertyName("m_OnStartTouch")]
    public int? MOnStartTouch
    {
        get;
        set;
    }

    [JsonProperty("m_OnStartTouchAll")]
    [JsonPropertyName("m_OnStartTouchAll")]
    public int? MOnStartTouchAll
    {
        get;
        set;
    }

    [JsonProperty("m_OnTouching")]
    [JsonPropertyName("m_OnTouching")]
    public int? MOnTouching
    {
        get;
        set;
    }

    [JsonProperty("m_OnTouchingEachEntity")]
    [JsonPropertyName("m_OnTouchingEachEntity")]
    public int? MOnTouchingEachEntity
    {
        get;
        set;
    }

    [JsonProperty("m_bDisabled")]
    [JsonPropertyName("m_bDisabled")]
    public int? MBDisabled
    {
        get;
        set;
    }

    [JsonProperty("m_hFilter")]
    [JsonPropertyName("m_hFilter")]
    public int? MHFilter
    {
        get;
        set;
    }

    [JsonProperty("m_hTouchingEntities")]
    [JsonPropertyName("m_hTouchingEntities")]
    public int? MHTouchingEntities
    {
        get;
        set;
    }

    [JsonProperty("m_iFilterName")]
    [JsonPropertyName("m_iFilterName")]
    public int? MIFilterName
    {
        get;
        set;
    }

    [JsonProperty("m_bTurnedOff")]
    [JsonPropertyName("m_bTurnedOff")]
    public int? MBTurnedOff
    {
        get;
        set;
    }

    [JsonProperty("m_fAmplitude")]
    [JsonPropertyName("m_fAmplitude")]
    public int? MFAmplitude
    {
        get;
        set;
    }

    [JsonProperty("m_fEndWidth")]
    [JsonPropertyName("m_fEndWidth")]
    public int? MFEndWidth
    {
        get;
        set;
    }

    [JsonProperty("m_fFadeLength")]
    [JsonPropertyName("m_fFadeLength")]
    public int? MFFadeLength
    {
        get;
        set;
    }

    [JsonProperty("m_fHaloScale")]
    [JsonPropertyName("m_fHaloScale")]
    public int? MFHaloScale
    {
        get;
        set;
    }

    [JsonProperty("m_fSpeed")]
    [JsonPropertyName("m_fSpeed")]
    public int? MFSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_fStartFrame")]
    [JsonPropertyName("m_fStartFrame")]
    public int? MFStartFrame
    {
        get;
        set;
    }

    [JsonProperty("m_fWidth")]
    [JsonPropertyName("m_fWidth")]
    public int? MFWidth
    {
        get;
        set;
    }

    [JsonProperty("m_flFireTime")]
    [JsonPropertyName("m_flFireTime")]
    public int? MFlFireTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFrame")]
    [JsonPropertyName("m_flFrame")]
    public int? MFlFrame
    {
        get;
        set;
    }

    [JsonProperty("m_flFrameRate")]
    [JsonPropertyName("m_flFrameRate")]
    public int? MFlFrameRate
    {
        get;
        set;
    }

    [JsonProperty("m_flHDRColorScale")]
    [JsonPropertyName("m_flHDRColorScale")]
    public int? MFlHDRColorScale
    {
        get;
        set;
    }

    [JsonProperty("m_hAttachEntity")]
    [JsonPropertyName("m_hAttachEntity")]
    public int? MHAttachEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hBaseMaterial")]
    [JsonPropertyName("m_hBaseMaterial")]
    public int? MHBaseMaterial
    {
        get;
        set;
    }

    [JsonProperty("m_hEndEntity")]
    [JsonPropertyName("m_hEndEntity")]
    public int? MHEndEntity
    {
        get;
        set;
    }

    [JsonProperty("m_nAttachIndex")]
    [JsonPropertyName("m_nAttachIndex")]
    public int? MNAttachIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nBeamFlags")]
    [JsonPropertyName("m_nBeamFlags")]
    public int? MNBeamFlags
    {
        get;
        set;
    }

    [JsonProperty("m_nBeamType")]
    [JsonPropertyName("m_nBeamType")]
    public int? MNBeamType
    {
        get;
        set;
    }

    [JsonProperty("m_nClipStyle")]
    [JsonPropertyName("m_nClipStyle")]
    public int? MNClipStyle
    {
        get;
        set;
    }

    [JsonProperty("m_nHaloIndex")]
    [JsonPropertyName("m_nHaloIndex")]
    public int? MNHaloIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nNumBeamEnts")]
    [JsonPropertyName("m_nNumBeamEnts")]
    public int? MNNumBeamEnts
    {
        get;
        set;
    }

    [JsonProperty("m_queryHandleHalo")]
    [JsonPropertyName("m_queryHandleHalo")]
    public int? MQueryHandleHalo
    {
        get;
        set;
    }

    [JsonProperty("m_vecEndPos")]
    [JsonPropertyName("m_vecEndPos")]
    public int? MVecEndPos
    {
        get;
        set;
    }

    [JsonProperty("m_BreakableContentsType")]
    [JsonPropertyName("m_BreakableContentsType")]
    public int? MBreakableContentsType
    {
        get;
        set;
    }

    [JsonProperty("m_CPropDataComponent")]
    [JsonPropertyName("m_CPropDataComponent")]
    public int? MCPropDataComponent
    {
        get;
        set;
    }

    [JsonProperty("m_OnBreak")]
    [JsonPropertyName("m_OnBreak")]
    public int? MOnBreak
    {
        get;
        set;
    }

    [JsonProperty("m_OnHealthChanged")]
    [JsonPropertyName("m_OnHealthChanged")]
    public int? MOnHealthChanged
    {
        get;
        set;
    }

    [JsonProperty("m_OnStartDeath")]
    [JsonPropertyName("m_OnStartDeath")]
    public int? MOnStartDeath
    {
        get;
        set;
    }

    [JsonProperty("m_OnTakeDamage")]
    [JsonPropertyName("m_OnTakeDamage")]
    public int? MOnTakeDamage
    {
        get;
        set;
    }

    [JsonProperty("m_PerformanceMode")]
    [JsonPropertyName("m_PerformanceMode")]
    public int? MPerformanceMode
    {
        get;
        set;
    }

    [JsonProperty("m_bHasBreakPiecesOrCommands")]
    [JsonPropertyName("m_bHasBreakPiecesOrCommands")]
    public int? MBHasBreakPiecesOrCommands
    {
        get;
        set;
    }

    [JsonProperty("m_explodeDamage")]
    [JsonPropertyName("m_explodeDamage")]
    public int? MExplodeDamage
    {
        get;
        set;
    }

    [JsonProperty("m_explodeRadius")]
    [JsonPropertyName("m_explodeRadius")]
    public int? MExplodeRadius
    {
        get;
        set;
    }

    [JsonProperty("m_explosionBuildupSound")]
    [JsonPropertyName("m_explosionBuildupSound")]
    public int? MExplosionBuildupSound
    {
        get;
        set;
    }

    [JsonProperty("m_explosionCustomEffect")]
    [JsonPropertyName("m_explosionCustomEffect")]
    public int? MExplosionCustomEffect
    {
        get;
        set;
    }

    [JsonProperty("m_explosionCustomSound")]
    [JsonPropertyName("m_explosionCustomSound")]
    public int? MExplosionCustomSound
    {
        get;
        set;
    }

    [JsonProperty("m_explosionDelay")]
    [JsonPropertyName("m_explosionDelay")]
    public int? MExplosionDelay
    {
        get;
        set;
    }

    [JsonProperty("m_explosionModifier")]
    [JsonPropertyName("m_explosionModifier")]
    public int? MExplosionModifier
    {
        get;
        set;
    }

    [JsonProperty("m_flDefBurstScale")]
    [JsonPropertyName("m_flDefBurstScale")]
    public int? MFlDefBurstScale
    {
        get;
        set;
    }

    [JsonProperty("m_flDefaultFadeScale")]
    [JsonPropertyName("m_flDefaultFadeScale")]
    public int? MFlDefaultFadeScale
    {
        get;
        set;
    }

    [JsonProperty("m_flLastPhysicsInfluenceTime")]
    [JsonPropertyName("m_flLastPhysicsInfluenceTime")]
    public int? MFlLastPhysicsInfluenceTime
    {
        get;
        set;
    }

    [JsonProperty("m_flPressureDelay")]
    [JsonPropertyName("m_flPressureDelay")]
    public int? MFlPressureDelay
    {
        get;
        set;
    }

    [JsonProperty("m_flPreventDamageBeforeTime")]
    [JsonPropertyName("m_flPreventDamageBeforeTime")]
    public int? MFlPreventDamageBeforeTime
    {
        get;
        set;
    }

    [JsonProperty("m_hBreaker")]
    [JsonPropertyName("m_hBreaker")]
    public int? MHBreaker
    {
        get;
        set;
    }

    [JsonProperty("m_hLastAttacker")]
    [JsonPropertyName("m_hLastAttacker")]
    public int? MHLastAttacker
    {
        get;
        set;
    }

    [JsonProperty("m_hPhysicsAttacker")]
    [JsonPropertyName("m_hPhysicsAttacker")]
    public int? MHPhysicsAttacker
    {
        get;
        set;
    }

    [JsonProperty("m_iMinHealthDmg")]
    [JsonPropertyName("m_iMinHealthDmg")]
    public int? MIMinHealthDmg
    {
        get;
        set;
    }

    [JsonProperty("m_impactEnergyScale")]
    [JsonPropertyName("m_impactEnergyScale")]
    public int? MImpactEnergyScale
    {
        get;
        set;
    }

    [JsonProperty("m_strBreakableContentsParticleOverride")]
    [JsonPropertyName("m_strBreakableContentsParticleOverride")]
    public int? MStrBreakableContentsParticleOverride
    {
        get;
        set;
    }

    [JsonProperty("m_strBreakableContentsPropGroupOverride")]
    [JsonPropertyName("m_strBreakableContentsPropGroupOverride")]
    public int? MStrBreakableContentsPropGroupOverride
    {
        get;
        set;
    }

    [JsonProperty("m_vDefBurstOffset")]
    [JsonPropertyName("m_vDefBurstOffset")]
    public int? MVDefBurstOffset
    {
        get;
        set;
    }

    [JsonProperty("m_bIsHit")]
    [JsonPropertyName("m_bIsHit")]
    public int? MBIsHit
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeCreated")]
    [JsonPropertyName("m_flTimeCreated")]
    public int? MFlTimeCreated
    {
        get;
        set;
    }

    [JsonProperty("m_hPlayerParent")]
    [JsonPropertyName("m_hPlayerParent")]
    public int? MHPlayerParent
    {
        get;
        set;
    }

    [JsonProperty("m_iBoneIndex")]
    [JsonPropertyName("m_iBoneIndex")]
    public int? MIBoneIndex
    {
        get;
        set;
    }

    [JsonProperty("m_matLocal")]
    [JsonPropertyName("m_matLocal")]
    public int? MMatLocal
    {
        get;
        set;
    }

    [JsonProperty("m_vecStartPos")]
    [JsonPropertyName("m_vecStartPos")]
    public int? MVecStartPos
    {
        get;
        set;
    }

    [JsonProperty("m_activeLightParticleIndex")]
    [JsonPropertyName("m_activeLightParticleIndex")]
    public int? MActiveLightParticleIndex
    {
        get;
        set;
    }

    [JsonProperty("m_bBombPlacedAnimation")]
    [JsonPropertyName("m_bBombPlacedAnimation")]
    public int? MBBombPlacedAnimation
    {
        get;
        set;
    }

    [JsonProperty("m_bBombPlanted")]
    [JsonPropertyName("m_bBombPlanted")]
    public int? MBBombPlanted
    {
        get;
        set;
    }

    [JsonProperty("m_bIsPlantingViaUse")]
    [JsonPropertyName("m_bIsPlantingViaUse")]
    public int? MBIsPlantingViaUse
    {
        get;
        set;
    }

    [JsonProperty("m_bPlayedArmingBeeps")]
    [JsonPropertyName("m_bPlayedArmingBeeps")]
    public int? MBPlayedArmingBeeps
    {
        get;
        set;
    }

    [JsonProperty("m_bStartedArming")]
    [JsonPropertyName("m_bStartedArming")]
    public int? MBStartedArming
    {
        get;
        set;
    }

    [JsonProperty("m_eActiveLightEffect")]
    [JsonPropertyName("m_eActiveLightEffect")]
    public int? MEActiveLightEffect
    {
        get;
        set;
    }

    [JsonProperty("m_entitySpottedState")]
    [JsonPropertyName("m_entitySpottedState")]
    public int? MEntitySpottedState
    {
        get;
        set;
    }

    [JsonProperty("m_fArmedTime")]
    [JsonPropertyName("m_fArmedTime")]
    public int? MFArmedTime
    {
        get;
        set;
    }

    [JsonProperty("m_nSpotRules")]
    [JsonPropertyName("m_nSpotRules")]
    public int? MNSpotRules
    {
        get;
        set;
    }

    [JsonProperty("m_bConstantSpeed")]
    [JsonPropertyName("m_bConstantSpeed")]
    public int? MBConstantSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_bDofEnabled")]
    [JsonPropertyName("m_bDofEnabled")]
    public int? MBDofEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bLoop")]
    [JsonPropertyName("m_bLoop")]
    public int? MBLoop
    {
        get;
        set;
    }

    [JsonProperty("m_bVerticalFOV")]
    [JsonPropertyName("m_bVerticalFOV")]
    public int? MBVerticalFOV
    {
        get;
        set;
    }

    [JsonProperty("m_flDofFarBlurry")]
    [JsonPropertyName("m_flDofFarBlurry")]
    public int? MFlDofFarBlurry
    {
        get;
        set;
    }

    [JsonProperty("m_flDofFarCrisp")]
    [JsonPropertyName("m_flDofFarCrisp")]
    public int? MFlDofFarCrisp
    {
        get;
        set;
    }

    [JsonProperty("m_flDofNearBlurry")]
    [JsonPropertyName("m_flDofNearBlurry")]
    public int? MFlDofNearBlurry
    {
        get;
        set;
    }

    [JsonProperty("m_flDofNearCrisp")]
    [JsonPropertyName("m_flDofNearCrisp")]
    public int? MFlDofNearCrisp
    {
        get;
        set;
    }

    [JsonProperty("m_flDofTiltToGround")]
    [JsonPropertyName("m_flDofTiltToGround")]
    public int? MFlDofTiltToGround
    {
        get;
        set;
    }

    [JsonProperty("m_flDuration")]
    [JsonPropertyName("m_flDuration")]
    public int? MFlDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flPathDuration")]
    [JsonPropertyName("m_flPathDuration")]
    public int? MFlPathDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flPathLength")]
    [JsonPropertyName("m_flPathLength")]
    public int? MFlPathLength
    {
        get;
        set;
    }

    [JsonProperty("m_flZFar")]
    [JsonPropertyName("m_flZFar")]
    public int? MFlZFar
    {
        get;
        set;
    }

    [JsonProperty("m_flZNear")]
    [JsonPropertyName("m_flZNear")]
    public int? MFlZNear
    {
        get;
        set;
    }

    [JsonProperty("m_flCameraSpeed")]
    [JsonPropertyName("m_flCameraSpeed")]
    public int? MFlCameraSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flEaseIn")]
    [JsonPropertyName("m_flEaseIn")]
    public int? MFlEaseIn
    {
        get;
        set;
    }

    [JsonProperty("m_flEaseOut")]
    [JsonPropertyName("m_flEaseOut")]
    public int? MFlEaseOut
    {
        get;
        set;
    }

    [JsonProperty("m_flFOV")]
    [JsonPropertyName("m_flFOV")]
    public int? MFlFOV
    {
        get;
        set;
    }

    [JsonProperty("m_nPathIndex")]
    [JsonPropertyName("m_nPathIndex")]
    public int? MNPathIndex
    {
        get;
        set;
    }

    [JsonProperty("m_szParentPathUniqueID")]
    [JsonPropertyName("m_szParentPathUniqueID")]
    public int? MSzParentPathUniqueID
    {
        get;
        set;
    }

    [JsonProperty("m_vInTangentLocal")]
    [JsonPropertyName("m_vInTangentLocal")]
    public int? MVInTangentLocal
    {
        get;
        set;
    }

    [JsonProperty("m_vInTangentWorld")]
    [JsonPropertyName("m_vInTangentWorld")]
    public int? MVInTangentWorld
    {
        get;
        set;
    }

    [JsonProperty("m_vOutTangentLocal")]
    [JsonPropertyName("m_vOutTangentLocal")]
    public int? MVOutTangentLocal
    {
        get;
        set;
    }

    [JsonProperty("m_vOutTangentWorld")]
    [JsonPropertyName("m_vOutTangentWorld")]
    public int? MVOutTangentWorld
    {
        get;
        set;
    }

    [JsonProperty("m_defaultAnim")]
    [JsonPropertyName("m_defaultAnim")]
    public int? MDefaultAnim
    {
        get;
        set;
    }

    [JsonProperty("m_flInitialModelScale")]
    [JsonPropertyName("m_flInitialModelScale")]
    public int? MFlInitialModelScale
    {
        get;
        set;
    }

    [JsonProperty("m_nDefaultAnimLoopMode")]
    [JsonPropertyName("m_nDefaultAnimLoopMode")]
    public int? MNDefaultAnimLoopMode
    {
        get;
        set;
    }

    [JsonProperty("m_sInitialWeaponState")]
    [JsonPropertyName("m_sInitialWeaponState")]
    public int? MSInitialWeaponState
    {
        get;
        set;
    }

    [JsonProperty("m_animgraphCharacterModeString")]
    [JsonPropertyName("m_animgraphCharacterModeString")]
    public int? MAnimgraphCharacterModeString
    {
        get;
        set;
    }

    [JsonProperty("m_nVariant")]
    [JsonPropertyName("m_nVariant")]
    public int? MNVariant
    {
        get;
        set;
    }

    [JsonProperty("m_agentItem")]
    [JsonPropertyName("m_agentItem")]
    public int? MAgentItem
    {
        get;
        set;
    }

    [JsonProperty("m_glovesItem")]
    [JsonPropertyName("m_glovesItem")]
    public int? MGlovesItem
    {
        get;
        set;
    }

    [JsonProperty("m_nOrdinal")]
    [JsonPropertyName("m_nOrdinal")]
    public int? MNOrdinal
    {
        get;
        set;
    }

    [JsonProperty("m_nRandom")]
    [JsonPropertyName("m_nRandom")]
    public int? MNRandom
    {
        get;
        set;
    }

    [JsonProperty("m_sWeaponName")]
    [JsonPropertyName("m_sWeaponName")]
    public int? MSWeaponName
    {
        get;
        set;
    }

    [JsonProperty("m_weaponItem")]
    [JsonPropertyName("m_weaponItem")]
    public int? MWeaponItem
    {
        get;
        set;
    }

    [JsonProperty("m_xuid")]
    [JsonPropertyName("m_xuid")]
    public int? MXuid
    {
        get;
        set;
    }

    [JsonProperty("m_MatchDevice")]
    [JsonPropertyName("m_MatchDevice")]
    public int? MMatchDevice
    {
        get;
        set;
    }

    [JsonProperty("m_MinimapVerticalSectionHeights")]
    [JsonPropertyName("m_MinimapVerticalSectionHeights")]
    public int? MMinimapVerticalSectionHeights
    {
        get;
        set;
    }

    [JsonProperty("m_RetakeRules")]
    [JsonPropertyName("m_RetakeRules")]
    public int? MRetakeRules
    {
        get;
        set;
    }

    [JsonProperty("m_TeamRespawnWaveTimes")]
    [JsonPropertyName("m_TeamRespawnWaveTimes")]
    public int? MTeamRespawnWaveTimes
    {
        get;
        set;
    }

    [JsonProperty("m_arrProhibitedItemIndices")]
    [JsonPropertyName("m_arrProhibitedItemIndices")]
    public int? MArrProhibitedItemIndices
    {
        get;
        set;
    }

    [JsonProperty("m_arrTournamentActiveCasterAccounts")]
    [JsonPropertyName("m_arrTournamentActiveCasterAccounts")]
    public int? MArrTournamentActiveCasterAccounts
    {
        get;
        set;
    }

    [JsonProperty("m_bAnyHostageReached")]
    [JsonPropertyName("m_bAnyHostageReached")]
    public int? MBAnyHostageReached
    {
        get;
        set;
    }

    [JsonProperty("m_bBombDropped")]
    [JsonPropertyName("m_bBombDropped")]
    public int? MBBombDropped
    {
        get;
        set;
    }

    [JsonProperty("m_bCTCantBuy")]
    [JsonPropertyName("m_bCTCantBuy")]
    public int? MBCTCantBuy
    {
        get;
        set;
    }

    [JsonProperty("m_bCTTimeOutActive")]
    [JsonPropertyName("m_bCTTimeOutActive")]
    public int? MBCTTimeOutActive
    {
        get;
        set;
    }

    [JsonProperty("m_bFreezePeriod")]
    [JsonPropertyName("m_bFreezePeriod")]
    public int? MBFreezePeriod
    {
        get;
        set;
    }

    [JsonProperty("m_bGameRestart")]
    [JsonPropertyName("m_bGameRestart")]
    public int? MBGameRestart
    {
        get;
        set;
    }

    [JsonProperty("m_bHasMatchStarted")]
    [JsonPropertyName("m_bHasMatchStarted")]
    public int? MBHasMatchStarted
    {
        get;
        set;
    }

    [JsonProperty("m_bHasTriggeredRoundStartMusic")]
    [JsonPropertyName("m_bHasTriggeredRoundStartMusic")]
    public int? MBHasTriggeredRoundStartMusic
    {
        get;
        set;
    }

    [JsonProperty("m_bIsDroppingItems")]
    [JsonPropertyName("m_bIsDroppingItems")]
    public int? MBIsDroppingItems
    {
        get;
        set;
    }

    [JsonProperty("m_bIsHltvActive")]
    [JsonPropertyName("m_bIsHltvActive")]
    public int? MBIsHltvActive
    {
        get;
        set;
    }

    [JsonProperty("m_bIsQuestEligible")]
    [JsonPropertyName("m_bIsQuestEligible")]
    public int? MBIsQuestEligible
    {
        get;
        set;
    }

    [JsonProperty("m_bIsQueuedMatchmaking")]
    [JsonPropertyName("m_bIsQueuedMatchmaking")]
    public int? MBIsQueuedMatchmaking
    {
        get;
        set;
    }

    [JsonProperty("m_bIsValveDS")]
    [JsonPropertyName("m_bIsValveDS")]
    public int? MBIsValveDS
    {
        get;
        set;
    }

    [JsonProperty("m_bLogoMap")]
    [JsonPropertyName("m_bLogoMap")]
    public int? MBLogoMap
    {
        get;
        set;
    }

    [JsonProperty("m_bMapHasBombTarget")]
    [JsonPropertyName("m_bMapHasBombTarget")]
    public int? MBMapHasBombTarget
    {
        get;
        set;
    }

    [JsonProperty("m_bMapHasBuyZone")]
    [JsonPropertyName("m_bMapHasBuyZone")]
    public int? MBMapHasBuyZone
    {
        get;
        set;
    }

    [JsonProperty("m_bMapHasRescueZone")]
    [JsonPropertyName("m_bMapHasRescueZone")]
    public int? MBMapHasRescueZone
    {
        get;
        set;
    }

    [JsonProperty("m_bMatchWaitingForResume")]
    [JsonPropertyName("m_bMatchWaitingForResume")]
    public int? MBMatchWaitingForResume
    {
        get;
        set;
    }

    [JsonProperty("m_bPlayAllStepSoundsOnServer")]
    [JsonPropertyName("m_bPlayAllStepSoundsOnServer")]
    public int? MBPlayAllStepSoundsOnServer
    {
        get;
        set;
    }

    [JsonProperty("m_bRoundEndNoMusic")]
    [JsonPropertyName("m_bRoundEndNoMusic")]
    public int? MBRoundEndNoMusic
    {
        get;
        set;
    }

    [JsonProperty("m_bRoundEndShowTimerDefend")]
    [JsonPropertyName("m_bRoundEndShowTimerDefend")]
    public int? MBRoundEndShowTimerDefend
    {
        get;
        set;
    }

    [JsonProperty("m_bSwitchingTeamsAtRoundReset")]
    [JsonPropertyName("m_bSwitchingTeamsAtRoundReset")]
    public int? MBSwitchingTeamsAtRoundReset
    {
        get;
        set;
    }

    [JsonProperty("m_bTCantBuy")]
    [JsonPropertyName("m_bTCantBuy")]
    public int? MBTCantBuy
    {
        get;
        set;
    }

    [JsonProperty("m_bTeamIntroPeriod")]
    [JsonPropertyName("m_bTeamIntroPeriod")]
    public int? MBTeamIntroPeriod
    {
        get;
        set;
    }

    [JsonProperty("m_bTechnicalTimeOut")]
    [JsonPropertyName("m_bTechnicalTimeOut")]
    public int? MBTechnicalTimeOut
    {
        get;
        set;
    }

    [JsonProperty("m_bTerroristTimeOutActive")]
    [JsonPropertyName("m_bTerroristTimeOutActive")]
    public int? MBTerroristTimeOutActive
    {
        get;
        set;
    }

    [JsonProperty("m_bWarmupPeriod")]
    [JsonPropertyName("m_bWarmupPeriod")]
    public int? MBWarmupPeriod
    {
        get;
        set;
    }

    [JsonProperty("m_eRoundEndReason")]
    [JsonPropertyName("m_eRoundEndReason")]
    public int? MERoundEndReason
    {
        get;
        set;
    }

    [JsonProperty("m_eRoundWinReason")]
    [JsonPropertyName("m_eRoundWinReason")]
    public int? MERoundWinReason
    {
        get;
        set;
    }

    [JsonProperty("m_fMatchStartTime")]
    [JsonPropertyName("m_fMatchStartTime")]
    public int? MFMatchStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_fRoundStartTime")]
    [JsonPropertyName("m_fRoundStartTime")]
    public int? MFRoundStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_fWarmupPeriodEnd")]
    [JsonPropertyName("m_fWarmupPeriodEnd")]
    public int? MFWarmupPeriodEnd
    {
        get;
        set;
    }

    [JsonProperty("m_fWarmupPeriodStart")]
    [JsonPropertyName("m_fWarmupPeriodStart")]
    public int? MFWarmupPeriodStart
    {
        get;
        set;
    }

    [JsonProperty("m_flCMMItemDropRevealEndTime")]
    [JsonPropertyName("m_flCMMItemDropRevealEndTime")]
    public int? MFlCMMItemDropRevealEndTime
    {
        get;
        set;
    }

    [JsonProperty("m_flCMMItemDropRevealStartTime")]
    [JsonPropertyName("m_flCMMItemDropRevealStartTime")]
    public int? MFlCMMItemDropRevealStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flCTTimeOutRemaining")]
    [JsonPropertyName("m_flCTTimeOutRemaining")]
    public int? MFlCTTimeOutRemaining
    {
        get;
        set;
    }

    [JsonProperty("m_flGameStartTime")]
    [JsonPropertyName("m_flGameStartTime")]
    public int? MFlGameStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastPerfSampleTime")]
    [JsonPropertyName("m_flLastPerfSampleTime")]
    public int? MFlLastPerfSampleTime
    {
        get;
        set;
    }

    [JsonProperty("m_flNextRespawnWave")]
    [JsonPropertyName("m_flNextRespawnWave")]
    public int? MFlNextRespawnWave
    {
        get;
        set;
    }

    [JsonProperty("m_flRestartRoundTime")]
    [JsonPropertyName("m_flRestartRoundTime")]
    public int? MFlRestartRoundTime
    {
        get;
        set;
    }

    [JsonProperty("m_flTerroristTimeOutRemaining")]
    [JsonPropertyName("m_flTerroristTimeOutRemaining")]
    public int? MFlTerroristTimeOutRemaining
    {
        get;
        set;
    }

    [JsonProperty("m_gamePhase")]
    [JsonPropertyName("m_gamePhase")]
    public int? MGamePhase
    {
        get;
        set;
    }

    [JsonProperty("m_iFreezeTime")]
    [JsonPropertyName("m_iFreezeTime")]
    public int? MIFreezeTime
    {
        get;
        set;
    }

    [JsonProperty("m_iHostagesRemaining")]
    [JsonPropertyName("m_iHostagesRemaining")]
    public int? MIHostagesRemaining
    {
        get;
        set;
    }

    [JsonProperty("m_iMatchStats_PlayersAlive_CT")]
    [JsonPropertyName("m_iMatchStats_PlayersAlive_CT")]
    public int? MIMatchStatsPlayersAliveCT
    {
        get;
        set;
    }

    [JsonProperty("m_iMatchStats_PlayersAlive_T")]
    [JsonPropertyName("m_iMatchStats_PlayersAlive_T")]
    public int? MIMatchStatsPlayersAliveT
    {
        get;
        set;
    }

    [JsonProperty("m_iMatchStats_RoundResults")]
    [JsonPropertyName("m_iMatchStats_RoundResults")]
    public int? MIMatchStatsRoundResults
    {
        get;
        set;
    }

    [JsonProperty("m_iNumConsecutiveCTLoses")]
    [JsonPropertyName("m_iNumConsecutiveCTLoses")]
    public int? MINumConsecutiveCTLoses
    {
        get;
        set;
    }

    [JsonProperty("m_iNumConsecutiveTerroristLoses")]
    [JsonPropertyName("m_iNumConsecutiveTerroristLoses")]
    public int? MINumConsecutiveTerroristLoses
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndFunFactData1")]
    [JsonPropertyName("m_iRoundEndFunFactData1")]
    public int? MIRoundEndFunFactData1
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndFunFactData2")]
    [JsonPropertyName("m_iRoundEndFunFactData2")]
    public int? MIRoundEndFunFactData2
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndFunFactData3")]
    [JsonPropertyName("m_iRoundEndFunFactData3")]
    public int? MIRoundEndFunFactData3
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndFunFactPlayerSlot")]
    [JsonPropertyName("m_iRoundEndFunFactPlayerSlot")]
    public int? MIRoundEndFunFactPlayerSlot
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndLegacy")]
    [JsonPropertyName("m_iRoundEndLegacy")]
    public int? MIRoundEndLegacy
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndPlayerCount")]
    [JsonPropertyName("m_iRoundEndPlayerCount")]
    public int? MIRoundEndPlayerCount
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndTimerTime")]
    [JsonPropertyName("m_iRoundEndTimerTime")]
    public int? MIRoundEndTimerTime
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundEndWinnerTeam")]
    [JsonPropertyName("m_iRoundEndWinnerTeam")]
    public int? MIRoundEndWinnerTeam
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundStartRoundNumber")]
    [JsonPropertyName("m_iRoundStartRoundNumber")]
    public int? MIRoundStartRoundNumber
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundTime")]
    [JsonPropertyName("m_iRoundTime")]
    public int? MIRoundTime
    {
        get;
        set;
    }

    [JsonProperty("m_iRoundWinStatus")]
    [JsonPropertyName("m_iRoundWinStatus")]
    public int? MIRoundWinStatus
    {
        get;
        set;
    }

    [JsonProperty("m_iSpectatorSlotCount")]
    [JsonPropertyName("m_iSpectatorSlotCount")]
    public int? MISpectatorSlotCount
    {
        get;
        set;
    }

    [JsonProperty("m_nCTTeamIntroVariant")]
    [JsonPropertyName("m_nCTTeamIntroVariant")]
    public int? MNCTTeamIntroVariant
    {
        get;
        set;
    }

    [JsonProperty("m_nCTTimeOuts")]
    [JsonPropertyName("m_nCTTimeOuts")]
    public int? MNCTTimeOuts
    {
        get;
        set;
    }

    [JsonProperty("m_nEndMatchMapGroupVoteOptions")]
    [JsonPropertyName("m_nEndMatchMapGroupVoteOptions")]
    public int? MNEndMatchMapGroupVoteOptions
    {
        get;
        set;
    }

    [JsonProperty("m_nEndMatchMapGroupVoteTypes")]
    [JsonPropertyName("m_nEndMatchMapGroupVoteTypes")]
    public int? MNEndMatchMapGroupVoteTypes
    {
        get;
        set;
    }

    [JsonProperty("m_nEndMatchMapVoteWinner")]
    [JsonPropertyName("m_nEndMatchMapVoteWinner")]
    public int? MNEndMatchMapVoteWinner
    {
        get;
        set;
    }

    [JsonProperty("m_nHalloweenMaskListSeed")]
    [JsonPropertyName("m_nHalloweenMaskListSeed")]
    public int? MNHalloweenMaskListSeed
    {
        get;
        set;
    }

    [JsonProperty("m_nMatchAbortedEarlyReason")]
    [JsonPropertyName("m_nMatchAbortedEarlyReason")]
    public int? MNMatchAbortedEarlyReason
    {
        get;
        set;
    }

    [JsonProperty("m_nMatchEndCount")]
    [JsonPropertyName("m_nMatchEndCount")]
    public int? MNMatchEndCount
    {
        get;
        set;
    }

    [JsonProperty("m_nNextMapInMapgroup")]
    [JsonPropertyName("m_nNextMapInMapgroup")]
    public int? MNNextMapInMapgroup
    {
        get;
        set;
    }

    [JsonProperty("m_nOvertimePlaying")]
    [JsonPropertyName("m_nOvertimePlaying")]
    public int? MNOvertimePlaying
    {
        get;
        set;
    }

    [JsonProperty("m_nQueuedMatchmakingMode")]
    [JsonPropertyName("m_nQueuedMatchmakingMode")]
    public int? MNQueuedMatchmakingMode
    {
        get;
        set;
    }

    [JsonProperty("m_nRoundEndCount")]
    [JsonPropertyName("m_nRoundEndCount")]
    public int? MNRoundEndCount
    {
        get;
        set;
    }

    [JsonProperty("m_nRoundStartCount")]
    [JsonPropertyName("m_nRoundStartCount")]
    public int? MNRoundStartCount
    {
        get;
        set;
    }

    [JsonProperty("m_nRoundsPlayedThisPhase")]
    [JsonPropertyName("m_nRoundsPlayedThisPhase")]
    public int? MNRoundsPlayedThisPhase
    {
        get;
        set;
    }

    [JsonProperty("m_nTTeamIntroVariant")]
    [JsonPropertyName("m_nTTeamIntroVariant")]
    public int? MNTTeamIntroVariant
    {
        get;
        set;
    }

    [JsonProperty("m_nTerroristTimeOuts")]
    [JsonPropertyName("m_nTerroristTimeOuts")]
    public int? MNTerroristTimeOuts
    {
        get;
        set;
    }

    [JsonProperty("m_nTournamentPredictionsPct")]
    [JsonPropertyName("m_nTournamentPredictionsPct")]
    public int? MNTournamentPredictionsPct
    {
        get;
        set;
    }

    [JsonProperty("m_numBestOfMaps")]
    [JsonPropertyName("m_numBestOfMaps")]
    public int? MNumBestOfMaps
    {
        get;
        set;
    }

    [JsonProperty("m_pGameModeRules")]
    [JsonPropertyName("m_pGameModeRules")]
    public int? MPGameModeRules
    {
        get;
        set;
    }

    [JsonProperty("m_sRoundEndFunFactToken")]
    [JsonPropertyName("m_sRoundEndFunFactToken")]
    public int? MSRoundEndFunFactToken
    {
        get;
        set;
    }

    [JsonProperty("m_sRoundEndMessage")]
    [JsonPropertyName("m_sRoundEndMessage")]
    public int? MSRoundEndMessage
    {
        get;
        set;
    }

    [JsonProperty("m_szMatchStatTxt")]
    [JsonPropertyName("m_szMatchStatTxt")]
    public int? MSzMatchStatTxt
    {
        get;
        set;
    }

    [JsonProperty("m_szTournamentEventName")]
    [JsonPropertyName("m_szTournamentEventName")]
    public int? MSzTournamentEventName
    {
        get;
        set;
    }

    [JsonProperty("m_szTournamentEventStage")]
    [JsonPropertyName("m_szTournamentEventStage")]
    public int? MSzTournamentEventStage
    {
        get;
        set;
    }

    [JsonProperty("m_szTournamentPredictionsTxt")]
    [JsonPropertyName("m_szTournamentPredictionsTxt")]
    public int? MSzTournamentPredictionsTxt
    {
        get;
        set;
    }

    [JsonProperty("m_timeUntilNextPhaseStarts")]
    [JsonPropertyName("m_timeUntilNextPhaseStarts")]
    public int? MTimeUntilNextPhaseStarts
    {
        get;
        set;
    }

    [JsonProperty("m_totalRoundsPlayed")]
    [JsonPropertyName("m_totalRoundsPlayed")]
    public int? MTotalRoundsPlayed
    {
        get;
        set;
    }

    [JsonProperty("m_ullLocalMatchID")]
    [JsonPropertyName("m_ullLocalMatchID")]
    public int? MUllLocalMatchID
    {
        get;
        set;
    }

    [JsonProperty("m_vMinimapMaxs")]
    [JsonPropertyName("m_vMinimapMaxs")]
    public int? MVMinimapMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vMinimapMins")]
    [JsonPropertyName("m_vMinimapMins")]
    public int? MVMinimapMins
    {
        get;
        set;
    }

    [JsonProperty("m_pGameRules")]
    [JsonPropertyName("m_pGameRules")]
    public int? MPGameRules
    {
        get;
        set;
    }

    [JsonProperty("m_hDetectParentChange")]
    [JsonPropertyName("m_hDetectParentChange")]
    public int? MHDetectParentChange
    {
        get;
        set;
    }

    [JsonProperty("m_ArmorValue")]
    [JsonPropertyName("m_ArmorValue")]
    public int? MArmorValue
    {
        get;
        set;
    }

    [JsonProperty("m_EconGloves")]
    [JsonPropertyName("m_EconGloves")]
    public int? MEconGloves
    {
        get;
        set;
    }

    [JsonProperty("m_GunGameImmunityColor")]
    [JsonPropertyName("m_GunGameImmunityColor")]
    public int? MGunGameImmunityColor
    {
        get;
        set;
    }

    [JsonProperty("m_PredictedDamageTags")]
    [JsonPropertyName("m_PredictedDamageTags")]
    public int? MPredictedDamageTags
    {
        get;
        set;
    }

    [JsonProperty("m_RetakesMVPBoostExtraUtility")]
    [JsonPropertyName("m_RetakesMVPBoostExtraUtility")]
    public int? MRetakesMVPBoostExtraUtility
    {
        get;
        set;
    }

    [JsonProperty("m_aimPunchAngle")]
    [JsonPropertyName("m_aimPunchAngle")]
    public int? MAimPunchAngle
    {
        get;
        set;
    }

    [JsonProperty("m_aimPunchAngleVel")]
    [JsonPropertyName("m_aimPunchAngleVel")]
    public int? MAimPunchAngleVel
    {
        get;
        set;
    }

    [JsonProperty("m_aimPunchCache")]
    [JsonPropertyName("m_aimPunchCache")]
    public int? MAimPunchCache
    {
        get;
        set;
    }

    [JsonProperty("m_aimPunchTickBase")]
    [JsonPropertyName("m_aimPunchTickBase")]
    public int? MAimPunchTickBase
    {
        get;
        set;
    }

    [JsonProperty("m_aimPunchTickFraction")]
    [JsonPropertyName("m_aimPunchTickFraction")]
    public int? MAimPunchTickFraction
    {
        get;
        set;
    }

    [JsonProperty("m_angEyeAngles")]
    [JsonPropertyName("m_angEyeAngles")]
    public int? MAngEyeAngles
    {
        get;
        set;
    }

    [JsonProperty("m_angEyeAnglesVelocity")]
    [JsonPropertyName("m_angEyeAnglesVelocity")]
    public int? MAngEyeAnglesVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_angShootAngleHistory")]
    [JsonPropertyName("m_angShootAngleHistory")]
    public int? MAngShootAngleHistory
    {
        get;
        set;
    }

    [JsonProperty("m_angStashedShootAngles")]
    [JsonPropertyName("m_angStashedShootAngles")]
    public int? MAngStashedShootAngles
    {
        get;
        set;
    }

    [JsonProperty("m_arrOldEyeAngles")]
    [JsonPropertyName("m_arrOldEyeAngles")]
    public int? MArrOldEyeAngles
    {
        get;
        set;
    }

    [JsonProperty("m_arrOldEyeAnglesTimes")]
    [JsonPropertyName("m_arrOldEyeAnglesTimes")]
    public int? MArrOldEyeAnglesTimes
    {
        get;
        set;
    }

    [JsonProperty("m_bCachedPlaneIsValid")]
    [JsonPropertyName("m_bCachedPlaneIsValid")]
    public int? MBCachedPlaneIsValid
    {
        get;
        set;
    }

    [JsonProperty("m_bClipHitStaticWorld")]
    [JsonPropertyName("m_bClipHitStaticWorld")]
    public int? MBClipHitStaticWorld
    {
        get;
        set;
    }

    [JsonProperty("m_bGrenadeParametersStashed")]
    [JsonPropertyName("m_bGrenadeParametersStashed")]
    public int? MBGrenadeParametersStashed
    {
        get;
        set;
    }

    [JsonProperty("m_bGunGameImmunity")]
    [JsonPropertyName("m_bGunGameImmunity")]
    public int? MBGunGameImmunity
    {
        get;
        set;
    }

    [JsonProperty("m_bHasDeathInfo")]
    [JsonPropertyName("m_bHasDeathInfo")]
    public int? MBHasDeathInfo
    {
        get;
        set;
    }

    [JsonProperty("m_bHasFemaleVoice")]
    [JsonPropertyName("m_bHasFemaleVoice")]
    public int? MBHasFemaleVoice
    {
        get;
        set;
    }

    [JsonProperty("m_bInBombZone")]
    [JsonPropertyName("m_bInBombZone")]
    public int? MBInBombZone
    {
        get;
        set;
    }

    [JsonProperty("m_bInBuyZone")]
    [JsonPropertyName("m_bInBuyZone")]
    public int? MBInBuyZone
    {
        get;
        set;
    }

    [JsonProperty("m_bInHostageRescueZone")]
    [JsonPropertyName("m_bInHostageRescueZone")]
    public int? MBInHostageRescueZone
    {
        get;
        set;
    }

    [JsonProperty("m_bInLanding")]
    [JsonPropertyName("m_bInLanding")]
    public int? MBInLanding
    {
        get;
        set;
    }

    [JsonProperty("m_bInNoDefuseArea")]
    [JsonPropertyName("m_bInNoDefuseArea")]
    public int? MBInNoDefuseArea
    {
        get;
        set;
    }

    [JsonProperty("m_bIsBuyMenuOpen")]
    [JsonPropertyName("m_bIsBuyMenuOpen")]
    public int? MBIsBuyMenuOpen
    {
        get;
        set;
    }

    [JsonProperty("m_bIsDefusing")]
    [JsonPropertyName("m_bIsDefusing")]
    public int? MBIsDefusing
    {
        get;
        set;
    }

    [JsonProperty("m_bIsGrabbingHostage")]
    [JsonPropertyName("m_bIsGrabbingHostage")]
    public int? MBIsGrabbingHostage
    {
        get;
        set;
    }

    [JsonProperty("m_bIsScoped")]
    [JsonPropertyName("m_bIsScoped")]
    public int? MBIsScoped
    {
        get;
        set;
    }

    [JsonProperty("m_bIsWalking")]
    [JsonPropertyName("m_bIsWalking")]
    public int? MBIsWalking
    {
        get;
        set;
    }

    [JsonProperty("m_bKilledByHeadshot")]
    [JsonPropertyName("m_bKilledByHeadshot")]
    public int? MBKilledByHeadshot
    {
        get;
        set;
    }

    [JsonProperty("m_bLeftHanded")]
    [JsonPropertyName("m_bLeftHanded")]
    public int? MBLeftHanded
    {
        get;
        set;
    }

    [JsonProperty("m_bMustSyncRagdollState")]
    [JsonPropertyName("m_bMustSyncRagdollState")]
    public int? MBMustSyncRagdollState
    {
        get;
        set;
    }

    [JsonProperty("m_bNeedToReApplyGloves")]
    [JsonPropertyName("m_bNeedToReApplyGloves")]
    public int? MBNeedToReApplyGloves
    {
        get;
        set;
    }

    [JsonProperty("m_bOldIsScoped")]
    [JsonPropertyName("m_bOldIsScoped")]
    public int? MBOldIsScoped
    {
        get;
        set;
    }

    [JsonProperty("m_bOnGroundLastTick")]
    [JsonPropertyName("m_bOnGroundLastTick")]
    public int? MBOnGroundLastTick
    {
        get;
        set;
    }

    [JsonProperty("m_bPrevDefuser")]
    [JsonPropertyName("m_bPrevDefuser")]
    public int? MBPrevDefuser
    {
        get;
        set;
    }

    [JsonProperty("m_bPrevHelmet")]
    [JsonPropertyName("m_bPrevHelmet")]
    public int? MBPrevHelmet
    {
        get;
        set;
    }

    [JsonProperty("m_bPreviouslyInBuyZone")]
    [JsonPropertyName("m_bPreviouslyInBuyZone")]
    public int? MBPreviouslyInBuyZone
    {
        get;
        set;
    }

    [JsonProperty("m_bRagdollDamageHeadshot")]
    [JsonPropertyName("m_bRagdollDamageHeadshot")]
    public int? MBRagdollDamageHeadshot
    {
        get;
        set;
    }

    [JsonProperty("m_bResumeZoom")]
    [JsonPropertyName("m_bResumeZoom")]
    public int? MBResumeZoom
    {
        get;
        set;
    }

    [JsonProperty("m_bRetakesHasDefuseKit")]
    [JsonPropertyName("m_bRetakesHasDefuseKit")]
    public int? MBRetakesHasDefuseKit
    {
        get;
        set;
    }

    [JsonProperty("m_bRetakesMVPLastRound")]
    [JsonPropertyName("m_bRetakesMVPLastRound")]
    public int? MBRetakesMVPLastRound
    {
        get;
        set;
    }

    [JsonProperty("m_bShouldAutobuyDMWeapons")]
    [JsonPropertyName("m_bShouldAutobuyDMWeapons")]
    public int? MBShouldAutobuyDMWeapons
    {
        get;
        set;
    }

    [JsonProperty("m_bSkipOneHeadConstraintUpdate")]
    [JsonPropertyName("m_bSkipOneHeadConstraintUpdate")]
    public int? MBSkipOneHeadConstraintUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_bWaitForNoAttack")]
    [JsonPropertyName("m_bWaitForNoAttack")]
    public int? MBWaitForNoAttack
    {
        get;
        set;
    }

    [JsonProperty("m_delayTargetIDTimer")]
    [JsonPropertyName("m_delayTargetIDTimer")]
    public int? MDelayTargetIDTimer
    {
        get;
        set;
    }

    [JsonProperty("m_fImmuneToGunGameDamageTime")]
    [JsonPropertyName("m_fImmuneToGunGameDamageTime")]
    public int? MFImmuneToGunGameDamageTime
    {
        get;
        set;
    }

    [JsonProperty("m_fImmuneToGunGameDamageTimeLast")]
    [JsonPropertyName("m_fImmuneToGunGameDamageTimeLast")]
    public int? MFImmuneToGunGameDamageTimeLast
    {
        get;
        set;
    }

    [JsonProperty("m_fMolotovDamageTime")]
    [JsonPropertyName("m_fMolotovDamageTime")]
    public int? MFMolotovDamageTime
    {
        get;
        set;
    }

    [JsonProperty("m_fRenderingClipPlane")]
    [JsonPropertyName("m_fRenderingClipPlane")]
    public int? MFRenderingClipPlane
    {
        get;
        set;
    }

    [JsonProperty("m_fSwitchedHandednessTime")]
    [JsonPropertyName("m_fSwitchedHandednessTime")]
    public int? MFSwitchedHandednessTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDeathInfoTime")]
    [JsonPropertyName("m_flDeathInfoTime")]
    public int? MFlDeathInfoTime
    {
        get;
        set;
    }

    [JsonProperty("m_flEmitSoundTime")]
    [JsonPropertyName("m_flEmitSoundTime")]
    public int? MFlEmitSoundTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFlinchStack")]
    [JsonPropertyName("m_flFlinchStack")]
    public int? MFlFlinchStack
    {
        get;
        set;
    }

    [JsonProperty("m_flHealthShotBoostExpirationTime")]
    [JsonPropertyName("m_flHealthShotBoostExpirationTime")]
    public int? MFlHealthShotBoostExpirationTime
    {
        get;
        set;
    }

    [JsonProperty("m_flHitHeading")]
    [JsonPropertyName("m_flHitHeading")]
    public int? MFlHitHeading
    {
        get;
        set;
    }

    [JsonProperty("m_flLandingStartTime")]
    [JsonPropertyName("m_flLandingStartTime")]
    public int? MFlLandingStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLandingTimeSeconds")]
    [JsonPropertyName("m_flLandingTimeSeconds")]
    public int? MFlLandingTimeSeconds
    {
        get;
        set;
    }

    [JsonProperty("m_flLastFiredWeaponTime")]
    [JsonPropertyName("m_flLastFiredWeaponTime")]
    public int? MFlLastFiredWeaponTime
    {
        get;
        set;
    }

    [JsonProperty("m_flNextSprayDecalTime")]
    [JsonPropertyName("m_flNextSprayDecalTime")]
    public int? MFlNextSprayDecalTime
    {
        get;
        set;
    }

    [JsonProperty("m_flOldFallVelocity")]
    [JsonPropertyName("m_flOldFallVelocity")]
    public int? MFlOldFallVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_flSlopeDropHeight")]
    [JsonPropertyName("m_flSlopeDropHeight")]
    public int? MFlSlopeDropHeight
    {
        get;
        set;
    }

    [JsonProperty("m_flSlopeDropOffset")]
    [JsonPropertyName("m_flSlopeDropOffset")]
    public int? MFlSlopeDropOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeOfLastInjury")]
    [JsonPropertyName("m_flTimeOfLastInjury")]
    public int? MFlTimeOfLastInjury
    {
        get;
        set;
    }

    [JsonProperty("m_flVelocityModifier")]
    [JsonPropertyName("m_flVelocityModifier")]
    public int? MFlVelocityModifier
    {
        get;
        set;
    }

    [JsonProperty("m_flViewmodelFOV")]
    [JsonPropertyName("m_flViewmodelFOV")]
    public int? MFlViewmodelFOV
    {
        get;
        set;
    }

    [JsonProperty("m_flViewmodelOffsetX")]
    [JsonPropertyName("m_flViewmodelOffsetX")]
    public int? MFlViewmodelOffsetX
    {
        get;
        set;
    }

    [JsonProperty("m_flViewmodelOffsetY")]
    [JsonPropertyName("m_flViewmodelOffsetY")]
    public int? MFlViewmodelOffsetY
    {
        get;
        set;
    }

    [JsonProperty("m_flViewmodelOffsetZ")]
    [JsonPropertyName("m_flViewmodelOffsetZ")]
    public int? MFlViewmodelOffsetZ
    {
        get;
        set;
    }

    [JsonProperty("m_grenadeParameterStashTime")]
    [JsonPropertyName("m_grenadeParameterStashTime")]
    public int? MGrenadeParameterStashTime
    {
        get;
        set;
    }

    [JsonProperty("m_hHudModelArms")]
    [JsonPropertyName("m_hHudModelArms")]
    public int? MHHudModelArms
    {
        get;
        set;
    }

    [JsonProperty("m_holdTargetIDTimer")]
    [JsonPropertyName("m_holdTargetIDTimer")]
    public int? MHoldTargetIDTimer
    {
        get;
        set;
    }

    [JsonProperty("m_iBlockingUseActionInProgress")]
    [JsonPropertyName("m_iBlockingUseActionInProgress")]
    public int? MIBlockingUseActionInProgress
    {
        get;
        set;
    }

    [JsonProperty("m_iIDEntIndex")]
    [JsonPropertyName("m_iIDEntIndex")]
    public int? MIIDEntIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iOldIDEntIndex")]
    [JsonPropertyName("m_iOldIDEntIndex")]
    public int? MIOldIDEntIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iRetakesMVPBoostItem")]
    [JsonPropertyName("m_iRetakesMVPBoostItem")]
    public int? MIRetakesMVPBoostItem
    {
        get;
        set;
    }

    [JsonProperty("m_iRetakesOffering")]
    [JsonPropertyName("m_iRetakesOffering")]
    public int? MIRetakesOffering
    {
        get;
        set;
    }

    [JsonProperty("m_iRetakesOfferingCard")]
    [JsonPropertyName("m_iRetakesOfferingCard")]
    public int? MIRetakesOfferingCard
    {
        get;
        set;
    }

    [JsonProperty("m_iShotsFired")]
    [JsonPropertyName("m_iShotsFired")]
    public int? MIShotsFired
    {
        get;
        set;
    }

    [JsonProperty("m_iTargetItemEntIdx")]
    [JsonPropertyName("m_iTargetItemEntIdx")]
    public int? MITargetItemEntIdx
    {
        get;
        set;
    }

    [JsonProperty("m_ignoreLadderJumpTime")]
    [JsonPropertyName("m_ignoreLadderJumpTime")]
    public int? MIgnoreLadderJumpTime
    {
        get;
        set;
    }

    [JsonProperty("m_lastLandTime")]
    [JsonPropertyName("m_lastLandTime")]
    public int? MLastLandTime
    {
        get;
        set;
    }

    [JsonProperty("m_nEconGlovesChanged")]
    [JsonPropertyName("m_nEconGlovesChanged")]
    public int? MNEconGlovesChanged
    {
        get;
        set;
    }

    [JsonProperty("m_nHighestAppliedDamageTagTick")]
    [JsonPropertyName("m_nHighestAppliedDamageTagTick")]
    public int? MNHighestAppliedDamageTagTick
    {
        get;
        set;
    }

    [JsonProperty("m_nHitBodyPart")]
    [JsonPropertyName("m_nHitBodyPart")]
    public int? MNHitBodyPart
    {
        get;
        set;
    }

    [JsonProperty("m_nLastClipPlaneSetupFrame")]
    [JsonPropertyName("m_nLastClipPlaneSetupFrame")]
    public int? MNLastClipPlaneSetupFrame
    {
        get;
        set;
    }

    [JsonProperty("m_nLastKillerIndex")]
    [JsonPropertyName("m_nLastKillerIndex")]
    public int? MNLastKillerIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nPlayerInfernoBodyFx")]
    [JsonPropertyName("m_nPlayerInfernoBodyFx")]
    public int? MNPlayerInfernoBodyFx
    {
        get;
        set;
    }

    [JsonProperty("m_nPrevArmorVal")]
    [JsonPropertyName("m_nPrevArmorVal")]
    public int? MNPrevArmorVal
    {
        get;
        set;
    }

    [JsonProperty("m_nPrevGrenadeAmmoCount")]
    [JsonPropertyName("m_nPrevGrenadeAmmoCount")]
    public int? MNPrevGrenadeAmmoCount
    {
        get;
        set;
    }

    [JsonProperty("m_nPrevHighestReceivedDamageTagTick")]
    [JsonPropertyName("m_nPrevHighestReceivedDamageTagTick")]
    public int? MNPrevHighestReceivedDamageTagTick
    {
        get;
        set;
    }

    [JsonProperty("m_nRagdollDamageBone")]
    [JsonPropertyName("m_nRagdollDamageBone")]
    public int? MNRagdollDamageBone
    {
        get;
        set;
    }

    [JsonProperty("m_nWhichBombZone")]
    [JsonPropertyName("m_nWhichBombZone")]
    public int? MNWhichBombZone
    {
        get;
        set;
    }

    [JsonProperty("m_pActionTrackingServices")]
    [JsonPropertyName("m_pActionTrackingServices")]
    public int? MPActionTrackingServices
    {
        get;
        set;
    }

    [JsonProperty("m_pBulletServices")]
    [JsonPropertyName("m_pBulletServices")]
    public int? MPBulletServices
    {
        get;
        set;
    }

    [JsonProperty("m_pBuyServices")]
    [JsonPropertyName("m_pBuyServices")]
    public int? MPBuyServices
    {
        get;
        set;
    }

    [JsonProperty("m_pClippingWeapon")]
    [JsonPropertyName("m_pClippingWeapon")]
    public int? MPClippingWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_pDamageReactServices")]
    [JsonPropertyName("m_pDamageReactServices")]
    public int? MPDamageReactServices
    {
        get;
        set;
    }

    [JsonProperty("m_pGlowServices")]
    [JsonPropertyName("m_pGlowServices")]
    public int? MPGlowServices
    {
        get;
        set;
    }

    [JsonProperty("m_pHostageServices")]
    [JsonPropertyName("m_pHostageServices")]
    public int? MPHostageServices
    {
        get;
        set;
    }

    [JsonProperty("m_qDeathEyeAngles")]
    [JsonPropertyName("m_qDeathEyeAngles")]
    public int? MQDeathEyeAngles
    {
        get;
        set;
    }

    [JsonProperty("m_szLastPlaceName")]
    [JsonPropertyName("m_szLastPlaceName")]
    public int? MSzLastPlaceName
    {
        get;
        set;
    }

    [JsonProperty("m_szRagdollDamageWeaponName")]
    [JsonPropertyName("m_szRagdollDamageWeaponName")]
    public int? MSzRagdollDamageWeaponName
    {
        get;
        set;
    }

    [JsonProperty("m_thirdPersonHeading")]
    [JsonPropertyName("m_thirdPersonHeading")]
    public int? MThirdPersonHeading
    {
        get;
        set;
    }

    [JsonProperty("m_unCurrentEquipmentValue")]
    [JsonPropertyName("m_unCurrentEquipmentValue")]
    public int? MUnCurrentEquipmentValue
    {
        get;
        set;
    }

    [JsonProperty("m_unFreezetimeEndEquipmentValue")]
    [JsonPropertyName("m_unFreezetimeEndEquipmentValue")]
    public int? MUnFreezetimeEndEquipmentValue
    {
        get;
        set;
    }

    [JsonProperty("m_unPreviousWeaponHash")]
    [JsonPropertyName("m_unPreviousWeaponHash")]
    public int? MUnPreviousWeaponHash
    {
        get;
        set;
    }

    [JsonProperty("m_unRoundStartEquipmentValue")]
    [JsonPropertyName("m_unRoundStartEquipmentValue")]
    public int? MUnRoundStartEquipmentValue
    {
        get;
        set;
    }

    [JsonProperty("m_unWeaponHash")]
    [JsonPropertyName("m_unWeaponHash")]
    public int? MUnWeaponHash
    {
        get;
        set;
    }

    [JsonProperty("m_vHeadConstraintOffset")]
    [JsonPropertyName("m_vHeadConstraintOffset")]
    public int? MVHeadConstraintOffset
    {
        get;
        set;
    }

    [JsonProperty("m_vRagdollDamageForce")]
    [JsonPropertyName("m_vRagdollDamageForce")]
    public int? MVRagdollDamageForce
    {
        get;
        set;
    }

    [JsonProperty("m_vRagdollDamagePosition")]
    [JsonPropertyName("m_vRagdollDamagePosition")]
    public int? MVRagdollDamagePosition
    {
        get;
        set;
    }

    [JsonProperty("m_vRagdollServerOrigin")]
    [JsonPropertyName("m_vRagdollServerOrigin")]
    public int? MVRagdollServerOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecBulletHitModels")]
    [JsonPropertyName("m_vecBulletHitModels")]
    public int? MVecBulletHitModels
    {
        get;
        set;
    }

    [JsonProperty("m_vecDeathInfoOrigin")]
    [JsonPropertyName("m_vecDeathInfoOrigin")]
    public int? MVecDeathInfoOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecLastAliveLocalVelocity")]
    [JsonPropertyName("m_vecLastAliveLocalVelocity")]
    public int? MVecLastAliveLocalVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecLastClipCameraForward")]
    [JsonPropertyName("m_vecLastClipCameraForward")]
    public int? MVecLastClipCameraForward
    {
        get;
        set;
    }

    [JsonProperty("m_vecLastClipCameraPos")]
    [JsonPropertyName("m_vecLastClipCameraPos")]
    public int? MVecLastClipCameraPos
    {
        get;
        set;
    }

    [JsonProperty("m_vecPlayerPatchEconIndices")]
    [JsonPropertyName("m_vecPlayerPatchEconIndices")]
    public int? MVecPlayerPatchEconIndices
    {
        get;
        set;
    }

    [JsonProperty("m_vecStashedGrenadeThrowPosition")]
    [JsonPropertyName("m_vecStashedGrenadeThrowPosition")]
    public int? MVecStashedGrenadeThrowPosition
    {
        get;
        set;
    }

    [JsonProperty("m_vecStashedVelocity")]
    [JsonPropertyName("m_vecStashedVelocity")]
    public int? MVecStashedVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecThrowPositionHistory")]
    [JsonPropertyName("m_vecThrowPositionHistory")]
    public int? MVecThrowPositionHistory
    {
        get;
        set;
    }

    [JsonProperty("m_vecVelocityHistory")]
    [JsonPropertyName("m_vecVelocityHistory")]
    public int? MVecVelocityHistory
    {
        get;
        set;
    }

    [JsonProperty("m_bDeferStartMusicOnWarmup")]
    [JsonPropertyName("m_bDeferStartMusicOnWarmup")]
    public int? MBDeferStartMusicOnWarmup
    {
        get;
        set;
    }

    [JsonProperty("m_bFlashBuildUp")]
    [JsonPropertyName("m_bFlashBuildUp")]
    public int? MBFlashBuildUp
    {
        get;
        set;
    }

    [JsonProperty("m_bFlashDspHasBeenCleared")]
    [JsonPropertyName("m_bFlashDspHasBeenCleared")]
    public int? MBFlashDspHasBeenCleared
    {
        get;
        set;
    }

    [JsonProperty("m_bFlashScreenshotHasBeenGrabbed")]
    [JsonPropertyName("m_bFlashScreenshotHasBeenGrabbed")]
    public int? MBFlashScreenshotHasBeenGrabbed
    {
        get;
        set;
    }

    [JsonProperty("m_bHasMovedSinceSpawn")]
    [JsonPropertyName("m_bHasMovedSinceSpawn")]
    public int? MBHasMovedSinceSpawn
    {
        get;
        set;
    }

    [JsonProperty("m_fNextThinkPushAway")]
    [JsonPropertyName("m_fNextThinkPushAway")]
    public int? MFNextThinkPushAway
    {
        get;
        set;
    }

    [JsonProperty("m_flClientDeathTime")]
    [JsonPropertyName("m_flClientDeathTime")]
    public int? MFlClientDeathTime
    {
        get;
        set;
    }

    [JsonProperty("m_flClientHealthFadeChangeTimestamp")]
    [JsonPropertyName("m_flClientHealthFadeChangeTimestamp")]
    public int? MFlClientHealthFadeChangeTimestamp
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentMusicStartTime")]
    [JsonPropertyName("m_flCurrentMusicStartTime")]
    public int? MFlCurrentMusicStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFlashBangTime")]
    [JsonPropertyName("m_flFlashBangTime")]
    public int? MFlFlashBangTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFlashDuration")]
    [JsonPropertyName("m_flFlashDuration")]
    public int? MFlFlashDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flFlashMaxAlpha")]
    [JsonPropertyName("m_flFlashMaxAlpha")]
    public int? MFlFlashMaxAlpha
    {
        get;
        set;
    }

    [JsonProperty("m_flFlashOverlayAlpha")]
    [JsonPropertyName("m_flFlashOverlayAlpha")]
    public int? MFlFlashOverlayAlpha
    {
        get;
        set;
    }

    [JsonProperty("m_flFlashScreenshotAlpha")]
    [JsonPropertyName("m_flFlashScreenshotAlpha")]
    public int? MFlFlashScreenshotAlpha
    {
        get;
        set;
    }

    [JsonProperty("m_flLastSmokeAge")]
    [JsonPropertyName("m_flLastSmokeAge")]
    public int? MFlLastSmokeAge
    {
        get;
        set;
    }

    [JsonProperty("m_flLastSmokeOverlayAlpha")]
    [JsonPropertyName("m_flLastSmokeOverlayAlpha")]
    public int? MFlLastSmokeOverlayAlpha
    {
        get;
        set;
    }

    [JsonProperty("m_flLastSpawnTimeIndex")]
    [JsonPropertyName("m_flLastSpawnTimeIndex")]
    public int? MFlLastSpawnTimeIndex
    {
        get;
        set;
    }

    [JsonProperty("m_flMusicRoundStartTime")]
    [JsonPropertyName("m_flMusicRoundStartTime")]
    public int? MFlMusicRoundStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flProgressBarStartTime")]
    [JsonPropertyName("m_flProgressBarStartTime")]
    public int? MFlProgressBarStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_hOriginalController")]
    [JsonPropertyName("m_hOriginalController")]
    public int? MHOriginalController
    {
        get;
        set;
    }

    [JsonProperty("m_iPlayerState")]
    [JsonPropertyName("m_iPlayerState")]
    public int? MIPlayerState
    {
        get;
        set;
    }

    [JsonProperty("m_iProgressBarDuration")]
    [JsonPropertyName("m_iProgressBarDuration")]
    public int? MIProgressBarDuration
    {
        get;
        set;
    }

    [JsonProperty("m_nClientHealthFadeParityValue")]
    [JsonPropertyName("m_nClientHealthFadeParityValue")]
    public int? MNClientHealthFadeParityValue
    {
        get;
        set;
    }

    [JsonProperty("m_pPingServices")]
    [JsonPropertyName("m_pPingServices")]
    public int? MPPingServices
    {
        get;
        set;
    }

    [JsonProperty("m_previousPlayerState")]
    [JsonPropertyName("m_previousPlayerState")]
    public int? MPreviousPlayerState
    {
        get;
        set;
    }

    [JsonProperty("m_vLastSmokeOverlayColor")]
    [JsonPropertyName("m_vLastSmokeOverlayColor")]
    public int? MVLastSmokeOverlayColor
    {
        get;
        set;
    }

    [JsonProperty("m_bEndMatchNextMapAllVoted")]
    [JsonPropertyName("m_bEndMatchNextMapAllVoted")]
    public int? MBEndMatchNextMapAllVoted
    {
        get;
        set;
    }

    [JsonProperty("m_bHostageAlive")]
    [JsonPropertyName("m_bHostageAlive")]
    public int? MBHostageAlive
    {
        get;
        set;
    }

    [JsonProperty("m_bombsiteCenterA")]
    [JsonPropertyName("m_bombsiteCenterA")]
    public int? MBombsiteCenterA
    {
        get;
        set;
    }

    [JsonProperty("m_bombsiteCenterB")]
    [JsonPropertyName("m_bombsiteCenterB")]
    public int? MBombsiteCenterB
    {
        get;
        set;
    }

    [JsonProperty("m_foundGoalPositions")]
    [JsonPropertyName("m_foundGoalPositions")]
    public int? MFoundGoalPositions
    {
        get;
        set;
    }

    [JsonProperty("m_hostageRescueX")]
    [JsonPropertyName("m_hostageRescueX")]
    public int? MHostageRescueX
    {
        get;
        set;
    }

    [JsonProperty("m_hostageRescueY")]
    [JsonPropertyName("m_hostageRescueY")]
    public int? MHostageRescueY
    {
        get;
        set;
    }

    [JsonProperty("m_hostageRescueZ")]
    [JsonPropertyName("m_hostageRescueZ")]
    public int? MHostageRescueZ
    {
        get;
        set;
    }

    [JsonProperty("m_iHostageEntityIDs")]
    [JsonPropertyName("m_iHostageEntityIDs")]
    public int? MIHostageEntityIDs
    {
        get;
        set;
    }

    [JsonProperty("m_isHostageFollowingSomeone")]
    [JsonPropertyName("m_isHostageFollowingSomeone")]
    public int? MIsHostageFollowingSomeone
    {
        get;
        set;
    }

    [JsonProperty("m_bSurrendered")]
    [JsonPropertyName("m_bSurrendered")]
    public int? MBSurrendered
    {
        get;
        set;
    }

    [JsonProperty("m_iClanID")]
    [JsonPropertyName("m_iClanID")]
    public int? MIClanID
    {
        get;
        set;
    }

    [JsonProperty("m_numMapVictories")]
    [JsonPropertyName("m_numMapVictories")]
    public int? MNumMapVictories
    {
        get;
        set;
    }

    [JsonProperty("m_scoreFirstHalf")]
    [JsonPropertyName("m_scoreFirstHalf")]
    public int? MScoreFirstHalf
    {
        get;
        set;
    }

    [JsonProperty("m_scoreOvertime")]
    [JsonPropertyName("m_scoreOvertime")]
    public int? MScoreOvertime
    {
        get;
        set;
    }

    [JsonProperty("m_scoreSecondHalf")]
    [JsonPropertyName("m_scoreSecondHalf")]
    public int? MScoreSecondHalf
    {
        get;
        set;
    }

    [JsonProperty("m_szClanTeamname")]
    [JsonPropertyName("m_szClanTeamname")]
    public int? MSzClanTeamname
    {
        get;
        set;
    }

    [JsonProperty("m_szTeamFlagImage")]
    [JsonPropertyName("m_szTeamFlagImage")]
    public int? MSzTeamFlagImage
    {
        get;
        set;
    }

    [JsonProperty("m_szTeamLogoImage")]
    [JsonPropertyName("m_szTeamLogoImage")]
    public int? MSzTeamLogoImage
    {
        get;
        set;
    }

    [JsonProperty("m_szTeamMatchStat")]
    [JsonPropertyName("m_szTeamMatchStat")]
    public int? MSzTeamMatchStat
    {
        get;
        set;
    }

    [JsonProperty("m_IronSightController")]
    [JsonPropertyName("m_IronSightController")]
    public int? MIronSightController
    {
        get;
        set;
    }

    [JsonProperty("m_OnPlayerPickup")]
    [JsonPropertyName("m_OnPlayerPickup")]
    public int? MOnPlayerPickup
    {
        get;
        set;
    }

    [JsonProperty("m_bBurstMode")]
    [JsonPropertyName("m_bBurstMode")]
    public int? MBBurstMode
    {
        get;
        set;
    }

    [JsonProperty("m_bClearWeaponIdentifyingUGC")]
    [JsonPropertyName("m_bClearWeaponIdentifyingUGC")]
    public int? MBClearWeaponIdentifyingUGC
    {
        get;
        set;
    }

    [JsonProperty("m_bDroppedNearBuyZone")]
    [JsonPropertyName("m_bDroppedNearBuyZone")]
    public int? MBDroppedNearBuyZone
    {
        get;
        set;
    }

    [JsonProperty("m_bFireOnEmpty")]
    [JsonPropertyName("m_bFireOnEmpty")]
    public int? MBFireOnEmpty
    {
        get;
        set;
    }

    [JsonProperty("m_bInReload")]
    [JsonPropertyName("m_bInReload")]
    public int? MBInReload
    {
        get;
        set;
    }

    [JsonProperty("m_bInspectPending")]
    [JsonPropertyName("m_bInspectPending")]
    public int? MBInspectPending
    {
        get;
        set;
    }

    [JsonProperty("m_bInspectShouldLoop")]
    [JsonPropertyName("m_bInspectShouldLoop")]
    public int? MBInspectShouldLoop
    {
        get;
        set;
    }

    [JsonProperty("m_bIsHauledBack")]
    [JsonPropertyName("m_bIsHauledBack")]
    public int? MBIsHauledBack
    {
        get;
        set;
    }

    [JsonProperty("m_bSilencerOn")]
    [JsonPropertyName("m_bSilencerOn")]
    public int? MBSilencerOn
    {
        get;
        set;
    }

    [JsonProperty("m_bUIWeapon")]
    [JsonPropertyName("m_bUIWeapon")]
    public int? MBUIWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_bVisualsDataSet")]
    [JsonPropertyName("m_bVisualsDataSet")]
    public int? MBVisualsDataSet
    {
        get;
        set;
    }

    [JsonProperty("m_bWasActiveWeaponWhenDropped")]
    [JsonPropertyName("m_bWasActiveWeaponWhenDropped")]
    public int? MBWasActiveWeaponWhenDropped
    {
        get;
        set;
    }

    [JsonProperty("m_bWasOwnedByCT")]
    [JsonPropertyName("m_bWasOwnedByCT")]
    public int? MBWasOwnedByCT
    {
        get;
        set;
    }

    [JsonProperty("m_bWasOwnedByTerrorist")]
    [JsonPropertyName("m_bWasOwnedByTerrorist")]
    public int? MBWasOwnedByTerrorist
    {
        get;
        set;
    }

    [JsonProperty("m_donated")]
    [JsonPropertyName("m_donated")]
    public int? MDonated
    {
        get;
        set;
    }

    [JsonProperty("m_fAccuracyPenalty")]
    [JsonPropertyName("m_fAccuracyPenalty")]
    public int? MFAccuracyPenalty
    {
        get;
        set;
    }

    [JsonProperty("m_fAccuracySmoothedForZoom")]
    [JsonPropertyName("m_fAccuracySmoothedForZoom")]
    public int? MFAccuracySmoothedForZoom
    {
        get;
        set;
    }

    [JsonProperty("m_fLastShotTime")]
    [JsonPropertyName("m_fLastShotTime")]
    public int? MFLastShotTime
    {
        get;
        set;
    }

    [JsonProperty("m_flCrosshairDistance")]
    [JsonPropertyName("m_flCrosshairDistance")]
    public int? MFlCrosshairDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flDroppedAtTime")]
    [JsonPropertyName("m_flDroppedAtTime")]
    public int? MFlDroppedAtTime
    {
        get;
        set;
    }

    [JsonProperty("m_flInspectCancelCompleteTime")]
    [JsonPropertyName("m_flInspectCancelCompleteTime")]
    public int? MFlInspectCancelCompleteTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastAccuracyUpdateTime")]
    [JsonPropertyName("m_flLastAccuracyUpdateTime")]
    public int? MFlLastAccuracyUpdateTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastBurstModeChangeTime")]
    [JsonPropertyName("m_flLastBurstModeChangeTime")]
    public int? MFlLastBurstModeChangeTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastLOSTraceFailureTime")]
    [JsonPropertyName("m_flLastLOSTraceFailureTime")]
    public int? MFlLastLOSTraceFailureTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastShakeTime")]
    [JsonPropertyName("m_flLastShakeTime")]
    public int? MFlLastShakeTime
    {
        get;
        set;
    }

    [JsonProperty("m_flNextAttackRenderTimeOffset")]
    [JsonPropertyName("m_flNextAttackRenderTimeOffset")]
    public int? MFlNextAttackRenderTimeOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flNextClientFireBulletTime")]
    [JsonPropertyName("m_flNextClientFireBulletTime")]
    public int? MFlNextClientFireBulletTime
    {
        get;
        set;
    }

    [JsonProperty("m_flNextClientFireBulletTime_Repredict")]
    [JsonPropertyName("m_flNextClientFireBulletTime_Repredict")]
    public int? MFlNextClientFireBulletTimeRepredict
    {
        get;
        set;
    }

    [JsonProperty("m_flPostponeFireReadyFrac")]
    [JsonPropertyName("m_flPostponeFireReadyFrac")]
    public int? MFlPostponeFireReadyFrac
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoilIndex")]
    [JsonPropertyName("m_flRecoilIndex")]
    public int? MFlRecoilIndex
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeSilencerSwitchComplete")]
    [JsonPropertyName("m_flTimeSilencerSwitchComplete")]
    public int? MFlTimeSilencerSwitchComplete
    {
        get;
        set;
    }

    [JsonProperty("m_flTurningInaccuracy")]
    [JsonPropertyName("m_flTurningInaccuracy")]
    public int? MFlTurningInaccuracy
    {
        get;
        set;
    }

    [JsonProperty("m_flTurningInaccuracyDelta")]
    [JsonPropertyName("m_flTurningInaccuracyDelta")]
    public int? MFlTurningInaccuracyDelta
    {
        get;
        set;
    }

    [JsonProperty("m_flWatTickOffset")]
    [JsonPropertyName("m_flWatTickOffset")]
    public int? MFlWatTickOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flWeaponGameplayAnimStateTimestamp")]
    [JsonPropertyName("m_flWeaponGameplayAnimStateTimestamp")]
    public int? MFlWeaponGameplayAnimStateTimestamp
    {
        get;
        set;
    }

    [JsonProperty("m_hPrevOwner")]
    [JsonPropertyName("m_hPrevOwner")]
    public int? MHPrevOwner
    {
        get;
        set;
    }

    [JsonProperty("m_iAmmoLastCheck")]
    [JsonPropertyName("m_iAmmoLastCheck")]
    public int? MIAmmoLastCheck
    {
        get;
        set;
    }

    [JsonProperty("m_iIronSightMode")]
    [JsonPropertyName("m_iIronSightMode")]
    public int? MIIronSightMode
    {
        get;
        set;
    }

    [JsonProperty("m_iMostRecentTeamNumber")]
    [JsonPropertyName("m_iMostRecentTeamNumber")]
    public int? MIMostRecentTeamNumber
    {
        get;
        set;
    }

    [JsonProperty("m_iOriginalTeamNumber")]
    [JsonPropertyName("m_iOriginalTeamNumber")]
    public int? MIOriginalTeamNumber
    {
        get;
        set;
    }

    [JsonProperty("m_iRecoilIndex")]
    [JsonPropertyName("m_iRecoilIndex")]
    public int? MIRecoilIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iWeaponGameplayAnimState")]
    [JsonPropertyName("m_iWeaponGameplayAnimState")]
    public int? MIWeaponGameplayAnimState
    {
        get;
        set;
    }

    [JsonProperty("m_nCustomEconReloadEventId")]
    [JsonPropertyName("m_nCustomEconReloadEventId")]
    public int? MNCustomEconReloadEventId
    {
        get;
        set;
    }

    [JsonProperty("m_nDropTick")]
    [JsonPropertyName("m_nDropTick")]
    public int? MNDropTick
    {
        get;
        set;
    }

    [JsonProperty("m_nLastEmptySoundCmdNum")]
    [JsonPropertyName("m_nLastEmptySoundCmdNum")]
    public int? MNLastEmptySoundCmdNum
    {
        get;
        set;
    }

    [JsonProperty("m_nPostponeFireReadyTicks")]
    [JsonPropertyName("m_nPostponeFireReadyTicks")]
    public int? MNPostponeFireReadyTicks
    {
        get;
        set;
    }

    [JsonProperty("m_nextPrevOwnerUseTime")]
    [JsonPropertyName("m_nextPrevOwnerUseTime")]
    public int? MNextPrevOwnerUseTime
    {
        get;
        set;
    }

    [JsonProperty("m_vecTurningInaccuracyEyeDirLast")]
    [JsonPropertyName("m_vecTurningInaccuracyEyeDirLast")]
    public int? MVecTurningInaccuracyEyeDirLast
    {
        get;
        set;
    }

    [JsonProperty("m_weaponMode")]
    [JsonPropertyName("m_weaponMode")]
    public int? MWeaponMode
    {
        get;
        set;
    }

    [JsonProperty("m_bNeedsBoltAction")]
    [JsonPropertyName("m_bNeedsBoltAction")]
    public int? MBNeedsBoltAction
    {
        get;
        set;
    }

    [JsonProperty("m_iBurstShotsRemaining")]
    [JsonPropertyName("m_iBurstShotsRemaining")]
    public int? MIBurstShotsRemaining
    {
        get;
        set;
    }

    [JsonProperty("m_iSilencerBodygroup")]
    [JsonPropertyName("m_iSilencerBodygroup")]
    public int? MISilencerBodygroup
    {
        get;
        set;
    }

    [JsonProperty("m_inPrecache")]
    [JsonPropertyName("m_inPrecache")]
    public int? MInPrecache
    {
        get;
        set;
    }

    [JsonProperty("m_nRevolverCylinderIdx")]
    [JsonPropertyName("m_nRevolverCylinderIdx")]
    public int? MNRevolverCylinderIdx
    {
        get;
        set;
    }

    [JsonProperty("m_silencedModelIndex")]
    [JsonPropertyName("m_silencedModelIndex")]
    public int? MSilencedModelIndex
    {
        get;
        set;
    }

    [JsonProperty("m_zoomLevel")]
    [JsonPropertyName("m_zoomLevel")]
    public int? MZoomLevel
    {
        get;
        set;
    }

    [JsonProperty("m_AttributeManager")]
    [JsonPropertyName("m_AttributeManager")]
    public int? MAttributeManager
    {
        get;
        set;
    }

    [JsonProperty("m_bAttributesInitialized")]
    [JsonPropertyName("m_bAttributesInitialized")]
    public int? MBAttributesInitialized
    {
        get;
        set;
    }

    [JsonProperty("m_bIsPreviewModel")]
    [JsonPropertyName("m_bIsPreviewModel")]
    public int? MBIsPreviewModel
    {
        get;
        set;
    }

    [JsonProperty("m_hHolidayHatAddon")]
    [JsonPropertyName("m_hHolidayHatAddon")]
    public int? MHHolidayHatAddon
    {
        get;
        set;
    }

    [JsonProperty("m_hWaterWakeParticles")]
    [JsonPropertyName("m_hWaterWakeParticles")]
    public int? MHWaterWakeParticles
    {
        get;
        set;
    }

    [JsonProperty("m_jumpedThisFrame")]
    [JsonPropertyName("m_jumpedThisFrame")]
    public int? MJumpedThisFrame
    {
        get;
        set;
    }

    [JsonProperty("m_leader")]
    [JsonPropertyName("m_leader")]
    public int? MLeader
    {
        get;
        set;
    }

    [JsonProperty("m_WeaponSequence")]
    [JsonPropertyName("m_WeaponSequence")]
    public int? MWeaponSequence
    {
        get;
        set;
    }

    [JsonProperty("m_bFadeOut")]
    [JsonPropertyName("m_bFadeOut")]
    public int? MBFadeOut
    {
        get;
        set;
    }

    [JsonProperty("m_bFadingOut")]
    [JsonPropertyName("m_bFadingOut")]
    public int? MBFadingOut
    {
        get;
        set;
    }

    [JsonProperty("m_bImportant")]
    [JsonPropertyName("m_bImportant")]
    public int? MBImportant
    {
        get;
        set;
    }

    [JsonProperty("m_bReleaseRagdoll")]
    [JsonPropertyName("m_bReleaseRagdoll")]
    public int? MBReleaseRagdoll
    {
        get;
        set;
    }

    [JsonProperty("m_flEffectTime")]
    [JsonPropertyName("m_flEffectTime")]
    public int? MFlEffectTime
    {
        get;
        set;
    }

    [JsonProperty("m_flScaleEnd")]
    [JsonPropertyName("m_flScaleEnd")]
    public int? MFlScaleEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flScaleTimeEnd")]
    [JsonPropertyName("m_flScaleTimeEnd")]
    public int? MFlScaleTimeEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flScaleTimeStart")]
    [JsonPropertyName("m_flScaleTimeStart")]
    public int? MFlScaleTimeStart
    {
        get;
        set;
    }

    [JsonProperty("m_gibDespawnTime")]
    [JsonPropertyName("m_gibDespawnTime")]
    public int? MGibDespawnTime
    {
        get;
        set;
    }

    [JsonProperty("m_iCurrentFriction")]
    [JsonPropertyName("m_iCurrentFriction")]
    public int? MICurrentFriction
    {
        get;
        set;
    }

    [JsonProperty("m_iFrictionAnimState")]
    [JsonPropertyName("m_iFrictionAnimState")]
    public int? MIFrictionAnimState
    {
        get;
        set;
    }

    [JsonProperty("m_iMaxFriction")]
    [JsonPropertyName("m_iMaxFriction")]
    public int? MIMaxFriction
    {
        get;
        set;
    }

    [JsonProperty("m_iMinFriction")]
    [JsonPropertyName("m_iMinFriction")]
    public int? MIMinFriction
    {
        get;
        set;
    }

    [JsonProperty("m_MaxFalloff")]
    [JsonPropertyName("m_MaxFalloff")]
    public int? MMaxFalloff
    {
        get;
        set;
    }

    [JsonProperty("m_MinFalloff")]
    [JsonPropertyName("m_MinFalloff")]
    public int? MMinFalloff
    {
        get;
        set;
    }

    [JsonProperty("m_bClientSide")]
    [JsonPropertyName("m_bClientSide")]
    public int? MBClientSide
    {
        get;
        set;
    }

    [JsonProperty("m_bEnabledOnClient")]
    [JsonPropertyName("m_bEnabledOnClient")]
    public int? MBEnabledOnClient
    {
        get;
        set;
    }

    [JsonProperty("m_bExclusive")]
    [JsonPropertyName("m_bExclusive")]
    public int? MBExclusive
    {
        get;
        set;
    }

    [JsonProperty("m_bFadingIn")]
    [JsonPropertyName("m_bFadingIn")]
    public int? MBFadingIn
    {
        get;
        set;
    }

    [JsonProperty("m_bMaster")]
    [JsonPropertyName("m_bMaster")]
    public int? MBMaster
    {
        get;
        set;
    }

    [JsonProperty("m_flCurWeight")]
    [JsonPropertyName("m_flCurWeight")]
    public int? MFlCurWeight
    {
        get;
        set;
    }

    [JsonProperty("m_flCurWeightOnClient")]
    [JsonPropertyName("m_flCurWeightOnClient")]
    public int? MFlCurWeightOnClient
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeDuration")]
    [JsonPropertyName("m_flFadeDuration")]
    public int? MFlFadeDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeInDuration")]
    [JsonPropertyName("m_flFadeInDuration")]
    public int? MFlFadeInDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeOutDuration")]
    [JsonPropertyName("m_flFadeOutDuration")]
    public int? MFlFadeOutDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeStartTime")]
    [JsonPropertyName("m_flFadeStartTime")]
    public int? MFlFadeStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeStartWeight")]
    [JsonPropertyName("m_flFadeStartWeight")]
    public int? MFlFadeStartWeight
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxWeight")]
    [JsonPropertyName("m_flMaxWeight")]
    public int? MFlMaxWeight
    {
        get;
        set;
    }

    [JsonProperty("m_netlookupFilename")]
    [JsonPropertyName("m_netlookupFilename")]
    public int? MNetlookupFilename
    {
        get;
        set;
    }

    [JsonProperty("m_vecOrigin")]
    [JsonPropertyName("m_vecOrigin")]
    public int? MVecOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_FadeDuration")]
    [JsonPropertyName("m_FadeDuration")]
    public int? MFadeDuration
    {
        get;
        set;
    }

    [JsonProperty("m_LastEnterTime")]
    [JsonPropertyName("m_LastEnterTime")]
    public int? MLastEnterTime
    {
        get;
        set;
    }

    [JsonProperty("m_LastEnterWeight")]
    [JsonPropertyName("m_LastEnterWeight")]
    public int? MLastEnterWeight
    {
        get;
        set;
    }

    [JsonProperty("m_LastExitTime")]
    [JsonPropertyName("m_LastExitTime")]
    public int? MLastExitTime
    {
        get;
        set;
    }

    [JsonProperty("m_LastExitWeight")]
    [JsonPropertyName("m_LastExitWeight")]
    public int? MLastExitWeight
    {
        get;
        set;
    }

    [JsonProperty("m_MaxWeight")]
    [JsonPropertyName("m_MaxWeight")]
    public int? MMaxWeight
    {
        get;
        set;
    }

    [JsonProperty("m_Weight")]
    [JsonPropertyName("m_Weight")]
    public int? MWeight
    {
        get;
        set;
    }

    [JsonProperty("m_lookupFilename")]
    [JsonPropertyName("m_lookupFilename")]
    public int? MLookupFilename
    {
        get;
        set;
    }

    [JsonProperty("m_cameraName")]
    [JsonPropertyName("m_cameraName")]
    public int? MCameraName
    {
        get;
        set;
    }

    [JsonProperty("m_flCsmFovOverrideValue")]
    [JsonPropertyName("m_flCsmFovOverrideValue")]
    public int? MFlCsmFovOverrideValue
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeParticleEffectSpawn")]
    [JsonPropertyName("m_flTimeParticleEffectSpawn")]
    public int? MFlTimeParticleEffectSpawn
    {
        get;
        set;
    }

    [JsonProperty("m_nClientLastKnownDecoyShotTick")]
    [JsonPropertyName("m_nClientLastKnownDecoyShotTick")]
    public int? MNClientLastKnownDecoyShotTick
    {
        get;
        set;
    }

    [JsonProperty("m_nDecoyShotTick")]
    [JsonPropertyName("m_nDecoyShotTick")]
    public int? MNDecoyShotTick
    {
        get;
        set;
    }

    [JsonProperty("m_Exponent")]
    [JsonPropertyName("m_Exponent")]
    public int? MExponent
    {
        get;
        set;
    }

    [JsonProperty("m_Flags")]
    [JsonPropertyName("m_Flags")]
    public int? MFlags
    {
        get;
        set;
    }

    [JsonProperty("m_InnerAngle")]
    [JsonPropertyName("m_InnerAngle")]
    public int? MInnerAngle
    {
        get;
        set;
    }

    [JsonProperty("m_LightStyle")]
    [JsonPropertyName("m_LightStyle")]
    public int? MLightStyle
    {
        get;
        set;
    }

    [JsonProperty("m_OuterAngle")]
    [JsonPropertyName("m_OuterAngle")]
    public int? MOuterAngle
    {
        get;
        set;
    }

    [JsonProperty("m_Radius")]
    [JsonPropertyName("m_Radius")]
    public int? MRadius
    {
        get;
        set;
    }

    [JsonProperty("m_SpotRadius")]
    [JsonPropertyName("m_SpotRadius")]
    public int? MSpotRadius
    {
        get;
        set;
    }

    [JsonProperty("m_OnAnimReachedEnd")]
    [JsonPropertyName("m_OnAnimReachedEnd")]
    public int? MOnAnimReachedEnd
    {
        get;
        set;
    }

    [JsonProperty("m_OnAnimReachedStart")]
    [JsonPropertyName("m_OnAnimReachedStart")]
    public int? MOnAnimReachedStart
    {
        get;
        set;
    }

    [JsonProperty("m_bCreateNonSolid")]
    [JsonPropertyName("m_bCreateNonSolid")]
    public int? MBCreateNonSolid
    {
        get;
        set;
    }

    [JsonProperty("m_bFiredStartEndOutput")]
    [JsonPropertyName("m_bFiredStartEndOutput")]
    public int? MBFiredStartEndOutput
    {
        get;
        set;
    }

    [JsonProperty("m_bForceNpcExclude")]
    [JsonPropertyName("m_bForceNpcExclude")]
    public int? MBForceNpcExclude
    {
        get;
        set;
    }

    [JsonProperty("m_bIsOverrideProp")]
    [JsonPropertyName("m_bIsOverrideProp")]
    public int? MBIsOverrideProp
    {
        get;
        set;
    }

    [JsonProperty("m_bRandomizeCycle")]
    [JsonPropertyName("m_bRandomizeCycle")]
    public int? MBRandomizeCycle
    {
        get;
        set;
    }

    [JsonProperty("m_bStartDisabled")]
    [JsonPropertyName("m_bStartDisabled")]
    public int? MBStartDisabled
    {
        get;
        set;
    }

    [JsonProperty("m_bUseAnimGraph")]
    [JsonPropertyName("m_bUseAnimGraph")]
    public int? MBUseAnimGraph
    {
        get;
        set;
    }

    [JsonProperty("m_bUseHitboxesForRenderBox")]
    [JsonPropertyName("m_bUseHitboxesForRenderBox")]
    public int? MBUseHitboxesForRenderBox
    {
        get;
        set;
    }

    [JsonProperty("m_glowColor")]
    [JsonPropertyName("m_glowColor")]
    public int? MGlowColor
    {
        get;
        set;
    }

    [JsonProperty("m_iCachedFrameCount")]
    [JsonPropertyName("m_iCachedFrameCount")]
    public int? MICachedFrameCount
    {
        get;
        set;
    }

    [JsonProperty("m_iInitialGlowState")]
    [JsonPropertyName("m_iInitialGlowState")]
    public int? MIInitialGlowState
    {
        get;
        set;
    }

    [JsonProperty("m_iszIdleAnim")]
    [JsonPropertyName("m_iszIdleAnim")]
    public int? MIszIdleAnim
    {
        get;
        set;
    }

    [JsonProperty("m_nGlowRange")]
    [JsonPropertyName("m_nGlowRange")]
    public int? MNGlowRange
    {
        get;
        set;
    }

    [JsonProperty("m_nGlowRangeMin")]
    [JsonPropertyName("m_nGlowRangeMin")]
    public int? MNGlowRangeMin
    {
        get;
        set;
    }

    [JsonProperty("m_nGlowTeam")]
    [JsonPropertyName("m_nGlowTeam")]
    public int? MNGlowTeam
    {
        get;
        set;
    }

    [JsonProperty("m_nIdleAnimLoopMode")]
    [JsonPropertyName("m_nIdleAnimLoopMode")]
    public int? MNIdleAnimLoopMode
    {
        get;
        set;
    }

    [JsonProperty("m_pOutputAnimBegun")]
    [JsonPropertyName("m_pOutputAnimBegun")]
    public int? MPOutputAnimBegun
    {
        get;
        set;
    }

    [JsonProperty("m_pOutputAnimLoopCycleOver")]
    [JsonPropertyName("m_pOutputAnimLoopCycleOver")]
    public int? MPOutputAnimLoopCycleOver
    {
        get;
        set;
    }

    [JsonProperty("m_pOutputAnimOver")]
    [JsonPropertyName("m_pOutputAnimOver")]
    public int? MPOutputAnimOver
    {
        get;
        set;
    }

    [JsonProperty("m_vecCachedRenderMaxs")]
    [JsonPropertyName("m_vecCachedRenderMaxs")]
    public int? MVecCachedRenderMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vecCachedRenderMins")]
    [JsonPropertyName("m_vecCachedRenderMins")]
    public int? MVecCachedRenderMins
    {
        get;
        set;
    }

    [JsonProperty("m_flDMBonusStartTime")]
    [JsonPropertyName("m_flDMBonusStartTime")]
    public int? MFlDMBonusStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDMBonusTimeLength")]
    [JsonPropertyName("m_flDMBonusTimeLength")]
    public int? MFlDMBonusTimeLength
    {
        get;
        set;
    }

    [JsonProperty("m_sDMBonusWeapon")]
    [JsonPropertyName("m_sDMBonusWeapon")]
    public int? MSDMBonusWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_OriginalOwnerXuidHigh")]
    [JsonPropertyName("m_OriginalOwnerXuidHigh")]
    public int? MOriginalOwnerXuidHigh
    {
        get;
        set;
    }

    [JsonProperty("m_OriginalOwnerXuidLow")]
    [JsonPropertyName("m_OriginalOwnerXuidLow")]
    public int? MOriginalOwnerXuidLow
    {
        get;
        set;
    }

    [JsonProperty("m_bAttachmentDirty")]
    [JsonPropertyName("m_bAttachmentDirty")]
    public int? MBAttachmentDirty
    {
        get;
        set;
    }

    [JsonProperty("m_bClientside")]
    [JsonPropertyName("m_bClientside")]
    public int? MBClientside
    {
        get;
        set;
    }

    [JsonProperty("m_bParticleSystemsCreated")]
    [JsonPropertyName("m_bParticleSystemsCreated")]
    public int? MBParticleSystemsCreated
    {
        get;
        set;
    }

    [JsonProperty("m_flFallbackWear")]
    [JsonPropertyName("m_flFallbackWear")]
    public int? MFlFallbackWear
    {
        get;
        set;
    }

    [JsonProperty("m_flFlexDelayTime")]
    [JsonPropertyName("m_flFlexDelayTime")]
    public int? MFlFlexDelayTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFlexDelayedWeight")]
    [JsonPropertyName("m_flFlexDelayedWeight")]
    public int? MFlFlexDelayedWeight
    {
        get;
        set;
    }

    [JsonProperty("m_hOldProvidee")]
    [JsonPropertyName("m_hOldProvidee")]
    public int? MHOldProvidee
    {
        get;
        set;
    }

    [JsonProperty("m_hViewmodelAttachment")]
    [JsonPropertyName("m_hViewmodelAttachment")]
    public int? MHViewmodelAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_iNumOwnerValidationRetries")]
    [JsonPropertyName("m_iNumOwnerValidationRetries")]
    public int? MINumOwnerValidationRetries
    {
        get;
        set;
    }

    [JsonProperty("m_iOldTeam")]
    [JsonPropertyName("m_iOldTeam")]
    public int? MIOldTeam
    {
        get;
        set;
    }

    [JsonProperty("m_nFallbackPaintKit")]
    [JsonPropertyName("m_nFallbackPaintKit")]
    public int? MNFallbackPaintKit
    {
        get;
        set;
    }

    [JsonProperty("m_nFallbackSeed")]
    [JsonPropertyName("m_nFallbackSeed")]
    public int? MNFallbackSeed
    {
        get;
        set;
    }

    [JsonProperty("m_nFallbackStatTrak")]
    [JsonPropertyName("m_nFallbackStatTrak")]
    public int? MNFallbackStatTrak
    {
        get;
        set;
    }

    [JsonProperty("m_nUnloadedModelIndex")]
    [JsonPropertyName("m_nUnloadedModelIndex")]
    public int? MNUnloadedModelIndex
    {
        get;
        set;
    }

    [JsonProperty("m_vecAttachedModels")]
    [JsonPropertyName("m_vecAttachedModels")]
    public int? MVecAttachedModels
    {
        get;
        set;
    }

    [JsonProperty("m_vecAttachedParticles")]
    [JsonPropertyName("m_vecAttachedParticles")]
    public int? MVecAttachedParticles
    {
        get;
        set;
    }

    [JsonProperty("m_iModelDisplayFlags")]
    [JsonPropertyName("m_iModelDisplayFlags")]
    public int? MIModelDisplayFlags
    {
        get;
        set;
    }

    [JsonProperty("m_AttributeList")]
    [JsonPropertyName("m_AttributeList")]
    public int? MAttributeList
    {
        get;
        set;
    }

    [JsonProperty("m_NetworkedDynamicAttributes")]
    [JsonPropertyName("m_NetworkedDynamicAttributes")]
    public int? MNetworkedDynamicAttributes
    {
        get;
        set;
    }

    [JsonProperty("m_bDisallowSOC")]
    [JsonPropertyName("m_bDisallowSOC")]
    public int? MBDisallowSOC
    {
        get;
        set;
    }

    [JsonProperty("m_bInitialized")]
    [JsonPropertyName("m_bInitialized")]
    public int? MBInitialized
    {
        get;
        set;
    }

    [JsonProperty("m_bInitializedTags")]
    [JsonPropertyName("m_bInitializedTags")]
    public int? MBInitializedTags
    {
        get;
        set;
    }

    [JsonProperty("m_bInventoryImageRgbaRequested")]
    [JsonPropertyName("m_bInventoryImageRgbaRequested")]
    public int? MBInventoryImageRgbaRequested
    {
        get;
        set;
    }

    [JsonProperty("m_bInventoryImageTriedCache")]
    [JsonPropertyName("m_bInventoryImageTriedCache")]
    public int? MBInventoryImageTriedCache
    {
        get;
        set;
    }

    [JsonProperty("m_bIsStoreItem")]
    [JsonPropertyName("m_bIsStoreItem")]
    public int? MBIsStoreItem
    {
        get;
        set;
    }

    [JsonProperty("m_bIsTradeItem")]
    [JsonPropertyName("m_bIsTradeItem")]
    public int? MBIsTradeItem
    {
        get;
        set;
    }

    [JsonProperty("m_bRestoreCustomMaterialAfterPrecache")]
    [JsonPropertyName("m_bRestoreCustomMaterialAfterPrecache")]
    public int? MBRestoreCustomMaterialAfterPrecache
    {
        get;
        set;
    }

    [JsonProperty("m_iAccountID")]
    [JsonPropertyName("m_iAccountID")]
    public int? MIAccountID
    {
        get;
        set;
    }

    [JsonProperty("m_iEntityLevel")]
    [JsonPropertyName("m_iEntityLevel")]
    public int? MIEntityLevel
    {
        get;
        set;
    }

    [JsonProperty("m_iEntityQuality")]
    [JsonPropertyName("m_iEntityQuality")]
    public int? MIEntityQuality
    {
        get;
        set;
    }

    [JsonProperty("m_iEntityQuantity")]
    [JsonPropertyName("m_iEntityQuantity")]
    public int? MIEntityQuantity
    {
        get;
        set;
    }

    [JsonProperty("m_iInventoryPosition")]
    [JsonPropertyName("m_iInventoryPosition")]
    public int? MIInventoryPosition
    {
        get;
        set;
    }

    [JsonProperty("m_iItemDefinitionIndex")]
    [JsonPropertyName("m_iItemDefinitionIndex")]
    public int? MIItemDefinitionIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iItemID")]
    [JsonPropertyName("m_iItemID")]
    public int? MIItemID
    {
        get;
        set;
    }

    [JsonProperty("m_iItemIDHigh")]
    [JsonPropertyName("m_iItemIDHigh")]
    public int? MIItemIDHigh
    {
        get;
        set;
    }

    [JsonProperty("m_iItemIDLow")]
    [JsonPropertyName("m_iItemIDLow")]
    public int? MIItemIDLow
    {
        get;
        set;
    }

    [JsonProperty("m_iOriginOverride")]
    [JsonPropertyName("m_iOriginOverride")]
    public int? MIOriginOverride
    {
        get;
        set;
    }

    [JsonProperty("m_iQualityOverride")]
    [JsonPropertyName("m_iQualityOverride")]
    public int? MIQualityOverride
    {
        get;
        set;
    }

    [JsonProperty("m_iRarityOverride")]
    [JsonPropertyName("m_iRarityOverride")]
    public int? MIRarityOverride
    {
        get;
        set;
    }

    [JsonProperty("m_nInventoryImageRgbaHeight")]
    [JsonPropertyName("m_nInventoryImageRgbaHeight")]
    public int? MNInventoryImageRgbaHeight
    {
        get;
        set;
    }

    [JsonProperty("m_nInventoryImageRgbaWidth")]
    [JsonPropertyName("m_nInventoryImageRgbaWidth")]
    public int? MNInventoryImageRgbaWidth
    {
        get;
        set;
    }

    [JsonProperty("m_szCurrentLoadCachedFileName")]
    [JsonPropertyName("m_szCurrentLoadCachedFileName")]
    public int? MSzCurrentLoadCachedFileName
    {
        get;
        set;
    }

    [JsonProperty("m_szCustomName")]
    [JsonPropertyName("m_szCustomName")]
    public int? MSzCustomName
    {
        get;
        set;
    }

    [JsonProperty("m_szCustomNameOverride")]
    [JsonPropertyName("m_szCustomNameOverride")]
    public int? MSzCustomNameOverride
    {
        get;
        set;
    }

    [JsonProperty("m_ubStyleOverride")]
    [JsonPropertyName("m_ubStyleOverride")]
    public int? MUbStyleOverride
    {
        get;
        set;
    }

    [JsonProperty("m_unClientFlags")]
    [JsonPropertyName("m_unClientFlags")]
    public int? MUnClientFlags
    {
        get;
        set;
    }

    [JsonProperty("m_bAlwaysAllow")]
    [JsonPropertyName("m_bAlwaysAllow")]
    public int? MBAlwaysAllow
    {
        get;
        set;
    }

    [JsonProperty("m_nForceSkin")]
    [JsonPropertyName("m_nForceSkin")]
    public int? MNForceSkin
    {
        get;
        set;
    }

    [JsonProperty("m_bCoreExplode")]
    [JsonPropertyName("m_bCoreExplode")]
    public int? MBCoreExplode
    {
        get;
        set;
    }

    [JsonProperty("m_bLinkedToServerEnt")]
    [JsonPropertyName("m_bLinkedToServerEnt")]
    public int? MBLinkedToServerEnt
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeInLength")]
    [JsonPropertyName("m_flFadeInLength")]
    public int? MFlFadeInLength
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeInStart")]
    [JsonPropertyName("m_flFadeInStart")]
    public int? MFlFadeInStart
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeOutLength")]
    [JsonPropertyName("m_flFadeOutLength")]
    public int? MFlFadeOutLength
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeOutModelLength")]
    [JsonPropertyName("m_flFadeOutModelLength")]
    public int? MFlFadeOutModelLength
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeOutModelStart")]
    [JsonPropertyName("m_flFadeOutModelStart")]
    public int? MFlFadeOutModelStart
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeOutStart")]
    [JsonPropertyName("m_flFadeOutStart")]
    public int? MFlFadeOutStart
    {
        get;
        set;
    }

    [JsonProperty("m_flNextSparkTime")]
    [JsonPropertyName("m_flNextSparkTime")]
    public int? MFlNextSparkTime
    {
        get;
        set;
    }

    [JsonProperty("m_flStartTime")]
    [JsonPropertyName("m_flStartTime")]
    public int? MFlStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_nDissolveType")]
    [JsonPropertyName("m_nDissolveType")]
    public int? MNDissolveType
    {
        get;
        set;
    }

    [JsonProperty("m_nMagnitude")]
    [JsonPropertyName("m_nMagnitude")]
    public int? MNMagnitude
    {
        get;
        set;
    }

    [JsonProperty("m_vDissolverOrigin")]
    [JsonPropertyName("m_vDissolverOrigin")]
    public int? MVDissolverOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_bCheapEffect")]
    [JsonPropertyName("m_bCheapEffect")]
    public int? MBCheapEffect
    {
        get;
        set;
    }

    [JsonProperty("m_hEntAttached")]
    [JsonPropertyName("m_hEntAttached")]
    public int? MHEntAttached
    {
        get;
        set;
    }

    [JsonProperty("m_hOldAttached")]
    [JsonPropertyName("m_hOldAttached")]
    public int? MHOldAttached
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_Color")]
    [JsonPropertyName("m_Entity_Color")]
    public int? MEntityColor
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bCustomCubemapTexture")]
    [JsonPropertyName("m_Entity_bCustomCubemapTexture")]
    public int? MEntityBCustomCubemapTexture
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bEnabled")]
    [JsonPropertyName("m_Entity_bEnabled")]
    public int? MEntityBEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bMoveable")]
    [JsonPropertyName("m_Entity_bMoveable")]
    public int? MEntityBMoveable
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bStartDisabled")]
    [JsonPropertyName("m_Entity_bStartDisabled")]
    public int? MEntityBStartDisabled
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_flBrightness")]
    [JsonPropertyName("m_Entity_flBrightness")]
    public int? MEntityFlBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_flEdgeFadeDist")]
    [JsonPropertyName("m_Entity_flEdgeFadeDist")]
    public int? MEntityFlEdgeFadeDist
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hCubemapTexture")]
    [JsonPropertyName("m_Entity_hCubemapTexture")]
    public int? MEntityHCubemapTexture
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeDirectLightIndicesTexture")]
    [JsonPropertyName("m_Entity_hLightProbeDirectLightIndicesTexture")]
    public int? MEntityHLightProbeDirectLightIndicesTexture
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeDirectLightScalarsTexture")]
    [JsonPropertyName("m_Entity_hLightProbeDirectLightScalarsTexture")]
    public int? MEntityHLightProbeDirectLightScalarsTexture
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeDirectLightShadowsTexture")]
    [JsonPropertyName("m_Entity_hLightProbeDirectLightShadowsTexture")]
    public int? MEntityHLightProbeDirectLightShadowsTexture
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeTexture_AmbientCube")]
    [JsonPropertyName("m_Entity_hLightProbeTexture_AmbientCube")]
    public int? MEntityHLightProbeTextureAmbientCube
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeTexture_SDF")]
    [JsonPropertyName("m_Entity_hLightProbeTexture_SDF")]
    public int? MEntityHLightProbeTextureSDF
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeTexture_SH2_B")]
    [JsonPropertyName("m_Entity_hLightProbeTexture_SH2_B")]
    public int? MEntityHLightProbeTextureSH2B
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeTexture_SH2_DC")]
    [JsonPropertyName("m_Entity_hLightProbeTexture_SH2_DC")]
    public int? MEntityHLightProbeTextureSH2DC
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeTexture_SH2_G")]
    [JsonPropertyName("m_Entity_hLightProbeTexture_SH2_G")]
    public int? MEntityHLightProbeTextureSH2G
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_hLightProbeTexture_SH2_R")]
    [JsonPropertyName("m_Entity_hLightProbeTexture_SH2_R")]
    public int? MEntityHLightProbeTextureSH2R
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nEnvCubeMapArrayIndex")]
    [JsonPropertyName("m_Entity_nEnvCubeMapArrayIndex")]
    public int? MEntityNEnvCubeMapArrayIndex
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nHandshake")]
    [JsonPropertyName("m_Entity_nHandshake")]
    public int? MEntityNHandshake
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nLightProbeAtlasX")]
    [JsonPropertyName("m_Entity_nLightProbeAtlasX")]
    public int? MEntityNLightProbeAtlasX
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nLightProbeAtlasY")]
    [JsonPropertyName("m_Entity_nLightProbeAtlasY")]
    public int? MEntityNLightProbeAtlasY
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nLightProbeAtlasZ")]
    [JsonPropertyName("m_Entity_nLightProbeAtlasZ")]
    public int? MEntityNLightProbeAtlasZ
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nLightProbeSizeX")]
    [JsonPropertyName("m_Entity_nLightProbeSizeX")]
    public int? MEntityNLightProbeSizeX
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nLightProbeSizeY")]
    [JsonPropertyName("m_Entity_nLightProbeSizeY")]
    public int? MEntityNLightProbeSizeY
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nLightProbeSizeZ")]
    [JsonPropertyName("m_Entity_nLightProbeSizeZ")]
    public int? MEntityNLightProbeSizeZ
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_nPriority")]
    [JsonPropertyName("m_Entity_nPriority")]
    public int? MEntityNPriority
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_vBoxMaxs")]
    [JsonPropertyName("m_Entity_vBoxMaxs")]
    public int? MEntityVBoxMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_vBoxMins")]
    [JsonPropertyName("m_Entity_vBoxMins")]
    public int? MEntityVBoxMins
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_vEdgeFadeDists")]
    [JsonPropertyName("m_Entity_vEdgeFadeDists")]
    public int? MEntityVEdgeFadeDists
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bCopyDiffuseFromDefaultCubemap")]
    [JsonPropertyName("m_Entity_bCopyDiffuseFromDefaultCubemap")]
    public int? MEntityBCopyDiffuseFromDefaultCubemap
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bDefaultEnvMap")]
    [JsonPropertyName("m_Entity_bDefaultEnvMap")]
    public int? MEntityBDefaultEnvMap
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bDefaultSpecEnvMap")]
    [JsonPropertyName("m_Entity_bDefaultSpecEnvMap")]
    public int? MEntityBDefaultSpecEnvMap
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_bIndoorCubeMap")]
    [JsonPropertyName("m_Entity_bIndoorCubeMap")]
    public int? MEntityBIndoorCubeMap
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_flDiffuseScale")]
    [JsonPropertyName("m_Entity_flDiffuseScale")]
    public int? MEntityFlDiffuseScale
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_flInfluenceRadius")]
    [JsonPropertyName("m_Entity_flInfluenceRadius")]
    public int? MEntityFlInfluenceRadius
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_vBoxProjectMaxs")]
    [JsonPropertyName("m_Entity_vBoxProjectMaxs")]
    public int? MEntityVBoxProjectMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_Entity_vBoxProjectMins")]
    [JsonPropertyName("m_Entity_vBoxProjectMins")]
    public int? MEntityVBoxProjectMins
    {
        get;
        set;
    }

    [JsonProperty("m_bFirstTime")]
    [JsonPropertyName("m_bFirstTime")]
    public int? MBFirstTime
    {
        get;
        set;
    }

    [JsonProperty("m_bHasHeightFogEnd")]
    [JsonPropertyName("m_bHasHeightFogEnd")]
    public int? MBHasHeightFogEnd
    {
        get;
        set;
    }

    [JsonProperty("m_bHeightFogEnabled")]
    [JsonPropertyName("m_bHeightFogEnabled")]
    public int? MBHeightFogEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_flEndDistance")]
    [JsonPropertyName("m_flEndDistance")]
    public int? MFlEndDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flFogFalloffExponent")]
    [JsonPropertyName("m_flFogFalloffExponent")]
    public int? MFlFogFalloffExponent
    {
        get;
        set;
    }

    [JsonProperty("m_flFogHeightEnd")]
    [JsonPropertyName("m_flFogHeightEnd")]
    public int? MFlFogHeightEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flFogHeightExponent")]
    [JsonPropertyName("m_flFogHeightExponent")]
    public int? MFlFogHeightExponent
    {
        get;
        set;
    }

    [JsonProperty("m_flFogHeightStart")]
    [JsonPropertyName("m_flFogHeightStart")]
    public int? MFlFogHeightStart
    {
        get;
        set;
    }

    [JsonProperty("m_flFogHeightWidth")]
    [JsonPropertyName("m_flFogHeightWidth")]
    public int? MFlFogHeightWidth
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMaxOpacity")]
    [JsonPropertyName("m_flFogMaxOpacity")]
    public int? MFlFogMaxOpacity
    {
        get;
        set;
    }

    [JsonProperty("m_flLODBias")]
    [JsonPropertyName("m_flLODBias")]
    public int? MFlLODBias
    {
        get;
        set;
    }

    [JsonProperty("m_flStartDistance")]
    [JsonPropertyName("m_flStartDistance")]
    public int? MFlStartDistance
    {
        get;
        set;
    }

    [JsonProperty("m_hFogCubemapTexture")]
    [JsonPropertyName("m_hFogCubemapTexture")]
    public int? MHFogCubemapTexture
    {
        get;
        set;
    }

    [JsonProperty("m_hSkyMaterial")]
    [JsonPropertyName("m_hSkyMaterial")]
    public int? MHSkyMaterial
    {
        get;
        set;
    }

    [JsonProperty("m_iszSkyEntity")]
    [JsonPropertyName("m_iszSkyEntity")]
    public int? MIszSkyEntity
    {
        get;
        set;
    }

    [JsonProperty("m_nCubemapSourceType")]
    [JsonPropertyName("m_nCubemapSourceType")]
    public int? MNCubemapSourceType
    {
        get;
        set;
    }

    [JsonProperty("m_bProjectOnCharacters")]
    [JsonPropertyName("m_bProjectOnCharacters")]
    public int? MBProjectOnCharacters
    {
        get;
        set;
    }

    [JsonProperty("m_bProjectOnWater")]
    [JsonPropertyName("m_bProjectOnWater")]
    public int? MBProjectOnWater
    {
        get;
        set;
    }

    [JsonProperty("m_bProjectOnWorld")]
    [JsonPropertyName("m_bProjectOnWorld")]
    public int? MBProjectOnWorld
    {
        get;
        set;
    }

    [JsonProperty("m_flDepth")]
    [JsonPropertyName("m_flDepth")]
    public int? MFlDepth
    {
        get;
        set;
    }

    [JsonProperty("m_flDepthSortBias")]
    [JsonPropertyName("m_flDepthSortBias")]
    public int? MFlDepthSortBias
    {
        get;
        set;
    }

    [JsonProperty("m_flHeight")]
    [JsonPropertyName("m_flHeight")]
    public int? MFlHeight
    {
        get;
        set;
    }

    [JsonProperty("m_flWidth")]
    [JsonPropertyName("m_flWidth")]
    public int? MFlWidth
    {
        get;
        set;
    }

    [JsonProperty("m_hDecalMaterial")]
    [JsonPropertyName("m_hDecalMaterial")]
    public int? MHDecalMaterial
    {
        get;
        set;
    }

    [JsonProperty("m_nRenderOrder")]
    [JsonPropertyName("m_nRenderOrder")]
    public int? MNRenderOrder
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeEndDist")]
    [JsonPropertyName("m_flFadeEndDist")]
    public int? MFlFadeEndDist
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeStartDist")]
    [JsonPropertyName("m_flFadeStartDist")]
    public int? MFlFadeStartDist
    {
        get;
        set;
    }

    [JsonProperty("m_ColorTint")]
    [JsonPropertyName("m_ColorTint")]
    public int? MColorTint
    {
        get;
        set;
    }

    [JsonProperty("m_flAlphaScale")]
    [JsonPropertyName("m_flAlphaScale")]
    public int? MFlAlphaScale
    {
        get;
        set;
    }

    [JsonProperty("m_flRadiusScale")]
    [JsonPropertyName("m_flRadiusScale")]
    public int? MFlRadiusScale
    {
        get;
        set;
    }

    [JsonProperty("m_flSelfIllumScale")]
    [JsonPropertyName("m_flSelfIllumScale")]
    public int? MFlSelfIllumScale
    {
        get;
        set;
    }

    [JsonProperty("m_hTextureOverride")]
    [JsonPropertyName("m_hTextureOverride")]
    public int? MHTextureOverride
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMaxEnd")]
    [JsonPropertyName("m_flFogMaxEnd")]
    public int? MFlFogMaxEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMaxStart")]
    [JsonPropertyName("m_flFogMaxStart")]
    public int? MFlFogMaxStart
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMinEnd")]
    [JsonPropertyName("m_flFogMinEnd")]
    public int? MFlFogMinEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMinStart")]
    [JsonPropertyName("m_flFogMinStart")]
    public int? MFlFogMinStart
    {
        get;
        set;
    }

    [JsonProperty("m_hSkyMaterialLightingOnly")]
    [JsonPropertyName("m_hSkyMaterialLightingOnly")]
    public int? MHSkyMaterialLightingOnly
    {
        get;
        set;
    }

    [JsonProperty("m_nFogType")]
    [JsonPropertyName("m_nFogType")]
    public int? MNFogType
    {
        get;
        set;
    }

    [JsonProperty("m_vTintColor")]
    [JsonPropertyName("m_vTintColor")]
    public int? MVTintColor
    {
        get;
        set;
    }

    [JsonProperty("m_vTintColorLightingOnly")]
    [JsonPropertyName("m_vTintColorLightingOnly")]
    public int? MVTintColorLightingOnly
    {
        get;
        set;
    }

    [JsonProperty("m_TintColor")]
    [JsonPropertyName("m_TintColor")]
    public int? MTintColor
    {
        get;
        set;
    }

    [JsonProperty("m_bEnableIndirect")]
    [JsonPropertyName("m_bEnableIndirect")]
    public int? MBEnableIndirect
    {
        get;
        set;
    }

    [JsonProperty("m_bIsMaster")]
    [JsonPropertyName("m_bIsMaster")]
    public int? MBIsMaster
    {
        get;
        set;
    }

    [JsonProperty("m_fFirstVolumeSliceThickness")]
    [JsonPropertyName("m_fFirstVolumeSliceThickness")]
    public int? MFFirstVolumeSliceThickness
    {
        get;
        set;
    }

    [JsonProperty("m_fNoiseSpeed")]
    [JsonPropertyName("m_fNoiseSpeed")]
    public int? MFNoiseSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_fNoiseStrength")]
    [JsonPropertyName("m_fNoiseStrength")]
    public int? MFNoiseStrength
    {
        get;
        set;
    }

    [JsonProperty("m_fWindSpeed")]
    [JsonPropertyName("m_fWindSpeed")]
    public int? MFWindSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flAnisotropy")]
    [JsonPropertyName("m_flAnisotropy")]
    public int? MFlAnisotropy
    {
        get;
        set;
    }

    [JsonProperty("m_flDefaultAnisotropy")]
    [JsonPropertyName("m_flDefaultAnisotropy")]
    public int? MFlDefaultAnisotropy
    {
        get;
        set;
    }

    [JsonProperty("m_flDefaultDrawDistance")]
    [JsonPropertyName("m_flDefaultDrawDistance")]
    public int? MFlDefaultDrawDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flDefaultScattering")]
    [JsonPropertyName("m_flDefaultScattering")]
    public int? MFlDefaultScattering
    {
        get;
        set;
    }

    [JsonProperty("m_flDrawDistance")]
    [JsonPropertyName("m_flDrawDistance")]
    public int? MFlDrawDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeInEnd")]
    [JsonPropertyName("m_flFadeInEnd")]
    public int? MFlFadeInEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeSpeed")]
    [JsonPropertyName("m_flFadeSpeed")]
    public int? MFlFadeSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flIndirectStrength")]
    [JsonPropertyName("m_flIndirectStrength")]
    public int? MFlIndirectStrength
    {
        get;
        set;
    }

    [JsonProperty("m_flScattering")]
    [JsonPropertyName("m_flScattering")]
    public int? MFlScattering
    {
        get;
        set;
    }

    [JsonProperty("m_flStartAnisoTime")]
    [JsonPropertyName("m_flStartAnisoTime")]
    public int? MFlStartAnisoTime
    {
        get;
        set;
    }

    [JsonProperty("m_flStartAnisotropy")]
    [JsonPropertyName("m_flStartAnisotropy")]
    public int? MFlStartAnisotropy
    {
        get;
        set;
    }

    [JsonProperty("m_flStartDrawDistance")]
    [JsonPropertyName("m_flStartDrawDistance")]
    public int? MFlStartDrawDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flStartDrawDistanceTime")]
    [JsonPropertyName("m_flStartDrawDistanceTime")]
    public int? MFlStartDrawDistanceTime
    {
        get;
        set;
    }

    [JsonProperty("m_flStartScatterTime")]
    [JsonPropertyName("m_flStartScatterTime")]
    public int? MFlStartScatterTime
    {
        get;
        set;
    }

    [JsonProperty("m_flStartScattering")]
    [JsonPropertyName("m_flStartScattering")]
    public int? MFlStartScattering
    {
        get;
        set;
    }

    [JsonProperty("m_hFogIndirectTexture")]
    [JsonPropertyName("m_hFogIndirectTexture")]
    public int? MHFogIndirectTexture
    {
        get;
        set;
    }

    [JsonProperty("m_nForceRefreshCount")]
    [JsonPropertyName("m_nForceRefreshCount")]
    public int? MNForceRefreshCount
    {
        get;
        set;
    }

    [JsonProperty("m_nIndirectTextureDimX")]
    [JsonPropertyName("m_nIndirectTextureDimX")]
    public int? MNIndirectTextureDimX
    {
        get;
        set;
    }

    [JsonProperty("m_nIndirectTextureDimY")]
    [JsonPropertyName("m_nIndirectTextureDimY")]
    public int? MNIndirectTextureDimY
    {
        get;
        set;
    }

    [JsonProperty("m_nIndirectTextureDimZ")]
    [JsonPropertyName("m_nIndirectTextureDimZ")]
    public int? MNIndirectTextureDimZ
    {
        get;
        set;
    }

    [JsonProperty("m_nVolumeDepth")]
    [JsonPropertyName("m_nVolumeDepth")]
    public int? MNVolumeDepth
    {
        get;
        set;
    }

    [JsonProperty("m_vBoxMaxs")]
    [JsonPropertyName("m_vBoxMaxs")]
    public int? MVBoxMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vBoxMins")]
    [JsonPropertyName("m_vBoxMins")]
    public int? MVBoxMins
    {
        get;
        set;
    }

    [JsonProperty("m_vNoiseScale")]
    [JsonPropertyName("m_vNoiseScale")]
    public int? MVNoiseScale
    {
        get;
        set;
    }

    [JsonProperty("m_vWindDirection")]
    [JsonPropertyName("m_vWindDirection")]
    public int? MVWindDirection
    {
        get;
        set;
    }

    [JsonProperty("m_bIndirectUseLPVs")]
    [JsonPropertyName("m_bIndirectUseLPVs")]
    public int? MBIndirectUseLPVs
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideIndirectLightStrength")]
    [JsonPropertyName("m_bOverrideIndirectLightStrength")]
    public int? MBOverrideIndirectLightStrength
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideNoiseStrength")]
    [JsonPropertyName("m_bOverrideNoiseStrength")]
    public int? MBOverrideNoiseStrength
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideSunLightStrength")]
    [JsonPropertyName("m_bOverrideSunLightStrength")]
    public int? MBOverrideSunLightStrength
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideTintColor")]
    [JsonPropertyName("m_bOverrideTintColor")]
    public int? MBOverrideTintColor
    {
        get;
        set;
    }

    [JsonProperty("m_fHeightFogEdgeWidth")]
    [JsonPropertyName("m_fHeightFogEdgeWidth")]
    public int? MFHeightFogEdgeWidth
    {
        get;
        set;
    }

    [JsonProperty("m_fIndirectLightStrength")]
    [JsonPropertyName("m_fIndirectLightStrength")]
    public int? MFIndirectLightStrength
    {
        get;
        set;
    }

    [JsonProperty("m_fSunLightStrength")]
    [JsonPropertyName("m_fSunLightStrength")]
    public int? MFSunLightStrength
    {
        get;
        set;
    }

    [JsonProperty("m_flFalloffExponent")]
    [JsonPropertyName("m_flFalloffExponent")]
    public int? MFlFalloffExponent
    {
        get;
        set;
    }

    [JsonProperty("m_flHeightFogDepth")]
    [JsonPropertyName("m_flHeightFogDepth")]
    public int? MFlHeightFogDepth
    {
        get;
        set;
    }

    [JsonProperty("m_flStrength")]
    [JsonPropertyName("m_flStrength")]
    public int? MFlStrength
    {
        get;
        set;
    }

    [JsonProperty("m_nFalloffShape")]
    [JsonPropertyName("m_nFalloffShape")]
    public int? MNFalloffShape
    {
        get;
        set;
    }

    [JsonProperty("m_Attributes")]
    [JsonPropertyName("m_Attributes")]
    public int? MAttributes
    {
        get;
        set;
    }

    [JsonProperty("m_pManager")]
    [JsonPropertyName("m_pManager")]
    public int? MPManager
    {
        get;
        set;
    }

    [JsonProperty("m_EnvWindShared")]
    [JsonPropertyName("m_EnvWindShared")]
    public int? MEnvWindShared
    {
        get;
        set;
    }

    [JsonProperty("m_fDirectionVariation")]
    [JsonPropertyName("m_fDirectionVariation")]
    public int? MFDirectionVariation
    {
        get;
        set;
    }

    [JsonProperty("m_fSpeedVariation")]
    [JsonPropertyName("m_fSpeedVariation")]
    public int? MFSpeedVariation
    {
        get;
        set;
    }

    [JsonProperty("m_fTurbulence")]
    [JsonPropertyName("m_fTurbulence")]
    public int? MFTurbulence
    {
        get;
        set;
    }

    [JsonProperty("m_fVolumeHalfExtentXY")]
    [JsonPropertyName("m_fVolumeHalfExtentXY")]
    public int? MFVolumeHalfExtentXY
    {
        get;
        set;
    }

    [JsonProperty("m_fVolumeHalfExtentZ")]
    [JsonPropertyName("m_fVolumeHalfExtentZ")]
    public int? MFVolumeHalfExtentZ
    {
        get;
        set;
    }

    [JsonProperty("m_nClipmapLevels")]
    [JsonPropertyName("m_nClipmapLevels")]
    public int? MNClipmapLevels
    {
        get;
        set;
    }

    [JsonProperty("m_nVolumeResolutionXY")]
    [JsonPropertyName("m_nVolumeResolutionXY")]
    public int? MNVolumeResolutionXY
    {
        get;
        set;
    }

    [JsonProperty("m_nVolumeResolutionZ")]
    [JsonPropertyName("m_nVolumeResolutionZ")]
    public int? MNVolumeResolutionZ
    {
        get;
        set;
    }

    [JsonProperty("m_flGustDuration")]
    [JsonPropertyName("m_flGustDuration")]
    public int? MFlGustDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flInitialWindSpeed")]
    [JsonPropertyName("m_flInitialWindSpeed")]
    public int? MFlInitialWindSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxGustDelay")]
    [JsonPropertyName("m_flMaxGustDelay")]
    public int? MFlMaxGustDelay
    {
        get;
        set;
    }

    [JsonProperty("m_flMinGustDelay")]
    [JsonPropertyName("m_flMinGustDelay")]
    public int? MFlMinGustDelay
    {
        get;
        set;
    }

    [JsonProperty("m_hEntOwner")]
    [JsonPropertyName("m_hEntOwner")]
    public int? MHEntOwner
    {
        get;
        set;
    }

    [JsonProperty("m_iGustDirChange")]
    [JsonPropertyName("m_iGustDirChange")]
    public int? MIGustDirChange
    {
        get;
        set;
    }

    [JsonProperty("m_iInitialWindDir")]
    [JsonPropertyName("m_iInitialWindDir")]
    public int? MIInitialWindDir
    {
        get;
        set;
    }

    [JsonProperty("m_iMaxGust")]
    [JsonPropertyName("m_iMaxGust")]
    public int? MIMaxGust
    {
        get;
        set;
    }

    [JsonProperty("m_iMaxWind")]
    [JsonPropertyName("m_iMaxWind")]
    public int? MIMaxWind
    {
        get;
        set;
    }

    [JsonProperty("m_iMinGust")]
    [JsonPropertyName("m_iMinGust")]
    public int? MIMinGust
    {
        get;
        set;
    }

    [JsonProperty("m_iMinWind")]
    [JsonPropertyName("m_iMinWind")]
    public int? MIMinWind
    {
        get;
        set;
    }

    [JsonProperty("m_iWindSeed")]
    [JsonPropertyName("m_iWindSeed")]
    public int? MIWindSeed
    {
        get;
        set;
    }

    [JsonProperty("m_location")]
    [JsonPropertyName("m_location")]
    public int? MLocation
    {
        get;
        set;
    }

    [JsonProperty("m_windRadius")]
    [JsonPropertyName("m_windRadius")]
    public int? MWindRadius
    {
        get;
        set;
    }

    [JsonProperty("m_fWindDirectionVariationMultiplier")]
    [JsonPropertyName("m_fWindDirectionVariationMultiplier")]
    public int? MFWindDirectionVariationMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_fWindSpeedMultiplier")]
    [JsonPropertyName("m_fWindSpeedMultiplier")]
    public int? MFWindSpeedMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_fWindSpeedVariationMultiplier")]
    [JsonPropertyName("m_fWindSpeedVariationMultiplier")]
    public int? MFWindSpeedVariationMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_fWindTurbulenceMultiplier")]
    [JsonPropertyName("m_fWindTurbulenceMultiplier")]
    public int? MFWindTurbulenceMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_nShape")]
    [JsonPropertyName("m_nShape")]
    public int? MNShape
    {
        get;
        set;
    }

    [JsonProperty("m_actualAngles")]
    [JsonPropertyName("m_actualAngles")]
    public int? MActualAngles
    {
        get;
        set;
    }

    [JsonProperty("m_actualPos")]
    [JsonPropertyName("m_actualPos")]
    public int? MActualPos
    {
        get;
        set;
    }

    [JsonProperty("m_angle")]
    [JsonPropertyName("m_angle")]
    public int? MAngle
    {
        get;
        set;
    }

    [JsonProperty("m_angles")]
    [JsonPropertyName("m_angles")]
    public int? MAngles
    {
        get;
        set;
    }

    [JsonProperty("m_averageError")]
    [JsonPropertyName("m_averageError")]
    public int? MAverageError
    {
        get;
        set;
    }

    [JsonProperty("m_buoyancy")]
    [JsonPropertyName("m_buoyancy")]
    public int? MBuoyancy
    {
        get;
        set;
    }

    [JsonProperty("m_deathAngle")]
    [JsonPropertyName("m_deathAngle")]
    public int? MDeathAngle
    {
        get;
        set;
    }

    [JsonProperty("m_deathDepth")]
    [JsonPropertyName("m_deathDepth")]
    public int? MDeathDepth
    {
        get;
        set;
    }

    [JsonProperty("m_errorHistory")]
    [JsonPropertyName("m_errorHistory")]
    public int? MErrorHistory
    {
        get;
        set;
    }

    [JsonProperty("m_errorHistoryCount")]
    [JsonPropertyName("m_errorHistoryCount")]
    public int? MErrorHistoryCount
    {
        get;
        set;
    }

    [JsonProperty("m_errorHistoryIndex")]
    [JsonPropertyName("m_errorHistoryIndex")]
    public int? MErrorHistoryIndex
    {
        get;
        set;
    }

    [JsonProperty("m_gotUpdate")]
    [JsonPropertyName("m_gotUpdate")]
    public int? MGotUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_localLifeState")]
    [JsonPropertyName("m_localLifeState")]
    public int? MLocalLifeState
    {
        get;
        set;
    }

    [JsonProperty("m_poolOrigin")]
    [JsonPropertyName("m_poolOrigin")]
    public int? MPoolOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_pos")]
    [JsonPropertyName("m_pos")]
    public int? MPos
    {
        get;
        set;
    }

    [JsonProperty("m_vel")]
    [JsonPropertyName("m_vel")]
    public int? MVel
    {
        get;
        set;
    }

    [JsonProperty("m_waterLevel")]
    [JsonPropertyName("m_waterLevel")]
    public int? MWaterLevel
    {
        get;
        set;
    }

    [JsonProperty("m_wigglePhase")]
    [JsonPropertyName("m_wigglePhase")]
    public int? MWigglePhase
    {
        get;
        set;
    }

    [JsonProperty("m_wiggleRate")]
    [JsonPropertyName("m_wiggleRate")]
    public int? MWiggleRate
    {
        get;
        set;
    }

    [JsonProperty("m_wiggleTimer")]
    [JsonPropertyName("m_wiggleTimer")]
    public int? MWiggleTimer
    {
        get;
        set;
    }

    [JsonProperty("m_x")]
    [JsonPropertyName("m_x")]
    public int? MX
    {
        get;
        set;
    }

    [JsonProperty("m_y")]
    [JsonPropertyName("m_y")]
    public int? MY
    {
        get;
        set;
    }

    [JsonProperty("m_z")]
    [JsonPropertyName("m_z")]
    public int? MZ
    {
        get;
        set;
    }

    [JsonProperty("m_bUseAngles")]
    [JsonPropertyName("m_bUseAngles")]
    public int? MBUseAngles
    {
        get;
        set;
    }

    [JsonProperty("m_fog")]
    [JsonPropertyName("m_fog")]
    public int? MFog
    {
        get;
        set;
    }

    [JsonProperty("m_iChangedVariables")]
    [JsonPropertyName("m_iChangedVariables")]
    public int? MIChangedVariables
    {
        get;
        set;
    }

    [JsonProperty("m_destination")]
    [JsonPropertyName("m_destination")]
    public int? MDestination
    {
        get;
        set;
    }

    [JsonProperty("m_source")]
    [JsonPropertyName("m_source")]
    public int? MSource
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentConveyorOffset")]
    [JsonPropertyName("m_flCurrentConveyorOffset")]
    public int? MFlCurrentConveyorOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentConveyorSpeed")]
    [JsonPropertyName("m_flCurrentConveyorSpeed")]
    public int? MFlCurrentConveyorSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flTargetSpeed")]
    [JsonPropertyName("m_flTargetSpeed")]
    public int? MFlTargetSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flTransitionStartSpeed")]
    [JsonPropertyName("m_flTransitionStartSpeed")]
    public int? MFlTransitionStartSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_hConveyorModels")]
    [JsonPropertyName("m_hConveyorModels")]
    public int? MHConveyorModels
    {
        get;
        set;
    }

    [JsonProperty("m_nTransitionDurationTicks")]
    [JsonPropertyName("m_nTransitionDurationTicks")]
    public int? MNTransitionDurationTicks
    {
        get;
        set;
    }

    [JsonProperty("m_nTransitionStartTick")]
    [JsonPropertyName("m_nTransitionStartTick")]
    public int? MNTransitionStartTick
    {
        get;
        set;
    }

    [JsonProperty("m_vecMoveDirEntitySpace")]
    [JsonPropertyName("m_vecMoveDirEntitySpace")]
    public int? MVecMoveDirEntitySpace
    {
        get;
        set;
    }

    [JsonProperty("m_EffectName")]
    [JsonPropertyName("m_EffectName")]
    public int? MEffectName
    {
        get;
        set;
    }

    [JsonProperty("m_bState")]
    [JsonPropertyName("m_bState")]
    public int? MBState
    {
        get;
        set;
    }

    [JsonProperty("m_nAmbientEffect")]
    [JsonPropertyName("m_nAmbientEffect")]
    public int? MNAmbientEffect
    {
        get;
        set;
    }

    [JsonProperty("m_Dismounts")]
    [JsonPropertyName("m_Dismounts")]
    public int? MDismounts
    {
        get;
        set;
    }

    [JsonProperty("m_bFakeLadder")]
    [JsonPropertyName("m_bFakeLadder")]
    public int? MBFakeLadder
    {
        get;
        set;
    }

    [JsonProperty("m_bHasSlack")]
    [JsonPropertyName("m_bHasSlack")]
    public int? MBHasSlack
    {
        get;
        set;
    }

    [JsonProperty("m_flAutoRideSpeed")]
    [JsonPropertyName("m_flAutoRideSpeed")]
    public int? MFlAutoRideSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_vecLadderDir")]
    [JsonPropertyName("m_vecLadderDir")]
    public int? MVecLadderDir
    {
        get;
        set;
    }

    [JsonProperty("m_vecLocalTop")]
    [JsonPropertyName("m_vecLocalTop")]
    public int? MVecLocalTop
    {
        get;
        set;
    }

    [JsonProperty("m_vecPlayerMountPositionBottom")]
    [JsonPropertyName("m_vecPlayerMountPositionBottom")]
    public int? MVecPlayerMountPositionBottom
    {
        get;
        set;
    }

    [JsonProperty("m_vecPlayerMountPositionTop")]
    [JsonPropertyName("m_vecPlayerMountPositionTop")]
    public int? MVecPlayerMountPositionTop
    {
        get;
        set;
    }

    [JsonProperty("m_bDraw3DSkybox")]
    [JsonPropertyName("m_bDraw3DSkybox")]
    public int? MBDraw3DSkybox
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderShadows")]
    [JsonPropertyName("m_bRenderShadows")]
    public int? MBRenderShadows
    {
        get;
        set;
    }

    [JsonProperty("m_bUseUniqueColorTarget")]
    [JsonPropertyName("m_bUseUniqueColorTarget")]
    public int? MBUseUniqueColorTarget
    {
        get;
        set;
    }

    [JsonProperty("m_brushModelName")]
    [JsonPropertyName("m_brushModelName")]
    public int? MBrushModelName
    {
        get;
        set;
    }

    [JsonProperty("m_hTargetCamera")]
    [JsonPropertyName("m_hTargetCamera")]
    public int? MHTargetCamera
    {
        get;
        set;
    }

    [JsonProperty("m_nResolutionEnum")]
    [JsonPropertyName("m_nResolutionEnum")]
    public int? MNResolutionEnum
    {
        get;
        set;
    }

    [JsonProperty("m_targetCamera")]
    [JsonPropertyName("m_targetCamera")]
    public int? MTargetCamera
    {
        get;
        set;
    }

    [JsonProperty("m_flLineLength")]
    [JsonPropertyName("m_flLineLength")]
    public int? MFlLineLength
    {
        get;
        set;
    }

    [JsonProperty("m_flRadius")]
    [JsonPropertyName("m_flRadius")]
    public int? MFlRadius
    {
        get;
        set;
    }

    [JsonProperty("m_nLongAxis")]
    [JsonPropertyName("m_nLongAxis")]
    public int? MNLongAxis
    {
        get;
        set;
    }

    [JsonProperty("m_obsInterpState")]
    [JsonPropertyName("m_obsInterpState")]
    public int? MObsInterpState
    {
        get;
        set;
    }

    [JsonProperty("m_bGamePaused")]
    [JsonPropertyName("m_bGamePaused")]
    public int? MBGamePaused
    {
        get;
        set;
    }

    [JsonProperty("m_nPauseStartTick")]
    [JsonPropertyName("m_nPauseStartTick")]
    public int? MNPauseStartTick
    {
        get;
        set;
    }

    [JsonProperty("m_nTotalPausedTicks")]
    [JsonPropertyName("m_nTotalPausedTicks")]
    public int? MNTotalPausedTicks
    {
        get;
        set;
    }

    [JsonProperty("m_WindClothForceHandle")]
    [JsonPropertyName("m_WindClothForceHandle")]
    public int? MWindClothForceHandle
    {
        get;
        set;
    }

    [JsonProperty("m_bGradientFogNeedsTextures")]
    [JsonPropertyName("m_bGradientFogNeedsTextures")]
    public int? MBGradientFogNeedsTextures
    {
        get;
        set;
    }

    [JsonProperty("m_bIsEnabled")]
    [JsonPropertyName("m_bIsEnabled")]
    public int? MBIsEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeTime")]
    [JsonPropertyName("m_flFadeTime")]
    public int? MFlFadeTime
    {
        get;
        set;
    }

    [JsonProperty("m_flFarZ")]
    [JsonPropertyName("m_flFarZ")]
    public int? MFlFarZ
    {
        get;
        set;
    }

    [JsonProperty("m_flFogEndDistance")]
    [JsonPropertyName("m_flFogEndDistance")]
    public int? MFlFogEndDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flFogEndHeight")]
    [JsonPropertyName("m_flFogEndHeight")]
    public int? MFlFogEndHeight
    {
        get;
        set;
    }

    [JsonProperty("m_flFogStartDistance")]
    [JsonPropertyName("m_flFogStartDistance")]
    public int? MFlFogStartDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flFogStartHeight")]
    [JsonPropertyName("m_flFogStartHeight")]
    public int? MFlFogStartHeight
    {
        get;
        set;
    }

    [JsonProperty("m_flFogVerticalExponent")]
    [JsonPropertyName("m_flFogVerticalExponent")]
    public int? MFlFogVerticalExponent
    {
        get;
        set;
    }

    [JsonProperty("m_fogColor")]
    [JsonPropertyName("m_fogColor")]
    public int? MFogColor
    {
        get;
        set;
    }

    [JsonProperty("m_hGradientFogTexture")]
    [JsonPropertyName("m_hGradientFogTexture")]
    public int? MHGradientFogTexture
    {
        get;
        set;
    }

    [JsonProperty("m_bSendHandle")]
    [JsonPropertyName("m_bSendHandle")]
    public int? MBSendHandle
    {
        get;
        set;
    }

    [JsonProperty("m_bHandsHaveBeenCut")]
    [JsonPropertyName("m_bHandsHaveBeenCut")]
    public int? MBHandsHaveBeenCut
    {
        get;
        set;
    }

    [JsonProperty("m_blinkTimer")]
    [JsonPropertyName("m_blinkTimer")]
    public int? MBlinkTimer
    {
        get;
        set;
    }

    [JsonProperty("m_chestAttachment")]
    [JsonPropertyName("m_chestAttachment")]
    public int? MChestAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_eyeAttachment")]
    [JsonPropertyName("m_eyeAttachment")]
    public int? MEyeAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_fLastGrabTime")]
    [JsonPropertyName("m_fLastGrabTime")]
    public int? MFLastGrabTime
    {
        get;
        set;
    }

    [JsonProperty("m_fNewestAlphaThinkTime")]
    [JsonPropertyName("m_fNewestAlphaThinkTime")]
    public int? MFNewestAlphaThinkTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDeadOrRescuedTime")]
    [JsonPropertyName("m_flDeadOrRescuedTime")]
    public int? MFlDeadOrRescuedTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDropStartTime")]
    [JsonPropertyName("m_flDropStartTime")]
    public int? MFlDropStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flGrabSuccessTime")]
    [JsonPropertyName("m_flGrabSuccessTime")]
    public int? MFlGrabSuccessTime
    {
        get;
        set;
    }

    [JsonProperty("m_flRescueStartTime")]
    [JsonPropertyName("m_flRescueStartTime")]
    public int? MFlRescueStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_hHostageGrabber")]
    [JsonPropertyName("m_hHostageGrabber")]
    public int? MHHostageGrabber
    {
        get;
        set;
    }

    [JsonProperty("m_isInit")]
    [JsonPropertyName("m_isInit")]
    public int? MIsInit
    {
        get;
        set;
    }

    [JsonProperty("m_isRescued")]
    [JsonPropertyName("m_isRescued")]
    public int? MIsRescued
    {
        get;
        set;
    }

    [JsonProperty("m_lookAroundTimer")]
    [JsonPropertyName("m_lookAroundTimer")]
    public int? MLookAroundTimer
    {
        get;
        set;
    }

    [JsonProperty("m_lookAt")]
    [JsonPropertyName("m_lookAt")]
    public int? MLookAt
    {
        get;
        set;
    }

    [JsonProperty("m_nHostageState")]
    [JsonPropertyName("m_nHostageState")]
    public int? MNHostageState
    {
        get;
        set;
    }

    [JsonProperty("m_pPredictionOwner")]
    [JsonPropertyName("m_pPredictionOwner")]
    public int? MPPredictionOwner
    {
        get;
        set;
    }

    [JsonProperty("m_reuseTimer")]
    [JsonPropertyName("m_reuseTimer")]
    public int? MReuseTimer
    {
        get;
        set;
    }

    [JsonProperty("m_vecGrabbedPos")]
    [JsonPropertyName("m_vecGrabbedPos")]
    public int? MVecGrabbedPos
    {
        get;
        set;
    }

    [JsonProperty("m_BurnNormal")]
    [JsonPropertyName("m_BurnNormal")]
    public int? MBurnNormal
    {
        get;
        set;
    }

    [JsonProperty("m_bFireIsBurning")]
    [JsonPropertyName("m_bFireIsBurning")]
    public int? MBFireIsBurning
    {
        get;
        set;
    }

    [JsonProperty("m_bInPostEffectTime")]
    [JsonPropertyName("m_bInPostEffectTime")]
    public int? MBInPostEffectTime
    {
        get;
        set;
    }

    [JsonProperty("m_blosCheck")]
    [JsonPropertyName("m_blosCheck")]
    public int? MBlosCheck
    {
        get;
        set;
    }

    [JsonProperty("m_drawableCount")]
    [JsonPropertyName("m_drawableCount")]
    public int? MDrawableCount
    {
        get;
        set;
    }

    [JsonProperty("m_fireCount")]
    [JsonPropertyName("m_fireCount")]
    public int? MFireCount
    {
        get;
        set;
    }

    [JsonProperty("m_fireParentPositions")]
    [JsonPropertyName("m_fireParentPositions")]
    public int? MFireParentPositions
    {
        get;
        set;
    }

    [JsonProperty("m_firePositions")]
    [JsonPropertyName("m_firePositions")]
    public int? MFirePositions
    {
        get;
        set;
    }

    [JsonProperty("m_flLastGrassBurnThink")]
    [JsonPropertyName("m_flLastGrassBurnThink")]
    public int? MFlLastGrassBurnThink
    {
        get;
        set;
    }

    [JsonProperty("m_hInfernoClimbingOutlinePointsSnapshot")]
    [JsonPropertyName("m_hInfernoClimbingOutlinePointsSnapshot")]
    public int? MHInfernoClimbingOutlinePointsSnapshot
    {
        get;
        set;
    }

    [JsonProperty("m_hInfernoDecalsSnapshot")]
    [JsonPropertyName("m_hInfernoDecalsSnapshot")]
    public int? MHInfernoDecalsSnapshot
    {
        get;
        set;
    }

    [JsonProperty("m_hInfernoFillerPointsSnapshot")]
    [JsonPropertyName("m_hInfernoFillerPointsSnapshot")]
    public int? MHInfernoFillerPointsSnapshot
    {
        get;
        set;
    }

    [JsonProperty("m_hInfernoOutlinePointsSnapshot")]
    [JsonPropertyName("m_hInfernoOutlinePointsSnapshot")]
    public int? MHInfernoOutlinePointsSnapshot
    {
        get;
        set;
    }

    [JsonProperty("m_hInfernoPointsSnapshot")]
    [JsonPropertyName("m_hInfernoPointsSnapshot")]
    public int? MHInfernoPointsSnapshot
    {
        get;
        set;
    }

    [JsonProperty("m_lastFireCount")]
    [JsonPropertyName("m_lastFireCount")]
    public int? MLastFireCount
    {
        get;
        set;
    }

    [JsonProperty("m_maxBounds")]
    [JsonPropertyName("m_maxBounds")]
    public int? MMaxBounds
    {
        get;
        set;
    }

    [JsonProperty("m_maxFireHalfWidth")]
    [JsonPropertyName("m_maxFireHalfWidth")]
    public int? MMaxFireHalfWidth
    {
        get;
        set;
    }

    [JsonProperty("m_maxFireHeight")]
    [JsonPropertyName("m_maxFireHeight")]
    public int? MMaxFireHeight
    {
        get;
        set;
    }

    [JsonProperty("m_minBounds")]
    [JsonPropertyName("m_minBounds")]
    public int? MMinBounds
    {
        get;
        set;
    }

    [JsonProperty("m_nFireEffectTickBegin")]
    [JsonPropertyName("m_nFireEffectTickBegin")]
    public int? MNFireEffectTickBegin
    {
        get;
        set;
    }

    [JsonProperty("m_nFireLifetime")]
    [JsonPropertyName("m_nFireLifetime")]
    public int? MNFireLifetime
    {
        get;
        set;
    }

    [JsonProperty("m_nInfernoType")]
    [JsonPropertyName("m_nInfernoType")]
    public int? MNInfernoType
    {
        get;
        set;
    }

    [JsonProperty("m_nfxFireDamageEffect")]
    [JsonPropertyName("m_nfxFireDamageEffect")]
    public int? MNfxFireDamageEffect
    {
        get;
        set;
    }

    [JsonProperty("m_nlosperiod")]
    [JsonPropertyName("m_nlosperiod")]
    public int? MNlosperiod
    {
        get;
        set;
    }

    [JsonProperty("m_nMode")]
    [JsonPropertyName("m_nMode")]
    public int? MNMode
    {
        get;
        set;
    }

    [JsonProperty("m_vBoxSize")]
    [JsonPropertyName("m_vBoxSize")]
    public int? MVBoxSize
    {
        get;
        set;
    }

    [JsonProperty("m_pReticleHintTextName")]
    [JsonPropertyName("m_pReticleHintTextName")]
    public int? MPReticleHintTextName
    {
        get;
        set;
    }

    [JsonProperty("m_KillingPlayer")]
    [JsonPropertyName("m_KillingPlayer")]
    public int? MKillingPlayer
    {
        get;
        set;
    }

    [JsonProperty("m_OwningPlayer")]
    [JsonPropertyName("m_OwningPlayer")]
    public int? MOwningPlayer
    {
        get;
        set;
    }

    [JsonProperty("m_nKeychainDefID")]
    [JsonPropertyName("m_nKeychainDefID")]
    public int? MNKeychainDefID
    {
        get;
        set;
    }

    [JsonProperty("m_nKeychainSeed")]
    [JsonPropertyName("m_nKeychainSeed")]
    public int? MNKeychainSeed
    {
        get;
        set;
    }

    [JsonProperty("m_bFirstAttack")]
    [JsonPropertyName("m_bFirstAttack")]
    public int? MBFirstAttack
    {
        get;
        set;
    }

    [JsonProperty("m_flFOVRate")]
    [JsonPropertyName("m_flFOVRate")]
    public int? MFlFOVRate
    {
        get;
        set;
    }

    [JsonProperty("m_flFOVTime")]
    [JsonPropertyName("m_flFOVTime")]
    public int? MFlFOVTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastShotFOV")]
    [JsonPropertyName("m_flLastShotFOV")]
    public int? MFlLastShotFOV
    {
        get;
        set;
    }

    [JsonProperty("m_hZoomOwner")]
    [JsonPropertyName("m_hZoomOwner")]
    public int? MHZoomOwner
    {
        get;
        set;
    }

    [JsonProperty("m_iFOV")]
    [JsonPropertyName("m_iFOV")]
    public int? MIFOV
    {
        get;
        set;
    }

    [JsonProperty("m_iFOVStart")]
    [JsonPropertyName("m_iFOVStart")]
    public int? MIFOVStart
    {
        get;
        set;
    }

    [JsonProperty("m_CLightComponent")]
    [JsonPropertyName("m_CLightComponent")]
    public int? MCLightComponent
    {
        get;
        set;
    }

    [JsonProperty("bounceFactor")]
    [JsonPropertyName("bounceFactor")]
    public int? BounceFactor
    {
        get;
        set;
    }

    [JsonProperty("die")]
    [JsonPropertyName("die")]
    public int? Die
    {
        get;
        set;
    }

    [JsonProperty("fadeSpeed")]
    [JsonPropertyName("fadeSpeed")]
    public int? FadeSpeed
    {
        get;
        set;
    }

    [JsonProperty("flags")]
    [JsonPropertyName("flags")]
    public int? Flags
    {
        get;
        set;
    }

    [JsonProperty("hitSound")]
    [JsonPropertyName("hitSound")]
    public int? HitSound
    {
        get;
        set;
    }

    [JsonProperty("m_bParticleCollision")]
    [JsonPropertyName("m_bParticleCollision")]
    public int? MBParticleCollision
    {
        get;
        set;
    }

    [JsonProperty("m_flFrameMax")]
    [JsonPropertyName("m_flFrameMax")]
    public int? MFlFrameMax
    {
        get;
        set;
    }

    [JsonProperty("m_flSpriteScale")]
    [JsonPropertyName("m_flSpriteScale")]
    public int? MFlSpriteScale
    {
        get;
        set;
    }

    [JsonProperty("m_iLastCollisionFrame")]
    [JsonPropertyName("m_iLastCollisionFrame")]
    public int? MILastCollisionFrame
    {
        get;
        set;
    }

    [JsonProperty("m_nFlickerFrame")]
    [JsonPropertyName("m_nFlickerFrame")]
    public int? MNFlickerFrame
    {
        get;
        set;
    }

    [JsonProperty("m_pszImpactEffect")]
    [JsonPropertyName("m_pszImpactEffect")]
    public int? MPszImpactEffect
    {
        get;
        set;
    }

    [JsonProperty("m_pszParticleEffect")]
    [JsonPropertyName("m_pszParticleEffect")]
    public int? MPszParticleEffect
    {
        get;
        set;
    }

    [JsonProperty("m_vLastCollisionOrigin")]
    [JsonPropertyName("m_vLastCollisionOrigin")]
    public int? MVLastCollisionOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecNormal")]
    [JsonPropertyName("m_vecNormal")]
    public int? MVecNormal
    {
        get;
        set;
    }

    [JsonProperty("m_vecPrevAbsOrigin")]
    [JsonPropertyName("m_vecPrevAbsOrigin")]
    public int? MVecPrevAbsOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecTempEntAcceleration")]
    [JsonPropertyName("m_vecTempEntAcceleration")]
    public int? MVecTempEntAcceleration
    {
        get;
        set;
    }

    [JsonProperty("m_vecTempEntAngVelocity")]
    [JsonPropertyName("m_vecTempEntAngVelocity")]
    public int? MVecTempEntAngVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_vecTempEntVelocity")]
    [JsonPropertyName("m_vecTempEntVelocity")]
    public int? MVecTempEntVelocity
    {
        get;
        set;
    }

    [JsonProperty("priority")]
    [JsonPropertyName("priority")]
    public int? Priority
    {
        get;
        set;
    }

    [JsonProperty("tempent_renderamt")]
    [JsonPropertyName("tempent_renderamt")]
    public int? TempentRenderamt
    {
        get;
        set;
    }

    [JsonProperty("tentOffset")]
    [JsonPropertyName("tentOffset")]
    public int? TentOffset
    {
        get;
        set;
    }

    [JsonProperty("x")]
    [JsonPropertyName("x")]
    public int? X
    {
        get;
        set;
    }

    [JsonProperty("y")]
    [JsonPropertyName("y")]
    public int? Y
    {
        get;
        set;
    }

    [JsonProperty("m_bDisabledHud")]
    [JsonPropertyName("m_bDisabledHud")]
    public int? MBDisabledHud
    {
        get;
        set;
    }

    [JsonProperty("m_nAccountIDs")]
    [JsonPropertyName("m_nAccountIDs")]
    public int? MNAccountIDs
    {
        get;
        set;
    }

    [JsonProperty("m_nCurrentPhase")]
    [JsonPropertyName("m_nCurrentPhase")]
    public int? MNCurrentPhase
    {
        get;
        set;
    }

    [JsonProperty("m_nDraftType")]
    [JsonPropertyName("m_nDraftType")]
    public int? MNDraftType
    {
        get;
        set;
    }

    [JsonProperty("m_nMapId0")]
    [JsonPropertyName("m_nMapId0")]
    public int? MNMapId0
    {
        get;
        set;
    }

    [JsonProperty("m_nMapId1")]
    [JsonPropertyName("m_nMapId1")]
    public int? MNMapId1
    {
        get;
        set;
    }

    [JsonProperty("m_nMapId2")]
    [JsonPropertyName("m_nMapId2")]
    public int? MNMapId2
    {
        get;
        set;
    }

    [JsonProperty("m_nMapId3")]
    [JsonPropertyName("m_nMapId3")]
    public int? MNMapId3
    {
        get;
        set;
    }

    [JsonProperty("m_nMapId4")]
    [JsonPropertyName("m_nMapId4")]
    public int? MNMapId4
    {
        get;
        set;
    }

    [JsonProperty("m_nMapId5")]
    [JsonPropertyName("m_nMapId5")]
    public int? MNMapId5
    {
        get;
        set;
    }

    [JsonProperty("m_nPhaseDurationTicks")]
    [JsonPropertyName("m_nPhaseDurationTicks")]
    public int? MNPhaseDurationTicks
    {
        get;
        set;
    }

    [JsonProperty("m_nPhaseStartTick")]
    [JsonPropertyName("m_nPhaseStartTick")]
    public int? MNPhaseStartTick
    {
        get;
        set;
    }

    [JsonProperty("m_nPostDataUpdateTick")]
    [JsonPropertyName("m_nPostDataUpdateTick")]
    public int? MNPostDataUpdateTick
    {
        get;
        set;
    }

    [JsonProperty("m_nStartingSide0")]
    [JsonPropertyName("m_nStartingSide0")]
    public int? MNStartingSide0
    {
        get;
        set;
    }

    [JsonProperty("m_nTeamWinningCoinToss")]
    [JsonPropertyName("m_nTeamWinningCoinToss")]
    public int? MNTeamWinningCoinToss
    {
        get;
        set;
    }

    [JsonProperty("m_nTeamWithFirstChoice")]
    [JsonPropertyName("m_nTeamWithFirstChoice")]
    public int? MNTeamWithFirstChoice
    {
        get;
        set;
    }

    [JsonProperty("m_nVoteMapIdsList")]
    [JsonPropertyName("m_nVoteMapIdsList")]
    public int? MNVoteMapIdsList
    {
        get;
        set;
    }

    [JsonProperty("m_bAbandonAllowsSurrender")]
    [JsonPropertyName("m_bAbandonAllowsSurrender")]
    public int? MBAbandonAllowsSurrender
    {
        get;
        set;
    }

    [JsonProperty("m_bAbandonOffersInstantSurrender")]
    [JsonPropertyName("m_bAbandonOffersInstantSurrender")]
    public int? MBAbandonOffersInstantSurrender
    {
        get;
        set;
    }

    [JsonProperty("m_bCanControlObservedBot")]
    [JsonPropertyName("m_bCanControlObservedBot")]
    public int? MBCanControlObservedBot
    {
        get;
        set;
    }

    [JsonProperty("m_bCannotBeKicked")]
    [JsonPropertyName("m_bCannotBeKicked")]
    public int? MBCannotBeKicked
    {
        get;
        set;
    }

    [JsonProperty("m_bControllingBot")]
    [JsonPropertyName("m_bControllingBot")]
    public int? MBControllingBot
    {
        get;
        set;
    }

    [JsonProperty("m_bDisconnection1MinWarningPrinted")]
    [JsonPropertyName("m_bDisconnection1MinWarningPrinted")]
    public int? MBDisconnection1MinWarningPrinted
    {
        get;
        set;
    }

    [JsonProperty("m_bEverFullyConnected")]
    [JsonPropertyName("m_bEverFullyConnected")]
    public int? MBEverFullyConnected
    {
        get;
        set;
    }

    [JsonProperty("m_bEverPlayedOnTeam")]
    [JsonPropertyName("m_bEverPlayedOnTeam")]
    public int? MBEverPlayedOnTeam
    {
        get;
        set;
    }

    [JsonProperty("m_bFireBulletsSeedSynchronized")]
    [JsonPropertyName("m_bFireBulletsSeedSynchronized")]
    public int? MBFireBulletsSeedSynchronized
    {
        get;
        set;
    }

    [JsonProperty("m_bHasBeenControlledByPlayerThisRound")]
    [JsonPropertyName("m_bHasBeenControlledByPlayerThisRound")]
    public int? MBHasBeenControlledByPlayerThisRound
    {
        get;
        set;
    }

    [JsonProperty("m_bHasCommunicationAbuseMute")]
    [JsonPropertyName("m_bHasCommunicationAbuseMute")]
    public int? MBHasCommunicationAbuseMute
    {
        get;
        set;
    }

    [JsonProperty("m_bHasControlledBotThisRound")]
    [JsonPropertyName("m_bHasControlledBotThisRound")]
    public int? MBHasControlledBotThisRound
    {
        get;
        set;
    }

    [JsonProperty("m_bIsPlayerNameDirty")]
    [JsonPropertyName("m_bIsPlayerNameDirty")]
    public int? MBIsPlayerNameDirty
    {
        get;
        set;
    }

    [JsonProperty("m_bMvpNoMusic")]
    [JsonPropertyName("m_bMvpNoMusic")]
    public int? MBMvpNoMusic
    {
        get;
        set;
    }

    [JsonProperty("m_bPawnHasDefuser")]
    [JsonPropertyName("m_bPawnHasDefuser")]
    public int? MBPawnHasDefuser
    {
        get;
        set;
    }

    [JsonProperty("m_bPawnHasHelmet")]
    [JsonPropertyName("m_bPawnHasHelmet")]
    public int? MBPawnHasHelmet
    {
        get;
        set;
    }

    [JsonProperty("m_bPawnIsAlive")]
    [JsonPropertyName("m_bPawnIsAlive")]
    public int? MBPawnIsAlive
    {
        get;
        set;
    }

    [JsonProperty("m_bScoreReported")]
    [JsonPropertyName("m_bScoreReported")]
    public int? MBScoreReported
    {
        get;
        set;
    }

    [JsonProperty("m_eMvpReason")]
    [JsonPropertyName("m_eMvpReason")]
    public int? MEMvpReason
    {
        get;
        set;
    }

    [JsonProperty("m_eNetworkDisconnectionReason")]
    [JsonPropertyName("m_eNetworkDisconnectionReason")]
    public int? MENetworkDisconnectionReason
    {
        get;
        set;
    }

    [JsonProperty("m_flForceTeamTime")]
    [JsonPropertyName("m_flForceTeamTime")]
    public int? MFlForceTeamTime
    {
        get;
        set;
    }

    [JsonProperty("m_flPreviousForceJoinTeamTime")]
    [JsonPropertyName("m_flPreviousForceJoinTeamTime")]
    public int? MFlPreviousForceJoinTeamTime
    {
        get;
        set;
    }

    [JsonProperty("m_hObserverPawn")]
    [JsonPropertyName("m_hObserverPawn")]
    public int? MHObserverPawn
    {
        get;
        set;
    }

    [JsonProperty("m_hOriginalControllerOfCurrentPawn")]
    [JsonPropertyName("m_hOriginalControllerOfCurrentPawn")]
    public int? MHOriginalControllerOfCurrentPawn
    {
        get;
        set;
    }

    [JsonProperty("m_hPlayerPawn")]
    [JsonPropertyName("m_hPlayerPawn")]
    public int? MHPlayerPawn
    {
        get;
        set;
    }

    [JsonProperty("m_iCoachingTeam")]
    [JsonPropertyName("m_iCoachingTeam")]
    public int? MICoachingTeam
    {
        get;
        set;
    }

    [JsonProperty("m_iCompTeammateColor")]
    [JsonPropertyName("m_iCompTeammateColor")]
    public int? MICompTeammateColor
    {
        get;
        set;
    }

    [JsonProperty("m_iCompetitiveRankType")]
    [JsonPropertyName("m_iCompetitiveRankType")]
    public int? MICompetitiveRankType
    {
        get;
        set;
    }

    [JsonProperty("m_iCompetitiveRanking")]
    [JsonPropertyName("m_iCompetitiveRanking")]
    public int? MICompetitiveRanking
    {
        get;
        set;
    }

    [JsonProperty("m_iCompetitiveRankingPredicted_Loss")]
    [JsonPropertyName("m_iCompetitiveRankingPredicted_Loss")]
    public int? MICompetitiveRankingPredictedLoss
    {
        get;
        set;
    }

    [JsonProperty("m_iCompetitiveRankingPredicted_Tie")]
    [JsonPropertyName("m_iCompetitiveRankingPredicted_Tie")]
    public int? MICompetitiveRankingPredictedTie
    {
        get;
        set;
    }

    [JsonProperty("m_iCompetitiveRankingPredicted_Win")]
    [JsonPropertyName("m_iCompetitiveRankingPredicted_Win")]
    public int? MICompetitiveRankingPredictedWin
    {
        get;
        set;
    }

    [JsonProperty("m_iCompetitiveWins")]
    [JsonPropertyName("m_iCompetitiveWins")]
    public int? MICompetitiveWins
    {
        get;
        set;
    }

    [JsonProperty("m_iDraftIndex")]
    [JsonPropertyName("m_iDraftIndex")]
    public int? MIDraftIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iMVPs")]
    [JsonPropertyName("m_iMVPs")]
    public int? MIMVPs
    {
        get;
        set;
    }

    [JsonProperty("m_iMusicKitID")]
    [JsonPropertyName("m_iMusicKitID")]
    public int? MIMusicKitID
    {
        get;
        set;
    }

    [JsonProperty("m_iMusicKitMVPs")]
    [JsonPropertyName("m_iMusicKitMVPs")]
    public int? MIMusicKitMVPs
    {
        get;
        set;
    }

    [JsonProperty("m_iPawnArmor")]
    [JsonPropertyName("m_iPawnArmor")]
    public int? MIPawnArmor
    {
        get;
        set;
    }

    [JsonProperty("m_iPawnBotDifficulty")]
    [JsonPropertyName("m_iPawnBotDifficulty")]
    public int? MIPawnBotDifficulty
    {
        get;
        set;
    }

    [JsonProperty("m_iPawnHealth")]
    [JsonPropertyName("m_iPawnHealth")]
    public int? MIPawnHealth
    {
        get;
        set;
    }

    [JsonProperty("m_iPawnLifetimeEnd")]
    [JsonPropertyName("m_iPawnLifetimeEnd")]
    public int? MIPawnLifetimeEnd
    {
        get;
        set;
    }

    [JsonProperty("m_iPawnLifetimeStart")]
    [JsonPropertyName("m_iPawnLifetimeStart")]
    public int? MIPawnLifetimeStart
    {
        get;
        set;
    }

    [JsonProperty("m_iPendingTeamNum")]
    [JsonPropertyName("m_iPendingTeamNum")]
    public int? MIPendingTeamNum
    {
        get;
        set;
    }

    [JsonProperty("m_iPing")]
    [JsonPropertyName("m_iPing")]
    public int? MIPing
    {
        get;
        set;
    }

    [JsonProperty("m_iScore")]
    [JsonPropertyName("m_iScore")]
    public int? MIScore
    {
        get;
        set;
    }

    [JsonProperty("m_msQueuedModeDisconnectionTimestamp")]
    [JsonPropertyName("m_msQueuedModeDisconnectionTimestamp")]
    public int? MMsQueuedModeDisconnectionTimestamp
    {
        get;
        set;
    }

    [JsonProperty("m_nBotsControlledThisRound")]
    [JsonPropertyName("m_nBotsControlledThisRound")]
    public int? MNBotsControlledThisRound
    {
        get;
        set;
    }

    [JsonProperty("m_nDisconnectionTick")]
    [JsonPropertyName("m_nDisconnectionTick")]
    public int? MNDisconnectionTick
    {
        get;
        set;
    }

    [JsonProperty("m_nEndMatchNextMapVote")]
    [JsonPropertyName("m_nEndMatchNextMapVote")]
    public int? MNEndMatchNextMapVote
    {
        get;
        set;
    }

    [JsonProperty("m_nFirstKill")]
    [JsonPropertyName("m_nFirstKill")]
    public int? MNFirstKill
    {
        get;
        set;
    }

    [JsonProperty("m_nKillCount")]
    [JsonPropertyName("m_nKillCount")]
    public int? MNKillCount
    {
        get;
        set;
    }

    [JsonProperty("m_nPawnCharacterDefIndex")]
    [JsonPropertyName("m_nPawnCharacterDefIndex")]
    public int? MNPawnCharacterDefIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nPlayerDominated")]
    [JsonPropertyName("m_nPlayerDominated")]
    public int? MNPlayerDominated
    {
        get;
        set;
    }

    [JsonProperty("m_nPlayerDominatingMe")]
    [JsonPropertyName("m_nPlayerDominatingMe")]
    public int? MNPlayerDominatingMe
    {
        get;
        set;
    }

    [JsonProperty("m_nQuestProgressReason")]
    [JsonPropertyName("m_nQuestProgressReason")]
    public int? MNQuestProgressReason
    {
        get;
        set;
    }

    [JsonProperty("m_pDamageServices")]
    [JsonPropertyName("m_pDamageServices")]
    public int? MPDamageServices
    {
        get;
        set;
    }

    [JsonProperty("m_pInGameMoneyServices")]
    [JsonPropertyName("m_pInGameMoneyServices")]
    public int? MPInGameMoneyServices
    {
        get;
        set;
    }

    [JsonProperty("m_pInventoryServices")]
    [JsonPropertyName("m_pInventoryServices")]
    public int? MPInventoryServices
    {
        get;
        set;
    }

    [JsonProperty("m_recentKillQueue")]
    [JsonPropertyName("m_recentKillQueue")]
    public int? MRecentKillQueue
    {
        get;
        set;
    }

    [JsonProperty("m_rtActiveMissionPeriod")]
    [JsonPropertyName("m_rtActiveMissionPeriod")]
    public int? MRtActiveMissionPeriod
    {
        get;
        set;
    }

    [JsonProperty("m_sSanitizedPlayerName")]
    [JsonPropertyName("m_sSanitizedPlayerName")]
    public int? MSSanitizedPlayerName
    {
        get;
        set;
    }

    [JsonProperty("m_szClan")]
    [JsonPropertyName("m_szClan")]
    public int? MSzClan
    {
        get;
        set;
    }

    [JsonProperty("m_szCrosshairCodes")]
    [JsonPropertyName("m_szCrosshairCodes")]
    public int? MSzCrosshairCodes
    {
        get;
        set;
    }

    [JsonProperty("m_uiAbandonRecordedReason")]
    [JsonPropertyName("m_uiAbandonRecordedReason")]
    public int? MUiAbandonRecordedReason
    {
        get;
        set;
    }

    [JsonProperty("m_uiCommunicationMuteFlags")]
    [JsonPropertyName("m_uiCommunicationMuteFlags")]
    public int? MUiCommunicationMuteFlags
    {
        get;
        set;
    }

    [JsonProperty("m_unActiveQuestId")]
    [JsonPropertyName("m_unActiveQuestId")]
    public int? MUnActiveQuestId
    {
        get;
        set;
    }

    [JsonProperty("m_unPlayerTvControlFlags")]
    [JsonPropertyName("m_unPlayerTvControlFlags")]
    public int? MUnPlayerTvControlFlags
    {
        get;
        set;
    }

    [JsonProperty("m_bIsIncGrenade")]
    [JsonPropertyName("m_bIsIncGrenade")]
    public int? MBIsIncGrenade
    {
        get;
        set;
    }

    [JsonProperty("m_hTargetC4")]
    [JsonPropertyName("m_hTargetC4")]
    public int? MHTargetC4
    {
        get;
        set;
    }

    [JsonProperty("m_strNametagString")]
    [JsonPropertyName("m_strNametagString")]
    public int? MStrNametagString
    {
        get;
        set;
    }

    [JsonProperty("m_bShowLight")]
    [JsonPropertyName("m_bShowLight")]
    public int? MBShowLight
    {
        get;
        set;
    }

    [JsonProperty("m_flInnerAngle")]
    [JsonPropertyName("m_flInnerAngle")]
    public int? MFlInnerAngle
    {
        get;
        set;
    }

    [JsonProperty("m_flOuterAngle")]
    [JsonPropertyName("m_flOuterAngle")]
    public int? MFlOuterAngle
    {
        get;
        set;
    }

    [JsonProperty("m_bAnimateDuringGameplayPause")]
    [JsonPropertyName("m_bAnimateDuringGameplayPause")]
    public int? MBAnimateDuringGameplayPause
    {
        get;
        set;
    }

    [JsonProperty("m_bFrozen")]
    [JsonPropertyName("m_bFrozen")]
    public int? MBFrozen
    {
        get;
        set;
    }

    [JsonProperty("m_bNoFreeze")]
    [JsonPropertyName("m_bNoFreeze")]
    public int? MBNoFreeze
    {
        get;
        set;
    }

    [JsonProperty("m_bNoRamp")]
    [JsonPropertyName("m_bNoRamp")]
    public int? MBNoRamp
    {
        get;
        set;
    }

    [JsonProperty("m_bNoSave")]
    [JsonPropertyName("m_bNoSave")]
    public int? MBNoSave
    {
        get;
        set;
    }

    [JsonProperty("m_bOldActive")]
    [JsonPropertyName("m_bOldActive")]
    public int? MBOldActive
    {
        get;
        set;
    }

    [JsonProperty("m_bOldFrozen")]
    [JsonPropertyName("m_bOldFrozen")]
    public int? MBOldFrozen
    {
        get;
        set;
    }

    [JsonProperty("m_bStartActive")]
    [JsonPropertyName("m_bStartActive")]
    public int? MBStartActive
    {
        get;
        set;
    }

    [JsonProperty("m_clrTint")]
    [JsonPropertyName("m_clrTint")]
    public int? MClrTint
    {
        get;
        set;
    }

    [JsonProperty("m_flFreezeTransitionDuration")]
    [JsonPropertyName("m_flFreezeTransitionDuration")]
    public int? MFlFreezeTransitionDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flPreSimTime")]
    [JsonPropertyName("m_flPreSimTime")]
    public int? MFlPreSimTime
    {
        get;
        set;
    }

    [JsonProperty("m_hControlPointEnts")]
    [JsonPropertyName("m_hControlPointEnts")]
    public int? MHControlPointEnts
    {
        get;
        set;
    }

    [JsonProperty("m_iEffectIndex")]
    [JsonPropertyName("m_iEffectIndex")]
    public int? MIEffectIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iServerControlPointAssignments")]
    [JsonPropertyName("m_iServerControlPointAssignments")]
    public int? MIServerControlPointAssignments
    {
        get;
        set;
    }

    [JsonProperty("m_iszControlPointNames")]
    [JsonPropertyName("m_iszControlPointNames")]
    public int? MIszControlPointNames
    {
        get;
        set;
    }

    [JsonProperty("m_iszEffectName")]
    [JsonPropertyName("m_iszEffectName")]
    public int? MIszEffectName
    {
        get;
        set;
    }

    [JsonProperty("m_nDataCP")]
    [JsonPropertyName("m_nDataCP")]
    public int? MNDataCP
    {
        get;
        set;
    }

    [JsonProperty("m_nStopType")]
    [JsonPropertyName("m_nStopType")]
    public int? MNStopType
    {
        get;
        set;
    }

    [JsonProperty("m_nTintCP")]
    [JsonPropertyName("m_nTintCP")]
    public int? MNTintCP
    {
        get;
        set;
    }

    [JsonProperty("m_szSnapshotFileName")]
    [JsonPropertyName("m_szSnapshotFileName")]
    public int? MSzSnapshotFileName
    {
        get;
        set;
    }

    [JsonProperty("m_vServerControlPoints")]
    [JsonPropertyName("m_vServerControlPoints")]
    public int? MVServerControlPoints
    {
        get;
        set;
    }

    [JsonProperty("m_vecDataCPValue")]
    [JsonPropertyName("m_vecDataCPValue")]
    public int? MVecDataCPValue
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_Color")]
    [JsonPropertyName("m_PathNodes_Color")]
    public int? MPathNodesColor
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_Name")]
    [JsonPropertyName("m_PathNodes_Name")]
    public int? MPathNodesName
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_PinEnabled")]
    [JsonPropertyName("m_PathNodes_PinEnabled")]
    public int? MPathNodesPinEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_Position")]
    [JsonPropertyName("m_PathNodes_Position")]
    public int? MPathNodesPosition
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_RadiusScale")]
    [JsonPropertyName("m_PathNodes_RadiusScale")]
    public int? MPathNodesRadiusScale
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_TangentIn")]
    [JsonPropertyName("m_PathNodes_TangentIn")]
    public int? MPathNodesTangentIn
    {
        get;
        set;
    }

    [JsonProperty("m_PathNodes_TangentOut")]
    [JsonPropertyName("m_PathNodes_TangentOut")]
    public int? MPathNodesTangentOut
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxSimulationTime")]
    [JsonPropertyName("m_flMaxSimulationTime")]
    public int? MFlMaxSimulationTime
    {
        get;
        set;
    }

    [JsonProperty("m_flParticleSpacing")]
    [JsonPropertyName("m_flParticleSpacing")]
    public int? MFlParticleSpacing
    {
        get;
        set;
    }

    [JsonProperty("m_flSlack")]
    [JsonPropertyName("m_flSlack")]
    public int? MFlSlack
    {
        get;
        set;
    }

    [JsonProperty("m_nEffectState")]
    [JsonPropertyName("m_nEffectState")]
    public int? MNEffectState
    {
        get;
        set;
    }

    [JsonProperty("m_flTotalRoundDamageDealt")]
    [JsonPropertyName("m_flTotalRoundDamageDealt")]
    public int? MFlTotalRoundDamageDealt
    {
        get;
        set;
    }

    [JsonProperty("m_iNumRoundKills")]
    [JsonPropertyName("m_iNumRoundKills")]
    public int? MINumRoundKills
    {
        get;
        set;
    }

    [JsonProperty("m_iNumRoundKillsHeadshots")]
    [JsonPropertyName("m_iNumRoundKillsHeadshots")]
    public int? MINumRoundKillsHeadshots
    {
        get;
        set;
    }

    [JsonProperty("m_matchStats")]
    [JsonPropertyName("m_matchStats")]
    public int? MMatchStats
    {
        get;
        set;
    }

    [JsonProperty("m_perRoundStats")]
    [JsonPropertyName("m_perRoundStats")]
    public int? MPerRoundStats
    {
        get;
        set;
    }

    [JsonProperty("m_aAttachedObjects")]
    [JsonPropertyName("m_aAttachedObjects")]
    public int? MAAttachedObjects
    {
        get;
        set;
    }

    [JsonProperty("m_aAttachedObjectsFromServer")]
    [JsonPropertyName("m_aAttachedObjectsFromServer")]
    public int? MAAttachedObjectsFromServer
    {
        get;
        set;
    }

    [JsonProperty("m_fDeathTime")]
    [JsonPropertyName("m_fDeathTime")]
    public int? MFDeathTime
    {
        get;
        set;
    }

    [JsonProperty("m_flTouchDelta")]
    [JsonPropertyName("m_flTouchDelta")]
    public int? MFlTouchDelta
    {
        get;
        set;
    }

    [JsonProperty("m_nDamageType")]
    [JsonPropertyName("m_nDamageType")]
    public int? MNDamageType
    {
        get;
        set;
    }

    [JsonProperty("m_vecDamageDirection")]
    [JsonPropertyName("m_vecDamageDirection")]
    public int? MVecDamageDirection
    {
        get;
        set;
    }

    [JsonProperty("m_vecDamagePosition")]
    [JsonPropertyName("m_vecDamagePosition")]
    public int? MVecDamagePosition
    {
        get;
        set;
    }

    [JsonProperty("m_bAwake")]
    [JsonPropertyName("m_bAwake")]
    public int? MBAwake
    {
        get;
        set;
    }

    [JsonProperty("m_bBeingDefused")]
    [JsonPropertyName("m_bBeingDefused")]
    public int? MBBeingDefused
    {
        get;
        set;
    }

    [JsonProperty("m_bBombDefused")]
    [JsonPropertyName("m_bBombDefused")]
    public int? MBBombDefused
    {
        get;
        set;
    }

    [JsonProperty("m_bBombTicking")]
    [JsonPropertyName("m_bBombTicking")]
    public int? MBBombTicking
    {
        get;
        set;
    }

    [JsonProperty("m_bC4Activated")]
    [JsonPropertyName("m_bC4Activated")]
    public int? MBC4Activated
    {
        get;
        set;
    }

    [JsonProperty("m_bCannotBeDefused")]
    [JsonPropertyName("m_bCannotBeDefused")]
    public int? MBCannotBeDefused
    {
        get;
        set;
    }

    [JsonProperty("m_bExplodeWarning")]
    [JsonPropertyName("m_bExplodeWarning")]
    public int? MBExplodeWarning
    {
        get;
        set;
    }

    [JsonProperty("m_bHasExploded")]
    [JsonPropertyName("m_bHasExploded")]
    public int? MBHasExploded
    {
        get;
        set;
    }

    [JsonProperty("m_bRadarFlash")]
    [JsonPropertyName("m_bRadarFlash")]
    public int? MBRadarFlash
    {
        get;
        set;
    }

    [JsonProperty("m_bTenSecWarning")]
    [JsonPropertyName("m_bTenSecWarning")]
    public int? MBTenSecWarning
    {
        get;
        set;
    }

    [JsonProperty("m_bTriggerWarning")]
    [JsonPropertyName("m_bTriggerWarning")]
    public int? MBTriggerWarning
    {
        get;
        set;
    }

    [JsonProperty("m_fLastDefuseTime")]
    [JsonPropertyName("m_fLastDefuseTime")]
    public int? MFLastDefuseTime
    {
        get;
        set;
    }

    [JsonProperty("m_flC4Blow")]
    [JsonPropertyName("m_flC4Blow")]
    public int? MFlC4Blow
    {
        get;
        set;
    }

    [JsonProperty("m_flC4ExplodeSpectateDuration")]
    [JsonPropertyName("m_flC4ExplodeSpectateDuration")]
    public int? MFlC4ExplodeSpectateDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flDefuseCountDown")]
    [JsonPropertyName("m_flDefuseCountDown")]
    public int? MFlDefuseCountDown
    {
        get;
        set;
    }

    [JsonProperty("m_flDefuseLength")]
    [JsonPropertyName("m_flDefuseLength")]
    public int? MFlDefuseLength
    {
        get;
        set;
    }

    [JsonProperty("m_flNextBeep")]
    [JsonPropertyName("m_flNextBeep")]
    public int? MFlNextBeep
    {
        get;
        set;
    }

    [JsonProperty("m_flNextGlow")]
    [JsonPropertyName("m_flNextGlow")]
    public int? MFlNextGlow
    {
        get;
        set;
    }

    [JsonProperty("m_flNextRadarFlashTime")]
    [JsonPropertyName("m_flNextRadarFlashTime")]
    public int? MFlNextRadarFlashTime
    {
        get;
        set;
    }

    [JsonProperty("m_flTimerLength")]
    [JsonPropertyName("m_flTimerLength")]
    public int? MFlTimerLength
    {
        get;
        set;
    }

    [JsonProperty("m_hBombDefuser")]
    [JsonPropertyName("m_hBombDefuser")]
    public int? MHBombDefuser
    {
        get;
        set;
    }

    [JsonProperty("m_hDefuserMultimeter")]
    [JsonPropertyName("m_hDefuserMultimeter")]
    public int? MHDefuserMultimeter
    {
        get;
        set;
    }

    [JsonProperty("m_nBombSite")]
    [JsonPropertyName("m_nBombSite")]
    public int? MNBombSite
    {
        get;
        set;
    }

    [JsonProperty("m_nSourceSoundscapeHash")]
    [JsonPropertyName("m_nSourceSoundscapeHash")]
    public int? MNSourceSoundscapeHash
    {
        get;
        set;
    }

    [JsonProperty("m_pBombDefuser")]
    [JsonPropertyName("m_pBombDefuser")]
    public int? MPBombDefuser
    {
        get;
        set;
    }

    [JsonProperty("m_vecC4ExplodeSpectateAng")]
    [JsonPropertyName("m_vecC4ExplodeSpectateAng")]
    public int? MVecC4ExplodeSpectateAng
    {
        get;
        set;
    }

    [JsonProperty("m_vecC4ExplodeSpectatePos")]
    [JsonPropertyName("m_vecC4ExplodeSpectatePos")]
    public int? MVecC4ExplodeSpectatePos
    {
        get;
        set;
    }

    [JsonProperty("m_bUrgent")]
    [JsonPropertyName("m_bUrgent")]
    public int? MBUrgent
    {
        get;
        set;
    }

    [JsonProperty("m_hPingedEntity")]
    [JsonPropertyName("m_hPingedEntity")]
    public int? MHPingedEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hPlayer")]
    [JsonPropertyName("m_hPlayer")]
    public int? MHPlayer
    {
        get;
        set;
    }

    [JsonProperty("m_iType")]
    [JsonPropertyName("m_iType")]
    public int? MIType
    {
        get;
        set;
    }

    [JsonProperty("m_szPlaceName")]
    [JsonPropertyName("m_szPlaceName")]
    public int? MSzPlaceName
    {
        get;
        set;
    }

    [JsonProperty("m_SprayRenderHelper")]
    [JsonPropertyName("m_SprayRenderHelper")]
    public int? MSprayRenderHelper
    {
        get;
        set;
    }

    [JsonProperty("m_flCreationTime")]
    [JsonPropertyName("m_flCreationTime")]
    public int? MFlCreationTime
    {
        get;
        set;
    }

    [JsonProperty("m_nEntity")]
    [JsonPropertyName("m_nEntity")]
    public int? MNEntity
    {
        get;
        set;
    }

    [JsonProperty("m_nHitbox")]
    [JsonPropertyName("m_nHitbox")]
    public int? MNHitbox
    {
        get;
        set;
    }

    [JsonProperty("m_nPlayer")]
    [JsonPropertyName("m_nPlayer")]
    public int? MNPlayer
    {
        get;
        set;
    }

    [JsonProperty("m_nTintID")]
    [JsonPropertyName("m_nTintID")]
    public int? MNTintID
    {
        get;
        set;
    }

    [JsonProperty("m_nUniqueID")]
    [JsonPropertyName("m_nUniqueID")]
    public int? MNUniqueID
    {
        get;
        set;
    }

    [JsonProperty("m_nVersion")]
    [JsonPropertyName("m_nVersion")]
    public int? MNVersion
    {
        get;
        set;
    }

    [JsonProperty("m_rtGcTime")]
    [JsonPropertyName("m_rtGcTime")]
    public int? MRtGcTime
    {
        get;
        set;
    }

    [JsonProperty("m_ubSignature")]
    [JsonPropertyName("m_ubSignature")]
    public int? MUbSignature
    {
        get;
        set;
    }

    [JsonProperty("m_unAccountID")]
    [JsonPropertyName("m_unAccountID")]
    public int? MUnAccountID
    {
        get;
        set;
    }

    [JsonProperty("m_unTraceID")]
    [JsonPropertyName("m_unTraceID")]
    public int? MUnTraceID
    {
        get;
        set;
    }

    [JsonProperty("m_vecLeft")]
    [JsonPropertyName("m_vecLeft")]
    public int? MVecLeft
    {
        get;
        set;
    }

    [JsonProperty("m_vecStart")]
    [JsonPropertyName("m_vecStart")]
    public int? MVecStart
    {
        get;
        set;
    }

    [JsonProperty("m_flFogDistanceMultiplier")]
    [JsonPropertyName("m_flFogDistanceMultiplier")]
    public int? MFlFogDistanceMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMaxDensityMultiplier")]
    [JsonPropertyName("m_flFogMaxDensityMultiplier")]
    public int? MFlFogMaxDensityMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flVisibilityStrength")]
    [JsonPropertyName("m_flVisibilityStrength")]
    public int? MFlVisibilityStrength
    {
        get;
        set;
    }

    [JsonProperty("m_DegreesPerSecond")]
    [JsonPropertyName("m_DegreesPerSecond")]
    public int? MDegreesPerSecond
    {
        get;
        set;
    }

    [JsonProperty("m_FOV")]
    [JsonPropertyName("m_FOV")]
    public int? MFOV
    {
        get;
        set;
    }

    [JsonProperty("m_Resolution")]
    [JsonPropertyName("m_Resolution")]
    public int? MResolution
    {
        get;
        set;
    }

    [JsonProperty("m_TargetFOV")]
    [JsonPropertyName("m_TargetFOV")]
    public int? MTargetFOV
    {
        get;
        set;
    }

    [JsonProperty("m_bAlignWithParent")]
    [JsonPropertyName("m_bAlignWithParent")]
    public int? MBAlignWithParent
    {
        get;
        set;
    }

    [JsonProperty("m_bCanHLTVUse")]
    [JsonPropertyName("m_bCanHLTVUse")]
    public int? MBCanHLTVUse
    {
        get;
        set;
    }

    [JsonProperty("m_bFogEnable")]
    [JsonPropertyName("m_bFogEnable")]
    public int? MBFogEnable
    {
        get;
        set;
    }

    [JsonProperty("m_bIsOn")]
    [JsonPropertyName("m_bIsOn")]
    public int? MBIsOn
    {
        get;
        set;
    }

    [JsonProperty("m_bNoSky")]
    [JsonPropertyName("m_bNoSky")]
    public int? MBNoSky
    {
        get;
        set;
    }

    [JsonProperty("m_bUseScreenAspectRatio")]
    [JsonPropertyName("m_bUseScreenAspectRatio")]
    public int? MBUseScreenAspectRatio
    {
        get;
        set;
    }

    [JsonProperty("m_fBrightness")]
    [JsonPropertyName("m_fBrightness")]
    public int? MFBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_flAspectRatio")]
    [JsonPropertyName("m_flAspectRatio")]
    public int? MFlAspectRatio
    {
        get;
        set;
    }

    [JsonProperty("m_flFogEnd")]
    [JsonPropertyName("m_flFogEnd")]
    public int? MFlFogEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flFogMaxDensity")]
    [JsonPropertyName("m_flFogMaxDensity")]
    public int? MFlFogMaxDensity
    {
        get;
        set;
    }

    [JsonProperty("m_flFogStart")]
    [JsonPropertyName("m_flFogStart")]
    public int? MFlFogStart
    {
        get;
        set;
    }

    [JsonProperty("m_pNext")]
    [JsonPropertyName("m_pNext")]
    public int? MPNext
    {
        get;
        set;
    }

    [JsonProperty("m_flVerticalFOV")]
    [JsonPropertyName("m_flVerticalFOV")]
    public int? MFlVerticalFOV
    {
        get;
        set;
    }

    [JsonProperty("m_DamageList")]
    [JsonPropertyName("m_DamageList")]
    public int? MDamageList
    {
        get;
        set;
    }

    [JsonProperty("m_nSendUpdate")]
    [JsonPropertyName("m_nSendUpdate")]
    public int? MNSendUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_bStartEnabled")]
    [JsonPropertyName("m_bStartEnabled")]
    public int? MBStartEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_hActivator")]
    [JsonPropertyName("m_hActivator")]
    public int? MHActivator
    {
        get;
        set;
    }

    [JsonProperty("m_bAllowInteractionFromAllSceneWorlds")]
    [JsonPropertyName("m_bAllowInteractionFromAllSceneWorlds")]
    public int? MBAllowInteractionFromAllSceneWorlds
    {
        get;
        set;
    }

    [JsonProperty("m_bCheckCSSClasses")]
    [JsonPropertyName("m_bCheckCSSClasses")]
    public int? MBCheckCSSClasses
    {
        get;
        set;
    }

    [JsonProperty("m_bIgnoreInput")]
    [JsonPropertyName("m_bIgnoreInput")]
    public int? MBIgnoreInput
    {
        get;
        set;
    }

    [JsonProperty("m_flDPI")]
    [JsonPropertyName("m_flDPI")]
    public int? MFlDPI
    {
        get;
        set;
    }

    [JsonProperty("m_flDepthOffset")]
    [JsonPropertyName("m_flDepthOffset")]
    public int? MFlDepthOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flInteractDistance")]
    [JsonPropertyName("m_flInteractDistance")]
    public int? MFlInteractDistance
    {
        get;
        set;
    }

    [JsonProperty("m_unHorizontalAlign")]
    [JsonPropertyName("m_unHorizontalAlign")]
    public int? MUnHorizontalAlign
    {
        get;
        set;
    }

    [JsonProperty("m_unOrientation")]
    [JsonPropertyName("m_unOrientation")]
    public int? MUnOrientation
    {
        get;
        set;
    }

    [JsonProperty("m_unOwnerContext")]
    [JsonPropertyName("m_unOwnerContext")]
    public int? MUnOwnerContext
    {
        get;
        set;
    }

    [JsonProperty("m_unVerticalAlign")]
    [JsonPropertyName("m_unVerticalAlign")]
    public int? MUnVerticalAlign
    {
        get;
        set;
    }

    [JsonProperty("m_vecCSSClasses")]
    [JsonPropertyName("m_vecCSSClasses")]
    public int? MVecCSSClasses
    {
        get;
        set;
    }

    [JsonProperty("m_anchorDeltaTransform")]
    [JsonPropertyName("m_anchorDeltaTransform")]
    public int? MAnchorDeltaTransform
    {
        get;
        set;
    }

    [JsonProperty("m_bDisableMipGen")]
    [JsonPropertyName("m_bDisableMipGen")]
    public int? MBDisableMipGen
    {
        get;
        set;
    }

    [JsonProperty("m_bExcludeFromSaveGames")]
    [JsonPropertyName("m_bExcludeFromSaveGames")]
    public int? MBExcludeFromSaveGames
    {
        get;
        set;
    }

    [JsonProperty("m_bFollowPlayerAcrossTeleport")]
    [JsonPropertyName("m_bFollowPlayerAcrossTeleport")]
    public int? MBFollowPlayerAcrossTeleport
    {
        get;
        set;
    }

    [JsonProperty("m_bForceRecreateNextUpdate")]
    [JsonPropertyName("m_bForceRecreateNextUpdate")]
    public int? MBForceRecreateNextUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_bGrabbable")]
    [JsonPropertyName("m_bGrabbable")]
    public int? MBGrabbable
    {
        get;
        set;
    }

    [JsonProperty("m_bLit")]
    [JsonPropertyName("m_bLit")]
    public int? MBLit
    {
        get;
        set;
    }

    [JsonProperty("m_bMoveViewToPlayerNextThink")]
    [JsonPropertyName("m_bMoveViewToPlayerNextThink")]
    public int? MBMoveViewToPlayerNextThink
    {
        get;
        set;
    }

    [JsonProperty("m_bNoDepth")]
    [JsonPropertyName("m_bNoDepth")]
    public int? MBNoDepth
    {
        get;
        set;
    }

    [JsonProperty("m_bOnlyRenderToTexture")]
    [JsonPropertyName("m_bOnlyRenderToTexture")]
    public int? MBOnlyRenderToTexture
    {
        get;
        set;
    }

    [JsonProperty("m_bOpaque")]
    [JsonPropertyName("m_bOpaque")]
    public int? MBOpaque
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderBackface")]
    [JsonPropertyName("m_bRenderBackface")]
    public int? MBRenderBackface
    {
        get;
        set;
    }

    [JsonProperty("m_bUseOffScreenIndicator")]
    [JsonPropertyName("m_bUseOffScreenIndicator")]
    public int? MBUseOffScreenIndicator
    {
        get;
        set;
    }

    [JsonProperty("m_bVisibleWhenParentNoDraw")]
    [JsonPropertyName("m_bVisibleWhenParentNoDraw")]
    public int? MBVisibleWhenParentNoDraw
    {
        get;
        set;
    }

    [JsonProperty("m_nExplicitImageLayout")]
    [JsonPropertyName("m_nExplicitImageLayout")]
    public int? MNExplicitImageLayout
    {
        get;
        set;
    }

    [JsonProperty("m_pOffScreenIndicator")]
    [JsonPropertyName("m_pOffScreenIndicator")]
    public int? MPOffScreenIndicator
    {
        get;
        set;
    }

    [JsonProperty("m_messageText")]
    [JsonPropertyName("m_messageText")]
    public int? MMessageText
    {
        get;
        set;
    }

    [JsonProperty("m_bListenedTo")]
    [JsonPropertyName("m_bListenedTo")]
    public int? MBListenedTo
    {
        get;
        set;
    }

    [JsonProperty("m_bRestartAfterRestore")]
    [JsonPropertyName("m_bRestartAfterRestore")]
    public int? MBRestartAfterRestore
    {
        get;
        set;
    }

    [JsonProperty("m_bWasActive")]
    [JsonPropertyName("m_bWasActive")]
    public int? MBWasActive
    {
        get;
        set;
    }

    [JsonProperty("m_flEndTime")]
    [JsonPropertyName("m_flEndTime")]
    public int? MFlEndTime
    {
        get;
        set;
    }

    [JsonProperty("m_flStartTimeInCommentary")]
    [JsonPropertyName("m_flStartTimeInCommentary")]
    public int? MFlStartTimeInCommentary
    {
        get;
        set;
    }

    [JsonProperty("m_hViewPosition")]
    [JsonPropertyName("m_hViewPosition")]
    public int? MHViewPosition
    {
        get;
        set;
    }

    [JsonProperty("m_iNodeNumber")]
    [JsonPropertyName("m_iNodeNumber")]
    public int? MINodeNumber
    {
        get;
        set;
    }

    [JsonProperty("m_iNodeNumberMax")]
    [JsonPropertyName("m_iNodeNumberMax")]
    public int? MINodeNumberMax
    {
        get;
        set;
    }

    [JsonProperty("m_iszCommentaryFile")]
    [JsonPropertyName("m_iszCommentaryFile")]
    public int? MIszCommentaryFile
    {
        get;
        set;
    }

    [JsonProperty("m_iszSpeakers")]
    [JsonPropertyName("m_iszSpeakers")]
    public int? MIszSpeakers
    {
        get;
        set;
    }

    [JsonProperty("m_iszTitle")]
    [JsonPropertyName("m_iszTitle")]
    public int? MIszTitle
    {
        get;
        set;
    }

    [JsonProperty("m_bDisabledOld")]
    [JsonPropertyName("m_bDisabledOld")]
    public int? MBDisabledOld
    {
        get;
        set;
    }

    [JsonProperty("m_bEngaged")]
    [JsonPropertyName("m_bEngaged")]
    public int? MBEngaged
    {
        get;
        set;
    }

    [JsonProperty("m_bFirstUpdate")]
    [JsonPropertyName("m_bFirstUpdate")]
    public int? MBFirstUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_bRequiresUseKey")]
    [JsonPropertyName("m_bRequiresUseKey")]
    public int? MBRequiresUseKey
    {
        get;
        set;
    }

    [JsonProperty("m_bUpdateOnClient")]
    [JsonPropertyName("m_bUpdateOnClient")]
    public int? MBUpdateOnClient
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentMomentum")]
    [JsonPropertyName("m_flCurrentMomentum")]
    public int? MFlCurrentMomentum
    {
        get;
        set;
    }

    [JsonProperty("m_flDisengageDistance")]
    [JsonPropertyName("m_flDisengageDistance")]
    public int? MFlDisengageDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flEngageDistance")]
    [JsonPropertyName("m_flEngageDistance")]
    public int? MFlEngageDistance
    {
        get;
        set;
    }

    [JsonProperty("m_flInputOffset")]
    [JsonPropertyName("m_flInputOffset")]
    public int? MFlInputOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flMaximumChangePerSecond")]
    [JsonPropertyName("m_flMaximumChangePerSecond")]
    public int? MFlMaximumChangePerSecond
    {
        get;
        set;
    }

    [JsonProperty("m_flMomentumModifier")]
    [JsonPropertyName("m_flMomentumModifier")]
    public int? MFlMomentumModifier
    {
        get;
        set;
    }

    [JsonProperty("m_flPreviousUpdateTickTime")]
    [JsonPropertyName("m_flPreviousUpdateTickTime")]
    public int? MFlPreviousUpdateTickTime
    {
        get;
        set;
    }

    [JsonProperty("m_flPreviousValue")]
    [JsonPropertyName("m_flPreviousValue")]
    public int? MFlPreviousValue
    {
        get;
        set;
    }

    [JsonProperty("m_flRatchetOffset")]
    [JsonPropertyName("m_flRatchetOffset")]
    public int? MFlRatchetOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flSnapValue")]
    [JsonPropertyName("m_flSnapValue")]
    public int? MFlSnapValue
    {
        get;
        set;
    }

    [JsonProperty("m_hOutputEntities")]
    [JsonPropertyName("m_hOutputEntities")]
    public int? MHOutputEntities
    {
        get;
        set;
    }

    [JsonProperty("m_hRemapLineEnd")]
    [JsonPropertyName("m_hRemapLineEnd")]
    public int? MHRemapLineEnd
    {
        get;
        set;
    }

    [JsonProperty("m_hRemapLineStart")]
    [JsonPropertyName("m_hRemapLineStart")]
    public int? MHRemapLineStart
    {
        get;
        set;
    }

    [JsonProperty("m_nHapticsType")]
    [JsonPropertyName("m_nHapticsType")]
    public int? MNHapticsType
    {
        get;
        set;
    }

    [JsonProperty("m_nInputType")]
    [JsonPropertyName("m_nInputType")]
    public int? MNInputType
    {
        get;
        set;
    }

    [JsonProperty("m_nMomentumType")]
    [JsonPropertyName("m_nMomentumType")]
    public int? MNMomentumType
    {
        get;
        set;
    }

    [JsonProperty("m_nOutputType")]
    [JsonPropertyName("m_nOutputType")]
    public int? MNOutputType
    {
        get;
        set;
    }

    [JsonProperty("m_nRatchetType")]
    [JsonPropertyName("m_nRatchetType")]
    public int? MNRatchetType
    {
        get;
        set;
    }

    [JsonProperty("m_vecPreviousTestPoint")]
    [JsonPropertyName("m_vecPreviousTestPoint")]
    public int? MVecPreviousTestPoint
    {
        get;
        set;
    }

    [JsonProperty("m_BackgroundMaterialName")]
    [JsonPropertyName("m_BackgroundMaterialName")]
    public int? MBackgroundMaterialName
    {
        get;
        set;
    }

    [JsonProperty("m_FontName")]
    [JsonPropertyName("m_FontName")]
    public int? MFontName
    {
        get;
        set;
    }

    [JsonProperty("m_bDrawBackground")]
    [JsonPropertyName("m_bDrawBackground")]
    public int? MBDrawBackground
    {
        get;
        set;
    }

    [JsonProperty("m_bFullbright")]
    [JsonPropertyName("m_bFullbright")]
    public int? MBFullbright
    {
        get;
        set;
    }

    [JsonProperty("m_flBackgroundBorderHeight")]
    [JsonPropertyName("m_flBackgroundBorderHeight")]
    public int? MFlBackgroundBorderHeight
    {
        get;
        set;
    }

    [JsonProperty("m_flBackgroundBorderWidth")]
    [JsonPropertyName("m_flBackgroundBorderWidth")]
    public int? MFlBackgroundBorderWidth
    {
        get;
        set;
    }

    [JsonProperty("m_flBackgroundWorldToUV")]
    [JsonPropertyName("m_flBackgroundWorldToUV")]
    public int? MFlBackgroundWorldToUV
    {
        get;
        set;
    }

    [JsonProperty("m_flFontSize")]
    [JsonPropertyName("m_flFontSize")]
    public int? MFlFontSize
    {
        get;
        set;
    }

    [JsonProperty("m_flWorldUnitsPerPx")]
    [JsonPropertyName("m_flWorldUnitsPerPx")]
    public int? MFlWorldUnitsPerPx
    {
        get;
        set;
    }

    [JsonProperty("m_nJustifyHorizontal")]
    [JsonPropertyName("m_nJustifyHorizontal")]
    public int? MNJustifyHorizontal
    {
        get;
        set;
    }

    [JsonProperty("m_nJustifyVertical")]
    [JsonPropertyName("m_nJustifyVertical")]
    public int? MNJustifyVertical
    {
        get;
        set;
    }

    [JsonProperty("m_nReorientMode")]
    [JsonPropertyName("m_nReorientMode")]
    public int? MNReorientMode
    {
        get;
        set;
    }

    [JsonProperty("m_bExposureControl")]
    [JsonPropertyName("m_bExposureControl")]
    public int? MBExposureControl
    {
        get;
        set;
    }

    [JsonProperty("m_flExposureCompensation")]
    [JsonPropertyName("m_flExposureCompensation")]
    public int? MFlExposureCompensation
    {
        get;
        set;
    }

    [JsonProperty("m_flExposureFadeSpeedDown")]
    [JsonPropertyName("m_flExposureFadeSpeedDown")]
    public int? MFlExposureFadeSpeedDown
    {
        get;
        set;
    }

    [JsonProperty("m_flExposureFadeSpeedUp")]
    [JsonPropertyName("m_flExposureFadeSpeedUp")]
    public int? MFlExposureFadeSpeedUp
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxExposure")]
    [JsonPropertyName("m_flMaxExposure")]
    public int? MFlMaxExposure
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxLogExposure")]
    [JsonPropertyName("m_flMaxLogExposure")]
    public int? MFlMaxLogExposure
    {
        get;
        set;
    }

    [JsonProperty("m_flMinExposure")]
    [JsonPropertyName("m_flMinExposure")]
    public int? MFlMinExposure
    {
        get;
        set;
    }

    [JsonProperty("m_flMinLogExposure")]
    [JsonPropertyName("m_flMinLogExposure")]
    public int? MFlMinLogExposure
    {
        get;
        set;
    }

    [JsonProperty("m_flTonemapEVSmoothingRange")]
    [JsonPropertyName("m_flTonemapEVSmoothingRange")]
    public int? MFlTonemapEVSmoothingRange
    {
        get;
        set;
    }

    [JsonProperty("m_hPostSettings")]
    [JsonPropertyName("m_hPostSettings")]
    public int? MHPostSettings
    {
        get;
        set;
    }

    [JsonProperty("m_iAccount")]
    [JsonPropertyName("m_iAccount")]
    public int? MIAccount
    {
        get;
        set;
    }

    [JsonProperty("m_iCashSpentThisRound")]
    [JsonPropertyName("m_iCashSpentThisRound")]
    public int? MICashSpentThisRound
    {
        get;
        set;
    }

    [JsonProperty("m_iStartAccount")]
    [JsonPropertyName("m_iStartAccount")]
    public int? MIStartAccount
    {
        get;
        set;
    }

    [JsonProperty("m_iTotalCashSpent")]
    [JsonPropertyName("m_iTotalCashSpent")]
    public int? MITotalCashSpent
    {
        get;
        set;
    }

    [JsonProperty("m_bActiveParticlePrecipEmitter")]
    [JsonPropertyName("m_bActiveParticlePrecipEmitter")]
    public int? MBActiveParticlePrecipEmitter
    {
        get;
        set;
    }

    [JsonProperty("m_bHasSimulatedSinceLastSceneObjectUpdate")]
    [JsonPropertyName("m_bHasSimulatedSinceLastSceneObjectUpdate")]
    public int? MBHasSimulatedSinceLastSceneObjectUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_bParticlePrecipInitialized")]
    [JsonPropertyName("m_bParticlePrecipInitialized")]
    public int? MBParticlePrecipInitialized
    {
        get;
        set;
    }

    [JsonProperty("m_flDensity")]
    [JsonPropertyName("m_flDensity")]
    public int? MFlDensity
    {
        get;
        set;
    }

    [JsonProperty("m_flParticleInnerDist")]
    [JsonPropertyName("m_flParticleInnerDist")]
    public int? MFlParticleInnerDist
    {
        get;
        set;
    }

    [JsonProperty("m_nAvailableSheetSequencesMaxIndex")]
    [JsonPropertyName("m_nAvailableSheetSequencesMaxIndex")]
    public int? MNAvailableSheetSequencesMaxIndex
    {
        get;
        set;
    }

    [JsonProperty("m_pParticleDef")]
    [JsonPropertyName("m_pParticleDef")]
    public int? MPParticleDef
    {
        get;
        set;
    }

    [JsonProperty("m_tParticlePrecipTraceTimer")]
    [JsonPropertyName("m_tParticlePrecipTraceTimer")]
    public int? MTParticlePrecipTraceTimer
    {
        get;
        set;
    }

    [JsonProperty("m_flBlendWeight")]
    [JsonPropertyName("m_flBlendWeight")]
    public int? MFlBlendWeight
    {
        get;
        set;
    }

    [JsonProperty("m_flBlendWeightCurrent")]
    [JsonPropertyName("m_flBlendWeightCurrent")]
    public int? MFlBlendWeightCurrent
    {
        get;
        set;
    }

    [JsonProperty("m_hRagdollSource")]
    [JsonPropertyName("m_hRagdollSource")]
    public int? MHRagdollSource
    {
        get;
        set;
    }

    [JsonProperty("m_parentPhysicsBoneIndices")]
    [JsonPropertyName("m_parentPhysicsBoneIndices")]
    public int? MParentPhysicsBoneIndices
    {
        get;
        set;
    }

    [JsonProperty("m_ragAngles")]
    [JsonPropertyName("m_ragAngles")]
    public int? MRagAngles
    {
        get;
        set;
    }

    [JsonProperty("m_ragEnabled")]
    [JsonPropertyName("m_ragEnabled")]
    public int? MRagEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_ragPos")]
    [JsonPropertyName("m_ragPos")]
    public int? MRagPos
    {
        get;
        set;
    }

    [JsonProperty("m_worldSpaceBoneComputationOrder")]
    [JsonPropertyName("m_worldSpaceBoneComputationOrder")]
    public int? MWorldSpaceBoneComputationOrder
    {
        get;
        set;
    }

    [JsonProperty("m_attachmentPointBoneSpace")]
    [JsonPropertyName("m_attachmentPointBoneSpace")]
    public int? MAttachmentPointBoneSpace
    {
        get;
        set;
    }

    [JsonProperty("m_attachmentPointRagdollSpace")]
    [JsonPropertyName("m_attachmentPointRagdollSpace")]
    public int? MAttachmentPointRagdollSpace
    {
        get;
        set;
    }

    [JsonProperty("m_bHasParent")]
    [JsonPropertyName("m_bHasParent")]
    public int? MBHasParent
    {
        get;
        set;
    }

    [JsonProperty("m_boneIndexAttached")]
    [JsonPropertyName("m_boneIndexAttached")]
    public int? MBoneIndexAttached
    {
        get;
        set;
    }

    [JsonProperty("m_parentTime")]
    [JsonPropertyName("m_parentTime")]
    public int? MParentTime
    {
        get;
        set;
    }

    [JsonProperty("m_ragdollAttachedObjectIndex")]
    [JsonPropertyName("m_ragdollAttachedObjectIndex")]
    public int? MRagdollAttachedObjectIndex
    {
        get;
        set;
    }

    [JsonProperty("m_vecOffset")]
    [JsonPropertyName("m_vecOffset")]
    public int? MVecOffset
    {
        get;
        set;
    }

    [JsonProperty("m_bBlockersPresent")]
    [JsonPropertyName("m_bBlockersPresent")]
    public int? MBBlockersPresent
    {
        get;
        set;
    }

    [JsonProperty("m_bRoundInProgress")]
    [JsonPropertyName("m_bRoundInProgress")]
    public int? MBRoundInProgress
    {
        get;
        set;
    }

    [JsonProperty("m_hBombPlanter")]
    [JsonPropertyName("m_hBombPlanter")]
    public int? MHBombPlanter
    {
        get;
        set;
    }

    [JsonProperty("m_iBombSite")]
    [JsonPropertyName("m_iBombSite")]
    public int? MIBombSite
    {
        get;
        set;
    }

    [JsonProperty("m_iFirstSecondHalfRound")]
    [JsonPropertyName("m_iFirstSecondHalfRound")]
    public int? MIFirstSecondHalfRound
    {
        get;
        set;
    }

    [JsonProperty("m_nMatchSeed")]
    [JsonPropertyName("m_nMatchSeed")]
    public int? MNMatchSeed
    {
        get;
        set;
    }

    [JsonProperty("m_LinksTouchingSomething")]
    [JsonPropertyName("m_LinksTouchingSomething")]
    public int? MLinksTouchingSomething
    {
        get;
        set;
    }

    [JsonProperty("m_PhysicsDelegate")]
    [JsonPropertyName("m_PhysicsDelegate")]
    public int? MPhysicsDelegate
    {
        get;
        set;
    }

    [JsonProperty("m_RopeFlags")]
    [JsonPropertyName("m_RopeFlags")]
    public int? MRopeFlags
    {
        get;
        set;
    }

    [JsonProperty("m_RopeLength")]
    [JsonPropertyName("m_RopeLength")]
    public int? MRopeLength
    {
        get;
        set;
    }

    [JsonProperty("m_Slack")]
    [JsonPropertyName("m_Slack")]
    public int? MSlack
    {
        get;
        set;
    }

    [JsonProperty("m_Subdiv")]
    [JsonPropertyName("m_Subdiv")]
    public int? MSubdiv
    {
        get;
        set;
    }

    [JsonProperty("m_TextureHeight")]
    [JsonPropertyName("m_TextureHeight")]
    public int? MTextureHeight
    {
        get;
        set;
    }

    [JsonProperty("m_TextureScale")]
    [JsonPropertyName("m_TextureScale")]
    public int? MTextureScale
    {
        get;
        set;
    }

    [JsonProperty("m_Width")]
    [JsonPropertyName("m_Width")]
    public int? MWidth
    {
        get;
        set;
    }

    [JsonProperty("m_bApplyWind")]
    [JsonPropertyName("m_bApplyWind")]
    public int? MBApplyWind
    {
        get;
        set;
    }

    [JsonProperty("m_bConstrainBetweenEndpoints")]
    [JsonPropertyName("m_bConstrainBetweenEndpoints")]
    public int? MBConstrainBetweenEndpoints
    {
        get;
        set;
    }

    [JsonProperty("m_bEndPointAttachmentAnglesDirty")]
    [JsonPropertyName("m_bEndPointAttachmentAnglesDirty")]
    public int? MBEndPointAttachmentAnglesDirty
    {
        get;
        set;
    }

    [JsonProperty("m_bEndPointAttachmentPositionsDirty")]
    [JsonPropertyName("m_bEndPointAttachmentPositionsDirty")]
    public int? MBEndPointAttachmentPositionsDirty
    {
        get;
        set;
    }

    [JsonProperty("m_bNewDataThisFrame")]
    [JsonPropertyName("m_bNewDataThisFrame")]
    public int? MBNewDataThisFrame
    {
        get;
        set;
    }

    [JsonProperty("m_bPhysicsInitted")]
    [JsonPropertyName("m_bPhysicsInitted")]
    public int? MBPhysicsInitted
    {
        get;
        set;
    }

    [JsonProperty("m_bPrevEndPointPos")]
    [JsonPropertyName("m_bPrevEndPointPos")]
    public int? MBPrevEndPointPos
    {
        get;
        set;
    }

    [JsonProperty("m_fLockedPoints")]
    [JsonPropertyName("m_fLockedPoints")]
    public int? MFLockedPoints
    {
        get;
        set;
    }

    [JsonProperty("m_fPrevLockedPoints")]
    [JsonPropertyName("m_fPrevLockedPoints")]
    public int? MFPrevLockedPoints
    {
        get;
        set;
    }

    [JsonProperty("m_flCurScroll")]
    [JsonPropertyName("m_flCurScroll")]
    public int? MFlCurScroll
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentGustLifetime")]
    [JsonPropertyName("m_flCurrentGustLifetime")]
    public int? MFlCurrentGustLifetime
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentGustTimer")]
    [JsonPropertyName("m_flCurrentGustTimer")]
    public int? MFlCurrentGustTimer
    {
        get;
        set;
    }

    [JsonProperty("m_flScrollSpeed")]
    [JsonPropertyName("m_flScrollSpeed")]
    public int? MFlScrollSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flTimeToNextGust")]
    [JsonPropertyName("m_flTimeToNextGust")]
    public int? MFlTimeToNextGust
    {
        get;
        set;
    }

    [JsonProperty("m_hEndPoint")]
    [JsonPropertyName("m_hEndPoint")]
    public int? MHEndPoint
    {
        get;
        set;
    }

    [JsonProperty("m_hMaterial")]
    [JsonPropertyName("m_hMaterial")]
    public int? MHMaterial
    {
        get;
        set;
    }

    [JsonProperty("m_hStartPoint")]
    [JsonPropertyName("m_hStartPoint")]
    public int? MHStartPoint
    {
        get;
        set;
    }

    [JsonProperty("m_iEndAttachment")]
    [JsonPropertyName("m_iEndAttachment")]
    public int? MIEndAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_iForcePointMoveCounter")]
    [JsonPropertyName("m_iForcePointMoveCounter")]
    public int? MIForcePointMoveCounter
    {
        get;
        set;
    }

    [JsonProperty("m_iRopeMaterialModelIndex")]
    [JsonPropertyName("m_iRopeMaterialModelIndex")]
    public int? MIRopeMaterialModelIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iStartAttachment")]
    [JsonPropertyName("m_iStartAttachment")]
    public int? MIStartAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_nChangeCount")]
    [JsonPropertyName("m_nChangeCount")]
    public int? MNChangeCount
    {
        get;
        set;
    }

    [JsonProperty("m_nLinksTouchingSomething")]
    [JsonPropertyName("m_nLinksTouchingSomething")]
    public int? MNLinksTouchingSomething
    {
        get;
        set;
    }

    [JsonProperty("m_nSegments")]
    [JsonPropertyName("m_nSegments")]
    public int? MNSegments
    {
        get;
        set;
    }

    [JsonProperty("m_vCachedEndPointAttachmentAngle")]
    [JsonPropertyName("m_vCachedEndPointAttachmentAngle")]
    public int? MVCachedEndPointAttachmentAngle
    {
        get;
        set;
    }

    [JsonProperty("m_vCachedEndPointAttachmentPos")]
    [JsonPropertyName("m_vCachedEndPointAttachmentPos")]
    public int? MVCachedEndPointAttachmentPos
    {
        get;
        set;
    }

    [JsonProperty("m_vColorMod")]
    [JsonPropertyName("m_vColorMod")]
    public int? MVColorMod
    {
        get;
        set;
    }

    [JsonProperty("m_vPrevEndPointPos")]
    [JsonPropertyName("m_vPrevEndPointPos")]
    public int? MVPrevEndPointPos
    {
        get;
        set;
    }

    [JsonProperty("m_vWindDir")]
    [JsonPropertyName("m_vWindDir")]
    public int? MVWindDir
    {
        get;
        set;
    }

    [JsonProperty("m_vecImpulse")]
    [JsonPropertyName("m_vecImpulse")]
    public int? MVecImpulse
    {
        get;
        set;
    }

    [JsonProperty("m_vecPreviousImpulse")]
    [JsonPropertyName("m_vecPreviousImpulse")]
    public int? MVecPreviousImpulse
    {
        get;
        set;
    }

    [JsonProperty("m_pKeyframe")]
    [JsonPropertyName("m_pKeyframe")]
    public int? MPKeyframe
    {
        get;
        set;
    }

    [JsonProperty("m_QueuedEvents")]
    [JsonPropertyName("m_QueuedEvents")]
    public int? MQueuedEvents
    {
        get;
        set;
    }

    [JsonProperty("m_bAutogenerated")]
    [JsonPropertyName("m_bAutogenerated")]
    public int? MBAutogenerated
    {
        get;
        set;
    }

    [JsonProperty("m_bClientOnly")]
    [JsonPropertyName("m_bClientOnly")]
    public int? MBClientOnly
    {
        get;
        set;
    }

    [JsonProperty("m_bIsPlayingBack")]
    [JsonPropertyName("m_bIsPlayingBack")]
    public int? MBIsPlayingBack
    {
        get;
        set;
    }

    [JsonProperty("m_bMultiplayer")]
    [JsonPropertyName("m_bMultiplayer")]
    public int? MBMultiplayer
    {
        get;
        set;
    }

    [JsonProperty("m_bPaused")]
    [JsonPropertyName("m_bPaused")]
    public int? MBPaused
    {
        get;
        set;
    }

    [JsonProperty("m_bWasPlaying")]
    [JsonPropertyName("m_bWasPlaying")]
    public int? MBWasPlaying
    {
        get;
        set;
    }

    [JsonProperty("m_flCurrentTime")]
    [JsonPropertyName("m_flCurrentTime")]
    public int? MFlCurrentTime
    {
        get;
        set;
    }

    [JsonProperty("m_flForceClientTime")]
    [JsonPropertyName("m_flForceClientTime")]
    public int? MFlForceClientTime
    {
        get;
        set;
    }

    [JsonProperty("m_hActorList")]
    [JsonPropertyName("m_hActorList")]
    public int? MHActorList
    {
        get;
        set;
    }

    [JsonProperty("m_hOwner")]
    [JsonPropertyName("m_hOwner")]
    public int? MHOwner
    {
        get;
        set;
    }

    [JsonProperty("m_nSceneStringIndex")]
    [JsonPropertyName("m_nSceneStringIndex")]
    public int? MNSceneStringIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nPersonaDataPublicCommendsFriendly")]
    [JsonPropertyName("m_nPersonaDataPublicCommendsFriendly")]
    public int? MNPersonaDataPublicCommendsFriendly
    {
        get;
        set;
    }

    [JsonProperty("m_nPersonaDataPublicCommendsLeader")]
    [JsonPropertyName("m_nPersonaDataPublicCommendsLeader")]
    public int? MNPersonaDataPublicCommendsLeader
    {
        get;
        set;
    }

    [JsonProperty("m_nPersonaDataPublicCommendsTeacher")]
    [JsonPropertyName("m_nPersonaDataPublicCommendsTeacher")]
    public int? MNPersonaDataPublicCommendsTeacher
    {
        get;
        set;
    }

    [JsonProperty("m_nPersonaDataPublicLevel")]
    [JsonPropertyName("m_nPersonaDataPublicLevel")]
    public int? MNPersonaDataPublicLevel
    {
        get;
        set;
    }

    [JsonProperty("m_nPersonaDataXpTrailLevel")]
    [JsonPropertyName("m_nPersonaDataXpTrailLevel")]
    public int? MNPersonaDataXpTrailLevel
    {
        get;
        set;
    }

    [JsonProperty("m_rank")]
    [JsonPropertyName("m_rank")]
    public int? MRank
    {
        get;
        set;
    }

    [JsonProperty("m_unMusicID")]
    [JsonPropertyName("m_unMusicID")]
    public int? MUnMusicID
    {
        get;
        set;
    }

    [JsonProperty("m_vecNetworkableLoadout")]
    [JsonPropertyName("m_vecNetworkableLoadout")]
    public int? MVecNetworkableLoadout
    {
        get;
        set;
    }

    [JsonProperty("m_vecServerAuthoritativeWeaponSlots")]
    [JsonPropertyName("m_vecServerAuthoritativeWeaponSlots")]
    public int? MVecServerAuthoritativeWeaponSlots
    {
        get;
        set;
    }

    [JsonProperty("starttime")]
    [JsonPropertyName("starttime")]
    public int? Starttime
    {
        get;
        set;
    }

    [JsonProperty("m_ShardDesc")]
    [JsonPropertyName("m_ShardDesc")]
    public int? MShardDesc
    {
        get;
        set;
    }

    [JsonProperty("m_skyboxData")]
    [JsonPropertyName("m_skyboxData")]
    public int? MSkyboxData
    {
        get;
        set;
    }

    [JsonProperty("m_skyboxSlotToken")]
    [JsonPropertyName("m_skyboxSlotToken")]
    public int? MSkyboxSlotToken
    {
        get;
        set;
    }

    [JsonProperty("m_VoxelFrameData")]
    [JsonPropertyName("m_VoxelFrameData")]
    public int? MVoxelFrameData
    {
        get;
        set;
    }

    [JsonProperty("m_bDidSmokeEffect")]
    [JsonPropertyName("m_bDidSmokeEffect")]
    public int? MBDidSmokeEffect
    {
        get;
        set;
    }

    [JsonProperty("m_bSmokeEffectSpawned")]
    [JsonPropertyName("m_bSmokeEffectSpawned")]
    public int? MBSmokeEffectSpawned
    {
        get;
        set;
    }

    [JsonProperty("m_bSmokeVolumeDataReceived")]
    [JsonPropertyName("m_bSmokeVolumeDataReceived")]
    public int? MBSmokeVolumeDataReceived
    {
        get;
        set;
    }

    [JsonProperty("m_nRandomSeed")]
    [JsonPropertyName("m_nRandomSeed")]
    public int? MNRandomSeed
    {
        get;
        set;
    }

    [JsonProperty("m_nSmokeEffectTickBegin")]
    [JsonPropertyName("m_nSmokeEffectTickBegin")]
    public int? MNSmokeEffectTickBegin
    {
        get;
        set;
    }

    [JsonProperty("m_nVoxelFrameDataSize")]
    [JsonPropertyName("m_nVoxelFrameDataSize")]
    public int? MNVoxelFrameDataSize
    {
        get;
        set;
    }

    [JsonProperty("m_nVoxelUpdate")]
    [JsonPropertyName("m_nVoxelUpdate")]
    public int? MNVoxelUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_vSmokeColor")]
    [JsonPropertyName("m_vSmokeColor")]
    public int? MVSmokeColor
    {
        get;
        set;
    }

    [JsonProperty("m_vSmokeDetonationPos")]
    [JsonPropertyName("m_vSmokeDetonationPos")]
    public int? MVSmokeDetonationPos
    {
        get;
        set;
    }

    [JsonProperty("m_bWasEnabled")]
    [JsonPropertyName("m_bWasEnabled")]
    public int? MBWasEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_iszSoundAreaType")]
    [JsonPropertyName("m_iszSoundAreaType")]
    public int? MIszSoundAreaType
    {
        get;
        set;
    }

    [JsonProperty("m_vPos")]
    [JsonPropertyName("m_vPos")]
    public int? MVPos
    {
        get;
        set;
    }

    [JsonProperty("m_vMax")]
    [JsonPropertyName("m_vMax")]
    public int? MVMax
    {
        get;
        set;
    }

    [JsonProperty("m_vMin")]
    [JsonPropertyName("m_vMin")]
    public int? MVMin
    {
        get;
        set;
    }

    [JsonProperty("m_vMaxs")]
    [JsonPropertyName("m_vMaxs")]
    public int? MVMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vMins")]
    [JsonPropertyName("m_vMins")]
    public int? MVMins
    {
        get;
        set;
    }

    [JsonProperty("m_CachedResults")]
    [JsonPropertyName("m_CachedResults")]
    public int? MCachedResults
    {
        get;
        set;
    }

    [JsonProperty("m_ProviderType")]
    [JsonPropertyName("m_ProviderType")]
    public int? MProviderType
    {
        get;
        set;
    }

    [JsonProperty("m_Providers")]
    [JsonPropertyName("m_Providers")]
    public int? MProviders
    {
        get;
        set;
    }

    [JsonProperty("m_bPreventLoopback")]
    [JsonPropertyName("m_bPreventLoopback")]
    public int? MBPreventLoopback
    {
        get;
        set;
    }

    [JsonProperty("m_hOuter")]
    [JsonPropertyName("m_hOuter")]
    public int? MHOuter
    {
        get;
        set;
    }

    [JsonProperty("m_iReapplyProvisionParity")]
    [JsonPropertyName("m_iReapplyProvisionParity")]
    public int? MIReapplyProvisionParity
    {
        get;
        set;
    }

    [JsonProperty("pItem")]
    [JsonPropertyName("pItem")]
    public int? PItem
    {
        get;
        set;
    }

    [JsonProperty("slot")]
    [JsonPropertyName("slot")]
    public int? Slot
    {
        get;
        set;
    }

    [JsonProperty("team")]
    [JsonPropertyName("team")]
    public int? Team
    {
        get;
        set;
    }

    [JsonProperty("m_bClientSideOnly")]
    [JsonPropertyName("m_bClientSideOnly")]
    public int? MBClientSideOnly
    {
        get;
        set;
    }

    [JsonProperty("m_bSaveRestore")]
    [JsonPropertyName("m_bSaveRestore")]
    public int? MBSaveRestore
    {
        get;
        set;
    }

    [JsonProperty("m_bSavedIsPlaying")]
    [JsonPropertyName("m_bSavedIsPlaying")]
    public int? MBSavedIsPlaying
    {
        get;
        set;
    }

    [JsonProperty("m_bStartOnSpawn")]
    [JsonPropertyName("m_bStartOnSpawn")]
    public int? MBStartOnSpawn
    {
        get;
        set;
    }

    [JsonProperty("m_bStopOnNew")]
    [JsonPropertyName("m_bStopOnNew")]
    public int? MBStopOnNew
    {
        get;
        set;
    }

    [JsonProperty("m_bToLocalPlayer")]
    [JsonPropertyName("m_bToLocalPlayer")]
    public int? MBToLocalPlayer
    {
        get;
        set;
    }

    [JsonProperty("m_flClientCullRadius")]
    [JsonPropertyName("m_flClientCullRadius")]
    public int? MFlClientCullRadius
    {
        get;
        set;
    }

    [JsonProperty("m_flSavedElapsedTime")]
    [JsonPropertyName("m_flSavedElapsedTime")]
    public int? MFlSavedElapsedTime
    {
        get;
        set;
    }

    [JsonProperty("m_hSource")]
    [JsonPropertyName("m_hSource")]
    public int? MHSource
    {
        get;
        set;
    }

    [JsonProperty("m_iszAttachmentName")]
    [JsonPropertyName("m_iszAttachmentName")]
    public int? MIszAttachmentName
    {
        get;
        set;
    }

    [JsonProperty("m_iszSoundName")]
    [JsonPropertyName("m_iszSoundName")]
    public int? MIszSoundName
    {
        get;
        set;
    }

    [JsonProperty("m_iszSourceEntityName")]
    [JsonPropertyName("m_iszSourceEntityName")]
    public int? MIszSourceEntityName
    {
        get;
        set;
    }

    [JsonProperty("m_nEntityIndexSelection")]
    [JsonPropertyName("m_nEntityIndexSelection")]
    public int? MNEntityIndexSelection
    {
        get;
        set;
    }

    [JsonProperty("m_onGUIDChanged")]
    [JsonPropertyName("m_onGUIDChanged")]
    public int? MOnGUIDChanged
    {
        get;
        set;
    }

    [JsonProperty("m_onSoundFinished")]
    [JsonPropertyName("m_onSoundFinished")]
    public int? MOnSoundFinished
    {
        get;
        set;
    }

    [JsonProperty("m_vecCornerPairsNetworked")]
    [JsonPropertyName("m_vecCornerPairsNetworked")]
    public int? MVecCornerPairsNetworked
    {
        get;
        set;
    }

    [JsonProperty("m_bIsRescuing")]
    [JsonPropertyName("m_bIsRescuing")]
    public int? MBIsRescuing
    {
        get;
        set;
    }

    [JsonProperty("m_hLastWeaponBeforeC4AutoSwitch")]
    [JsonPropertyName("m_hLastWeaponBeforeC4AutoSwitch")]
    public int? MHLastWeaponBeforeC4AutoSwitch
    {
        get;
        set;
    }

    [JsonProperty("m_weaponPurchasesThisMatch")]
    [JsonPropertyName("m_weaponPurchasesThisMatch")]
    public int? MWeaponPurchasesThisMatch
    {
        get;
        set;
    }

    [JsonProperty("m_weaponPurchasesThisRound")]
    [JsonPropertyName("m_weaponPurchasesThisRound")]
    public int? MWeaponPurchasesThisRound
    {
        get;
        set;
    }

    [JsonProperty("m_bUseAutoCompare")]
    [JsonPropertyName("m_bUseAutoCompare")]
    public int? MBUseAutoCompare
    {
        get;
        set;
    }

    [JsonProperty("m_iOpvarIndex")]
    [JsonPropertyName("m_iOpvarIndex")]
    public int? MIOpvarIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iszOperatorName")]
    [JsonPropertyName("m_iszOperatorName")]
    public int? MIszOperatorName
    {
        get;
        set;
    }

    [JsonProperty("m_iszOpvarName")]
    [JsonPropertyName("m_iszOpvarName")]
    public int? MIszOpvarName
    {
        get;
        set;
    }

    [JsonProperty("m_iszStackName")]
    [JsonPropertyName("m_iszStackName")]
    public int? MIszStackName
    {
        get;
        set;
    }

    [JsonProperty("m_flLightScale")]
    [JsonPropertyName("m_flLightScale")]
    public int? MFlLightScale
    {
        get;
        set;
    }

    [JsonProperty("m_bWorldSpaceScale")]
    [JsonPropertyName("m_bWorldSpaceScale")]
    public int? MBWorldSpaceScale
    {
        get;
        set;
    }

    [JsonProperty("m_flBrightnessDuration")]
    [JsonPropertyName("m_flBrightnessDuration")]
    public int? MFlBrightnessDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flBrightnessTimeStart")]
    [JsonPropertyName("m_flBrightnessTimeStart")]
    public int? MFlBrightnessTimeStart
    {
        get;
        set;
    }

    [JsonProperty("m_flDestScale")]
    [JsonPropertyName("m_flDestScale")]
    public int? MFlDestScale
    {
        get;
        set;
    }

    [JsonProperty("m_flDieTime")]
    [JsonPropertyName("m_flDieTime")]
    public int? MFlDieTime
    {
        get;
        set;
    }

    [JsonProperty("m_flGlowProxySize")]
    [JsonPropertyName("m_flGlowProxySize")]
    public int? MFlGlowProxySize
    {
        get;
        set;
    }

    [JsonProperty("m_flLastTime")]
    [JsonPropertyName("m_flLastTime")]
    public int? MFlLastTime
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxFrame")]
    [JsonPropertyName("m_flMaxFrame")]
    public int? MFlMaxFrame
    {
        get;
        set;
    }

    [JsonProperty("m_flScaleDuration")]
    [JsonPropertyName("m_flScaleDuration")]
    public int? MFlScaleDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flSpriteFramerate")]
    [JsonPropertyName("m_flSpriteFramerate")]
    public int? MFlSpriteFramerate
    {
        get;
        set;
    }

    [JsonProperty("m_flStartScale")]
    [JsonPropertyName("m_flStartScale")]
    public int? MFlStartScale
    {
        get;
        set;
    }

    [JsonProperty("m_hAttachedToEntity")]
    [JsonPropertyName("m_hAttachedToEntity")]
    public int? MHAttachedToEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hSpriteMaterial")]
    [JsonPropertyName("m_hSpriteMaterial")]
    public int? MHSpriteMaterial
    {
        get;
        set;
    }

    [JsonProperty("m_nAttachment")]
    [JsonPropertyName("m_nAttachment")]
    public int? MNAttachment
    {
        get;
        set;
    }

    [JsonProperty("m_nBrightness")]
    [JsonPropertyName("m_nBrightness")]
    public int? MNBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_nDestBrightness")]
    [JsonPropertyName("m_nDestBrightness")]
    public int? MNDestBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_nSpriteHeight")]
    [JsonPropertyName("m_nSpriteHeight")]
    public int? MNSpriteHeight
    {
        get;
        set;
    }

    [JsonProperty("m_nSpriteWidth")]
    [JsonPropertyName("m_nSpriteWidth")]
    public int? MNSpriteWidth
    {
        get;
        set;
    }

    [JsonProperty("m_nStartBrightness")]
    [JsonPropertyName("m_nStartBrightness")]
    public int? MNStartBrightness
    {
        get;
        set;
    }

    [JsonProperty("m_bKnife")]
    [JsonPropertyName("m_bKnife")]
    public int? MBKnife
    {
        get;
        set;
    }

    [JsonProperty("m_aPlayerControllers")]
    [JsonPropertyName("m_aPlayerControllers")]
    public int? MAPlayerControllers
    {
        get;
        set;
    }

    [JsonProperty("m_aPlayers")]
    [JsonPropertyName("m_aPlayers")]
    public int? MAPlayers
    {
        get;
        set;
    }

    [JsonProperty("m_szTeamname")]
    [JsonPropertyName("m_szTeamname")]
    public int? MSzTeamname
    {
        get;
        set;
    }

    [JsonProperty("m_flFPS")]
    [JsonPropertyName("m_flFPS")]
    public int? MFlFPS
    {
        get;
        set;
    }

    [JsonProperty("m_flStartFrame")]
    [JsonPropertyName("m_flStartFrame")]
    public int? MFlStartFrame
    {
        get;
        set;
    }

    [JsonProperty("m_hPositionKeys")]
    [JsonPropertyName("m_hPositionKeys")]
    public int? MHPositionKeys
    {
        get;
        set;
    }

    [JsonProperty("m_hRotationKeys")]
    [JsonPropertyName("m_hRotationKeys")]
    public int? MHRotationKeys
    {
        get;
        set;
    }

    [JsonProperty("m_vAnimationBoundsMax")]
    [JsonPropertyName("m_vAnimationBoundsMax")]
    public int? MVAnimationBoundsMax
    {
        get;
        set;
    }

    [JsonProperty("m_vAnimationBoundsMin")]
    [JsonPropertyName("m_vAnimationBoundsMin")]
    public int? MVAnimationBoundsMin
    {
        get;
        set;
    }

    [JsonProperty("m_flAutoExposureMax")]
    [JsonPropertyName("m_flAutoExposureMax")]
    public int? MFlAutoExposureMax
    {
        get;
        set;
    }

    [JsonProperty("m_flAutoExposureMin")]
    [JsonPropertyName("m_flAutoExposureMin")]
    public int? MFlAutoExposureMin
    {
        get;
        set;
    }

    [JsonProperty("m_flExposureAdaptationSpeedDown")]
    [JsonPropertyName("m_flExposureAdaptationSpeedDown")]
    public int? MFlExposureAdaptationSpeedDown
    {
        get;
        set;
    }

    [JsonProperty("m_flExposureAdaptationSpeedUp")]
    [JsonPropertyName("m_flExposureAdaptationSpeedUp")]
    public int? MFlExposureAdaptationSpeedUp
    {
        get;
        set;
    }

    [JsonProperty("m_totalHitsOnServer")]
    [JsonPropertyName("m_totalHitsOnServer")]
    public int? MTotalHitsOnServer
    {
        get;
        set;
    }

    [JsonProperty("m_BuoyancyHelper")]
    [JsonPropertyName("m_BuoyancyHelper")]
    public int? MBuoyancyHelper
    {
        get;
        set;
    }

    [JsonProperty("m_angularDamping")]
    [JsonPropertyName("m_angularDamping")]
    public int? MAngularDamping
    {
        get;
        set;
    }

    [JsonProperty("m_angularLimit")]
    [JsonPropertyName("m_angularLimit")]
    public int? MAngularLimit
    {
        get;
        set;
    }

    [JsonProperty("m_bCollapseToForcePoint")]
    [JsonPropertyName("m_bCollapseToForcePoint")]
    public int? MBCollapseToForcePoint
    {
        get;
        set;
    }

    [JsonProperty("m_bConvertToDebrisWhenPossible")]
    [JsonPropertyName("m_bConvertToDebrisWhenPossible")]
    public int? MBConvertToDebrisWhenPossible
    {
        get;
        set;
    }

    [JsonProperty("m_flDampingRatio")]
    [JsonPropertyName("m_flDampingRatio")]
    public int? MFlDampingRatio
    {
        get;
        set;
    }

    [JsonProperty("m_flFrequency")]
    [JsonPropertyName("m_flFrequency")]
    public int? MFlFrequency
    {
        get;
        set;
    }

    [JsonProperty("m_gravityScale")]
    [JsonPropertyName("m_gravityScale")]
    public int? MGravityScale
    {
        get;
        set;
    }

    [JsonProperty("m_linearDamping")]
    [JsonPropertyName("m_linearDamping")]
    public int? MLinearDamping
    {
        get;
        set;
    }

    [JsonProperty("m_linearForce")]
    [JsonPropertyName("m_linearForce")]
    public int? MLinearForce
    {
        get;
        set;
    }

    [JsonProperty("m_linearLimit")]
    [JsonPropertyName("m_linearLimit")]
    public int? MLinearLimit
    {
        get;
        set;
    }

    [JsonProperty("m_vecLinearForceDirection")]
    [JsonPropertyName("m_vecLinearForceDirection")]
    public int? MVecLinearForceDirection
    {
        get;
        set;
    }

    [JsonProperty("m_vecLinearForcePointAt")]
    [JsonPropertyName("m_vecLinearForcePointAt")]
    public int? MVecLinearForcePointAt
    {
        get;
        set;
    }

    [JsonProperty("m_vecLinearForcePointAtWorld")]
    [JsonPropertyName("m_vecLinearForcePointAtWorld")]
    public int? MVecLinearForcePointAtWorld
    {
        get;
        set;
    }

    [JsonProperty("m_bIsYesNoVote")]
    [JsonPropertyName("m_bIsYesNoVote")]
    public int? MBIsYesNoVote
    {
        get;
        set;
    }

    [JsonProperty("m_bTypeDirty")]
    [JsonPropertyName("m_bTypeDirty")]
    public int? MBTypeDirty
    {
        get;
        set;
    }

    [JsonProperty("m_bVotesDirty")]
    [JsonPropertyName("m_bVotesDirty")]
    public int? MBVotesDirty
    {
        get;
        set;
    }

    [JsonProperty("m_iActiveIssueIndex")]
    [JsonPropertyName("m_iActiveIssueIndex")]
    public int? MIActiveIssueIndex
    {
        get;
        set;
    }

    [JsonProperty("m_iOnlyTeamToVote")]
    [JsonPropertyName("m_iOnlyTeamToVote")]
    public int? MIOnlyTeamToVote
    {
        get;
        set;
    }

    [JsonProperty("m_nPotentialVotes")]
    [JsonPropertyName("m_nPotentialVotes")]
    public int? MNPotentialVotes
    {
        get;
        set;
    }

    [JsonProperty("m_nVoteOptionCount")]
    [JsonPropertyName("m_nVoteOptionCount")]
    public int? MNVoteOptionCount
    {
        get;
        set;
    }

    [JsonProperty("m_vecSellbackPurchaseEntries")]
    [JsonPropertyName("m_vecSellbackPurchaseEntries")]
    public int? MVecSellbackPurchaseEntries
    {
        get;
        set;
    }

    [JsonProperty("m_bSequenceInProgress")]
    [JsonPropertyName("m_bSequenceInProgress")]
    public int? MBSequenceInProgress
    {
        get;
        set;
    }

    [JsonProperty("m_bMagazineRemoved")]
    [JsonPropertyName("m_bMagazineRemoved")]
    public int? MBMagazineRemoved
    {
        get;
        set;
    }

    [JsonProperty("m_flDeathCamTilt")]
    [JsonPropertyName("m_flDeathCamTilt")]
    public int? MFlDeathCamTilt
    {
        get;
        set;
    }

    [JsonProperty("m_vClientScopeInaccuracy")]
    [JsonPropertyName("m_vClientScopeInaccuracy")]
    public int? MVClientScopeInaccuracy
    {
        get;
        set;
    }

    [JsonProperty("m_fFireTime")]
    [JsonPropertyName("m_fFireTime")]
    public int? MFFireTime
    {
        get;
        set;
    }

    [JsonProperty("m_nLastAttackTick")]
    [JsonPropertyName("m_nLastAttackTick")]
    public int? MNLastAttackTick
    {
        get;
        set;
    }

    [JsonProperty("m_NewColor")]
    [JsonPropertyName("m_NewColor")]
    public int? MNewColor
    {
        get;
        set;
    }

    [JsonProperty("m_OldColor")]
    [JsonPropertyName("m_OldColor")]
    public int? MOldColor
    {
        get;
        set;
    }

    [JsonProperty("m_flNewEnd")]
    [JsonPropertyName("m_flNewEnd")]
    public int? MFlNewEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flNewFarZ")]
    [JsonPropertyName("m_flNewFarZ")]
    public int? MFlNewFarZ
    {
        get;
        set;
    }

    [JsonProperty("m_flNewHDRColorScale")]
    [JsonPropertyName("m_flNewHDRColorScale")]
    public int? MFlNewHDRColorScale
    {
        get;
        set;
    }

    [JsonProperty("m_flNewMaxDensity")]
    [JsonPropertyName("m_flNewMaxDensity")]
    public int? MFlNewMaxDensity
    {
        get;
        set;
    }

    [JsonProperty("m_flNewStart")]
    [JsonPropertyName("m_flNewStart")]
    public int? MFlNewStart
    {
        get;
        set;
    }

    [JsonProperty("m_flOldEnd")]
    [JsonPropertyName("m_flOldEnd")]
    public int? MFlOldEnd
    {
        get;
        set;
    }

    [JsonProperty("m_flOldFarZ")]
    [JsonPropertyName("m_flOldFarZ")]
    public int? MFlOldFarZ
    {
        get;
        set;
    }

    [JsonProperty("m_flOldHDRColorScale")]
    [JsonPropertyName("m_flOldHDRColorScale")]
    public int? MFlOldHDRColorScale
    {
        get;
        set;
    }

    [JsonProperty("m_flOldMaxDensity")]
    [JsonPropertyName("m_flOldMaxDensity")]
    public int? MFlOldMaxDensity
    {
        get;
        set;
    }

    [JsonProperty("m_flOldStart")]
    [JsonPropertyName("m_flOldStart")]
    public int? MFlOldStart
    {
        get;
        set;
    }

    [JsonProperty("m_flTransitionTime")]
    [JsonPropertyName("m_flTransitionTime")]
    public int? MFlTransitionTime
    {
        get;
        set;
    }

    [JsonProperty("m_hCtrl")]
    [JsonPropertyName("m_hCtrl")]
    public int? MHCtrl
    {
        get;
        set;
    }

    [JsonProperty("m_duration")]
    [JsonPropertyName("m_duration")]
    public int? MDuration
    {
        get;
        set;
    }

    [JsonProperty("m_nWorldGroupId")]
    [JsonPropertyName("m_nWorldGroupId")]
    public int? MNWorldGroupId
    {
        get;
        set;
    }

    [JsonProperty("m_timescale")]
    [JsonPropertyName("m_timescale")]
    public int? MTimescale
    {
        get;
        set;
    }

    [JsonProperty("m_timestamp")]
    [JsonPropertyName("m_timestamp")]
    public int? MTimestamp
    {
        get;
        set;
    }

    [JsonProperty("m_ID")]
    [JsonPropertyName("m_ID")]
    public int? MID
    {
        get;
        set;
    }

    [JsonProperty("m_Values")]
    [JsonPropertyName("m_Values")]
    public int? MValues
    {
        get;
        set;
    }

    [JsonProperty("m_bSpotted")]
    [JsonPropertyName("m_bSpotted")]
    public int? MBSpotted
    {
        get;
        set;
    }

    [JsonProperty("m_bSpottedByMask")]
    [JsonPropertyName("m_bSpottedByMask")]
    public int? MBSpottedByMask
    {
        get;
        set;
    }

    [JsonProperty("m_iDamageType")]
    [JsonPropertyName("m_iDamageType")]
    public int? MIDamageType
    {
        get;
        set;
    }

    [JsonProperty("m_hCarriedHostage")]
    [JsonPropertyName("m_hCarriedHostage")]
    public int? MHCarriedHostage
    {
        get;
        set;
    }

    [JsonProperty("m_hCarriedHostageProp")]
    [JsonPropertyName("m_hCarriedHostageProp")]
    public int? MHCarriedHostageProp
    {
        get;
        set;
    }

    [JsonProperty("m_bAdrenalineActive")]
    [JsonPropertyName("m_bAdrenalineActive")]
    public int? MBAdrenalineActive
    {
        get;
        set;
    }

    [JsonProperty("m_iHealthMax")]
    [JsonPropertyName("m_iHealthMax")]
    public int? MIHealthMax
    {
        get;
        set;
    }

    [JsonProperty("m_iHealthMin")]
    [JsonPropertyName("m_iHealthMin")]
    public int? MIHealthMin
    {
        get;
        set;
    }

    [JsonProperty("m_Connection")]
    [JsonPropertyName("m_Connection")]
    public int? MConnection
    {
        get;
        set;
    }

    [JsonProperty("m_DestinationFlowNodeID")]
    [JsonPropertyName("m_DestinationFlowNodeID")]
    public int? MDestinationFlowNodeID
    {
        get;
        set;
    }

    [JsonProperty("m_RequirementNodeIDs")]
    [JsonPropertyName("m_RequirementNodeIDs")]
    public int? MRequirementNodeIDs
    {
        get;
        set;
    }

    [JsonProperty("m_nCursorStateBlockIndex")]
    [JsonPropertyName("m_nCursorStateBlockIndex")]
    public int? MNCursorStateBlockIndex
    {
        get;
        set;
    }

    [JsonProperty("m_Transforms")]
    [JsonPropertyName("m_Transforms")]
    public int? MTransforms
    {
        get;
        set;
    }

    [JsonProperty("m_bSetFromDebugHistory")]
    [JsonPropertyName("m_bSetFromDebugHistory")]
    public int? MBSetFromDebugHistory
    {
        get;
        set;
    }

    [JsonProperty("flFlinchModLarge")]
    [JsonPropertyName("flFlinchModLarge")]
    public int? FlFlinchModLarge
    {
        get;
        set;
    }

    [JsonProperty("flFlinchModSmall")]
    [JsonPropertyName("flFlinchModSmall")]
    public int? FlFlinchModSmall
    {
        get;
        set;
    }

    [JsonProperty("flFriendlyFireDamageReductionRatio")]
    [JsonPropertyName("flFriendlyFireDamageReductionRatio")]
    public int? FlFriendlyFireDamageReductionRatio
    {
        get;
        set;
    }

    [JsonProperty("nTagTick")]
    [JsonPropertyName("nTagTick")]
    public int? NTagTick
    {
        get;
        set;
    }

    [JsonProperty("m_OutflowID")]
    [JsonPropertyName("m_OutflowID")]
    public int? MOutflowID
    {
        get;
        set;
    }

    [JsonProperty("m_DependentObservableBlackboardReferences")]
    [JsonPropertyName("m_DependentObservableBlackboardReferences")]
    public int? MDependentObservableBlackboardReferences
    {
        get;
        set;
    }

    [JsonProperty("m_DependentObservableVars")]
    [JsonPropertyName("m_DependentObservableVars")]
    public int? MDependentObservableVars
    {
        get;
        set;
    }

    [JsonProperty("m_EvaluateConnection")]
    [JsonPropertyName("m_EvaluateConnection")]
    public int? MEvaluateConnection
    {
        get;
        set;
    }

    [JsonProperty("m_hItem")]
    [JsonPropertyName("m_hItem")]
    public int? MHItem
    {
        get;
        set;
    }

    [JsonProperty("m_nCost")]
    [JsonPropertyName("m_nCost")]
    public int? MNCost
    {
        get;
        set;
    }

    [JsonProperty("m_nPrevArmor")]
    [JsonPropertyName("m_nPrevArmor")]
    public int? MNPrevArmor
    {
        get;
        set;
    }

    [JsonProperty("m_unDefIdx")]
    [JsonPropertyName("m_unDefIdx")]
    public int? MUnDefIdx
    {
        get;
        set;
    }

    [JsonProperty("m_bHasDefuser")]
    [JsonPropertyName("m_bHasDefuser")]
    public int? MBHasDefuser
    {
        get;
        set;
    }

    [JsonProperty("m_bHasHelmet")]
    [JsonPropertyName("m_bHasHelmet")]
    public int? MBHasHelmet
    {
        get;
        set;
    }

    [JsonProperty("m_flCyclesPerSecond")]
    [JsonPropertyName("m_flCyclesPerSecond")]
    public int? MFlCyclesPerSecond
    {
        get;
        set;
    }

    [JsonProperty("m_flPlaybackRate")]
    [JsonPropertyName("m_flPlaybackRate")]
    public int? MFlPlaybackRate
    {
        get;
        set;
    }

    [JsonProperty("m_flSeqFixedCycle")]
    [JsonPropertyName("m_flSeqFixedCycle")]
    public int? MFlSeqFixedCycle
    {
        get;
        set;
    }

    [JsonProperty("m_flSeqStartTime")]
    [JsonPropertyName("m_flSeqStartTime")]
    public int? MFlSeqStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_nSeqLoopMode")]
    [JsonPropertyName("m_nSeqLoopMode")]
    public int? MNSeqLoopMode
    {
        get;
        set;
    }

    [JsonProperty("m_nCollisionFunctionMask")]
    [JsonPropertyName("m_nCollisionFunctionMask")]
    public int? MNCollisionFunctionMask
    {
        get;
        set;
    }

    [JsonProperty("m_nCollisionGroup")]
    [JsonPropertyName("m_nCollisionGroup")]
    public int? MNCollisionGroup
    {
        get;
        set;
    }

    [JsonProperty("m_nEntityId")]
    [JsonPropertyName("m_nEntityId")]
    public int? MNEntityId
    {
        get;
        set;
    }

    [JsonProperty("m_nHierarchyId")]
    [JsonPropertyName("m_nHierarchyId")]
    public int? MNHierarchyId
    {
        get;
        set;
    }

    [JsonProperty("m_nInteractsAs")]
    [JsonPropertyName("m_nInteractsAs")]
    public int? MNInteractsAs
    {
        get;
        set;
    }

    [JsonProperty("m_nInteractsExclude")]
    [JsonPropertyName("m_nInteractsExclude")]
    public int? MNInteractsExclude
    {
        get;
        set;
    }

    [JsonProperty("m_nInteractsWith")]
    [JsonPropertyName("m_nInteractsWith")]
    public int? MNInteractsWith
    {
        get;
        set;
    }

    [JsonProperty("m_nOwnerId")]
    [JsonPropertyName("m_nOwnerId")]
    public int? MNOwnerId
    {
        get;
        set;
    }

    [JsonProperty("nIndex")]
    [JsonPropertyName("nIndex")]
    public int? NIndex
    {
        get;
        set;
    }

    [JsonProperty("nType")]
    [JsonPropertyName("nType")]
    public int? NType
    {
        get;
        set;
    }

    [JsonProperty("qAngle")]
    [JsonPropertyName("qAngle")]
    public int? QAngle
    {
        get;
        set;
    }

    [JsonProperty("m_nCount")]
    [JsonPropertyName("m_nCount")]
    public int? MNCount
    {
        get;
        set;
    }

    [JsonProperty("m_nItemDefIndex")]
    [JsonPropertyName("m_nItemDefIndex")]
    public int? MNItemDefIndex
    {
        get;
        set;
    }

    [JsonProperty("m_weaponPurchases")]
    [JsonPropertyName("m_weaponPurchases")]
    public int? MWeaponPurchases
    {
        get;
        set;
    }

    [JsonProperty("localBits")]
    [JsonPropertyName("localBits")]
    public int? LocalBits
    {
        get;
        set;
    }

    [JsonProperty("localSound")]
    [JsonPropertyName("localSound")]
    public int? LocalSound
    {
        get;
        set;
    }

    [JsonProperty("soundEventHash")]
    [JsonPropertyName("soundEventHash")]
    public int? SoundEventHash
    {
        get;
        set;
    }

    [JsonProperty("soundscapeEntityListIndex")]
    [JsonPropertyName("soundscapeEntityListIndex")]
    public int? SoundscapeEntityListIndex
    {
        get;
        set;
    }

    [JsonProperty("soundscapeIndex")]
    [JsonPropertyName("soundscapeIndex")]
    public int? SoundscapeIndex
    {
        get;
        set;
    }

    [JsonProperty("HDRColorScale")]
    [JsonPropertyName("HDRColorScale")]
    public int? HDRColorScale
    {
        get;
        set;
    }

    [JsonProperty("blend")]
    [JsonPropertyName("blend")]
    public int? Blend
    {
        get;
        set;
    }

    [JsonProperty("blendtobackground")]
    [JsonPropertyName("blendtobackground")]
    public int? Blendtobackground
    {
        get;
        set;
    }

    [JsonProperty("colorPrimary")]
    [JsonPropertyName("colorPrimary")]
    public int? ColorPrimary
    {
        get;
        set;
    }

    [JsonProperty("colorPrimaryLerpTo")]
    [JsonPropertyName("colorPrimaryLerpTo")]
    public int? ColorPrimaryLerpTo
    {
        get;
        set;
    }

    [JsonProperty("colorSecondary")]
    [JsonPropertyName("colorSecondary")]
    public int? ColorSecondary
    {
        get;
        set;
    }

    [JsonProperty("colorSecondaryLerpTo")]
    [JsonPropertyName("colorSecondaryLerpTo")]
    public int? ColorSecondaryLerpTo
    {
        get;
        set;
    }

    [JsonProperty("dirPrimary")]
    [JsonPropertyName("dirPrimary")]
    public int? DirPrimary
    {
        get;
        set;
    }

    [JsonProperty("duration")]
    [JsonPropertyName("duration")]
    public int? Duration
    {
        get;
        set;
    }

    [JsonProperty("enable")]
    [JsonPropertyName("enable")]
    public int? Enable
    {
        get;
        set;
    }

    [JsonProperty("end")]
    [JsonPropertyName("end")]
    public int? End
    {
        get;
        set;
    }

    [JsonProperty("endLerpTo")]
    [JsonPropertyName("endLerpTo")]
    public int? EndLerpTo
    {
        get;
        set;
    }

    [JsonProperty("exponent")]
    [JsonPropertyName("exponent")]
    public int? Exponent
    {
        get;
        set;
    }

    [JsonProperty("farz")]
    [JsonPropertyName("farz")]
    public int? Farz
    {
        get;
        set;
    }

    [JsonProperty("lerptime")]
    [JsonPropertyName("lerptime")]
    public int? Lerptime
    {
        get;
        set;
    }

    [JsonProperty("locallightscale")]
    [JsonPropertyName("locallightscale")]
    public int? Locallightscale
    {
        get;
        set;
    }

    [JsonProperty("m_bPadding")]
    [JsonPropertyName("m_bPadding")]
    public int? MBPadding
    {
        get;
        set;
    }

    [JsonProperty("m_bPadding2")]
    [JsonPropertyName("m_bPadding2")]
    public int? MBPadding2
    {
        get;
        set;
    }

    [JsonProperty("maxdensity")]
    [JsonPropertyName("maxdensity")]
    public int? Maxdensity
    {
        get;
        set;
    }

    [JsonProperty("maxdensityLerpTo")]
    [JsonPropertyName("maxdensityLerpTo")]
    public int? MaxdensityLerpTo
    {
        get;
        set;
    }

    [JsonProperty("scattering")]
    [JsonPropertyName("scattering")]
    public int? Scattering
    {
        get;
        set;
    }

    [JsonProperty("skyboxFogFactor")]
    [JsonPropertyName("skyboxFogFactor")]
    public int? SkyboxFogFactor
    {
        get;
        set;
    }

    [JsonProperty("skyboxFogFactorLerpTo")]
    [JsonPropertyName("skyboxFogFactorLerpTo")]
    public int? SkyboxFogFactorLerpTo
    {
        get;
        set;
    }

    [JsonProperty("start")]
    [JsonPropertyName("start")]
    public int? Start
    {
        get;
        set;
    }

    [JsonProperty("startLerpTo")]
    [JsonPropertyName("startLerpTo")]
    public int? StartLerpTo
    {
        get;
        set;
    }

    [JsonProperty("m_SurfacePropStringToken")]
    [JsonPropertyName("m_SurfacePropStringToken")]
    public int? MSurfacePropStringToken
    {
        get;
        set;
    }

    [JsonProperty("m_bParentFrozen")]
    [JsonPropertyName("m_bParentFrozen")]
    public int? MBParentFrozen
    {
        get;
        set;
    }

    [JsonProperty("m_flGlassHalfThickness")]
    [JsonPropertyName("m_flGlassHalfThickness")]
    public int? MFlGlassHalfThickness
    {
        get;
        set;
    }

    [JsonProperty("m_hMaterialBase")]
    [JsonPropertyName("m_hMaterialBase")]
    public int? MHMaterialBase
    {
        get;
        set;
    }

    [JsonProperty("m_hMaterialDamageOverlay")]
    [JsonPropertyName("m_hMaterialDamageOverlay")]
    public int? MHMaterialDamageOverlay
    {
        get;
        set;
    }

    [JsonProperty("m_nModelID")]
    [JsonPropertyName("m_nModelID")]
    public int? MNModelID
    {
        get;
        set;
    }

    [JsonProperty("m_solid")]
    [JsonPropertyName("m_solid")]
    public int? MSolid
    {
        get;
        set;
    }

    [JsonProperty("m_vInitialPanelVertices")]
    [JsonPropertyName("m_vInitialPanelVertices")]
    public int? MVInitialPanelVertices
    {
        get;
        set;
    }

    [JsonProperty("m_vecPanelSize")]
    [JsonPropertyName("m_vecPanelSize")]
    public int? MVecPanelSize
    {
        get;
        set;
    }

    [JsonProperty("m_vecPanelVertices")]
    [JsonPropertyName("m_vecPanelVertices")]
    public int? MVecPanelVertices
    {
        get;
        set;
    }

    [JsonProperty("m_vecStressPositionA")]
    [JsonPropertyName("m_vecStressPositionA")]
    public int? MVecStressPositionA
    {
        get;
        set;
    }

    [JsonProperty("m_vecStressPositionB")]
    [JsonPropertyName("m_vecStressPositionB")]
    public int? MVecStressPositionB
    {
        get;
        set;
    }

    [JsonProperty("m_StuckLast")]
    [JsonPropertyName("m_StuckLast")]
    public int? MStuckLast
    {
        get;
        set;
    }

    [JsonProperty("m_bDesiresDuck")]
    [JsonPropertyName("m_bDesiresDuck")]
    public int? MBDesiresDuck
    {
        get;
        set;
    }

    [JsonProperty("m_bDuckOverride")]
    [JsonPropertyName("m_bDuckOverride")]
    public int? MBDuckOverride
    {
        get;
        set;
    }

    [JsonProperty("m_bHasWalkMovedSinceLastJump")]
    [JsonPropertyName("m_bHasWalkMovedSinceLastJump")]
    public int? MBHasWalkMovedSinceLastJump
    {
        get;
        set;
    }

    [JsonProperty("m_bInStuckTest")]
    [JsonPropertyName("m_bInStuckTest")]
    public int? MBInStuckTest
    {
        get;
        set;
    }

    [JsonProperty("m_bJumpApexPending")]
    [JsonPropertyName("m_bJumpApexPending")]
    public int? MBJumpApexPending
    {
        get;
        set;
    }

    [JsonProperty("m_bOldJumpPressed")]
    [JsonPropertyName("m_bOldJumpPressed")]
    public int? MBOldJumpPressed
    {
        get;
        set;
    }

    [JsonProperty("m_bSpeedCropped")]
    [JsonPropertyName("m_bSpeedCropped")]
    public int? MBSpeedCropped
    {
        get;
        set;
    }

    [JsonProperty("m_bWasSurfing")]
    [JsonPropertyName("m_bWasSurfing")]
    public int? MBWasSurfing
    {
        get;
        set;
    }

    [JsonProperty("m_duckUntilOnGround")]
    [JsonPropertyName("m_duckUntilOnGround")]
    public int? MDuckUntilOnGround
    {
        get;
        set;
    }

    [JsonProperty("m_fStashGrenadeParameterWhen")]
    [JsonPropertyName("m_fStashGrenadeParameterWhen")]
    public int? MFStashGrenadeParameterWhen
    {
        get;
        set;
    }

    [JsonProperty("m_flAccumulatedJumpError")]
    [JsonPropertyName("m_flAccumulatedJumpError")]
    public int? MFlAccumulatedJumpError
    {
        get;
        set;
    }

    [JsonProperty("m_flDuckAmount")]
    [JsonPropertyName("m_flDuckAmount")]
    public int? MFlDuckAmount
    {
        get;
        set;
    }

    [JsonProperty("m_flDuckOffset")]
    [JsonPropertyName("m_flDuckOffset")]
    public int? MFlDuckOffset
    {
        get;
        set;
    }

    [JsonProperty("m_flDuckSpeed")]
    [JsonPropertyName("m_flDuckSpeed")]
    public int? MFlDuckSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flHeightAtJumpStart")]
    [JsonPropertyName("m_flHeightAtJumpStart")]
    public int? MFlHeightAtJumpStart
    {
        get;
        set;
    }

    [JsonProperty("m_flJumpPressedTime")]
    [JsonPropertyName("m_flJumpPressedTime")]
    public int? MFlJumpPressedTime
    {
        get;
        set;
    }

    [JsonProperty("m_flLastDuckTime")]
    [JsonPropertyName("m_flLastDuckTime")]
    public int? MFlLastDuckTime
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxJumpHeightLastJump")]
    [JsonPropertyName("m_flMaxJumpHeightLastJump")]
    public int? MFlMaxJumpHeightLastJump
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxJumpHeightThisJump")]
    [JsonPropertyName("m_flMaxJumpHeightThisJump")]
    public int? MFlMaxJumpHeightThisJump
    {
        get;
        set;
    }

    [JsonProperty("m_flOffsetTickCompleteTime")]
    [JsonPropertyName("m_flOffsetTickCompleteTime")]
    public int? MFlOffsetTickCompleteTime
    {
        get;
        set;
    }

    [JsonProperty("m_flOffsetTickStashedSpeed")]
    [JsonPropertyName("m_flOffsetTickStashedSpeed")]
    public int? MFlOffsetTickStashedSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flStamina")]
    [JsonPropertyName("m_flStamina")]
    public int? MFlStamina
    {
        get;
        set;
    }

    [JsonProperty("m_flStaminaAtJumpStart")]
    [JsonPropertyName("m_flStaminaAtJumpStart")]
    public int? MFlStaminaAtJumpStart
    {
        get;
        set;
    }

    [JsonProperty("m_flTicksSinceLastSurfingDetected")]
    [JsonPropertyName("m_flTicksSinceLastSurfingDetected")]
    public int? MFlTicksSinceLastSurfingDetected
    {
        get;
        set;
    }

    [JsonProperty("m_flWaterEntryTime")]
    [JsonPropertyName("m_flWaterEntryTime")]
    public int? MFlWaterEntryTime
    {
        get;
        set;
    }

    [JsonProperty("m_nButtonDownMaskPrev")]
    [JsonPropertyName("m_nButtonDownMaskPrev")]
    public int? MNButtonDownMaskPrev
    {
        get;
        set;
    }

    [JsonProperty("m_nDuckJumpTimeMsecs")]
    [JsonPropertyName("m_nDuckJumpTimeMsecs")]
    public int? MNDuckJumpTimeMsecs
    {
        get;
        set;
    }

    [JsonProperty("m_nDuckTimeMsecs")]
    [JsonPropertyName("m_nDuckTimeMsecs")]
    public int? MNDuckTimeMsecs
    {
        get;
        set;
    }

    [JsonProperty("m_nGameCodeHasMovedPlayerAfterCommand")]
    [JsonPropertyName("m_nGameCodeHasMovedPlayerAfterCommand")]
    public int? MNGameCodeHasMovedPlayerAfterCommand
    {
        get;
        set;
    }

    [JsonProperty("m_nJumpTimeMsecs")]
    [JsonPropertyName("m_nJumpTimeMsecs")]
    public int? MNJumpTimeMsecs
    {
        get;
        set;
    }

    [JsonProperty("m_nLadderSurfacePropIndex")]
    [JsonPropertyName("m_nLadderSurfacePropIndex")]
    public int? MNLadderSurfacePropIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nOldWaterLevel")]
    [JsonPropertyName("m_nOldWaterLevel")]
    public int? MNOldWaterLevel
    {
        get;
        set;
    }

    [JsonProperty("m_nTraceCount")]
    [JsonPropertyName("m_nTraceCount")]
    public int? MNTraceCount
    {
        get;
        set;
    }

    [JsonProperty("m_vecForward")]
    [JsonPropertyName("m_vecForward")]
    public int? MVecForward
    {
        get;
        set;
    }

    [JsonProperty("m_vecInputRotated")]
    [JsonPropertyName("m_vecInputRotated")]
    public int? MVecInputRotated
    {
        get;
        set;
    }

    [JsonProperty("m_vecLadderNormal")]
    [JsonPropertyName("m_vecLadderNormal")]
    public int? MVecLadderNormal
    {
        get;
        set;
    }

    [JsonProperty("m_vecLastPositionAtFullCrouchSpeed")]
    [JsonPropertyName("m_vecLastPositionAtFullCrouchSpeed")]
    public int? MVecLastPositionAtFullCrouchSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_vecUp")]
    [JsonPropertyName("m_vecUp")]
    public int? MVecUp
    {
        get;
        set;
    }

    [JsonProperty("bClip3DSkyBoxNearToWorldFar")]
    [JsonPropertyName("bClip3DSkyBoxNearToWorldFar")]
    public int? BClip3DSkyBoxNearToWorldFar
    {
        get;
        set;
    }

    [JsonProperty("flClip3DSkyBoxNearToWorldFarOffset")]
    [JsonPropertyName("flClip3DSkyBoxNearToWorldFarOffset")]
    public int? FlClip3DSkyBoxNearToWorldFarOffset
    {
        get;
        set;
    }

    [JsonProperty("fog")]
    [JsonPropertyName("fog")]
    public int? Fog
    {
        get;
        set;
    }

    [JsonProperty("m_nWorldGroupID")]
    [JsonPropertyName("m_nWorldGroupID")]
    public int? MNWorldGroupID
    {
        get;
        set;
    }

    [JsonProperty("origin")]
    [JsonPropertyName("origin")]
    public int? Origin
    {
        get;
        set;
    }

    [JsonProperty("scale")]
    [JsonPropertyName("scale")]
    public int? Scale
    {
        get;
        set;
    }

    [JsonProperty("flIn")]
    [JsonPropertyName("flIn")]
    public int? FlIn
    {
        get;
        set;
    }

    [JsonProperty("flOut")]
    [JsonPropertyName("flOut")]
    public int? FlOut
    {
        get;
        set;
    }

    [JsonProperty("iAttribHook")]
    [JsonPropertyName("iAttribHook")]
    public int? IAttribHook
    {
        get;
        set;
    }

    [JsonProperty("m_hPlayerPing")]
    [JsonPropertyName("m_hPlayerPing")]
    public int? MHPlayerPing
    {
        get;
        set;
    }

    [JsonProperty("m_flSwimSoundTime")]
    [JsonPropertyName("m_flSwimSoundTime")]
    public int? MFlSwimSoundTime
    {
        get;
        set;
    }

    [JsonProperty("m_flWaterJumpTime")]
    [JsonPropertyName("m_flWaterJumpTime")]
    public int? MFlWaterJumpTime
    {
        get;
        set;
    }

    [JsonProperty("m_vecWaterJumpVel")]
    [JsonPropertyName("m_vecWaterJumpVel")]
    public int? MVecWaterJumpVel
    {
        get;
        set;
    }

    [JsonProperty("m_bBlockInspectUntilNextGraphUpdate")]
    [JsonPropertyName("m_bBlockInspectUntilNextGraphUpdate")]
    public int? MBBlockInspectUntilNextGraphUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_bIsHoldingLookAtWeapon")]
    [JsonPropertyName("m_bIsHoldingLookAtWeapon")]
    public int? MBIsHoldingLookAtWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_bIsLookingAtWeapon")]
    [JsonPropertyName("m_bIsLookingAtWeapon")]
    public int? MBIsLookingAtWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_nOldTotalInputHistoryCount")]
    [JsonPropertyName("m_nOldTotalInputHistoryCount")]
    public int? MNOldTotalInputHistoryCount
    {
        get;
        set;
    }

    [JsonProperty("m_nOldTotalShootPositionHistoryCount")]
    [JsonPropertyName("m_nOldTotalShootPositionHistoryCount")]
    public int? MNOldTotalShootPositionHistoryCount
    {
        get;
        set;
    }

    [JsonProperty("m_networkAnimTiming")]
    [JsonPropertyName("m_networkAnimTiming")]
    public int? MNetworkAnimTiming
    {
        get;
        set;
    }

    [JsonProperty("m_DefaultLoadoutSlot")]
    [JsonPropertyName("m_DefaultLoadoutSlot")]
    public int? MDefaultLoadoutSlot
    {
        get;
        set;
    }

    [JsonProperty("m_GearSlot")]
    [JsonPropertyName("m_GearSlot")]
    public int? MGearSlot
    {
        get;
        set;
    }

    [JsonProperty("m_GearSlotPosition")]
    [JsonPropertyName("m_GearSlotPosition")]
    public int? MGearSlotPosition
    {
        get;
        set;
    }

    [JsonProperty("m_WeaponCategory")]
    [JsonPropertyName("m_WeaponCategory")]
    public int? MWeaponCategory
    {
        get;
        set;
    }

    [JsonProperty("m_WeaponType")]
    [JsonPropertyName("m_WeaponType")]
    public int? MWeaponType
    {
        get;
        set;
    }

    [JsonProperty("m_bAllowBurstHolster")]
    [JsonPropertyName("m_bAllowBurstHolster")]
    public int? MBAllowBurstHolster
    {
        get;
        set;
    }

    [JsonProperty("m_bCannotShootUnderwater")]
    [JsonPropertyName("m_bCannotShootUnderwater")]
    public int? MBCannotShootUnderwater
    {
        get;
        set;
    }

    [JsonProperty("m_bHasBurstMode")]
    [JsonPropertyName("m_bHasBurstMode")]
    public int? MBHasBurstMode
    {
        get;
        set;
    }

    [JsonProperty("m_bHideViewModelWhenZoomed")]
    [JsonPropertyName("m_bHideViewModelWhenZoomed")]
    public int? MBHideViewModelWhenZoomed
    {
        get;
        set;
    }

    [JsonProperty("m_bIsFullAuto")]
    [JsonPropertyName("m_bIsFullAuto")]
    public int? MBIsFullAuto
    {
        get;
        set;
    }

    [JsonProperty("m_bIsRevolver")]
    [JsonPropertyName("m_bIsRevolver")]
    public int? MBIsRevolver
    {
        get;
        set;
    }

    [JsonProperty("m_bMeleeWeapon")]
    [JsonPropertyName("m_bMeleeWeapon")]
    public int? MBMeleeWeapon
    {
        get;
        set;
    }

    [JsonProperty("m_bReloadsSingleShells")]
    [JsonPropertyName("m_bReloadsSingleShells")]
    public int? MBReloadsSingleShells
    {
        get;
        set;
    }

    [JsonProperty("m_bUnzoomsAfterShot")]
    [JsonPropertyName("m_bUnzoomsAfterShot")]
    public int? MBUnzoomsAfterShot
    {
        get;
        set;
    }

    [JsonProperty("m_eSilencerType")]
    [JsonPropertyName("m_eSilencerType")]
    public int? MESilencerType
    {
        get;
        set;
    }

    [JsonProperty("m_flArmorRatio")]
    [JsonPropertyName("m_flArmorRatio")]
    public int? MFlArmorRatio
    {
        get;
        set;
    }

    [JsonProperty("m_flAttackMovespeedFactor")]
    [JsonPropertyName("m_flAttackMovespeedFactor")]
    public int? MFlAttackMovespeedFactor
    {
        get;
        set;
    }

    [JsonProperty("m_flCycleTime")]
    [JsonPropertyName("m_flCycleTime")]
    public int? MFlCycleTime
    {
        get;
        set;
    }

    [JsonProperty("m_flDeployDuration")]
    [JsonPropertyName("m_flDeployDuration")]
    public int? MFlDeployDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flDisallowAttackAfterReloadStartDuration")]
    [JsonPropertyName("m_flDisallowAttackAfterReloadStartDuration")]
    public int? MFlDisallowAttackAfterReloadStartDuration
    {
        get;
        set;
    }

    [JsonProperty("m_flFlinchVelocityModifierLarge")]
    [JsonPropertyName("m_flFlinchVelocityModifierLarge")]
    public int? MFlFlinchVelocityModifierLarge
    {
        get;
        set;
    }

    [JsonProperty("m_flFlinchVelocityModifierSmall")]
    [JsonPropertyName("m_flFlinchVelocityModifierSmall")]
    public int? MFlFlinchVelocityModifierSmall
    {
        get;
        set;
    }

    [JsonProperty("m_flHeadshotMultiplier")]
    [JsonPropertyName("m_flHeadshotMultiplier")]
    public int? MFlHeadshotMultiplier
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyAltSoundThreshold")]
    [JsonPropertyName("m_flInaccuracyAltSoundThreshold")]
    public int? MFlInaccuracyAltSoundThreshold
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyCrouch")]
    [JsonPropertyName("m_flInaccuracyCrouch")]
    public int? MFlInaccuracyCrouch
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyFire")]
    [JsonPropertyName("m_flInaccuracyFire")]
    public int? MFlInaccuracyFire
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyJump")]
    [JsonPropertyName("m_flInaccuracyJump")]
    public int? MFlInaccuracyJump
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyJumpApex")]
    [JsonPropertyName("m_flInaccuracyJumpApex")]
    public int? MFlInaccuracyJumpApex
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyJumpInitial")]
    [JsonPropertyName("m_flInaccuracyJumpInitial")]
    public int? MFlInaccuracyJumpInitial
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyLadder")]
    [JsonPropertyName("m_flInaccuracyLadder")]
    public int? MFlInaccuracyLadder
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyLand")]
    [JsonPropertyName("m_flInaccuracyLand")]
    public int? MFlInaccuracyLand
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyMove")]
    [JsonPropertyName("m_flInaccuracyMove")]
    public int? MFlInaccuracyMove
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyPitchShift")]
    [JsonPropertyName("m_flInaccuracyPitchShift")]
    public int? MFlInaccuracyPitchShift
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyReload")]
    [JsonPropertyName("m_flInaccuracyReload")]
    public int? MFlInaccuracyReload
    {
        get;
        set;
    }

    [JsonProperty("m_flInaccuracyStand")]
    [JsonPropertyName("m_flInaccuracyStand")]
    public int? MFlInaccuracyStand
    {
        get;
        set;
    }

    [JsonProperty("m_flIronSightFOV")]
    [JsonPropertyName("m_flIronSightFOV")]
    public int? MFlIronSightFOV
    {
        get;
        set;
    }

    [JsonProperty("m_flIronSightLooseness")]
    [JsonPropertyName("m_flIronSightLooseness")]
    public int? MFlIronSightLooseness
    {
        get;
        set;
    }

    [JsonProperty("m_flIronSightPivotForward")]
    [JsonPropertyName("m_flIronSightPivotForward")]
    public int? MFlIronSightPivotForward
    {
        get;
        set;
    }

    [JsonProperty("m_flIronSightPullUpSpeed")]
    [JsonPropertyName("m_flIronSightPullUpSpeed")]
    public int? MFlIronSightPullUpSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flIronSightPutDownSpeed")]
    [JsonPropertyName("m_flIronSightPutDownSpeed")]
    public int? MFlIronSightPutDownSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxSpeed")]
    [JsonPropertyName("m_flMaxSpeed")]
    public int? MFlMaxSpeed
    {
        get;
        set;
    }

    [JsonProperty("m_flPenetration")]
    [JsonPropertyName("m_flPenetration")]
    public int? MFlPenetration
    {
        get;
        set;
    }

    [JsonProperty("m_flRangeModifier")]
    [JsonPropertyName("m_flRangeModifier")]
    public int? MFlRangeModifier
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoilAngle")]
    [JsonPropertyName("m_flRecoilAngle")]
    public int? MFlRecoilAngle
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoilAngleVariance")]
    [JsonPropertyName("m_flRecoilAngleVariance")]
    public int? MFlRecoilAngleVariance
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoilMagnitude")]
    [JsonPropertyName("m_flRecoilMagnitude")]
    public int? MFlRecoilMagnitude
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoilMagnitudeVariance")]
    [JsonPropertyName("m_flRecoilMagnitudeVariance")]
    public int? MFlRecoilMagnitudeVariance
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoveryTimeCrouch")]
    [JsonPropertyName("m_flRecoveryTimeCrouch")]
    public int? MFlRecoveryTimeCrouch
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoveryTimeCrouchFinal")]
    [JsonPropertyName("m_flRecoveryTimeCrouchFinal")]
    public int? MFlRecoveryTimeCrouchFinal
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoveryTimeStand")]
    [JsonPropertyName("m_flRecoveryTimeStand")]
    public int? MFlRecoveryTimeStand
    {
        get;
        set;
    }

    [JsonProperty("m_flRecoveryTimeStandFinal")]
    [JsonPropertyName("m_flRecoveryTimeStandFinal")]
    public int? MFlRecoveryTimeStandFinal
    {
        get;
        set;
    }

    [JsonProperty("m_flSpread")]
    [JsonPropertyName("m_flSpread")]
    public int? MFlSpread
    {
        get;
        set;
    }

    [JsonProperty("m_flThrowVelocity")]
    [JsonPropertyName("m_flThrowVelocity")]
    public int? MFlThrowVelocity
    {
        get;
        set;
    }

    [JsonProperty("m_flZoomTime0")]
    [JsonPropertyName("m_flZoomTime0")]
    public int? MFlZoomTime0
    {
        get;
        set;
    }

    [JsonProperty("m_flZoomTime1")]
    [JsonPropertyName("m_flZoomTime1")]
    public int? MFlZoomTime1
    {
        get;
        set;
    }

    [JsonProperty("m_flZoomTime2")]
    [JsonPropertyName("m_flZoomTime2")]
    public int? MFlZoomTime2
    {
        get;
        set;
    }

    [JsonProperty("m_nBurstShotCount")]
    [JsonPropertyName("m_nBurstShotCount")]
    public int? MNBurstShotCount
    {
        get;
        set;
    }

    [JsonProperty("m_nCrosshairDeltaDistance")]
    [JsonPropertyName("m_nCrosshairDeltaDistance")]
    public int? MNCrosshairDeltaDistance
    {
        get;
        set;
    }

    [JsonProperty("m_nCrosshairMinDistance")]
    [JsonPropertyName("m_nCrosshairMinDistance")]
    public int? MNCrosshairMinDistance
    {
        get;
        set;
    }

    [JsonProperty("m_nDamage")]
    [JsonPropertyName("m_nDamage")]
    public int? MNDamage
    {
        get;
        set;
    }

    [JsonProperty("m_nKillAward")]
    [JsonPropertyName("m_nKillAward")]
    public int? MNKillAward
    {
        get;
        set;
    }

    [JsonProperty("m_nNumBullets")]
    [JsonPropertyName("m_nNumBullets")]
    public int? MNNumBullets
    {
        get;
        set;
    }

    [JsonProperty("m_nPrice")]
    [JsonPropertyName("m_nPrice")]
    public int? MNPrice
    {
        get;
        set;
    }

    [JsonProperty("m_nPrimaryReserveAmmoMax")]
    [JsonPropertyName("m_nPrimaryReserveAmmoMax")]
    public int? MNPrimaryReserveAmmoMax
    {
        get;
        set;
    }

    [JsonProperty("m_nRecoilSeed")]
    [JsonPropertyName("m_nRecoilSeed")]
    public int? MNRecoilSeed
    {
        get;
        set;
    }

    [JsonProperty("m_nRecoveryTransitionEndBullet")]
    [JsonPropertyName("m_nRecoveryTransitionEndBullet")]
    public int? MNRecoveryTransitionEndBullet
    {
        get;
        set;
    }

    [JsonProperty("m_nRecoveryTransitionStartBullet")]
    [JsonPropertyName("m_nRecoveryTransitionStartBullet")]
    public int? MNRecoveryTransitionStartBullet
    {
        get;
        set;
    }

    [JsonProperty("m_nSecondaryReserveAmmoMax")]
    [JsonPropertyName("m_nSecondaryReserveAmmoMax")]
    public int? MNSecondaryReserveAmmoMax
    {
        get;
        set;
    }

    [JsonProperty("m_nSpreadSeed")]
    [JsonPropertyName("m_nSpreadSeed")]
    public int? MNSpreadSeed
    {
        get;
        set;
    }

    [JsonProperty("m_nTracerFrequency")]
    [JsonPropertyName("m_nTracerFrequency")]
    public int? MNTracerFrequency
    {
        get;
        set;
    }

    [JsonProperty("m_nZoomFOV1")]
    [JsonPropertyName("m_nZoomFOV1")]
    public int? MNZoomFOV1
    {
        get;
        set;
    }

    [JsonProperty("m_nZoomFOV2")]
    [JsonPropertyName("m_nZoomFOV2")]
    public int? MNZoomFOV2
    {
        get;
        set;
    }

    [JsonProperty("m_nZoomLevels")]
    [JsonPropertyName("m_nZoomLevels")]
    public int? MNZoomLevels
    {
        get;
        set;
    }

    [JsonProperty("m_szAnimClass")]
    [JsonPropertyName("m_szAnimClass")]
    public int? MSzAnimClass
    {
        get;
        set;
    }

    [JsonProperty("m_szAnimSkeleton")]
    [JsonPropertyName("m_szAnimSkeleton")]
    public int? MSzAnimSkeleton
    {
        get;
        set;
    }

    [JsonProperty("m_szModel_AG2")]
    [JsonPropertyName("m_szModel_AG2")]
    public int? MSzModelAG2
    {
        get;
        set;
    }

    [JsonProperty("m_szName")]
    [JsonPropertyName("m_szName")]
    public int? MSzName
    {
        get;
        set;
    }

    [JsonProperty("m_szTracerParticle")]
    [JsonPropertyName("m_szTracerParticle")]
    public int? MSzTracerParticle
    {
        get;
        set;
    }

    [JsonProperty("m_szUseRadioSubtitle")]
    [JsonPropertyName("m_szUseRadioSubtitle")]
    public int? MSzUseRadioSubtitle
    {
        get;
        set;
    }

    [JsonProperty("m_vecMuzzlePos0")]
    [JsonPropertyName("m_vecMuzzlePos0")]
    public int? MVecMuzzlePos0
    {
        get;
        set;
    }

    [JsonProperty("m_vecMuzzlePos1")]
    [JsonPropertyName("m_vecMuzzlePos1")]
    public int? MVecMuzzlePos1
    {
        get;
        set;
    }

    [JsonProperty("m_nAABBDirection")]
    [JsonPropertyName("m_nAABBDirection")]
    public int? MNAABBDirection
    {
        get;
        set;
    }

    [JsonProperty("m_vDistanceInnerMaxs")]
    [JsonPropertyName("m_vDistanceInnerMaxs")]
    public int? MVDistanceInnerMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vDistanceInnerMins")]
    [JsonPropertyName("m_vDistanceInnerMins")]
    public int? MVDistanceInnerMins
    {
        get;
        set;
    }

    [JsonProperty("m_vDistanceOuterMaxs")]
    [JsonPropertyName("m_vDistanceOuterMaxs")]
    public int? MVDistanceOuterMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vDistanceOuterMins")]
    [JsonPropertyName("m_vDistanceOuterMins")]
    public int? MVDistanceOuterMins
    {
        get;
        set;
    }

    [JsonProperty("m_CollisionGroup")]
    [JsonPropertyName("m_CollisionGroup")]
    public int? MCollisionGroup
    {
        get;
        set;
    }

    [JsonProperty("m_collisionAttribute")]
    [JsonPropertyName("m_collisionAttribute")]
    public int? MCollisionAttribute
    {
        get;
        set;
    }

    [JsonProperty("m_flBoundingRadius")]
    [JsonPropertyName("m_flBoundingRadius")]
    public int? MFlBoundingRadius
    {
        get;
        set;
    }

    [JsonProperty("m_flCapsuleRadius")]
    [JsonPropertyName("m_flCapsuleRadius")]
    public int? MFlCapsuleRadius
    {
        get;
        set;
    }

    [JsonProperty("m_nEnablePhysics")]
    [JsonPropertyName("m_nEnablePhysics")]
    public int? MNEnablePhysics
    {
        get;
        set;
    }

    [JsonProperty("m_nSolidType")]
    [JsonPropertyName("m_nSolidType")]
    public int? MNSolidType
    {
        get;
        set;
    }

    [JsonProperty("m_nSurroundType")]
    [JsonPropertyName("m_nSurroundType")]
    public int? MNSurroundType
    {
        get;
        set;
    }

    [JsonProperty("m_triggerBloat")]
    [JsonPropertyName("m_triggerBloat")]
    public int? MTriggerBloat
    {
        get;
        set;
    }

    [JsonProperty("m_usSolidFlags")]
    [JsonPropertyName("m_usSolidFlags")]
    public int? MUsSolidFlags
    {
        get;
        set;
    }

    [JsonProperty("m_vCapsuleCenter1")]
    [JsonPropertyName("m_vCapsuleCenter1")]
    public int? MVCapsuleCenter1
    {
        get;
        set;
    }

    [JsonProperty("m_vCapsuleCenter2")]
    [JsonPropertyName("m_vCapsuleCenter2")]
    public int? MVCapsuleCenter2
    {
        get;
        set;
    }

    [JsonProperty("m_vecMaxs")]
    [JsonPropertyName("m_vecMaxs")]
    public int? MVecMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vecMins")]
    [JsonPropertyName("m_vecMins")]
    public int? MVecMins
    {
        get;
        set;
    }

    [JsonProperty("m_vecSpecifiedSurroundingMaxs")]
    [JsonPropertyName("m_vecSpecifiedSurroundingMaxs")]
    public int? MVecSpecifiedSurroundingMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vecSpecifiedSurroundingMins")]
    [JsonPropertyName("m_vecSpecifiedSurroundingMins")]
    public int? MVecSpecifiedSurroundingMins
    {
        get;
        set;
    }

    [JsonProperty("m_vecSurroundingMaxs")]
    [JsonPropertyName("m_vecSurroundingMaxs")]
    public int? MVecSurroundingMaxs
    {
        get;
        set;
    }

    [JsonProperty("m_vecSurroundingMins")]
    [JsonPropertyName("m_vecSurroundingMins")]
    public int? MVecSurroundingMins
    {
        get;
        set;
    }

    [JsonProperty("m_DamagerXuid")]
    [JsonPropertyName("m_DamagerXuid")]
    public int? MDamagerXuid
    {
        get;
        set;
    }

    [JsonProperty("m_PlayerDamager")]
    [JsonPropertyName("m_PlayerDamager")]
    public int? MPlayerDamager
    {
        get;
        set;
    }

    [JsonProperty("m_PlayerRecipient")]
    [JsonPropertyName("m_PlayerRecipient")]
    public int? MPlayerRecipient
    {
        get;
        set;
    }

    [JsonProperty("m_RecipientXuid")]
    [JsonPropertyName("m_RecipientXuid")]
    public int? MRecipientXuid
    {
        get;
        set;
    }

    [JsonProperty("m_bIsOtherEnemy")]
    [JsonPropertyName("m_bIsOtherEnemy")]
    public int? MBIsOtherEnemy
    {
        get;
        set;
    }

    [JsonProperty("m_flActualHealthRemoved")]
    [JsonPropertyName("m_flActualHealthRemoved")]
    public int? MFlActualHealthRemoved
    {
        get;
        set;
    }

    [JsonProperty("m_flBulletsDamage")]
    [JsonPropertyName("m_flBulletsDamage")]
    public int? MFlBulletsDamage
    {
        get;
        set;
    }

    [JsonProperty("m_hPlayerControllerDamager")]
    [JsonPropertyName("m_hPlayerControllerDamager")]
    public int? MHPlayerControllerDamager
    {
        get;
        set;
    }

    [JsonProperty("m_hPlayerControllerRecipient")]
    [JsonPropertyName("m_hPlayerControllerRecipient")]
    public int? MHPlayerControllerRecipient
    {
        get;
        set;
    }

    [JsonProperty("m_iLastBulletUpdate")]
    [JsonPropertyName("m_iLastBulletUpdate")]
    public int? MILastBulletUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_iNumHits")]
    [JsonPropertyName("m_iNumHits")]
    public int? MINumHits
    {
        get;
        set;
    }

    [JsonProperty("m_killType")]
    [JsonPropertyName("m_killType")]
    public int? MKillType
    {
        get;
        set;
    }

    [JsonProperty("m_szPlayerDamagerName")]
    [JsonPropertyName("m_szPlayerDamagerName")]
    public int? MSzPlayerDamagerName
    {
        get;
        set;
    }

    [JsonProperty("m_szPlayerRecipientName")]
    [JsonPropertyName("m_szPlayerRecipientName")]
    public int? MSzPlayerRecipientName
    {
        get;
        set;
    }

    [JsonProperty("m_nLastHitDamageLevel")]
    [JsonPropertyName("m_nLastHitDamageLevel")]
    public int? MNLastHitDamageLevel
    {
        get;
        set;
    }

    [JsonProperty("m_vecDamageTakenByHitGroup")]
    [JsonPropertyName("m_vecDamageTakenByHitGroup")]
    public int? MVecDamageTakenByHitGroup
    {
        get;
        set;
    }

    [JsonProperty("m_RagdollPose")]
    [JsonPropertyName("m_RagdollPose")]
    public int? MRagdollPose
    {
        get;
        set;
    }

    [JsonProperty("m_bAnimGraphUpdateEnabled")]
    [JsonPropertyName("m_bAnimGraphUpdateEnabled")]
    public int? MBAnimGraphUpdateEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bAnimationUpdateScheduled")]
    [JsonPropertyName("m_bAnimationUpdateScheduled")]
    public int? MBAnimationUpdateScheduled
    {
        get;
        set;
    }

    [JsonProperty("m_bBuiltRagdoll")]
    [JsonPropertyName("m_bBuiltRagdoll")]
    public int? MBBuiltRagdoll
    {
        get;
        set;
    }

    [JsonProperty("m_bHasAnimatedMaterialAttributes")]
    [JsonPropertyName("m_bHasAnimatedMaterialAttributes")]
    public int? MBHasAnimatedMaterialAttributes
    {
        get;
        set;
    }

    [JsonProperty("m_bInitiallyPopulateInterpHistory")]
    [JsonPropertyName("m_bInitiallyPopulateInterpHistory")]
    public int? MBInitiallyPopulateInterpHistory
    {
        get;
        set;
    }

    [JsonProperty("m_bRagdollClientSide")]
    [JsonPropertyName("m_bRagdollClientSide")]
    public int? MBRagdollClientSide
    {
        get;
        set;
    }

    [JsonProperty("m_bRagdollEnabled")]
    [JsonPropertyName("m_bRagdollEnabled")]
    public int? MBRagdollEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_bSuppressAnimEventSounds")]
    [JsonPropertyName("m_bSuppressAnimEventSounds")]
    public int? MBSuppressAnimEventSounds
    {
        get;
        set;
    }

    [JsonProperty("m_flMaxSlopeDistance")]
    [JsonPropertyName("m_flMaxSlopeDistance")]
    public int? MFlMaxSlopeDistance
    {
        get;
        set;
    }

    [JsonProperty("m_nForceBone")]
    [JsonPropertyName("m_nForceBone")]
    public int? MNForceBone
    {
        get;
        set;
    }

    [JsonProperty("m_pClientsideRagdoll")]
    [JsonPropertyName("m_pClientsideRagdoll")]
    public int? MPClientsideRagdoll
    {
        get;
        set;
    }

    [JsonProperty("m_vLastSlopeCheckPos")]
    [JsonPropertyName("m_vLastSlopeCheckPos")]
    public int? MVLastSlopeCheckPos
    {
        get;
        set;
    }

    [JsonProperty("m_vecForce")]
    [JsonPropertyName("m_vecForce")]
    public int? MVecForce
    {
        get;
        set;
    }

    [JsonProperty("m_bSetBonus")]
    [JsonPropertyName("m_bSetBonus")]
    public int? MBSetBonus
    {
        get;
        set;
    }

    [JsonProperty("m_flInitialValue")]
    [JsonPropertyName("m_flInitialValue")]
    public int? MFlInitialValue
    {
        get;
        set;
    }

    [JsonProperty("m_flValue")]
    [JsonPropertyName("m_flValue")]
    public int? MFlValue
    {
        get;
        set;
    }

    [JsonProperty("m_iAttributeDefinitionIndex")]
    [JsonPropertyName("m_iAttributeDefinitionIndex")]
    public int? MIAttributeDefinitionIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nRefundableCurrency")]
    [JsonPropertyName("m_nRefundableCurrency")]
    public int? MNRefundableCurrency
    {
        get;
        set;
    }

    [JsonProperty("m_flMagnitude")]
    [JsonPropertyName("m_flMagnitude")]
    public int? MFlMagnitude
    {
        get;
        set;
    }

    [JsonProperty("m_flScale")]
    [JsonPropertyName("m_flScale")]
    public int? MFlScale
    {
        get;
        set;
    }

    [JsonProperty("m_hEntity")]
    [JsonPropertyName("m_hEntity")]
    public int? MHEntity
    {
        get;
        set;
    }

    [JsonProperty("m_hOtherEntity")]
    [JsonPropertyName("m_hOtherEntity")]
    public int? MHOtherEntity
    {
        get;
        set;
    }

    [JsonProperty("m_iEffectName")]
    [JsonPropertyName("m_iEffectName")]
    public int? MIEffectName
    {
        get;
        set;
    }

    [JsonProperty("m_nAttachmentIndex")]
    [JsonPropertyName("m_nAttachmentIndex")]
    public int? MNAttachmentIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nAttachmentName")]
    [JsonPropertyName("m_nAttachmentName")]
    public int? MNAttachmentName
    {
        get;
        set;
    }

    [JsonProperty("m_nColor")]
    [JsonPropertyName("m_nColor")]
    public int? MNColor
    {
        get;
        set;
    }

    [JsonProperty("m_nEffectIndex")]
    [JsonPropertyName("m_nEffectIndex")]
    public int? MNEffectIndex
    {
        get;
        set;
    }

    [JsonProperty("m_nExplosionType")]
    [JsonPropertyName("m_nExplosionType")]
    public int? MNExplosionType
    {
        get;
        set;
    }

    [JsonProperty("m_nHitBox")]
    [JsonPropertyName("m_nHitBox")]
    public int? MNHitBox
    {
        get;
        set;
    }

    [JsonProperty("m_nMaterial")]
    [JsonPropertyName("m_nMaterial")]
    public int? MNMaterial
    {
        get;
        set;
    }

    [JsonProperty("m_nPenetrate")]
    [JsonPropertyName("m_nPenetrate")]
    public int? MNPenetrate
    {
        get;
        set;
    }

    [JsonProperty("m_nSurfaceProp")]
    [JsonPropertyName("m_nSurfaceProp")]
    public int? MNSurfaceProp
    {
        get;
        set;
    }

    [JsonProperty("m_vAngles")]
    [JsonPropertyName("m_vAngles")]
    public int? MVAngles
    {
        get;
        set;
    }

    [JsonProperty("m_vNormal")]
    [JsonPropertyName("m_vNormal")]
    public int? MVNormal
    {
        get;
        set;
    }

    [JsonProperty("m_vOrigin")]
    [JsonPropertyName("m_vOrigin")]
    public int? MVOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vStart")]
    [JsonPropertyName("m_vStart")]
    public int? MVStart
    {
        get;
        set;
    }

    [JsonProperty("m_PathIndex")]
    [JsonPropertyName("m_PathIndex")]
    public int? MPathIndex
    {
        get;
        set;
    }

    [JsonProperty("m_designerName")]
    [JsonPropertyName("m_designerName")]
    public int? MDesignerName
    {
        get;
        set;
    }

    [JsonProperty("m_fDataObjectTypes")]
    [JsonPropertyName("m_fDataObjectTypes")]
    public int? MFDataObjectTypes
    {
        get;
        set;
    }


    [JsonProperty("m_nameStringableIndex")]
    [JsonPropertyName("m_nameStringableIndex")]
    public int? MNameStringableIndex
    {
        get;
        set;
    }

    [JsonProperty("m_pNextByClass")]
    [JsonPropertyName("m_pNextByClass")]
    public int? MPNextByClass
    {
        get;
        set;
    }

    [JsonProperty("m_pPrev")]
    [JsonPropertyName("m_pPrev")]
    public int? MPPrev
    {
        get;
        set;
    }

    [JsonProperty("m_pPrevByClass")]
    [JsonPropertyName("m_pPrevByClass")]
    public int? MPPrevByClass
    {
        get;
        set;
    }

    [JsonProperty("m_CScriptComponent")]
    [JsonPropertyName("m_CScriptComponent")]
    public int? MCScriptComponent
    {
        get;
        set;
    }

    [JsonProperty("m_iszPrivateVScripts")]
    [JsonPropertyName("m_iszPrivateVScripts")]
    public int? MIszPrivateVScripts
    {
        get;
        set;
    }

    [JsonProperty("m_pEntity")]
    [JsonPropertyName("m_pEntity")]
    public int? MPEntity
    {
        get;
        set;
    }

    [JsonProperty("m_OnPlay")]
    [JsonPropertyName("m_OnPlay")]
    public int? MOnPlay
    {
        get;
        set;
    }

    [JsonProperty("m_bOverrideWithEvent")]
    [JsonPropertyName("m_bOverrideWithEvent")]
    public int? MBOverrideWithEvent
    {
        get;
        set;
    }

    [JsonProperty("m_hProxySoundscape")]
    [JsonPropertyName("m_hProxySoundscape")]
    public int? MHProxySoundscape
    {
        get;
        set;
    }

    [JsonProperty("m_positionNames")]
    [JsonPropertyName("m_positionNames")]
    public int? MPositionNames
    {
        get;
        set;
    }

    [JsonProperty("m_soundEventHash")]
    [JsonPropertyName("m_soundEventHash")]
    public int? MSoundEventHash
    {
        get;
        set;
    }

    [JsonProperty("m_soundEventName")]
    [JsonPropertyName("m_soundEventName")]
    public int? MSoundEventName
    {
        get;
        set;
    }

    [JsonProperty("m_soundscapeEntityListId")]
    [JsonPropertyName("m_soundscapeEntityListId")]
    public int? MSoundscapeEntityListId
    {
        get;
        set;
    }

    [JsonProperty("m_soundscapeIndex")]
    [JsonPropertyName("m_soundscapeIndex")]
    public int? MSoundscapeIndex
    {
        get;
        set;
    }

    [JsonProperty("m_soundscapeName")]
    [JsonPropertyName("m_soundscapeName")]
    public int? MSoundscapeName
    {
        get;
        set;
    }

    [JsonProperty("m_MainSoundscapeName")]
    [JsonPropertyName("m_MainSoundscapeName")]
    public int? MMainSoundscapeName
    {
        get;
        set;
    }

    [JsonProperty("m_animGraphNetworkedVars")]
    [JsonPropertyName("m_animGraphNetworkedVars")]
    public int? MAnimGraphNetworkedVars
    {
        get;
        set;
    }

    [JsonProperty("m_bIsUsingAG2")]
    [JsonPropertyName("m_bIsUsingAG2")]
    public int? MBIsUsingAG2
    {
        get;
        set;
    }

    [JsonProperty("m_bLastUpdateSkipped")]
    [JsonPropertyName("m_bLastUpdateSkipped")]
    public int? MBLastUpdateSkipped
    {
        get;
        set;
    }

    [JsonProperty("m_bNetworkedAnimationInputsChanged")]
    [JsonPropertyName("m_bNetworkedAnimationInputsChanged")]
    public int? MBNetworkedAnimationInputsChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bNetworkedSequenceChanged")]
    [JsonPropertyName("m_bNetworkedSequenceChanged")]
    public int? MBNetworkedSequenceChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bSequenceFinished")]
    [JsonPropertyName("m_bSequenceFinished")]
    public int? MBSequenceFinished
    {
        get;
        set;
    }

    [JsonProperty("m_flPrevAnimUpdateTime")]
    [JsonPropertyName("m_flPrevAnimUpdateTime")]
    public int? MFlPrevAnimUpdateTime
    {
        get;
        set;
    }

    [JsonProperty("m_flSoundSyncTime")]
    [JsonPropertyName("m_flSoundSyncTime")]
    public int? MFlSoundSyncTime
    {
        get;
        set;
    }

    [JsonProperty("m_hGraphDefinitionAG2")]
    [JsonPropertyName("m_hGraphDefinitionAG2")]
    public int? MHGraphDefinitionAG2
    {
        get;
        set;
    }

    [JsonProperty("m_nActiveIKChainMask")]
    [JsonPropertyName("m_nActiveIKChainMask")]
    public int? MNActiveIKChainMask
    {
        get;
        set;
    }

    [JsonProperty("m_nAnimLoopMode")]
    [JsonPropertyName("m_nAnimLoopMode")]
    public int? MNAnimLoopMode
    {
        get;
        set;
    }

    [JsonProperty("m_nGraphCreationFlagsAG2")]
    [JsonPropertyName("m_nGraphCreationFlagsAG2")]
    public int? MNGraphCreationFlagsAG2
    {
        get;
        set;
    }

    [JsonProperty("m_nNotifyState")]
    [JsonPropertyName("m_nNotifyState")]
    public int? MNNotifyState
    {
        get;
        set;
    }

    [JsonProperty("m_nSerializePoseRecipeSizeAG2")]
    [JsonPropertyName("m_nSerializePoseRecipeSizeAG2")]
    public int? MNSerializePoseRecipeSizeAG2
    {
        get;
        set;
    }

    [JsonProperty("m_nSerializePoseRecipeVersionAG2")]
    [JsonPropertyName("m_nSerializePoseRecipeVersionAG2")]
    public int? MNSerializePoseRecipeVersionAG2
    {
        get;
        set;
    }

    [JsonProperty("m_nServerGraphDefReloadCountAG2")]
    [JsonPropertyName("m_nServerGraphDefReloadCountAG2")]
    public int? MNServerGraphDefReloadCountAG2
    {
        get;
        set;
    }

    [JsonProperty("m_nServerSerializationContextIteration")]
    [JsonPropertyName("m_nServerSerializationContextIteration")]
    public int? MNServerSerializationContextIteration
    {
        get;
        set;
    }

    [JsonProperty("m_serializedPoseRecipeAG2")]
    [JsonPropertyName("m_serializedPoseRecipeAG2")]
    public int? MSerializedPoseRecipeAG2
    {
        get;
        set;
    }

    [JsonProperty("m_sAttributeName")]
    [JsonPropertyName("m_sAttributeName")]
    public int? MSAttributeName
    {
        get;
        set;
    }

    [JsonProperty("m_iFilterClass")]
    [JsonPropertyName("m_iFilterClass")]
    public int? MIFilterClass
    {
        get;
        set;
    }

    [JsonProperty("m_fFilterMass")]
    [JsonPropertyName("m_fFilterMass")]
    public int? MFFilterMass
    {
        get;
        set;
    }

    [JsonProperty("m_iFilterModel")]
    [JsonPropertyName("m_iFilterModel")]
    public int? MIFilterModel
    {
        get;
        set;
    }

    [JsonProperty("m_nFilterType")]
    [JsonPropertyName("m_nFilterType")]
    public int? MNFilterType
    {
        get;
        set;
    }

    [JsonProperty("m_OnFail")]
    [JsonPropertyName("m_OnFail")]
    public int? MOnFail
    {
        get;
        set;
    }

    [JsonProperty("m_OnPass")]
    [JsonPropertyName("m_OnPass")]
    public int? MOnPass
    {
        get;
        set;
    }

    [JsonProperty("m_bNegated")]
    [JsonPropertyName("m_bNegated")]
    public int? MBNegated
    {
        get;
        set;
    }

    [JsonProperty("m_iFilterTeam")]
    [JsonPropertyName("m_iFilterTeam")]
    public int? MIFilterTeam
    {
        get;
        set;
    }

    [JsonProperty("m_angAbsRotation")]
    [JsonPropertyName("m_angAbsRotation")]
    public int? MAngAbsRotation
    {
        get;
        set;
    }

    [JsonProperty("m_angRotation")]
    [JsonPropertyName("m_angRotation")]
    public int? MAngRotation
    {
        get;
        set;
    }

    [JsonProperty("m_angWrappedLocalRotation")]
    [JsonPropertyName("m_angWrappedLocalRotation")]
    public int? MAngWrappedLocalRotation
    {
        get;
        set;
    }

    [JsonProperty("m_bBoneMergeFlex")]
    [JsonPropertyName("m_bBoneMergeFlex")]
    public int? MBBoneMergeFlex
    {
        get;
        set;
    }

    [JsonProperty("m_bDebugAbsOriginChanges")]
    [JsonPropertyName("m_bDebugAbsOriginChanges")]
    public int? MBDebugAbsOriginChanges
    {
        get;
        set;
    }

    [JsonProperty("m_bDirtyBoneMergeBoneToRoot")]
    [JsonPropertyName("m_bDirtyBoneMergeBoneToRoot")]
    public int? MBDirtyBoneMergeBoneToRoot
    {
        get;
        set;
    }

    [JsonProperty("m_bDirtyBoneMergeInfo")]
    [JsonPropertyName("m_bDirtyBoneMergeInfo")]
    public int? MBDirtyBoneMergeInfo
    {
        get;
        set;
    }

    [JsonProperty("m_bDirtyHierarchy")]
    [JsonPropertyName("m_bDirtyHierarchy")]
    public int? MBDirtyHierarchy
    {
        get;
        set;
    }

    [JsonProperty("m_bDormant")]
    [JsonPropertyName("m_bDormant")]
    public int? MBDormant
    {
        get;
        set;
    }

    [JsonProperty("m_bForceParentToBeNetworked")]
    [JsonPropertyName("m_bForceParentToBeNetworked")]
    public int? MBForceParentToBeNetworked
    {
        get;
        set;
    }

    [JsonProperty("m_bNetworkedAnglesChanged")]
    [JsonPropertyName("m_bNetworkedAnglesChanged")]
    public int? MBNetworkedAnglesChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bNetworkedPositionChanged")]
    [JsonPropertyName("m_bNetworkedPositionChanged")]
    public int? MBNetworkedPositionChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bNetworkedScaleChanged")]
    [JsonPropertyName("m_bNetworkedScaleChanged")]
    public int? MBNetworkedScaleChanged
    {
        get;
        set;
    }

    [JsonProperty("m_bWillBeCallingPostDataUpdate")]
    [JsonPropertyName("m_bWillBeCallingPostDataUpdate")]
    public int? MBWillBeCallingPostDataUpdate
    {
        get;
        set;
    }

    [JsonProperty("m_flAbsScale")]
    [JsonPropertyName("m_flAbsScale")]
    public int? MFlAbsScale
    {
        get;
        set;
    }

    [JsonProperty("m_flClientLocalScale")]
    [JsonPropertyName("m_flClientLocalScale")]
    public int? MFlClientLocalScale
    {
        get;
        set;
    }

    [JsonProperty("m_flWrappedScale")]
    [JsonPropertyName("m_flWrappedScale")]
    public int? MFlWrappedScale
    {
        get;
        set;
    }

    [JsonProperty("m_flZOffset")]
    [JsonPropertyName("m_flZOffset")]
    public int? MFlZOffset
    {
        get;
        set;
    }

    [JsonProperty("m_hParent")]
    [JsonPropertyName("m_hParent")]
    public int? MHParent
    {
        get;
        set;
    }

    [JsonProperty("m_hierarchyAttachName")]
    [JsonPropertyName("m_hierarchyAttachName")]
    public int? MHierarchyAttachName
    {
        get;
        set;
    }

    [JsonProperty("m_nDoNotSetAnimTimeInInvalidatePhysicsCount")]
    [JsonPropertyName("m_nDoNotSetAnimTimeInInvalidatePhysicsCount")]
    public int? MNDoNotSetAnimTimeInInvalidatePhysicsCount
    {
        get;
        set;
    }

    [JsonProperty("m_nHierarchicalDepth")]
    [JsonPropertyName("m_nHierarchicalDepth")]
    public int? MNHierarchicalDepth
    {
        get;
        set;
    }

    [JsonProperty("m_nHierarchyType")]
    [JsonPropertyName("m_nHierarchyType")]
    public int? MNHierarchyType
    {
        get;
        set;
    }

    [JsonProperty("m_nLatchAbsOrigin")]
    [JsonPropertyName("m_nLatchAbsOrigin")]
    public int? MNLatchAbsOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_nParentAttachmentOrBone")]
    [JsonPropertyName("m_nParentAttachmentOrBone")]
    public int? MNParentAttachmentOrBone
    {
        get;
        set;
    }

    [JsonProperty("m_nodeToWorld")]
    [JsonPropertyName("m_nodeToWorld")]
    public int? MNodeToWorld
    {
        get;
        set;
    }

    [JsonProperty("m_pChild")]
    [JsonPropertyName("m_pChild")]
    public int? MPChild
    {
        get;
        set;
    }

    [JsonProperty("m_pNextSibling")]
    [JsonPropertyName("m_pNextSibling")]
    public int? MPNextSibling
    {
        get;
        set;
    }

    [JsonProperty("m_pOwner")]
    [JsonPropertyName("m_pOwner")]
    public int? MPOwner
    {
        get;
        set;
    }

    [JsonProperty("m_pParent")]
    [JsonPropertyName("m_pParent")]
    public int? MPParent
    {
        get;
        set;
    }

    [JsonProperty("m_vRenderOrigin")]
    [JsonPropertyName("m_vRenderOrigin")]
    public int? MVRenderOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecAbsOrigin")]
    [JsonPropertyName("m_vecAbsOrigin")]
    public int? MVecAbsOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_vecWrappedLocalOrigin")]
    [JsonPropertyName("m_vecWrappedLocalOrigin")]
    public int? MVecWrappedLocalOrigin
    {
        get;
        set;
    }

    [JsonProperty("m_bEligibleForScreenHighlight")]
    [JsonPropertyName("m_bEligibleForScreenHighlight")]
    public int? MBEligibleForScreenHighlight
    {
        get;
        set;
    }

    [JsonProperty("m_bFlashing")]
    [JsonPropertyName("m_bFlashing")]
    public int? MBFlashing
    {
        get;
        set;
    }

    [JsonProperty("m_bGlowing")]
    [JsonPropertyName("m_bGlowing")]
    public int? MBGlowing
    {
        get;
        set;
    }

    [JsonProperty("m_fGlowColor")]
    [JsonPropertyName("m_fGlowColor")]
    public int? MFGlowColor
    {
        get;
        set;
    }

    [JsonProperty("m_flGlowStartTime")]
    [JsonPropertyName("m_flGlowStartTime")]
    public int? MFlGlowStartTime
    {
        get;
        set;
    }

    [JsonProperty("m_flGlowTime")]
    [JsonPropertyName("m_flGlowTime")]
    public int? MFlGlowTime
    {
        get;
        set;
    }

    [JsonProperty("m_glowColorOverride")]
    [JsonPropertyName("m_glowColorOverride")]
    public int? MGlowColorOverride
    {
        get;
        set;
    }

    [JsonProperty("m_iGlowTeam")]
    [JsonPropertyName("m_iGlowTeam")]
    public int? MIGlowTeam
    {
        get;
        set;
    }

    [JsonProperty("m_iGlowType")]
    [JsonPropertyName("m_iGlowType")]
    public int? MIGlowType
    {
        get;
        set;
    }

    [JsonProperty("m_flTracerDuration")]
    [JsonPropertyName("m_flTracerDuration")]
    public int? MFlTracerDuration
    {
        get;
        set;
    }

    [JsonProperty("m_nType")]
    [JsonPropertyName("m_nType")]
    public int? MNType
    {
        get;
        set;
    }

    [JsonProperty("m_flBoundsExpandRadius")]
    [JsonPropertyName("m_flBoundsExpandRadius")]
    public int? MFlBoundsExpandRadius
    {
        get;
        set;
    }

    [JsonProperty("m_CommandContext")]
    [JsonPropertyName("m_CommandContext")]
    public int? MCommandContext
    {
        get;
        set;
    }

    [JsonProperty("m_bIsHLTV")]
    [JsonPropertyName("m_bIsHLTV")]
    public int? MBIsHLTV
    {
        get;
        set;
    }

    [JsonProperty("m_bIsLocalPlayerController")]
    [JsonPropertyName("m_bIsLocalPlayerController")]
    public int? MBIsLocalPlayerController
    {
        get;
        set;
    }

    [JsonProperty("m_bKnownTeamMismatch")]
    [JsonPropertyName("m_bKnownTeamMismatch")]
    public int? MBKnownTeamMismatch
    {
        get;
        set;
    }

    [JsonProperty("m_bNoClipEnabled")]
    [JsonPropertyName("m_bNoClipEnabled")]
    public int? MBNoClipEnabled
    {
        get;
        set;
    }

    [JsonProperty("m_hPawn")]
    [JsonPropertyName("m_hPawn")]
    public int? MHPawn
    {
        get;
        set;
    }

    [JsonProperty("m_hPredictedPawn")]
    [JsonPropertyName("m_hPredictedPawn")]
    public int? MHPredictedPawn
    {
        get;
        set;
    }

    [JsonProperty("m_hSplitOwner")]
    [JsonPropertyName("m_hSplitOwner")]
    public int? MHSplitOwner
    {
        get;
        set;
    }

    [JsonProperty("m_hSplitScreenPlayers")]
    [JsonPropertyName("m_hSplitScreenPlayers")]
    public int? MHSplitScreenPlayers
    {
        get;
        set;
    }

    [JsonProperty("m_iConnected")]
    [JsonPropertyName("m_iConnected")]
    public int? MIConnected
    {
        get;
        set;
    }

    [JsonProperty("m_iDesiredFOV")]
    [JsonPropertyName("m_iDesiredFOV")]
    public int? MIDesiredFOV
    {
        get;
        set;
    }

    [JsonProperty("m_iszPlayerName")]
    [JsonPropertyName("m_iszPlayerName")]
    public int? MIszPlayerName
    {
        get;
        set;
    }

    [JsonProperty("m_nInButtonsWhichAreToggles")]
    [JsonPropertyName("m_nInButtonsWhichAreToggles")]
    public int? MNInButtonsWhichAreToggles
    {
        get;
        set;
    }

    [JsonProperty("m_nSplitScreenSlot")]
    [JsonPropertyName("m_nSplitScreenSlot")]
    public int? MNSplitScreenSlot
    {
        get;
        set;
    }

    [JsonProperty("m_nTickBase")]
    [JsonPropertyName("m_nTickBase")]
    public int? MNTickBase
    {
        get;
        set;
    }

    [JsonProperty("m_steamID")]
    [JsonPropertyName("m_steamID")]
    public int? MSteamID
    {
        get;
        set;
    }

    [JsonProperty("m_hLight")]
    [JsonPropertyName("m_hLight")]
    public int? MHLight
    {
        get;
        set;
    }

    [JsonProperty("m_nImportance")]
    [JsonPropertyName("m_nImportance")]
    public int? MNImportance
    {
        get;
        set;
    }

    [JsonProperty("m_nLightChoice")]
    [JsonPropertyName("m_nLightChoice")]
    public int? MNLightChoice
    {
        get;
        set;
    }

    [JsonProperty("m_FanForceCurveString")]
    [JsonPropertyName("m_FanForceCurveString")]
    public int? MFanForceCurveString
    {
        get;
        set;
    }

    [JsonProperty("m_fFanForceMaxRadius")]
    [JsonPropertyName("m_fFanForceMaxRadius")]
    public int? MFFanForceMaxRadius
    {
        get;
        set;
    }

    [JsonProperty("m_fFanForceMinRadius")]
    [JsonPropertyName("m_fFanForceMinRadius")]
    public int? MFFanForceMinRadius
    {
        get;
        set;
    }

    [JsonProperty("m_flCurveDistRange")]
    [JsonPropertyName("m_flCurveDistRange")]
    public int? MFlCurveDistRange
    {
        get;
        set;
    }

    [JsonProperty("m_RenderAttrName")]
    [JsonPropertyName("m_RenderAttrName")]
    public int? MRenderAttrName
    {
        get;
        set;
    }

    [JsonProperty("m_TargetEntities")]
    [JsonPropertyName("m_TargetEntities")]
    public int? MTargetEntities
    {
        get;
        set;
    }

    [JsonProperty("m_nResolutionX")]
    [JsonPropertyName("m_nResolutionX")]
    public int? MNResolutionX
    {
        get;
        set;
    }

    [JsonProperty("m_nResolutionY")]
    [JsonPropertyName("m_nResolutionY")]
    public int? MNResolutionY
    {
        get;
        set;
    }

    [JsonProperty("m_nTargetChangeCount")]
    [JsonPropertyName("m_nTargetChangeCount")]
    public int? MNTargetChangeCount
    {
        get;
        set;
    }

    [JsonProperty("m_szLayoutFileName")]
    [JsonPropertyName("m_szLayoutFileName")]
    public int? MSzLayoutFileName
    {
        get;
        set;
    }

    [JsonProperty("m_bCreateAsChildSpawnGroup")]
    [JsonPropertyName("m_bCreateAsChildSpawnGroup")]
    public int? MBCreateAsChildSpawnGroup
    {
        get;
        set;
    }

    [JsonProperty("m_bEntitiesSpawned")]
    [JsonPropertyName("m_bEntitiesSpawned")]
    public int? MBEntitiesSpawned
    {
        get;
        set;
    }

    [JsonProperty("m_bWorldLayerActuallyVisible")]
    [JsonPropertyName("m_bWorldLayerActuallyVisible")]
    public int? MBWorldLayerActuallyVisible
    {
        get;
        set;
    }

    [JsonProperty("m_bWorldLayerVisible")]
    [JsonPropertyName("m_bWorldLayerVisible")]
    public int? MBWorldLayerVisible
    {
        get;
        set;
    }

    [JsonProperty("m_hLayerSpawnGroup")]
    [JsonPropertyName("m_hLayerSpawnGroup")]
    public int? MHLayerSpawnGroup
    {
        get;
        set;
    }

    [JsonProperty("m_layerName")]
    [JsonPropertyName("m_layerName")]
    public int? MLayerName
    {
        get;
        set;
    }

    [JsonProperty("m_pOutputOnEntitiesSpawned")]
    [JsonPropertyName("m_pOutputOnEntitiesSpawned")]
    public int? MPOutputOnEntitiesSpawned
    {
        get;
        set;
    }

    [JsonProperty("m_worldName")]
    [JsonPropertyName("m_worldName")]
    public int? MWorldName
    {
        get;
        set;
    }

    [JsonProperty("m_Pattern")]
    [JsonPropertyName("m_Pattern")]
    public int? MPattern
    {
        get;
        set;
    }

    [JsonProperty("m_SecondaryColor")]
    [JsonPropertyName("m_SecondaryColor")]
    public int? MSecondaryColor
    {
        get;
        set;
    }

    [JsonProperty("m_SkyAmbientBounce")]
    [JsonPropertyName("m_SkyAmbientBounce")]
    public int? MSkyAmbientBounce
    {
        get;
        set;
    }

    [JsonProperty("m_SkyColor")]
    [JsonPropertyName("m_SkyColor")]
    public int? MSkyColor
    {
        get;
        set;
    }

    [JsonProperty("m_bAllowSSTGeneration")]
    [JsonPropertyName("m_bAllowSSTGeneration")]
    public int? MBAllowSSTGeneration
    {
        get;
        set;
    }

    [JsonProperty("m_bFlicker")]
    [JsonPropertyName("m_bFlicker")]
    public int? MBFlicker
    {
        get;
        set;
    }

    [JsonProperty("m_bMixedShadows")]
    [JsonPropertyName("m_bMixedShadows")]
    public int? MBMixedShadows
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderDiffuse")]
    [JsonPropertyName("m_bRenderDiffuse")]
    public int? MBRenderDiffuse
    {
        get;
        set;
    }

    [JsonProperty("m_bRenderTransmissive")]
    [JsonPropertyName("m_bRenderTransmissive")]
    public int? MBRenderTransmissive
    {
        get;
        set;
    }

    [JsonProperty("m_bUseSecondaryColor")]
    [JsonPropertyName("m_bUseSecondaryColor")]
    public int? MBUseSecondaryColor
    {
        get;
        set;
    }

    [JsonProperty("m_bUsesBakedShadowing")]
    [JsonPropertyName("m_bUsesBakedShadowing")]
    public int? MBUsesBakedShadowing
    {
        get;
        set;
    }

    [JsonProperty("m_flAttenuation0")]
    [JsonPropertyName("m_flAttenuation0")]
    public int? MFlAttenuation0
    {
        get;
        set;
    }

    [JsonProperty("m_flAttenuation1")]
    [JsonPropertyName("m_flAttenuation1")]
    public int? MFlAttenuation1
    {
        get;
        set;
    }

    [JsonProperty("m_flAttenuation2")]
    [JsonPropertyName("m_flAttenuation2")]
    public int? MFlAttenuation2
    {
        get;
        set;
    }

    [JsonProperty("m_flBrightnessMult")]
    [JsonPropertyName("m_flBrightnessMult")]
    public int? MFlBrightnessMult
    {
        get;
        set;
    }

    [JsonProperty("m_flCapsuleLength")]
    [JsonPropertyName("m_flCapsuleLength")]
    public int? MFlCapsuleLength
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeMaxDist")]
    [JsonPropertyName("m_flFadeMaxDist")]
    public int? MFlFadeMaxDist
    {
        get;
        set;
    }

    [JsonProperty("m_flFadeMinDist")]
    [JsonPropertyName("m_flFadeMinDist")]
    public int? MFlFadeMinDist
    {
        get;
        set;
    }

    [JsonProperty("m_flFalloff")]
    [JsonPropertyName("m_flFalloff")]
    public int? MFlFalloff
    {
        get;
        set;
    }

    [JsonProperty("m_flFogContributionStength")]
    [JsonPropertyName("m_flFogContributionStength")]
    public int? MFlFogContributionStength
    {
        get;
        set;
    }

    [JsonProperty("m_flNearClipPlane")]
    [JsonPropertyName("m_flNearClipPlane")]
    public int? MFlNearClipPlane
    {
        get;
        set;
    }

    [JsonProperty("m_flOrthoLightHeight")]
    [JsonPropertyName("m_flOrthoLightHeight")]
    public int? MFlOrthoLightHeight
    {
        get;
        set;
    }

    [JsonProperty("m_flOrthoLightWidth")]
    [JsonPropertyName("m_flOrthoLightWidth")]
    public int? MFlOrthoLightWidth
    {
        get;
        set;
    }

    [JsonProperty("m_flPhi")]
    [JsonPropertyName("m_flPhi")]
    public int? MFlPhi
    {
        get;
        set;
    }

    [JsonProperty("m_flPrecomputedMaxRange")]
    [JsonPropertyName("m_flPrecomputedMaxRange")]
    public int? MFlPrecomputedMaxRange
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowCascadeCrossFade")]
    [JsonPropertyName("m_flShadowCascadeCrossFade")]
    public int? MFlShadowCascadeCrossFade
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowCascadeDistance0")]
    [JsonPropertyName("m_flShadowCascadeDistance0")]
    public int? MFlShadowCascadeDistance0
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowCascadeDistance1")]
    [JsonPropertyName("m_flShadowCascadeDistance1")]
    public int? MFlShadowCascadeDistance1
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowCascadeDistance2")]
    [JsonPropertyName("m_flShadowCascadeDistance2")]
    public int? MFlShadowCascadeDistance2
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowCascadeDistance3")]
    [JsonPropertyName("m_flShadowCascadeDistance3")]
    public int? MFlShadowCascadeDistance3
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowCascadeDistanceFade")]
    [JsonPropertyName("m_flShadowCascadeDistanceFade")]
    public int? MFlShadowCascadeDistanceFade
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowFadeMaxDist")]
    [JsonPropertyName("m_flShadowFadeMaxDist")]
    public int? MFlShadowFadeMaxDist
    {
        get;
        set;
    }

    [JsonProperty("m_flShadowFadeMinDist")]
    [JsonPropertyName("m_flShadowFadeMinDist")]
    public int? MFlShadowFadeMinDist
    {
        get;
        set;
    }

    [JsonProperty("m_flSkyIntensity")]
    [JsonPropertyName("m_flSkyIntensity")]
    public int? MFlSkyIntensity
    {
        get;
        set;
    }

    [JsonProperty("m_flTheta")]
    [JsonPropertyName("m_flTheta")]
    public int? MFlTheta
    {
        get;
        set;
    }

    [JsonProperty("m_nCascadeRenderStaticObjects")]
    [JsonPropertyName("m_nCascadeRenderStaticObjects")]
    public int? MNCascadeRenderStaticObjects
    {
        get;
        set;
    }

    [JsonProperty("m_nCascades")]
    [JsonPropertyName("m_nCascades")]
    public int? MNCascades
    {
        get;
        set;
    }

    [JsonProperty("m_nFogLightingMode")]
    [JsonPropertyName("m_nFogLightingMode")]
    public int? MNFogLightingMode
    {
        get;
        set;
    }

    [JsonProperty("m_nIndirectLight")]
    [JsonPropertyName("m_nIndirectLight")]
    public int? MNIndirectLight
    {
        get;
        set;
    }

    [JsonProperty("m_nRenderSpecular")]
    [JsonPropertyName("m_nRenderSpecular")]
    public int? MNRenderSpecular
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowCascadeResolution0")]
    [JsonPropertyName("m_nShadowCascadeResolution0")]
    public int? MNShadowCascadeResolution0
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowCascadeResolution1")]
    [JsonPropertyName("m_nShadowCascadeResolution1")]
    public int? MNShadowCascadeResolution1
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowCascadeResolution2")]
    [JsonPropertyName("m_nShadowCascadeResolution2")]
    public int? MNShadowCascadeResolution2
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowCascadeResolution3")]
    [JsonPropertyName("m_nShadowCascadeResolution3")]
    public int? MNShadowCascadeResolution3
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowHeight")]
    [JsonPropertyName("m_nShadowHeight")]
    public int? MNShadowHeight
    {
        get;
        set;
    }

    [JsonProperty("m_nShadowWidth")]
    [JsonPropertyName("m_nShadowWidth")]
    public int? MNShadowWidth
    {
        get;
        set;
    }

    [JsonProperty("m_nStyle")]
    [JsonPropertyName("m_nStyle")]
    public int? MNStyle
    {
        get;
        set;
    }

    [JsonProperty("m_bFastRetrigger")]
    [JsonPropertyName("m_bFastRetrigger")]
    public int? MBFastRetrigger
    {
        get;
        set;
    }

    [JsonProperty("m_bPassthoughCaller")]
    [JsonPropertyName("m_bPassthoughCaller")]
    public int? MBPassthoughCaller
    {
        get;
        set;
    }

    [JsonProperty("m_bTriggerOnce")]
    [JsonPropertyName("m_bTriggerOnce")]
    public int? MBTriggerOnce
    {
        get;
        set;
    }

    [JsonProperty("m_bWaitForRefire")]
    [JsonPropertyName("m_bWaitForRefire")]
    public int? MBWaitForRefire
    {
        get;
        set;
    }
}

public class FilterDamageType
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class FilterHealth
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class FogparamsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class IntervalTimer
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class InventoryNodeTypeT
{
    [JsonProperty("alignment")]
    [JsonPropertyName("alignment")]
    public int? Alignment
    {
        get;
        set;
    }

    [JsonProperty("members")]
    [JsonPropertyName("members")]
    public Members Members
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }
}

public class Members
{
    [JsonProperty("COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_EXISTS")]
    [JsonPropertyName("COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_EXISTS")]
    public int? COMPMATMUTATORCONDITIONINPUTCONTAINEREXISTS
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EQUALS")]
    [JsonPropertyName("COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EQUALS")]
    public int? COMPMATMUTATORCONDITIONINPUTCONTAINERVALUEEQUALS
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EXISTS")]
    [JsonPropertyName("COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EXISTS")]
    public int? COMPMATMUTATORCONDITIONINPUTCONTAINERVALUEEXISTS
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_CONDITIONAL_MUTATORS")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_CONDITIONAL_MUTATORS")]
    public int? COMPMATPROPERTYMUTATORCONDITIONALMUTATORS
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_COPY_KEYS_WITH_SUFFIX")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_COPY_KEYS_WITH_SUFFIX")]
    public int? COMPMATPROPERTYMUTATORCOPYKEYSWITHSUFFIX
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_COPY_MATCHING_KEYS")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_COPY_MATCHING_KEYS")]
    public int? COMPMATPROPERTYMUTATORCOPYMATCHINGKEYS
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_COPY_PROPERTY")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_COPY_PROPERTY")]
    public int? COMPMATPROPERTYMUTATORCOPYPROPERTY
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_DRAW_TEXT")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_DRAW_TEXT")]
    public int? COMPMATPROPERTYMUTATORDRAWTEXT
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_GENERATE_TEXTURE")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_GENERATE_TEXTURE")]
    public int? COMPMATPROPERTYMUTATORGENERATETEXTURE
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_INIT")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_INIT")]
    public int? COMPMATPROPERTYMUTATORINIT
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_POP_INPUT_QUEUE")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_POP_INPUT_QUEUE")]
    public int? COMPMATPROPERTYMUTATORPOPINPUTQUEUE
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_RANDOM_ROLL_INPUT_VARIABLES")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_RANDOM_ROLL_INPUT_VARIABLES")]
    public int? COMPMATPROPERTYMUTATORRANDOMROLLINPUTVARIABLES
    {
        get;
        set;
    }

    [JsonProperty("COMP_MAT_PROPERTY_MUTATOR_SET_VALUE")]
    [JsonPropertyName("COMP_MAT_PROPERTY_MUTATOR_SET_VALUE")]
    public int? COMPMATPROPERTYMUTATORSETVALUE
    {
        get;
        set;
    }

    [JsonProperty("CONTAINER_SOURCE_TYPE_LOOSE_VARIABLES")]
    [JsonPropertyName("CONTAINER_SOURCE_TYPE_LOOSE_VARIABLES")]
    public int? CONTAINERSOURCETYPELOOSEVARIABLES
    {
        get;
        set;
    }

    [JsonProperty("CONTAINER_SOURCE_TYPE_MATERIAL_FROM_TARGET_ATTR")]
    [JsonPropertyName("CONTAINER_SOURCE_TYPE_MATERIAL_FROM_TARGET_ATTR")]
    public int? CONTAINERSOURCETYPEMATERIALFROMTARGETATTR
    {
        get;
        set;
    }

    [JsonProperty("CONTAINER_SOURCE_TYPE_SPECIFIC_MATERIAL")]
    [JsonPropertyName("CONTAINER_SOURCE_TYPE_SPECIFIC_MATERIAL")]
    public int? CONTAINERSOURCETYPESPECIFICMATERIAL
    {
        get;
        set;
    }

    [JsonProperty("CONTAINER_SOURCE_TYPE_TARGET_INSTANCE_MATERIAL")]
    [JsonPropertyName("CONTAINER_SOURCE_TYPE_TARGET_INSTANCE_MATERIAL")]
    public int? CONTAINERSOURCETYPETARGETINSTANCEMATERIAL
    {
        get;
        set;
    }

    [JsonProperty("CONTAINER_SOURCE_TYPE_TARGET_MATERIAL")]
    [JsonPropertyName("CONTAINER_SOURCE_TYPE_TARGET_MATERIAL")]
    public int? CONTAINERSOURCETYPETARGETMATERIAL
    {
        get;
        set;
    }

    [JsonProperty("CONTAINER_SOURCE_TYPE_VARIABLE_FROM_TARGET_ATTR")]
    [JsonPropertyName("CONTAINER_SOURCE_TYPE_VARIABLE_FROM_TARGET_ATTR")]
    public int? CONTAINERSOURCETYPEVARIABLEFROMTARGETATTR
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_BOOLEAN")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_BOOLEAN")]
    public int? LOOSEVARIABLETYPEBOOLEAN
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_COLOR4")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_COLOR4")]
    public int? LOOSEVARIABLETYPECOLOR4
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_FLOAT1")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_FLOAT1")]
    public int? LOOSEVARIABLETYPEFLOAT1
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_FLOAT2")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_FLOAT2")]
    public int? LOOSEVARIABLETYPEFLOAT2
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_FLOAT3")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_FLOAT3")]
    public int? LOOSEVARIABLETYPEFLOAT3
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_FLOAT4")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_FLOAT4")]
    public int? LOOSEVARIABLETYPEFLOAT4
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_INTEGER1")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_INTEGER1")]
    public int? LOOSEVARIABLETYPEINTEGER1
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_INTEGER2")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_INTEGER2")]
    public int? LOOSEVARIABLETYPEINTEGER2
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_INTEGER3")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_INTEGER3")]
    public int? LOOSEVARIABLETYPEINTEGER3
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_INTEGER4")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_INTEGER4")]
    public int? LOOSEVARIABLETYPEINTEGER4
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_PANORAMA_RENDER")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_PANORAMA_RENDER")]
    public int? LOOSEVARIABLETYPEPANORAMARENDER
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_RESOURCE_MATERIAL")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_RESOURCE_MATERIAL")]
    public int? LOOSEVARIABLETYPERESOURCEMATERIAL
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_RESOURCE_TEXTURE")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_RESOURCE_TEXTURE")]
    public int? LOOSEVARIABLETYPERESOURCETEXTURE
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_STRING")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_STRING")]
    public int? LOOSEVARIABLETYPESTRING
    {
        get;
        set;
    }

    [JsonProperty("LOOSE_VARIABLE_TYPE_SYSTEMVAR")]
    [JsonPropertyName("LOOSE_VARIABLE_TYPE_SYSTEMVAR")]
    public int? LOOSEVARIABLETYPESYSTEMVAR
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_AO")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_AO")]
    public int? INPUTTEXTURETYPEAO
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_COLOR")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_COLOR")]
    public int? INPUTTEXTURETYPECOLOR
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_DEFAULT")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_DEFAULT")]
    public int? INPUTTEXTURETYPEDEFAULT
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_MASKS")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_MASKS")]
    public int? INPUTTEXTURETYPEMASKS
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_NORMALMAP")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_NORMALMAP")]
    public int? INPUTTEXTURETYPENORMALMAP
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_PEARLESCENCE_MASK")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_PEARLESCENCE_MASK")]
    public int? INPUTTEXTURETYPEPEARLESCENCEMASK
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_POSITION")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_POSITION")]
    public int? INPUTTEXTURETYPEPOSITION
    {
        get;
        set;
    }

    [JsonProperty("INPUT_TEXTURE_TYPE_ROUGHNESS")]
    [JsonPropertyName("INPUT_TEXTURE_TYPE_ROUGHNESS")]
    public int? INPUTTEXTURETYPEROUGHNESS
    {
        get;
        set;
    }

    [JsonProperty("MATCH_FILTER_MATERIAL_ATTRIBUTE_EQUALS")]
    [JsonPropertyName("MATCH_FILTER_MATERIAL_ATTRIBUTE_EQUALS")]
    public int? MATCHFILTERMATERIALATTRIBUTEEQUALS
    {
        get;
        set;
    }

    [JsonProperty("MATCH_FILTER_MATERIAL_ATTRIBUTE_EXISTS")]
    [JsonPropertyName("MATCH_FILTER_MATERIAL_ATTRIBUTE_EXISTS")]
    public int? MATCHFILTERMATERIALATTRIBUTEEXISTS
    {
        get;
        set;
    }

    [JsonProperty("MATCH_FILTER_MATERIAL_NAME_SUBSTR")]
    [JsonPropertyName("MATCH_FILTER_MATERIAL_NAME_SUBSTR")]
    public int? MATCHFILTERMATERIALNAMESUBSTR
    {
        get;
        set;
    }

    [JsonProperty("MATCH_FILTER_MATERIAL_PROPERTY_EQUALS")]
    [JsonPropertyName("MATCH_FILTER_MATERIAL_PROPERTY_EQUALS")]
    public int? MATCHFILTERMATERIALPROPERTYEQUALS
    {
        get;
        set;
    }

    [JsonProperty("MATCH_FILTER_MATERIAL_PROPERTY_EXISTS")]
    [JsonPropertyName("MATCH_FILTER_MATERIAL_PROPERTY_EXISTS")]
    public int? MATCHFILTERMATERIALPROPERTYEXISTS
    {
        get;
        set;
    }

    [JsonProperty("MATCH_FILTER_MATERIAL_SHADER")]
    [JsonPropertyName("MATCH_FILTER_MATERIAL_SHADER")]
    public int? MATCHFILTERMATERIALSHADER
    {
        get;
        set;
    }

    [JsonProperty("COMPMATSYSVAR_COMPOSITETIME")]
    [JsonPropertyName("COMPMATSYSVAR_COMPOSITETIME")]
    public int? COMPMATSYSVARCOMPOSITETIME
    {
        get;
        set;
    }

    [JsonProperty("COMPMATSYSVAR_EMPTY_RESOURCE_SPACER")]
    [JsonPropertyName("COMPMATSYSVAR_EMPTY_RESOURCE_SPACER")]
    public int? COMPMATSYSVAREMPTYRESOURCESPACER
    {
        get;
        set;
    }

    [JsonProperty("CONCRETE_NODE_SCHEMA_ITEMDEF")]
    [JsonPropertyName("CONCRETE_NODE_SCHEMA_ITEMDEF")]
    public int? CONCRETENODESCHEMAITEMDEF
    {
        get;
        set;
    }

    [JsonProperty("CONCRETE_NODE_SCHEMA_KEYCHAIN")]
    [JsonPropertyName("CONCRETE_NODE_SCHEMA_KEYCHAIN")]
    public int? CONCRETENODESCHEMAKEYCHAIN
    {
        get;
        set;
    }

    [JsonProperty("CONCRETE_NODE_SCHEMA_PREFAB")]
    [JsonPropertyName("CONCRETE_NODE_SCHEMA_PREFAB")]
    public int? CONCRETENODESCHEMAPREFAB
    {
        get;
        set;
    }

    [JsonProperty("CONCRETE_NODE_SCHEMA_STICKER")]
    [JsonPropertyName("CONCRETE_NODE_SCHEMA_STICKER")]
    public int? CONCRETENODESCHEMASTICKER
    {
        get;
        set;
    }

    [JsonProperty("NODE_TYPE_INVALID")]
    [JsonPropertyName("NODE_TYPE_INVALID")]
    public int? NODETYPEINVALID
    {
        get;
        set;
    }

    [JsonProperty("VIRTUAL_NODE_SCHEMA_ITEMDEF")]
    [JsonPropertyName("VIRTUAL_NODE_SCHEMA_ITEMDEF")]
    public int? VIRTUALNODESCHEMAITEMDEF
    {
        get;
        set;
    }

    [JsonProperty("VIRTUAL_NODE_SCHEMA_KEYCHAIN")]
    [JsonPropertyName("VIRTUAL_NODE_SCHEMA_KEYCHAIN")]
    public int? VIRTUALNODESCHEMAKEYCHAIN
    {
        get;
        set;
    }

    [JsonProperty("VIRTUAL_NODE_SCHEMA_PREFAB")]
    [JsonPropertyName("VIRTUAL_NODE_SCHEMA_PREFAB")]
    public int? VIRTUALNODESCHEMAPREFAB
    {
        get;
        set;
    }

    [JsonProperty("VIRTUAL_NODE_SCHEMA_STICKER")]
    [JsonPropertyName("VIRTUAL_NODE_SCHEMA_STICKER")]
    public int? VIRTUALNODESCHEMASTICKER
    {
        get;
        set;
    }
}

public class Metadata
{
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name
    {
        get;
        set;
    }

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type
    {
        get;
        set;
    }

    [JsonProperty("type_name")]
    [JsonPropertyName("type_name")]
    public string TypeName
    {
        get;
        set;
    }
}

public class OutflowWithRequirementsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class PhysicsRagdollPoseT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class PredictedDamageTagT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class PulseNodeDynamicOutflowsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class PulseNodeDynamicOutflowsTDynamicOutflowT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class PulseObservableBoolExpressionT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class PulseSelectorOutflowListT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class Root
{
    [JsonProperty("client.dll")]
    [JsonPropertyName("client.dll")]
    public ClientDll ClientDll
    {
        get;
        set;
    }
}

public class SellbackPurchaseEntryT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class SequenceHistoryT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class ShardModelDescT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class SignatureOutflowContinue
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class SignatureOutflowResume
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public object Parent
    {
        get;
        set;
    }
}

public class Sky3dparamsT
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<Metadata> Metadata
    {
        get;
        set;
    }

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string Parent
    {
        get;
        set;
    }
}

public class ViewAngleServerChangeT: ClientDllDtoBase
{

}

public class VPhysicsCollisionAttributeT : ClientDllDtoBase
{

}

public class WeaponPurchaseCountT : ClientDllDtoBase
{

}

public class WeaponPurchaseTrackerT : ClientDllDtoBase
{

}
