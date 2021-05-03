using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace AngularShop.ViewModels
{
    public class VmOrderDashboard
    {
        public int OrderId { get; set; }
        public DateTime DateOrdered { get; set; }
        public string Status { get; set; }
        public long PriceSum { get; set; }
        public List<(VmProduct product, VmAmount amount)> ProductsAndAmounts { get; set; }

        public VmOrderDashboard()
        {

        }

        public VmOrderDashboard(TblOrder order)
        {
            ProductsAndAmounts = new List<(VmProduct product, VmAmount amount)>();
            OrderId = order.OrdeId;
            DateOrdered = order.DateSubmited;
            Status = order.IsPayed ? "پرداخت شده" : "پرداخت نشده";
            PriceSum = order.FinalPrice;
            List<TblProduct> products = order.TblOrderDetails.Select(i => i.Product).ToList();
            List<TblAmount> amounts = order.TblOrderDetails.Select(i => i.Amount).ToList();
            for (int i = 0; i < products.Count; i++)
                ProductsAndAmounts.Add((new VmProduct(products[i]), new VmAmount(amounts[i])));
        }
    }
}
