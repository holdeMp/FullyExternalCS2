namespace CS2Cheat.Data.Game;

using System.Diagnostics;
using System.Drawing;
using Core;
using Microsoft.Extensions.Hosting;
using Utils;

public sealed class GameProcess : BackgroundService
{
    private const string NameProcess = "cs2";

    private const string NameModule = "client.dll";

    private const string NameWindow = "Counter-Strike 2";


    private TimeSpan ThreadFrameSleep
    {
        get;
    } = new(0, 0, 0, 0, 500);

    public Process? Process
    {
        get;
        private set;
    }

    public Module? ModuleClient
    {
        get;
        private set;
    }

    private IntPtr WindowHwnd
    {
        get;
        set;
    }

    public Rectangle WindowRectangleClient
    {
        get;
        private set;
    }

    private bool WindowActive
    {
        get;
        set;
    }

    public bool IsValid => WindowActive;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                if (!EnsureProcessAndModules())
                {
                    InvalidateModules();
                }

                if (!EnsureWindow())
                {
                    InvalidateWindow();
                }

                await Task.Delay(ThreadFrameSleep, stoppingToken);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public override void Dispose()
    {
        base.Dispose();
        InvalidateWindow();
        InvalidateModules();
    }

    private void InvalidateModules()
    {
        ModuleClient?.Dispose();
        ModuleClient = null;

        Process?.Dispose();
        Process = null;
    }

    private void InvalidateWindow()
    {
        WindowHwnd = IntPtr.Zero;
        WindowRectangleClient = Rectangle.Empty;
        WindowActive = false;
    }

    private bool EnsureProcessAndModules()
    {
        Process ??= Process.GetProcessesByName(NameProcess).FirstOrDefault();
        if (Process == null || Process.HasExited)
        {
            return false;
        }

        var processModule = Process.Modules
            .OfType<ProcessModule>()
            .FirstOrDefault(m => m.ModuleName.Equals(NameModule, StringComparison.OrdinalIgnoreCase));
        if (processModule != null)
        {
            ModuleClient = new Module(Process, processModule); // Pass both Process and ProcessModule as required
        }

        return ModuleClient != null;
    }


    private bool EnsureWindow()
    {
        WindowHwnd = User32.FindWindow(null!, NameWindow);
        if (WindowHwnd == IntPtr.Zero)
        {
            return false;
        }

        WindowRectangleClient = Utility.GetClientRectangle(WindowHwnd);
        if (WindowRectangleClient.Width <= 0 || WindowRectangleClient.Height <= 0)
        {
            return false;
        }

        WindowActive = WindowHwnd == User32.GetForegroundWindow();

        return WindowActive;
    }
}
