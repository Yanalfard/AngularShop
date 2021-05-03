using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmRate
    {
        public double Rate { get; set; }
        public TblClient Client { get; set; }
        public TblProduct Product { get; set; }

        public VmRate()
        {
            
        }

        public VmRate(TblRate rate)
        {
            Client = new TblClient();
            Product = new TblProduct();
            Rate = rate.Rate;
            Client = rate.Client;
            Product = rate.Product;
        }
    }
}
