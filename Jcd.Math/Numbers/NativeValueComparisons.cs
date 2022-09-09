using System;

namespace Jcd.Math.Numbers;

public static class NativeValueComparisons
{
    #region x as bool
    
    /// <summary>
    /// Upcast bool to byte 0 if false 1 if true, then compare.
    /// </summary>
    /// <param name="x">left hand operand</param>
    /// <param name="y">right hand operand</param>
    /// <returns>-1 if x less than y; 1 if x greater than y; 0 if equal</returns>
    public static int Compare(bool x, byte y)
    {
        var xb = x ? (byte) 1 : (byte) 0;
        return xb.CompareTo(y);
    }
    
    /// <summary>
    /// upcast bool to (byte)1/0 then compare.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static int Compare(bool x, ushort y)
    {
        throw new NotImplementedException();
    }
    
    #endregion
}