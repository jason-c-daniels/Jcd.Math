namespace Jcd.Math;

/// <summary>
/// Defines methods to support the comparison of two items of differing
/// types for equality.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
public interface IDisjointEqualityComparer<in T1, in T2>
{
    /// <summary>
    /// Compares an instance of T1 to an instance of T2.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>True if equivalent.</returns>
    bool Equals(T1 x, T2 y);
    
    /// <summary>
    /// Compares an instance of T1 to an instance of T2.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>True if equivalent.</returns>
    bool Equals(T2 x, T1 y);
}