using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmAmount
    {
        public int AmountId { get; set; }
        public TblColor Color { get; set; }
        public TblSize Size { get; set; }
        public long PriceBeforeDiscount { get; set; }
        public long PriceAfterDiscount { get; set; }
        public int Count { get; set; }
        public TblProduct Product { get; set; }

        public VmAmount()
        {
            
        }

        public VmAmount(TblAmount amount)
        {
            Product = new TblProduct();
            AmountId = amount.AmountId;
            Color = amount.Color;
            Size = amount.Size;
            PriceBeforeDiscount = amount.PriceBeforeDiscount??0;
            PriceAfterDiscount = amount.PriceAfterDiscount??0;
            Count = amount.Count;
            Product = amount.Product;
        }
    }
}
