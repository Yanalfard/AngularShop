using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.ViewModels
{
    public class VmSearchProduct
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public long PriceBeforeDiscount { get; set; }
        public long PriceAfterDiscount { get; set; }
        public double Rating { get; set; }
        public int RateCount { get; set; }
        public List<VmAmount> AvailableAmount { get; set; }

        public VmSearchProduct()
        {

        }

        public VmSearchProduct(TblProduct product, int colorId, int sizeId)
        {
            AvailableAmount = new List<VmAmount>();
            Core core = new Core();
            ProductId = product.ProductId;
            ImageUrl = product.MainImage;
            Name = product.Name;
            TblAmount amount = core.Amount
                .Get(i => i.ProductId == product.ProductId && i.ColorId == colorId && i.SizeId == sizeId).First();
            PriceBeforeDiscount = amount.PriceBeforeDiscount ?? 0;
            PriceAfterDiscount = amount.PriceAfterDiscount ?? 0;
            List<TblRate> rates = core.Rate.Get(i => i.ProductId == product.ProductId).ToList();
            Rating = Math.Round(rates.Average(i => i.Rate), 2);
            RateCount = rates.Count;
            core.Amount.Get(i => i.Count > 0).ToList().ForEach(j => AvailableAmount.Add(new VmAmount(j)));
        }
    }
}
