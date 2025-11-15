namespace CS2Cheat.Utils;

using System.Diagnostics;

public class Module(Process process, ProcessModule processModule) : IDisposable
{
    public void Dispose()
    {
        Process.Dispose();
        Process = null;

        ProcessModule.Dispose();
        ProcessModule = null;
    }

    public Process Process
    {
        get;
        private set;
    } = process;

    public ProcessModule ProcessModule
    {
        get;
        private set;
    } = processModule;
}
