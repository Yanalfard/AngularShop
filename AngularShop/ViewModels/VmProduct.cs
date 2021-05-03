using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using DataLayer.Models;
using Services.Services;

namespace AngularShop.ViewModels
{
    public class VmProduct
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public long PriceBeforeDiscount { get; set; }
        public long PriceAfterDiscount { get; set; }
        public double Rating { get; set; }
        public int RateCount { get; set; }
        public List<VmAmount> AvailableAmount { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<VmPropertyMini> MiniProperty { get; set; }
        public List<VmPropertyBig> BigProperty { get; set; }
        public List<string> Images { get; set; }
        public TblCatagory Category { get; set; }
        public List<TblKeyword> Keywords { get; set; }
        public List<VmComment> Comments { get; set; }
        public List<VmHomeProduct> RelatedProducts { get; set; }


        public VmProduct()
        {

        }

        public VmProduct(TblProduct product)
        {
            AvailableAmount = new List<VmAmount>();
            MiniProperty = new List<VmPropertyMini>();
            BigProperty = new List<VmPropertyBig>();
            Images = new List<string>();
            Category = new TblCatagory();
            Keywords = new List<TblKeyword>();
            Comments = new List<VmComment>();
            RelatedProducts = new List<VmHomeProduct>();
            Core core = new Core();
            ProductId = product.ProductId;
            Name = product.Name;
            PriceBeforeDiscount = product.TblAmounts.ToList()[0].PriceBeforeDiscount ?? 0;
            PriceAfterDiscount = product.TblAmounts.ToList()[0].PriceAfterDiscount ?? 0;
            List<TblRate> rates = core.Rate.Get(i => i.ProductId == product.ProductId).ToList();
            Rating = Math.Round(rates.Average(i => i.Rate), 2);
            RateCount = rates.Count;
            core.Amount.Get(i => i.Count > 0).ToList().ForEach(j => AvailableAmount.Add(new VmAmount(j)));
            foreach (TblComment i in core.ProductCommentRel.Get(i => i.ProductId == product.ProductId).Select(j => j.Comment))
                Comments.Add(new VmComment(i));

            foreach (TblKeyword i in core.ProductKeywordRel.Get(i => i.ProductId == product.ProductId).Select(j => j.Keyword))
                Keywords.Add(i);

            Category = product.Catagory;
            core.ProductImageRel.Get(i => i.ProductId == product.ProductId).Select(j => j.Image).ToList().ForEach(k => Images.Add(k.Image));
            core.ProductPropertyRel.Get(i => i.ProductId == product.ProductId).Select(j => j.Property).ToList().ForEach(k => MiniProperty.Add(new VmPropertyMini(k)));
            core.ProductPropertyRel.Get(i => i.ProductId == product.ProductId).Select(j => j.Property).ToList().ForEach(k => BigProperty.Add(new VmPropertyBig(k)));
            ShortDescription = product.DescriptionShortHtml;
            LongDescription = product.DescriptionLongHtml;
            foreach (TblProductKeywordRel i in core.ProductKeywordRel.Get(i => i.ProductId == product.ProductId))
            {
                foreach (TblProduct j in core.ProductKeywordRel.Get(j => j.KeywordId == i.KeywordId).Select(k => k.Product))
                {
                    RelatedProducts.Add(new VmHomeProduct(j));
                }
            }
        }
    }
}
