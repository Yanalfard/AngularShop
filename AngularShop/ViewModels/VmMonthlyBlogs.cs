using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmMonthlyBlogs
    {
        public string MonthName { get; set; }

        public List<VmDailyBlogs> DailyBlogs { get; set; } = new List<VmDailyBlogs>();

        public VmMonthlyBlogs()
        {

        }

        public VmMonthlyBlogs(string monthName, List<VmDailyBlogs> blogs)
        {
            MonthName = monthName;
            DailyBlogs = blogs;
        }
    }
}
