using Keys = Process.NET.Native.Types.Keys;

namespace CS2Cheat.Utils;

using System.Text.Json;

public class ConfigManager
{
    private const string ConfigFile = "config.json";
    private static JsonSerializerOptions _jsonWriteIndentedSerializerOptions;
    private static JsonSerializerOptions _jsonCaseInsensitiveSerializerOptions;

    public bool AimBot
    {
        get;
        set;
    }

    public bool BombTimer
    {
        get;
        set;
    }

    public bool EspAimCrosshair
    {
        get;
        set;
    }

    public bool EspBox
    {
        get;
        set;
    }

    public bool SkeletonEsp
    {
        get;
        set;
    }

    public bool TriggerBot
    {
        get;
        set;
    }

    public Keys AimBotKey
    {
        get;
        set;
    }

    public Keys TriggerBotKey
    {
        get;
        set;
    }

    public bool TeamCheck
    {
        get;
        set;
    }


    public static ConfigManager Load()
    {
        try
        {
            if (!File.Exists(ConfigFile))
            {
                var defaultOptions = Default();
                Save(defaultOptions);
                return defaultOptions;
            }

            var json = File.ReadAllText(ConfigFile);
            _jsonCaseInsensitiveSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var options = JsonSerializer.Deserialize<ConfigManager>(json, _jsonCaseInsensitiveSerializerOptions);
            return options ?? Default();
        }
        catch (JsonException)
        {
            return Default();
        }
    }

    public static void Save(ConfigManager options)
    {
        try
        {
            _jsonWriteIndentedSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(options, _jsonWriteIndentedSerializerOptions);
            File.WriteAllText(ConfigFile, json);
        }
        catch (JsonException)
        {
            // Handle serialization errors
        }
    }

    public static ConfigManager Default() =>
        new()
        {
            AimBot = true,
            BombTimer = true,
            EspAimCrosshair = false,
            EspBox = true,
            SkeletonEsp = false,
            TriggerBot = true,
            AimBotKey =
                Keys.LButton, // https://github.com/lolp1/Process.NET/blob/ce9ac9cceb2afb30c9288495615c6f3aa34bc1f8/src/Process.NET/Native/Types/NativeEnums.cs#L235
            TriggerBotKey = Keys.LMenu,
            TeamCheck = true
        };
}
