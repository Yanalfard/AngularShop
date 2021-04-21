using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblProduct")]
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblAmounts = new HashSet<TblAmount>();
            TblBookMarks = new HashSet<TblBookMark>();
            TblColors = new HashSet<TblColor>();
            TblOrderDetails = new HashSet<TblOrderDetail>();
            TblProductCommentRels = new HashSet<TblProductCommentRel>();
            TblProductImageRels = new HashSet<TblProductImageRel>();
            TblProductKeywordRels = new HashSet<TblProductKeywordRel>();
            TblProductPropertyRels = new HashSet<TblProductPropertyRel>();
            TblRates = new HashSet<TblRate>();
            TblSizes = new HashSet<TblSize>();
            TblSpecialOffers = new HashSet<TblSpecialOffer>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string MainImage { get; set; }
        public string DescriptionShortHtml { get; set; }
        public string DescriptionLongHtml { get; set; }
        public int? CatagoryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [StringLength(500)]
        public string SearchText { get; set; }
        public int BrandId { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(CatagoryId))]
        [InverseProperty(nameof(TblCatagory.TblProducts))]
        public virtual TblCatagory Catagory { get; set; }
        [InverseProperty(nameof(TblAmount.Product))]
        public virtual ICollection<TblAmount> TblAmounts { get; set; }
        [InverseProperty(nameof(TblBookMark.Product))]
        public virtual ICollection<TblBookMark> TblBookMarks { get; set; }
        [InverseProperty(nameof(TblColor.Product))]
        public virtual ICollection<TblColor> TblColors { get; set; }
        [InverseProperty(nameof(TblOrderDetail.Product))]
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
        [InverseProperty(nameof(TblProductCommentRel.Product))]
        public virtual ICollection<TblProductCommentRel> TblProductCommentRels { get; set; }
        [InverseProperty(nameof(TblProductImageRel.Product))]
        public virtual ICollection<TblProductImageRel> TblProductImageRels { get; set; }
        [InverseProperty(nameof(TblProductKeywordRel.Product))]
        public virtual ICollection<TblProductKeywordRel> TblProductKeywordRels { get; set; }
        [InverseProperty(nameof(TblProductPropertyRel.Product))]
        public virtual ICollection<TblProductPropertyRel> TblProductPropertyRels { get; set; }
        [InverseProperty(nameof(TblRate.Product))]
        public virtual ICollection<TblRate> TblRates { get; set; }
        [InverseProperty(nameof(TblSize.Product))]
        public virtual ICollection<TblSize> TblSizes { get; set; }
        [InverseProperty(nameof(TblSpecialOffer.Product))]
        public virtual ICollection<TblSpecialOffer> TblSpecialOffers { get; set; }
    }
}
