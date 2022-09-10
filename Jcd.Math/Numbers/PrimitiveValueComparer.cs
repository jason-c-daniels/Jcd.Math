
using System;

namespace Jcd.Math.Numbers;

public static class PrimitiveValueComparer
{
    #region [Boolean to Byte comparisons]


    /// <summary>
    /// Checks a Boolean and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Byte y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Byte and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Byte comparisons]


    #region [Boolean to SByte comparisons]


    /// <summary>
    /// Checks a Boolean and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, SByte y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a SByte and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to SByte comparisons]


    #region [Boolean to Int16 comparisons]


    /// <summary>
    /// Checks a Boolean and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Int16 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Int16 and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Int16 comparisons]


    #region [Boolean to UInt16 comparisons]


    /// <summary>
    /// Checks a Boolean and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, UInt16 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a UInt16 and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to UInt16 comparisons]


    #region [Boolean to Int32 comparisons]


    /// <summary>
    /// Checks a Boolean and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Int32 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Int32 and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Int32 comparisons]


    #region [Boolean to UInt32 comparisons]


    /// <summary>
    /// Checks a Boolean and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, UInt32 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a UInt32 and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to UInt32 comparisons]


    #region [Boolean to Single comparisons]


    /// <summary>
    /// Checks a Boolean and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Single y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Single and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Single comparisons]


    #region [Boolean to Int64 comparisons]


    /// <summary>
    /// Checks a Boolean and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Int64 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Int64 and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Int64 comparisons]


    #region [Boolean to UInt64 comparisons]


    /// <summary>
    /// Checks a Boolean and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, UInt64 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a UInt64 and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to UInt64 comparisons]


    #region [Boolean to Double comparisons]


    /// <summary>
    /// Checks a Boolean and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Double y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Double and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Double comparisons]


    #region [Boolean to Decimal comparisons]


    /// <summary>
    /// Checks a Boolean and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Decimal y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Decimal and a Boolean for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }

    #endregion // [Boolean to Decimal comparisons]


    #region [Byte to SByte comparisons]


    /// <summary>
    /// Checks a Byte and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, SByte y)
    {
         var x1=(Int16)x;
         var y1=(Int16)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Byte y)
    {
         var x1=(Int16)x;
         var y1=(Int16)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a Byte to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, SByte y)
    {
         var x1=(Int16)x;
         var y1=(Int16)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Byte 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Byte y)
    {
         var x1=(Int16)x;
         var y1=(Int16)y;
         return x1.CompareTo(y1);
    }

    #endregion // [Byte to SByte comparisons]


    #region [Int16 to Byte comparisons]


    /// <summary>
    /// Checks a Int16 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Byte y)
    {
         var y1=(Int16)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Int16 y)
    {
         var x1=(Int16)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int16 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Byte y)
    {
         var y1=(Int16)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Int16 y)
    {
         var x1=(Int16)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int16 to Byte comparisons]


    #region [Int16 to SByte comparisons]


    /// <summary>
    /// Checks a Int16 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, SByte y)
    {
         var y1=(Int16)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Int16 y)
    {
         var x1=(Int16)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int16 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, SByte y)
    {
         var y1=(Int16)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Int16 y)
    {
         var x1=(Int16)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int16 to SByte comparisons]


    #region [Int16 to UInt16 comparisons]


