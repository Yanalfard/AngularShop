using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularShop.Utilities;
using AngularShop.ViewModels;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private Core core = new Core();

        [HttpGet]
        [Route("GetSliders1")]
        public IActionResult GetSliders1()
        {
            List<TblBannerAndSlide> sliders = core.BannerAndSlide.Get(i => i.IsSlider && i.IsActive && i.ActiveTill < DateTime.Now).Take(6).ToList();
            List<VmHomeSlider> result = new List<VmHomeSlider>();
            foreach (TblBannerAndSlide i in sliders)
                result.Add(new VmHomeSlider(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetNewProducts2")]
        public IActionResult GetNewProducts2()
        {

            DateTime date = DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0));
            List<TblProduct> sliders = core.Product.Get(i => !i.IsDeleted && i.DateCreated > date).ToList();
            List<VmHomeProduct> result = new List<VmHomeProduct>();
            foreach (TblProduct i in sliders)
                result.Add(new VmHomeProduct(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetMostRatedProducts3")]
        public IActionResult GetMostRatedProducts3()
        {
            List<TblProduct> sliders = core.Product.Get(i => !i.IsDeleted && i.TblRates.Average(j => j.Rate) > 4).Take(10).ToList();
            List<VmHomeProduct> result = new List<VmHomeProduct>();
            foreach (TblProduct i in sliders)
                result.Add(new VmHomeProduct(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetBanners4")]
        public IActionResult GetBanners4()
        {
            List<TblBannerAndSlide> sliders = core.BannerAndSlide.Get(i => !i.IsSlider && i.IsActive && i.ActiveTill < DateTime.Now).Randomize().Take(2).ToList();
            List<VmHomeBanner> result = new List<VmHomeBanner>();
            foreach (TblBannerAndSlide i in sliders)
                result.Add(new VmHomeBanner(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetDiscountedProducts5")]
        public IActionResult GetDiscountedProducts5()
        {
            List<TblProduct> sliders =
                core.SpecialOffer.Get(i => i.ValidTill > DateTime.Now).Select(j => j.Product).Take(6).ToList();
            List<VmHomeProduct> result = new List<VmHomeProduct>();
            foreach (TblProduct i in sliders)
                result.Add(new VmHomeProduct(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetBannerAfterProducts6")]
        public IActionResult GetBannerAfterProducts6()
        {
            List<TblBannerAndSlide> sliders = core.BannerAndSlide.Get(i => !i.IsSlider && i.IsActive && i.ActiveTill < DateTime.Now).Randomize().Take(3).ToList();
            List<VmHomeBannerNoText> result = new List<VmHomeBannerNoText>();
            foreach (TblBannerAndSlide i in sliders)
                result.Add(new VmHomeBannerNoText(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetProductsAfterBanners7")]
        public IActionResult GetProductsAfterBanners7()
        {
            List<TblProduct> sliders = core.Product.Get(i => !i.IsDeleted).Randomize().Take(10).ToList();
            List<VmHomeProductSpecial> result = new List<VmHomeProductSpecial>();
            foreach (TblProduct i in sliders)
                result.Add(new VmHomeProductSpecial(i));

            return Ok(result);
        }

        [HttpGet]
        [Route("GetFooter")]
        public IActionResult GetFooter()
        {
            VmFooter footer = new VmFooter(DataAccess.GetConfig("Description"),
                DataAccess.GetConfig("Address"), DataAccess.GetConfig("Email"),
                DataAccess.GetConfig("TellNo"), DataAccess.GetConfig("InstagramLink"),
                DataAccess.GetConfig("YoutubeLink"), DataAccess.GetConfig("GooglePlusLink"),
                DataAccess.GetConfig("TwitterLink"), DataAccess.GetConfig("FacebookLink"));

            return Ok(footer);
        }
    }
}
