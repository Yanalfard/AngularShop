using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.ViewModels
{
    public class VmHomeProductSpecial
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int RateCount { get; set; }
        public long PriceBeforeDiscount { get; set; }
        public long PriceAfterDiscount { get; set; }

        public VmHomeProductSpecial()
        {

        }

        public VmHomeProductSpecial(TblProduct product)
        {
            Core core = new Core();
            ProductId = product.ProductId;
            ImageUrl = product.MainImage;
            Name = product.Name;
            if (product.TblAmounts.Count != 0)
            {
                PriceBeforeDiscount = product.TblAmounts.First().PriceBeforeDiscount ?? 0;
                PriceAfterDiscount = product.TblAmounts.First().PriceAfterDiscount ?? 0;
            }

            if (product.TblRates.Count != 0)
            {
                List<TblRate> rates = core.Rate.Get(i => i.ProductId == product.ProductId).ToList();
                Rating = Math.Round(rates.Average(i => i.Rate), 2);
                RateCount = rates.Count;
            }
        }
    }
}
