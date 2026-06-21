using System;

public class DateDifferenceHelper
{
    
    public static string GetDateDiff(DateOnly start, DateOnly end)
    {

        if (start > end) (start, end) = (end, start); // Swap if out of order

        int years = end.Year - start.Year;
        int months = end.Month - start.Month;
        int days = end.Day - start.Day;

        // In case days difference is negative
        if (days < 0)
        {
            months--;

            // Add days to the previous month
            DateOnly previousMonth = end.AddMonths(-1);
            days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
        }

        // In case months difference is negative
        if (months < 0)
        {
            years--;
            months += 12;
        }

        return $"{years} years, {months} months, {days} days";
    }

}