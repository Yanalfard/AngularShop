using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmBlogLastBlogs
    {
        public int BlogId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public VmBlogLastBlogs()
        {

        }

        public VmBlogLastBlogs(TblBlog blog)
        {
            BlogId = blog.BlogId;
            ImageUrl = blog.MainImage;
            Title = blog.Title;
            DateCreated = blog.DateCreated;
        }
    }
}
