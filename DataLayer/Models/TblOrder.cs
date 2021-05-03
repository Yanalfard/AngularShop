using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblOrder")]
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        [Key]
        public int OrdeId { get; set; }
        public int? DiscountId { get; set; }
        public int ClientId { get; set; }
        public bool IsPayed { get; set; }
        public int FinalPrice { get; set; }
        public int AddressId { get; set; }
        public int? SendPrice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateSubmited { get; set; }
        [StringLength(256)]
        public string Description { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty(nameof(TblAddress.TblOrders))]
        public virtual TblAddress Address { get; set; }
        [ForeignKey(nameof(ClientId))]
        [InverseProperty(nameof(TblClient.TblOrders))]
        public virtual TblClient Client { get; set; }
        [ForeignKey(nameof(DiscountId))]
        [InverseProperty(nameof(TblDiscount.TblOrders))]
        public virtual TblDiscount Discount { get; set; }
        [InverseProperty(nameof(TblOrderDetail.FinalOrder))]
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
