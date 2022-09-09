namespace Jcd.Math.NativeValueComparisonsGenerator;

public static class Generate
{
    public static string DowncastToBool(Type first, Type second)
    {
        if (first != typeof(bool)) return string.Empty;
        return Template.Process(Template.BeginRegion, first, second, first)
               + Template.Process(Template.EqualsWithBool, first, second, first)
               + Template.Process(Template.CompareToBool, first, second, first)
               + Template.Process(Template.EndRegion, first, second, first)
            ;
    }

    public static string UpcastBoth(Type first, Type second, Type upcast)
    {
        return Template.Process(Template.BeginRegion, first, second, upcast)
               + Template.Process(Template.EqualsUpcastBoth, first, second, upcast)
               + Template.Process(Template.CompareToUpcastBoth, first, second, upcast)
               + Template.Process(Template.EndRegion, first, second, upcast)
            ;
    }

    public static string UpcastFirst(Type first, Type second, Type upcast)
    {
        return Template.Process(Template.BeginRegion, first, second, upcast)
               + Template.Process(Template.EqualsUpcastFirst, first, second, upcast)
               + Template.Process(Template.CompareToUpcastFirst, first, second, upcast)
               + Template.Process(Template.EndRegion, first, second, upcast)
            ;
    }

    public static string UpcastSecond(Type first, Type second, Type upcast)
    {
        return Template.Process(Template.BeginRegion, first, second, upcast)
               + Template.Process(Template.EqualsUpcastSecond, first, second, upcast)
               + Template.Process(Template.CompareToUpcastSecond, first, second, upcast)
               + Template.Process(Template.EndRegion, first, second, upcast)
            ;
    }

    public static string UpcastToFirst<T1, T2>() => UpcastSecond(typeof(T1), typeof(T2), typeof(T1));
    public static string UpcastToSecond<T1, T2>() => UpcastFirst(typeof(T1), typeof(T2), typeof(T2));
    public static string UpcastBoth<T1, T2, T3>() => UpcastBoth(typeof(T1), typeof(T2), typeof(T3));
}