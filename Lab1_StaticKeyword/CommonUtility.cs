using System;
using System.Collections.Generic;

// static class - instantiated once
//static class is used to group un-related functions / comfiguration details which need to be shared across
//static class can NOT: inherited, Abstract, Polymorphism (static/Dynamic), Interface
//all members and methods are static for static class
//in case u want to cache data rather than going again and again to SQL server to fetch data

public static class CommonUtility
{
    //caching of data

    public static List<string> oDaysOfWeek = new List<string>();

    static CommonUtility()
    {
        Console.WriteLine("Executed once!");

        //data is cached once and can be used anywhere
        oDaysOfWeek.Add("Sunday");
        oDaysOfWeek.Add("Monday");
        oDaysOfWeek.Add("Tuesday");
        oDaysOfWeek.Add("Wednesday");
        oDaysOfWeek.Add("Thursday");
        oDaysOfWeek.Add("Friday");
        oDaysOfWeek.Add("Saturday");

    }
    public static int counter = 0;

    //group unrelated functions/methods
    public static string getMachineName() 
    {
        return System.Environment.MachineName;
    }

    public static bool IsEmpty(string val)
    {
        return string.IsNullOrEmpty(val) ? true : false;
    }
}
