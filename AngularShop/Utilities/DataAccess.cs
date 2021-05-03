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
    }
}
