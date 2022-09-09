using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Jcd.Math;

/// <summary>
/// 1. A set of upcoming C# features:
///    Generic `Min`, `Max`, and `Clamp`. Once MS has implemented these
///    (C# 11, .NET7?) they will be off of the Math. class.
/// 
/// 2. Some custom extension methods that everyone seems to have to
///    create, despite well known algorithms. (InRange and CompareToRange)
///  
/// </summary>
public static class Compare
{
    /// <summary>
    /// Returns the lesser of two values for an IComparable&lt;T&gt;
    /// </summary>
    /// <param name="val1">The first of two values to compare.</param>
    /// <param name="val2">The second of two values to compare.</param>
    /// <typeparam name="T">The data type of the values.</typeparam>
    /// <returns>The smaller of the two values. `val1` if equivalent.</returns>
    public static T Min<T>(T val1, T val2) where T : IComparable<T>
        => val1.CompareTo(val2) <= 0 ? val1 : val2;
    
    /// <summary>
    /// Returns the lesser of two values for an IComparable&lt;T&gt;
    /// </summary>
    /// <param name="val1">The first of two values to compare.</param>
    /// <param name="val2">The second of two values to compare.</param>
    /// <param name="comparer">A value comparer to use for the comparisons.</param>
    /// <typeparam name="T">The data type of the values.</typeparam>
    /// <returns>The smaller of the two values. `val1` if equivalent.</returns>
    public static T Min<T>(T val1, T val2, IComparer<T> comparer) where T : IComparable<T>
        => comparer.Compare(val1,val2) <= 0 ? val1 : val2;
    
    /// <summary>
    /// Returns the greater of two values for an IComparable&lt;T&gt;
    /// </summary>
    /// <param name="val1">The first value to compare.</param>
    /// <param name="val2">The second value to compare.</param>
    /// <typeparam name="T">The data type of the values.</typeparam>
    /// <returns>The greater of the two values. `val1` if equivalent.</returns>
    public static T Max<T>(T val1, T val2) 
        where T : IComparable<T>
        => val1.CompareTo(val2) >= 0 ? val1 : val2;
    
    /// <summary>
    /// Returns the greater of two values for an IComparable&lt;T&gt;
    /// </summary>
    /// <param name="val1">The first of two values to compare.</param>
    /// <param name="val2">The second of two values to compare.</param>
    /// <param name="comparer">A value comparer to use for the comparisons.</param>
    /// <typeparam name="T">The data type of the values.</typeparam>
    /// <returns>The greater of the two values. `val1` if equivalent.</returns>
    public static T Max<T>(T val1, T val2, IComparer<T> comparer) 
        where T : IComparable<T>
        => comparer.Compare(val1,val2) >= 0 ? val1 : val2;
    
    /// <summary>
    /// Returns a `value` clamped to the inclusive range of `min` and `max`.
    /// </summary>
    /// <param name="value">The value to be clamped.</param>
    /// <param name="min">The lower bounds of the result.</param>
    /// <param name="max">The upper bounds of the result.</param>
    /// <typeparam name="T">The data type.</typeparam>
    /// <returns>
    ///     - `min` : when `value` &lt; `min`.
    /// -or-
    ///     - `max` : when `value` &gt; `max`.
    /// -or-
    ///     - `value` : when `min` ≤ `value` ≤ `max`.
    /// </returns>
    public static T Clamp<T>(T value, T min, T max)
        where T : IComparable<T>
        => value.CompareTo(min) < 0
            ? min
            : value.CompareTo(max) > 0 
                ? max
                : value
    ;
    
    /// <summary>
    /// Clamps a value to the specified range.
    /// </summary>
    /// <param name="value">The value to clamp.</param>
    /// <param name="min">The minimum value for the range.</param>
    /// <param name="max">The maximum value for the range.</param>
    /// <param name="comparer">The value comparer</param>
    /// <typeparam name="T">The data type.</typeparam>
    /// <returns>
    ///     - min if value less than min,
    ///     - max if value greater than max,
    ///     - value otherwise.
    /// </returns>
    public static T Clamp<T>(T value, T min, T max, IComparer<T> comparer) 
        where T : IComparable<T>
        => comparer.Compare(value,min) < 0
            ? min
            : comparer.Compare(value,max) > 0 
                ? max
                : value
    ;
    
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ToRange<T>(this T value, T start, T end)
        where T: IComparable<T>
    {
        return value.InRange(start,end) 
            ? 0 // in range, so 0.
            : value.CompareTo(start) < 0 
                ? -1 // less than start
                : 1; // the only other option is greater than the end.
    }
}