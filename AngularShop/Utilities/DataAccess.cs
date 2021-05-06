using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.Utilities
{
    public static class DataAccess
    {
        private static readonly Core Core = new Core();
        public static string GetConfig(string key)
        {
            return Core.Config.Get(i => i.Key == key).First().Value;
        }

        public static bool SetConfig(string key, string value)
        {
            try
            {
                TblConfig config = Core.Config.Get(i => i.Key == key).First();
                config.Value = value;
                Core.Config.Update(config);
                Core.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetNameGetter(int month)
        {
            switch (month)
            {
                case 1: return "فروردین";
                case 2: return "اردیبهشت";
                case 3: return "خرداد";
                case 4: return "";
                case 5: return "مرداد";
                case 6: return "شهریور";
                case 7: return "مهر";
                case 8: return "آبان";
                case 9: return "آذر";
                case 10: return "دی";
                case 11: return "بهمن";
                case 12: return "اسفند";
                default: return "";
            }
        }
    }
}
