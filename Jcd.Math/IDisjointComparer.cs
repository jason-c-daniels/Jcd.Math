using System;
using System.Collections.Generic;

namespace Jcd.Math;

/// <summary>
/// A generic IComparer interface implements a method that compares 
/// two objects of differing types. It is used in conjunction with
/// the Infinity and Number structs to provide comparisons.
/// </summary>
/// <typeparam name="T1">The first type.</typeparam>
/// <typeparam name="T2">The second type.</typeparam>
public interface IDisjointComparer<in T1, in T2>
{
    /// <summary>
    /// Compares an instance of T1 to an instance of T2.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    int Compare(T1 x, T2 y);
    
    /// <summary>
    /// Compares an instance of T1 to an instance of T2.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    int Compare(T2 x, T1 y);
}