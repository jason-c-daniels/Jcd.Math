// See https://aka.ms/new-console-template for more information

using Jcd.Math.NativeValueComparisonsGenerator;

var d = Convert.ToDecimal(ulong.MaxValue);
var ul = Convert.ToUInt64(d);

if (ul != ulong.MaxValue) Console.WriteLine("data lost");


Console.WriteLine(@"
using System;

namespace Jcd.Math.Numbers;

public static class PrimitiveValueComparer
{
    public static int Compare<T>(T x, T y)
        where T : IComparable<T>
    {
        return x.CompareTo(y);
    }

    public static bool Equals<T>(T x, T y)
        where T : IEquatable<T>
    {
        return x.Equals(y);
    }


    public static int Compare<T1,T2>(T1 x, T2 y)
        where T1 : IComparable<T2>
    {
        return x.CompareTo(y);
    }

    public static bool Equals<T1,T2>(T1 x, T2 y)
        where T1 : IEquatable<T2>
    {
        return x.Equals(y);
    }

");

foreach (var upcast in Upcast.Generate())
{
    Console.WriteLine(Processor.Generate(upcast));
    //Console.WriteLine(upcast.ToString());
}

Console.WriteLine(@"
}");

