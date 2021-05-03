using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmBlogList
    {
        public int BlogId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int CommentCount { get; set; }

        public VmBlogList()
        {
            
        }

        public VmBlogList(TblBlog blog)
        {
            BlogId = blog.BlogId;
            ImageUrl = blog.MainImage;
            Title = blog.Title;
            Description = blog.Description;
            DateCreated = blog.DateCreated;
            CommentCount = blog.TblBlogCommentRels.Count;
        }
    }
}
