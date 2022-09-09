using System;
// ReSharper disable InconsistentNaming

namespace Jcd.Math.Numbers;

/// <summary>
/// A storage agnostic non-signaling NaN implementation.
/// </summary>
public readonly struct qNaN : 
    IEquatable<qNaN>
{
    /// <summary>
    /// The singular instance of qNaN.
    /// Not sure HOW I'll use this just yet...
    /// I'll likely just implement operators for it against
    /// other integral data types. Most, will compare to false.
    /// </summary>
    public static readonly qNaN NaN=default;

    #region Relational and Equality Operators qNaN v qNaN

    /// <summary>
    /// The less than operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is less than right</returns>
    public static bool operator <(qNaN left, qNaN right)  => false;

    /// <summary>
    /// The greater than operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is greater than right</returns>
    public static bool operator >(qNaN left, qNaN right) => false;

    /// <summary>
    /// The less than or equals operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is less than or equal to right</returns>
    public static bool operator <=(qNaN left, qNaN right) => false;

    /// <summary>
    /// The greater than or equals operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is greater than or equal to right</returns>
    public static bool operator >=(qNaN left, qNaN right) => false;

    #endregion
    
    #region Equality operators

    /// <summary>
    /// The equals operator. 
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if equivalent</returns>
    public static bool operator ==(qNaN left, qNaN right) => false;

    /// <summary>
    /// The not equals operator.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if not equivalent</returns>
    public static bool operator !=(qNaN left, qNaN right)  => true;
    
    /// <summary>
    /// The equals operator. 
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if equivalent</returns>
    public static bool operator ==(Infinity left, qNaN right) => false;

    /// <summary>
    /// The not equals operator.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if not equivalent</returns>
    public static bool operator !=(Infinity left, qNaN right)  => true;

    #endregion
    
    #region Implementation of IEquatable<qNaN>

    /// <inheritdoc />
    public override bool Equals(object obj) => false;

    /// <inheritdoc />
    public bool Equals(qNaN other) => false;

    /// <summary>
    /// qNaN is always not equal to any value.
    /// </summary>
    /// <param name="other">The value to compare against.</param>
    /// <typeparam name="T">The type of the value being compared.</typeparam>
    /// <returns>false</returns>
    public bool Equals<T>(T other) => false;
    
    /// <inheritdoc />
    public override int GetHashCode() => 0;

    #endregion

    /// <summary>
    /// The qNaN comparer implementation.
    /// </summary>
    /// <typeparam name="T">The other data being compared.</typeparam>
    public readonly struct Comparer<T> :
        IDisjointComparer<qNaN,T>,
        IDisjointEqualityComparer<qNaN,T>
    {
        /// <summary>
        /// The default instance of the comparer.
        /// </summary>
        public static readonly Comparer<T> Default = default;

        #region Implementation of IDisjointComparer<in qNaN,in T>
        // provide a stable sort that puts qNaN before everything, including nulls
        
        /// <inheritdoc />
        public int Compare(qNaN x, T y) => -1; 

        /// <inheritdoc />
        public int Compare(T x, qNaN y) => 1;

        #endregion

        #region Implementation of IDisjointEqualityComparer<in qNaN,in T>

        /// <inheritdoc />
        public bool Equals(qNaN x, T y) => false;

        /// <inheritdoc />
        public bool Equals(T x, qNaN y) => false;
        
        #endregion
    }
}