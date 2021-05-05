using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmDailyBlogs
    {
        public int BlogId { get; set; }
        public string Title { get; set; }

        public VmDailyBlogs()
        {

        }

        public VmDailyBlogs(TblBlog blog)
        {
            BlogId = blog.BlogId;
            Title = blog.Title;
        }
    }
}
