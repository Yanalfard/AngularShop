using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.ViewModels
{
    public class VmProductCompare
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public List<TblColor> Colors { get; set; }
        public List<TblSize> Sizes { get; set; }
        public List<VmPropertyBig> Properties { get; set; }
        public long Price { get; set; }

        public VmProductCompare()
        {
            
        }

        public VmProductCompare(TblProduct product)
        {
            Colors = new List<TblColor>();
            Sizes = new List<TblSize>();
            Properties = new List<VmPropertyBig>();
            ProductId = product.ProductId;
            ImageUrl = product.MainImage;
            Name = product.Name;
            Colors = product.TblAmounts.Select(i => i.Color).ToList();
            Sizes = product.TblAmounts.Select(i => i.Size).ToList();
            Rating = Math.Round(product.TblRates.Average(i => i.Rate));
            Description = product.DescriptionShortHtml;
            product.TblProductPropertyRels.Select(i => i.Property).ToList().ForEach(j => Properties.Add(new VmPropertyBig(j)));
        }
    }
}
