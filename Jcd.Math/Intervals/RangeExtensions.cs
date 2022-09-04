using System;
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Math.Intervals;

/// <summary>
/// Provides range comparison facilities.
/// </summary>
public static class RangeExtensions
{
    /// <summary>
    /// Checks if a value is within a closed interval. (i.e. interval includes start and endpoints)
    /// </summary>
    /// <param name="value">The value to compare</param>
    /// <param name="start">Start of the range to check</param>
    /// <param name="end">End of the range to check.</param>
    /// <typeparam name="T">The data type being compared.</typeparam>
    /// <returns>true if the value is within the range.</returns>
    public static bool InRange<T>(this T value, T start, T end)
        where T: IComparable<T>
    {
        return start.CompareTo(value) <= 0 && value.CompareTo(end) <= 0;
    }

    /// <summary>
    /// Determines if a value is less than the start (-1) of the
    /// closed interval [start,end], within the interval (0),
    /// or after the end of the interval (1)
    /// </summary>
    /// <param name="value">The value to compare</param>
    /// <param name="start">Start of the range to check</param>
    /// <param name="end">End of the range to check.</param>
    /// <typeparam name="T">The data type being compared.</typeparam>
    /// <returns>-1, for less than, 0 for in range, 1 for greater than end.</returns>
    public static int CompareToRange<T>(this T value, T start, T end)
        where T: IComparable<T>
    {
        return value.InRange(start,end) 
            ? 0 // in range, so 0.
            : value.CompareTo(start) < 0 
                ? -1 // less than start
                : 1; // the only other option is greater than the end.
    }
}