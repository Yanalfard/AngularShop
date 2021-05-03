using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmHomeBannerNoText
    {
        public string ImageUrl { get; set; }
        public string Link { get; set; }

        public VmHomeBannerNoText()
        {

        }

        public VmHomeBannerNoText(TblBannerAndSlide slider)
        {
            ImageUrl = slider.ImageUrl;
            Link = slider.Link;
        }
    }
}
