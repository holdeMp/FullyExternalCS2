namespace CS2Cheat.Core;

using System.Runtime.InteropServices;

public abstract partial class Kernel32
{
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
        out IntPtr lpBuffer, int dwSize, out int lpNumberOfBytesRead);
}
