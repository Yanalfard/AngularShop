using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblAmount")]
    public partial class TblAmount
    {
        public TblAmount()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        [Key]
        public int AmountId { get; set; }
        public int? ColorId { get; set; }
        public int? SizeId { get; set; }
        public long? PriceBeforeDiscount { get; set; }
        public long? PriceAfterDiscount { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ColorId))]
        [InverseProperty(nameof(TblColor.TblAmounts))]
        public virtual TblColor Color { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblAmounts))]
        public virtual TblProduct Product { get; set; }
        [ForeignKey(nameof(SizeId))]
        [InverseProperty(nameof(TblSize.TblAmounts))]
        public virtual TblSize Size { get; set; }
        [InverseProperty(nameof(TblOrderDetail.Amount))]
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
