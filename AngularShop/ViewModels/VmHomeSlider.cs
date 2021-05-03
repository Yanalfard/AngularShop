using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmHomeSlider
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }

        public VmHomeSlider()
        {
            
        }

        public VmHomeSlider(TblBannerAndSlide slider)
        {
            ImageUrl = slider.ImageUrl;
            Title = slider.Title;
            Link = slider.Link;
        }
    }
}
