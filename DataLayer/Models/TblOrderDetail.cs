﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblOrderDetail")]
    public partial class TblOrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public long Price { get; set; }
        public int? FinalOrderId { get; set; }
        public int? AmountId { get; set; }

        [ForeignKey(nameof(AmountId))]
        [InverseProperty(nameof(TblAmount.TblOrderDetails))]
        public virtual TblAmount Amount { get; set; }
        [ForeignKey(nameof(FinalOrderId))]
        [InverseProperty(nameof(TblOrder.TblOrderDetails))]
        public virtual TblOrder FinalOrder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblOrderDetails))]
        public virtual TblProduct Product { get; set; }
    }
}
