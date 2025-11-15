using System.Diagnostics;

namespace CS2Cheat.Utils;

public class FpsCounter
{
    public void Update()
    {
        var fpsTimerElapsed = FpsTimer.Elapsed;
        if (fpsTimerElapsed > _timeSpanFpsUpdate)
        {
            Fps = (int)(FpsFrameCount / fpsTimerElapsed.TotalSeconds);
            FpsTimer.Restart();
            FpsFrameCount = 0;
        }

        FpsFrameCount++;
    }

    private static readonly TimeSpan _timeSpanFpsUpdate = new(0, 0, 0, 1);


    private Stopwatch FpsTimer { get; } = Stopwatch.StartNew();


    private int FpsFrameCount
    {
        get; set;
    }


    public int Fps
    {
        get; private set;
    }
}
