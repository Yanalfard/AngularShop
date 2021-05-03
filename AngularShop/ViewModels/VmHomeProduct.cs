using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.ViewModels
{
    public class VmHomeProduct
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int RateCount { get; set; }
        public List<VmAmount> AvailableAmount { get; set; }


        public VmHomeProduct()
        {

        }

        public VmHomeProduct(TblProduct product)
        {
            AvailableAmount = new List<VmAmount>();
            Core core = new Core();
            ProductId = product.ProductId;
            ImageUrl = product.MainImage;
            Name = product.Name;
            foreach (TblAmount i in core.Amount.Get(i => i.ProductId == product.ProductId))
                AvailableAmount.Add(new VmAmount(i));
            List<TblRate> rates = core.Rate.Get(i => i.ProductId == product.ProductId).ToList();
            Rating = Math.Round(rates.Average(i => i.Rate), 2);
            RateCount = rates.Count;
        }
    }
}
