using System.Globalization;

// namespace ExtensionMethods.Extensions;
namespace System;

public static class DateTimeExtensions
{
    public static string ElapsedTime(this DateTime thisObj)
    {
        TimeSpan duration  = DateTime.Now.Subtract(thisObj);
        if(duration.TotalHours < 24) 
            return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
        return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
    }
}