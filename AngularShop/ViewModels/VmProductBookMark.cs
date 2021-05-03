using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmProductBookMark
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public bool IsAvailable { get; set; }

        public VmProductBookMark()
        {

        }

        public VmProductBookMark(TblProduct product, int amountId)
        {
            ProductId = product.ProductId;
            ImageUrl = product.MainImage;
            Name = product.Name;
            Price = product.TblAmounts.First(i => i.AmountId == amountId).PriceAfterDiscount ?? 0;
            IsAvailable = product.TblAmounts.Sum(i => i.Count) != 0;
        }
    }
}
