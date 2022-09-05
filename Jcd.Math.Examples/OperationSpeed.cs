using System.Diagnostics;

namespace Jcd.Math.Examples;

public static class OperationSpeed
{
    // NOTE: Change this value to match your system so that the
    // CPU cycles per operation computes correctly.
    // No clue how to get this programmatically in .NET 6.
    private const double CpuFrequencyInGhz = 3.5;
    private const int KiloScaleFactor = 1000;
    private const int MegaScaleFactor = 1000 * KiloScaleFactor;
    private const int GigaScaleFactor = 1000 * MegaScaleFactor;
    private const double CpuFrequencyInHz = CpuFrequencyInGhz * GigaScaleFactor;
    private const double SecondsPerCycle = 1.0 / CpuFrequencyInHz;
    private const double MillisecondsPerCycle = SecondsPerCycle * 1000;
    private const double MicrosecondsPerCycle = MillisecondsPerCycle * 1000;
    private const double NanosecondsPerCycle = MicrosecondsPerCycle * 1000;
    private const double PicosecondsPerCycle = NanosecondsPerCycle * 1000;
    
    public static void Report(string actionName, int repetitionCount, TimeSpan duration, int operationsPerRepetition=1)
    {
        var operationCount = repetitionCount * operationsPerRepetition;
        var timeForSingleCallInMs = duration.TotalMilliseconds / operationCount;
        var cyclesPerOperation = timeForSingleCallInMs / MillisecondsPerCycle;
        var ops = operationsPerRepetition > 1 ? "ops" : "op";
        Console.WriteLine($"{duration.TotalMilliseconds,7:n1}ms; @{CpuFrequencyInGhz:n1}GHz; {repetitionCount:n0} reps; {operationsPerRepetition} {ops,3}/rep; {cyclesPerOperation,3:n0} cycles/op; {actionName}");
    }
}