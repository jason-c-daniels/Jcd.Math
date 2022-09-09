using System;

namespace Jcd.Math;

/// <summary>
/// 
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Determines if a type is a user defined struct
    /// or user defined enum.
    /// </summary>
    /// <param name="type">the type to inspect</param>
    /// <returns>true if the type is a used defined struct or enum.</returns>
    public static bool IsUserDefinedStructOrEnum(this Type type) 
    {
        return type.IsValueType && !type.IsPrimitive;
    }
    
    /// <summary>
    /// Determines if a type is a a primitive struct or primitive (built-in) enum
    /// </summary>
    /// <param name="type">the type to inspect.</param>
    /// <returns>True if the type is a primitive struct or enum.</returns>
    public static bool IsPrimitiveStructOrEnum(this Type type) 
    {
        return type.IsValueType && type.IsPrimitive;
    }
}