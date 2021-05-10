using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AngularShop.Utilities
{
    public static class ExtenuationMethods
    {
        private static Random ran = new Random();

        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            return source.OrderBy<T, int>((item) => ran.Next());
        }

        public static string DateToShamsi(this DateTime value)
        {
            PersianCalendar calendar = new PersianCalendar();
            return " " + calendar.GetYear(value) + "/" + calendar.GetMonth(value).ToString("00") + "/" +
                   calendar.GetDayOfMonth(value).ToString("00");
        }

        public static string DateTimeToShamsi(this DateTime value)
        {
            PersianCalendar calendar = new PersianCalendar();
            return " " + calendar.GetYear(value) + "/" + calendar.GetMonth(value).ToString("00") + "/" +
                   calendar.GetDayOfMonth(value).ToString("00") + " " + value.Hour + ":" +
                   value.Minute;
        }
    }
}
