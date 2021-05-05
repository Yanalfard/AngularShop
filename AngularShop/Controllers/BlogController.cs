using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularShop.ViewModels;
using DataLayer.Models;
using Services.Services;
using System.Globalization;
using AngularShop.Utilities;

namespace AngularShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private Core _core = new Core();

        [HttpGet]
        [Route("GetBlogList1")]
        public IActionResult GetBlogList1()
        {
            List<VmBlogList> blogs = new List<VmBlogList>();
            foreach (TblBlog i in _core.Blog.Get().Take(20).ToList())
            {
                blogs.Add(new VmBlogList(i));
            }

            return Ok(blogs);
        }

        [HttpGet]
        [Route("GetLastBlogList2")]
        public IActionResult GetLastBlogList2()
        {
            List<VmBlogLastBlogs> blogs = new List<VmBlogLastBlogs>();
            foreach (TblBlog i in _core.Blog.Get().Take(20).ToList())
            {
                blogs.Add(new VmBlogLastBlogs(i));
            }

            return Ok(blogs);
        }

        [HttpGet]
        [Route("GetBlogsByDate3")]
        public IActionResult GetBlogsByDate3()
        {
            List<VmMonthlyBlogs> res = new List<VmMonthlyBlogs>();
            string[] date = DateTime.Now.DateToShamsi().Split('/');
            int year = Convert.ToInt32(date[0]), month = Convert.ToInt32(date[1]), day = Convert.ToInt32(date[2]);
            PersianCalendar p = new PersianCalendar();
            for (int i = month; i >= 1; i--)
            {
                List<VmDailyBlogs> daily = new List<VmDailyBlogs>();
                for (int j = day; j >= 1; j--)
                {
                    DateTime dd = p.ToDateTime(year, i, j, 0, 0, 0, 0);
                    List<TblBlog> blogg = _core.Blog.Get(k => k.DateCreated.Date == dd.Date).ToList();
                    foreach (TblBlog x in  blogg)
                        daily.Add(new VmDailyBlogs(x));
                }

                res.Add(new VmMonthlyBlogs(DataAccess.GetNameGetter(i), daily));
            }

            return Ok(res);
        }

        [HttpGet]
        [Route("GetBanner4")]
        public IActionResult GetBanner4()
        {
            List<TblBannerAndSlide> sliders = _core.BannerAndSlide.Get(i => !i.IsSlider && i.IsActive && i.ActiveTill < DateTime.Now).Randomize().Take(1).ToList();
            List<VmHomeBanner> result = new List<VmHomeBanner>();
            foreach (TblBannerAndSlide i in sliders)
                result.Add(new VmHomeBanner(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetKeywords5")]
        public IActionResult GetKeywords5()
        {
            List<VmKeyword> keywords = new List<VmKeyword>();
            foreach (TblKeyword i in _core.Keyword.Get().Take(10))
            {
                keywords.Add(new VmKeyword(i));
            }

            return Ok(keywords);
        }

    }
}
