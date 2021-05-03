using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.ViewModels
{
    public class VmBlog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BodyHtml { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public List<TblKeyword> Keywords { get; set; }
        public List<VmBlogList> RelatedBlogs { get; set; }
        public List<VmComment> Comments { get; set; }
        public string ImageUrl { get; set; }

        public VmBlog()
        {

        }

        public VmBlog(TblBlog blog)
        {
            Keywords = new List<TblKeyword>();
            RelatedBlogs = new List<VmBlogList>();
            Comments = new List<VmComment>();
            Core core = new Core();
            BlogId = blog.BlogId;
            ImageUrl = blog.MainImage;
            Title = blog.Title;
            Description = blog.Description;
            DateCreated = blog.DateCreated;
            BodyHtml = blog.BodyHtml;
            LikeCount = blog.LikeCount;
            ViewCount = blog.ViewCount;
            DateCreated = blog.DateCreated;
            Keywords = blog.TblBlogKeywordRels.Select(i => i.Keyword).ToList();
            foreach (TblBlogKeywordRel i in blog.TblBlogKeywordRels)
                foreach (TblBlog x in core.BlogKeywordRel.Get(j => j.KeywordId == i.KeywordId).Select(k => k.Blog).ToList())
                    RelatedBlogs.Add(new VmBlogList(x));
            foreach (TblComment i in blog.TblBlogCommentRels.Select(i => i.Comment).ToList())
                Comments.Add(new VmComment(i));
        }
    }
}
