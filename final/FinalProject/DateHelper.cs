using System;

public static class DateHelper
{
    public static int DaysUntil(DateTime date)
    {
        return (date - DateTime.Now).Days;
    }
}
