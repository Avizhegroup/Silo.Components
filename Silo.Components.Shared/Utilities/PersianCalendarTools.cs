using System.Globalization;

namespace Silo.Components.Shared;

public static class PersianCalendarTools
{
    public static DateTime PersianToGregorian(string date)
    {
        var array = date.Split('/');

        return new (int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), new System.Globalization.PersianCalendar());
    }

    public static string GregorianToPersian(DateTime date)
    {
        PersianCalendar pc = new ();
       
        var firstDate = pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" +
                        pc.GetDayOfMonth(date);
        
        var array = firstDate.Split('/');
        
        var returnVal = "";
        
        if (array[1].Length == 1)
        {
            array[1] = "0" + array[1]; 
        }
       
        if (array[2].Length == 1)
        { 
            array[2] = "0" + array[2]; 
        }
       
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 | i == 1)
            {
                returnVal += array[i] + "/";
            }
            else
            {
                returnVal += array[i];
            }
        }
        return returnVal;
    }
}
