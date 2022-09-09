namespace Jcd.Math.NativeValueComparisonsGenerator;

public static class Template
{

    public const string CompareToUpcastBoth=@"

    /// <summary>
    /// Compares a $firstType$ to a $secondType$
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($firstType$ x, $secondType$ y)
    {
         var x1=($upcastType$)x;
         var y1=($upcastType$)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a $secondType$ to a $firstType$ 
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($secondType$ x, $firstType$ y)
    {
         var x1=($upcastType$)x;
         var y1=($upcastType$)y;
         return x1.CompareTo(y1);
    }
";

    public const string CompareToUpcastFirst=@"

    /// <summary>
    /// Compares a $firstType$ to a $secondType$
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($firstType$ x, $secondType$ y)
    {
         var x1=($upcastType$)x;
         return x1.CompareTo(y);
    }

    /// <summary>
    /// Compares a $secondType$ to a $firstType$ 
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($secondType$ x, $firstType$ y)
    {
         var y1=($upcastType$)y;
         return x.CompareTo(y1);
    }
";
    
    public const string CompareToUpcastSecond=@"

    /// <summary>
    /// Compares a $firstType$ to a $secondType$
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($firstType$ x, $secondType$ y)
    {
         var y1=($upcastType$)y;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a $secondType$ to a $firstType$ 
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($secondType$ x, $firstType$ y)
    {
         var x1=($upcastType$)x;
         return x1.CompareTo(y);
    }
";
 
    public const string EqualsUpcastBoth=@"

    /// <summary>
    /// Checks a $firstType$ and a $secondType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($firstType$ x, $secondType$ y)
    {
         var x1=($upcastType$)x;
         var y1=($upcastType$)y;
         return x1.Equals(y1);
    }

    /// <summary>
    /// Checks a $secondType$ and a $firstType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($secondType$ x, $firstType$ y)
    {
         var x1=($upcastType$)x;
         var y1=($upcastType$)y;
         return x1.Equals(y1);
    }
";

    public const string EqualsUpcastFirst=@"

    /// <summary>
    /// Checks a $firstType$ and a $secondType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($firstType$ x, $secondType$ y)
    {
         var x1=($upcastType$)x;
         return x1.Equals(y);
    }

    /// <summary>
    /// Checks a $secondType$ and a $firstType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($secondType$ x, $firstType$ y)
    {
         var y1=($upcastType$)y;
         return x.Equals(y1);
    }
";

    
    public const string EqualsUpcastSecond=@"

    /// <summary>
    /// Checks a $firstType$ and a $secondType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($firstType$ x, $secondType$ y)
    {
         var y1=($upcastType$)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a $secondType$ and a $firstType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($secondType$ x, $firstType$ y)
    {
         var x1=($upcastType$)x;
         return x1.Equals(y);
    }
";

    public const string BeginRegion=@"
    #region [$firstType$ to $secondType$ comparisons]
";
    public const string EndRegion=@"
    #endregion // [$firstType$ to $secondType$ comparisons]
";
 
    #region bool templates
    
    /// <summary>
    /// Note: $firstType must be bool for this template to work.
    /// </summary>
    public const string CompareToBool=@"

    /// <summary>
    /// Compares a Boolean to a $secondType$.
    /// $secondType$ is down converted to bool then compared.
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($firstType$ x, $secondType$ y)
    {
         var y1 = y == 0 ? false : true;
         return x.CompareTo(y1);
    }

    /// <summary>
    /// Compares a $firstType$ to a Boolean.
    /// $firstType$ is down converted to bool then compared.
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public int Compare($firstType$ x, $secondType$ y)
    {
         var x1 = x == 0 ? false : true;
         return x1.CompareTo(y);
    }
";
 
    /// <summary>
    /// Note: $firstType must be bool for this template to work.
    /// </summary>
    public const string EqualsWithBool=@"

    /// <summary>
    /// Checks a $firstType$ and a $secondType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($firstType$ x, $secondType$ y)
    {
         var y1 = y == 0 ? false : true;
         return x == y1;
    }

    /// <summary>
    /// Checks a $secondType$ and a $firstType$ for equality
    /// </summary>
    /// <param name=""x"">The first item to compare</param>
    /// <param name=""y"">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public bool Equals($secondType$ x, $firstType$ y)
    {
         var x1=($upcastType$)x;
         var y1=($upcastType$)y;
         return x1.Equals(y1);
    }
";
    
    #endregion
    
    public static string Process(string template, Type firstType, Type secondType, Type upcastType)
    {
        return template.Replace("$firstType$", firstType.Name)
            .Replace("$secondType$", secondType.Name)
            .Replace("$upcastType$", upcastType.Name);
    }
}