    /// <summary>
    /// Checks a Int16 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, UInt16 y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Int16 y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a Int16 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, UInt16 y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Int16 y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.CompareTo(y1);
    }

    #endregion // [Int16 to UInt16 comparisons]


    #region [UInt16 to Byte comparisons]


    /// <summary>
    /// Checks a UInt16 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Byte y)
    {
         var y1=(UInt16)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, UInt16 y)
    {
         var x1=(UInt16)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a UInt16 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Byte y)
    {
         var y1=(UInt16)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a UInt16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, UInt16 y)
    {
         var x1=(UInt16)x;
         return x1.CompareTo(y);
    }

    #endregion // [UInt16 to Byte comparisons]


    #region [UInt16 to SByte comparisons]


    /// <summary>
    /// Checks a UInt16 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, SByte y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, UInt16 y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a UInt16 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, SByte y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a UInt16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, UInt16 y)
    {
         var x1=(Int32)x;
         var y1=(Int32)y;
         return x1.CompareTo(y1);
    }

    #endregion // [UInt16 to SByte comparisons]


    #region [Int32 to Byte comparisons]


    /// <summary>
    /// Checks a Int32 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Byte y)
    {
         var y1=(Int32)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int32 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Byte y)
    {
         var y1=(Int32)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int32 to Byte comparisons]


    #region [Int32 to SByte comparisons]


    /// <summary>
    /// Checks a Int32 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, SByte y)
    {
         var y1=(Int32)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int32 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, SByte y)
    {
         var y1=(Int32)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int32 to SByte comparisons]


    #region [Int32 to Int16 comparisons]


    /// <summary>
    /// Checks a Int32 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Int16 y)
    {
         var y1=(Int32)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int16 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int32 to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Int16 y)
    {
         var y1=(Int32)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int16 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int32 to Int16 comparisons]


    #region [Int32 to UInt16 comparisons]


    /// <summary>
    /// Checks a Int32 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, UInt16 y)
    {
         var y1=(Int32)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int32 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, UInt16 y)
    {
         var y1=(Int32)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Int32 y)
    {
         var x1=(Int32)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int32 to UInt16 comparisons]


    #region [Int32 to UInt32 comparisons]


    /// <summary>
    /// Checks a Int32 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, UInt32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt32 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Int32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a Int32 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, UInt32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt32 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Int32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.CompareTo(y1);
    }

    #endregion // [Int32 to UInt32 comparisons]


    #region [Int32 to Single comparisons]


    /// <summary>
    /// Checks a Int32 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a Single and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Int32 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a Int32 to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Single to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Int32 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    #endregion // [Int32 to Single comparisons]


    #region [UInt32 to Byte comparisons]


    /// <summary>
    /// Checks a UInt32 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Byte y)
    {
         var y1=(UInt32)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, UInt32 y)
    {
         var x1=(UInt32)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a UInt32 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Byte y)
    {
         var y1=(UInt32)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, UInt32 y)
    {
         var x1=(UInt32)x;
         return x1.CompareTo(y);
    }

    #endregion // [UInt32 to Byte comparisons]


    #region [UInt32 to SByte comparisons]


    /// <summary>
    /// Checks a UInt32 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, SByte y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, UInt32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a UInt32 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, SByte y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, UInt32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.CompareTo(y1);
    }

    #endregion // [UInt32 to SByte comparisons]


    #region [UInt32 to Int16 comparisons]


    /// <summary>
    /// Checks a UInt32 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Int16 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a Int16 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, UInt32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a UInt32 to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Int16 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int16 to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, UInt32 y)
    {
         var x1=(Int64)x;
         var y1=(Int64)y;
         return x1.CompareTo(y1);
    }

    #endregion // [UInt32 to Int16 comparisons]


    #region [UInt32 to UInt16 comparisons]


    /// <summary>
    /// Checks a UInt32 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, UInt16 y)
    {
         var y1=(UInt32)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, UInt32 y)
    {
         var x1=(UInt32)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a UInt32 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, UInt16 y)
    {
         var y1=(UInt32)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, UInt32 y)
    {
         var x1=(UInt32)x;
         return x1.CompareTo(y);
    }

    #endregion // [UInt32 to UInt16 comparisons]


    #region [UInt32 to Single comparisons]


    /// <summary>
    /// Checks a UInt32 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a Single and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, UInt32 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a UInt32 to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Single to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, UInt32 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    #endregion // [UInt32 to Single comparisons]


    #region [Single to Byte comparisons]


    /// <summary>
    /// Checks a Single and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Byte y)
    {
         var y1=(Single)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Single y)
    {
         var x1=(Single)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Single to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Byte y)
    {
         var y1=(Single)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Single y)
    {
         var x1=(Single)x;
         return x1.CompareTo(y);
    }

    #endregion // [Single to Byte comparisons]


    #region [Single to SByte comparisons]


    /// <summary>
    /// Checks a Single and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, SByte y)
    {
         var y1=(Single)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Single y)
    {
         var x1=(Single)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Single to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, SByte y)
    {
         var y1=(Single)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Single y)
    {
         var x1=(Single)x;
         return x1.CompareTo(y);
    }

    #endregion // [Single to SByte comparisons]


    #region [Single to Int16 comparisons]


    /// <summary>
    /// Checks a Single and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Int16 y)
    {
         var y1=(Single)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int16 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Single y)
    {
         var x1=(Single)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Single to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Int16 y)
    {
         var y1=(Single)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int16 to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Single y)
    {
         var x1=(Single)x;
         return x1.CompareTo(y);
    }

    #endregion // [Single to Int16 comparisons]


    #region [Single to UInt16 comparisons]


    /// <summary>
    /// Checks a Single and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, UInt16 y)
    {
         var y1=(Single)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Single y)
    {
         var x1=(Single)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Single to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, UInt16 y)
    {
         var y1=(Single)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Single y)
    {
         var x1=(Single)x;
         return x1.CompareTo(y);
    }

    #endregion // [Single to UInt16 comparisons]


    #region [Int64 to Byte comparisons]


    /// <summary>
    /// Checks a Int64 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Byte y)
    {
         var y1=(Int64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int64 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Byte y)
    {
         var y1=(Int64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int64 to Byte comparisons]


    #region [Int64 to SByte comparisons]


    /// <summary>
    /// Checks a Int64 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, SByte y)
    {
         var y1=(Int64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int64 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, SByte y)
    {
         var y1=(Int64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int64 to SByte comparisons]


    #region [Int64 to Int16 comparisons]


    /// <summary>
    /// Checks a Int64 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Int16 y)
    {
         var y1=(Int64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int16 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int64 to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Int16 y)
    {
         var y1=(Int64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int16 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int64 to Int16 comparisons]


    #region [Int64 to UInt16 comparisons]


    /// <summary>
    /// Checks a Int64 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, UInt16 y)
    {
         var y1=(Int64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int64 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, UInt16 y)
    {
         var y1=(Int64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int64 to UInt16 comparisons]


    #region [Int64 to Int32 comparisons]


    /// <summary>
    /// Checks a Int64 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Int32 y)
    {
         var y1=(Int64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int32 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int64 to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Int32 y)
    {
         var y1=(Int64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int32 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int64 to Int32 comparisons]


    #region [Int64 to UInt32 comparisons]


    /// <summary>
    /// Checks a Int64 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, UInt32 y)
    {
         var y1=(Int64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt32 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Int64 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, UInt32 y)
    {
         var y1=(Int64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt32 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Int64 y)
    {
         var x1=(Int64)x;
         return x1.CompareTo(y);
    }

    #endregion // [Int64 to UInt32 comparisons]


    #region [Int64 to Single comparisons]


    /// <summary>
    /// Checks a Int64 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a Single and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Int64 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a Int64 to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Single to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Int64 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    #endregion // [Int64 to Single comparisons]


    #region [UInt64 to Byte comparisons]


    /// <summary>
    /// Checks a UInt64 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Byte y)
    {
         var y1=(UInt64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, UInt64 y)
    {
         var x1=(UInt64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a UInt64 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Byte y)
    {
         var y1=(UInt64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, UInt64 y)
    {
         var x1=(UInt64)x;
         return x1.CompareTo(y);
    }

    #endregion // [UInt64 to Byte comparisons]


    #region [UInt64 to UInt16 comparisons]


    /// <summary>
    /// Checks a UInt64 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, UInt16 y)
    {
         var y1=(UInt64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, UInt64 y)
    {
         var x1=(UInt64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a UInt64 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, UInt16 y)
    {
         var y1=(UInt64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, UInt64 y)
    {
         var x1=(UInt64)x;
         return x1.CompareTo(y);
    }

    #endregion // [UInt64 to UInt16 comparisons]


    #region [UInt64 to UInt32 comparisons]


    /// <summary>
    /// Checks a UInt64 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, UInt32 y)
    {
         var y1=(UInt64)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt32 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, UInt64 y)
    {
         var x1=(UInt64)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a UInt64 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, UInt32 y)
    {
         var y1=(UInt64)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt32 to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, UInt64 y)
    {
         var x1=(UInt64)x;
         return x1.CompareTo(y);
    }

    #endregion // [UInt64 to UInt32 comparisons]


    #region [UInt64 to Single comparisons]


    /// <summary>
    /// Checks a UInt64 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a Single and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, UInt64 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.Equals(y1);
    }


    /// <summary>
    /// Compares a UInt64 to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Single y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Single to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, UInt64 y)
    {
         var x1=(Decimal)x;
         var y1=(Decimal)y;
         return x1.CompareTo(y1);
    }

    #endregion // [UInt64 to Single comparisons]


    #region [Double to Byte comparisons]


    /// <summary>
    /// Checks a Double and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Byte y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Byte y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to Byte comparisons]


    #region [Double to SByte comparisons]


    /// <summary>
    /// Checks a Double and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, SByte y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, SByte y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to SByte comparisons]


    #region [Double to Int16 comparisons]


    /// <summary>
    /// Checks a Double and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Int16 y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int16 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Int16 y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int16 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to Int16 comparisons]


    #region [Double to UInt16 comparisons]


    /// <summary>
    /// Checks a Double and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, UInt16 y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, UInt16 y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to UInt16 comparisons]


    #region [Double to Int32 comparisons]


    /// <summary>
    /// Checks a Double and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Int32 y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int32 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Int32 y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int32 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to Int32 comparisons]


    #region [Double to UInt32 comparisons]


    /// <summary>
    /// Checks a Double and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, UInt32 y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt32 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, UInt32 y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt32 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to UInt32 comparisons]


    #region [Double to Single comparisons]


    /// <summary>
    /// Checks a Double and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Single y)
    {
         var y1=(Double)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Single and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Double y)
    {
         var x1=(Double)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Double to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Single y)
    {
         var y1=(Double)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Single to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Double y)
    {
         var x1=(Double)x;
         return x1.CompareTo(y);
    }

    #endregion // [Double to Single comparisons]


    #region [Decimal to Byte comparisons]


    /// <summary>
    /// Checks a Decimal and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Byte y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Byte and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Byte y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Byte to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to Byte comparisons]


    #region [Decimal to SByte comparisons]


    /// <summary>
    /// Checks a Decimal and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, SByte y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a SByte and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, SByte y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a SByte to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to SByte comparisons]


    #region [Decimal to Int16 comparisons]


    /// <summary>
    /// Checks a Decimal and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Int16 y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int16 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Int16 y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int16 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to Int16 comparisons]


    #region [Decimal to UInt16 comparisons]


    /// <summary>
    /// Checks a Decimal and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, UInt16 y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt16 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, UInt16 y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt16 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to UInt16 comparisons]


    #region [Decimal to Int32 comparisons]


    /// <summary>
    /// Checks a Decimal and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Int32 y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int32 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Int32 y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int32 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to Int32 comparisons]


    #region [Decimal to UInt32 comparisons]


    /// <summary>
    /// Checks a Decimal and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, UInt32 y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt32 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, UInt32 y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt32 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to UInt32 comparisons]


    #region [Decimal to Single comparisons]


    /// <summary>
    /// Checks a Decimal and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Single y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Single and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Single y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Single to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to Single comparisons]


    #region [Decimal to UInt64 comparisons]


    /// <summary>
    /// Checks a Decimal and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, UInt64 y)
    {
         var y1=(Decimal)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt64 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.Equals(y);
    }


    /// <summary>
    /// Compares a Decimal to a UInt64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, UInt64 y)
    {
         var y1=(Decimal)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt64 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Decimal y)
    {
         var x1=(Decimal)x;
         return x1.CompareTo(y);
    }

    #endregion // [Decimal to UInt64 comparisons]
}
