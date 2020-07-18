using System;

// static class - instantiated once
//static class contain re-usable code which is unreelated to object / comfiguration details which need to be shared across
//static class can NOT: inherited, Abstract, Polymorphism (static/Dynamic), Interface
//all members and methods are static for static class

public static class Utility
{
    public static string getMachineName()
    {
        return System.Environment.MachineName;
    }

    public static bool IsEmpty(string val)
    {
        return string.IsNullOrEmpty(val) ? true : false;
    }
}
