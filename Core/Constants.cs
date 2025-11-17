namespace CS2Cheat.Core;

using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible")]
public static class Constants
{
    [SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible")]
    public static Uri ClientDllUri =
        new("https://raw.githubusercontent.com/a2x/cs2-dumper/main/output/client_dll.json");

    public static Uri OffsetsDllUri = new("https://raw.githubusercontent.com/a2x/cs2-dumper/main/output/offsets.json");
}
