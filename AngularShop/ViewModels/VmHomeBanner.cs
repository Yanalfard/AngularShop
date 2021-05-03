using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmHomeBanner
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }

        public VmHomeBanner()
        {

        }

        public VmHomeBanner(TblBannerAndSlide slider)
        {
            ImageUrl = slider.ImageUrl;
            Title = slider.Title;
            Link = slider.Link;
        }
    }
}
